using Newtonsoft.Json;
using dp.write.transaction.Queue.MySqlCaching;

namespace dp.write.transaction.Services.Queues
{
    /// <summary>
    /// Implements <see cref="IQueueService"/> with an on-queue database and content storage.
    /// </summary>
    public sealed class QueueService : IQueueService
    {
        #region Constants

        private MySqlQueuing queue;

        private bool disposed;

        private string connectionString = Configuration.Queue.Connectionstring;

        #endregion Constants

        #region Ctor
        /// <summary>
        /// Initializes a new instance of the DiskCache class.
        /// </summary>
        public QueueService()
        {
            queue = new MySqlQueuing(connectionString);
        }

        /// <summary>
        /// Finalizes an instance of the QueueService class.
        /// </summary>
        ~QueueService()
        {
            Dispose(false);
        }

        #endregion Ctor

        #region Public Methods

        /// <summary>
        /// Adds an item to the cache.
        /// </summary>
        /// <param name="id">The id of the guid to add.</param>
        /// <param name="jsondocument">The jsondocument of the item to add.</param>
        public void Set(string id, object jsondocument, object dateadded, object state)
        {
            string value = JsonConvert.SerializeObject(jsondocument);
            queue.SetContent(new MySqlQueuing.QueueItem(id, value, dateadded, state));
        }
        /// <summary>
        /// Adds an item to the cache.
        /// </summary>
        /// <param name="id">The id of the guid to add.</param>
        /// <param name="jsondocument">The jsondocument of the item to add.</param>
        public void Put(string id, object jsondocument, object state)
        {
            queue.PutContent(id, jsondocument, state);
        }
        /// <summary>
        /// Gets the content for the item with the given
        /// key. Returns null if the item is not found.
        /// </summary>
        /// <param name="key">The key of the item to get.</param>
        /// <returns>The content, or null if none is found.</returns>
        public T? Get<T>(string state)
        {
            var value = queue.GetContent(state);
            if (value != null)
            {
                return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(value));
            }
            return default(T);
        }
        /// <summary>
        /// Disposes of resources used by this instance.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (queue != null)
                    {
                        queue.Dispose();
                    }
                }
                queue = null;
                disposed = true;
            }
        }

        #endregion Public Methods
    }
}
