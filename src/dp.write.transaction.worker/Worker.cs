using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<Worker> _logger;
        private readonly IServiceProvider _serviceProvider;

        public Worker(ILogger<Worker> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        public virtual async Task<bool> TransactionSyncAsync()
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

            // Recomended try catch
            IQueueService queueService = _serviceProvider.GetRequiredService<IQueueService>();

            string marked = Configuration.State.Marked.ToString();
            var result = queueService.Get<TransactionEntity>(marked);
            if (result.JsonDocument != null)
            {
                //Begin
                ITransactionService transactionService = _serviceProvider.GetRequiredService<ITransactionService>();
                var hash = await transactionService.SendTransactionAsync(result.JsonDocument);
                _logger.LogInformation($"send transaction id #{result.Id} success");

                queueService.Put(result.Id, "marked");
                _logger.LogInformation($"Updated state on id #{result.Id} marked");

                //Commit
                return true;
            }
            else 
            {
                _logger.LogInformation("Worker end at: {time}", DateTimeOffset.Now);
                return false;
            }            
        }
    }
}