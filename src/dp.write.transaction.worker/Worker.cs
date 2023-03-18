using System;
using Microsoft.Extensions.Configuration;
using System.Diagnostics.Metrics;
using Microsoft.Extensions.DependencyInjection;
using dp.write.transaction.Entities;
using dp.write.transaction.Services.Queues;
using dp.write.transaction.Services.Transactions;

namespace dp.write.transaction.worker
{
    public partial interface IWorker
    {
        Task<bool> TransactionSyncAsync();
    }

    public partial class Worker: IWorker
    {
        private readonly IServiceProvider _serviceProvider;

        public Worker(IServiceProvider serviceProvider)
        {
               _serviceProvider = serviceProvider;
        }

        public virtual async Task<bool> TransactionSyncAsync()
        {
            //Console.WriteLine("Worker running at: " +  DateTimeOffset.Now);
         
            // Recomended try catch
            IQueueService queueService = _serviceProvider.GetRequiredService<IQueueService>();
            string initialize = Configuration.State.Initialize.ToString();
            string marked = Configuration.State.Marked.ToString();
            var result = queueService.Get<TransactionEntity>(initialize);
            if (result != null)
            {
                Console.WriteLine("result.JsonDocument : " + result.JsonDocument);
                //Begin
                ITransactionService transactionService = _serviceProvider.GetRequiredService<ITransactionService>();
                var responsePharse = await transactionService.SendTransactionAsync(result.Id, result.JsonDocument);
                Console.WriteLine("send transaction status # " + responsePharse);
               // if(responsePharse == "OK")
                //{
                    queueService.Put(result.Id, marked);
                    Console.WriteLine("Updated state on id # " + result.Id + marked);
                //}
                //Commit
                return true;
            }
            else 
            {
                //Console.WriteLine("Worker end at:  " + DateTimeOffset.Now);
                return false;
            }            
        }
    }
}