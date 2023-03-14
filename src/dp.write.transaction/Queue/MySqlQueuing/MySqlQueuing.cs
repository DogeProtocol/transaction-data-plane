using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Globalization;
using System.Diagnostics;
using MySqlConnector;
using Nethereum.Model;

namespace dp.write.transaction.Queue.MySqlCaching
{
    internal sealed class MySqlQueuing
    {
        public class QueueItem
        {
            public string id;
            public object jsondocument;
            public object dateadded;
            public object state;
        
            public QueueItem()
            {

            }

            public QueueItem(string id, object jsondocument, object dateadded, object state)
            {
                this.id = id;
                this.jsondocument = jsondocument;
                this.dateadded = dateadded;
                this.state = state;
            }
        }

        private String _connectionString;
        private bool disposed;
   
        internal MySqlQueuing(String connectionString)
        {
            if (connectionString == null)
            {
                throw new ArgumentNullException("storage", "storage cannot be null.");
            }

            this._connectionString = connectionString;
        }

        ~MySqlQueuing()
        {
            this.Dispose(false);
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void SetContent(QueueItem item)
        {
            this.AddContentImpl(item.id, item.jsondocument, item.dateadded, item.state);
        }

        public void PutContent(string id, object state)
        {
            this.MarkContentImpl(id, state);
        }

        public QueueItem? GetContent(string state)
        {
            // var stopwatch = new Stopwatch();
            // stopwatch.Start();
            //string content = null;

            QueueItem? item;
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                item = MySqlQueuing.GetNextItem(state, connection);
                connection.Close();
                return item;
            }
        }

        private void AddContentImpl(string id, object jsondocument, object dateadded, object state)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException("id", "id must contain a value.");
            }

            if (jsondocument == null)
            {
                throw new ArgumentNullException("jsondocument", "content cannot be null.");
            }

            if (dateadded == null)
            {
                throw new ArgumentNullException("dateadded", "dateadded cannot be null.");
            }

            if (state == null)
            {
                throw new ArgumentNullException("state", "state cannot be null.");
            }

            QueueItem item = new QueueItem()
            {
                id = id,
                jsondocument = jsondocument,
                dateadded = dateadded,
                state = state,
            };

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        MySqlQueuing.InsertItem(item, connection, transaction);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        transaction.Rollback();
                        throw ex;
                    }
                }
                connection.Close();
            }
        }


        private void MarkContentImpl(string id,  object state)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException("id", "id must contain a value.");
            }

            if (state == null)
            {
                throw new ArgumentNullException("state", "state cannot be null.");
            }

            QueueItem item = new QueueItem()
            {
                id = id,
                state = state,
            };

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        MySqlQueuing.MarkItem(item, connection, transaction);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        transaction.Rollback();
                        throw ex;
                    }
                }
                connection.Close();
            }
        }

        private static QueueItem? GetNextItem(string state,  MySqlConnection connection)
        {
            try
            {
                const string Sql =
                @"SELECT *
                    FROM transactions
                    WHERE State=@State ORDER BY DateAdded ASC;";

                using (MySqlCommand command = new MySqlCommand(Sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@State", state.ToString());
                    command.CommandTimeout = 10;

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            QueueItem c = new QueueItem();
                            c.id = Convert.ToString(reader["Id"], CultureInfo.InvariantCulture);
                            c.jsondocument = Convert.ToString(reader["JsonDocument"], CultureInfo.InvariantCulture);
                            c.dateadded = Convert.ToString(reader["DateAdded"], CultureInfo.InvariantCulture);
                            c.state = Convert.ToString(reader["State"], CultureInfo.InvariantCulture);
                            return c;
                        }
                    }
                }

                return default(QueueItem);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        private static int InsertItem(QueueItem item, MySqlConnection connection, MySqlTransaction transaction)
        {
            try
            {
                const string Sql =
                    @"INSERT INTO transactions (Id,JsonDocument,DateAdded,State) VALUES(@Id,@JsonDocument,@DateAdded,@State);";

                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = Sql;
                    command.Transaction = transaction;
                    command.Parameters.AddWithValue("@Id", item.id);
                    command.Parameters.AddWithValue("@JsonDocument", item.jsondocument);
                    command.Parameters.AddWithValue("@DateAdded", item.dateadded);
                    command.Parameters.AddWithValue("@State", item.state);
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        private static int MarkItem(QueueItem item, MySqlConnection connection, MySqlTransaction transaction)
        {
            try
            {
                const string Sql =
                    @"UPDATE transactions SET State=@State WHERE Id=@Id";

                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = Sql;
                    command.Transaction = transaction;
                    command.Parameters.AddWithValue("@Id", item.id);
                    command.Parameters.AddWithValue("@State", item.state);
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        private void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                this.disposed = true;
            }
        }
    }
}
