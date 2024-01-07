using System;
using Microsoft.Extensions.Configuration;
using System.Diagnostics.Metrics;
using Microsoft.Extensions.DependencyInjection;
using dp.write.transaction.Entities;
using dp.write.transaction.Services.Queues;
using dp.write.transaction.Services.Transactions;
using System.Runtime.Serialization;
using System.Xml.Linq;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.Pkcs;

namespace dp.write.transaction.worker
{
    public partial interface IWorker
    {
        Task<bool> PendingTransactionSyncAsync();
    }

    public partial class Worker : IWorker
    {
        private readonly IServiceProvider _serviceProvider;

        public Worker(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public virtual async Task<bool> PendingTransactionSyncAsync()
        {
            // Recomended try catch
            IQueueService queueService = _serviceProvider.GetRequiredService<IQueueService>();
            string pending = Configuration.State.Pending.ToString();
           
            var result = queueService.Get<TransactionEntity>(pending);
            if (result != null)
            {
                ITransactionService transactionService = _serviceProvider.GetRequiredService<ITransactionService>();
                var httpResponse = await transactionService.SendTransactionAsync(result.Id, result.JsonDocument);
                Console.WriteLine("send transaction status # " + httpResponse);

                var document = result.JsonDocument;
                var data = JsonConvert.DeserializeObject<TransactionSummaryResponse>(httpResponse.ToString(), new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });
                data.TxData = document;

                string state = Configuration.State.Marked.ToString();
                if (data.Error != null)
                {
                    state = Configuration.State.Error.ToString();
                }

                var json = JsonConvert.SerializeObject(data);
                queueService.Put(result.Id, json, state);

                Console.WriteLine("Updated state on id # " + result.Id + state);

                return true;
            }
            else
            {
                //Console.WriteLine("Worker end at:  " + DateTimeOffset.Now);
                return false;
            }
        }    
    }

    public class TransactionSummaryResponse
    {
        public string? TxData { get; set; }
        public string? id { get; set; }
        public string? Result { get; set; }
        public Error? Error { get; set; }
    }

    public class Error
    {
        public string? Code { get; set; }
        public string? Message { get; set; }
    }
}