using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Diagnostics.Metrics;
using dp.write.transaction.Entities;
using dp.write.transaction;

namespace dp.write.transaction.worker
{
    public class Program
    {
        private static ServiceProvider serviceProvider;
        const int SLEEP_TIME = 3000;

        public static async Task Main(string[] args)
        {
            System.AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;

            IServiceCollection services = ConfigureServices();
            serviceProvider = services.BuildServiceProvider();

            IConfiguration configuration = Configure();
            QueueSettings queue = new();
            DpClientSettings dpClient = new();
            StateSettings state = new();
            LoggingSettings logging = new();

            configuration.GetSection("Queue")
                .Bind(queue);

            configuration.GetSection("HttpDpClient")
               .Bind(dpClient);

            configuration.GetSection("State")
              .Bind(state);

            configuration.GetSection("Logging")
                .Bind(logging);

            Config.Create(new Settings
            {
                Queue = queue,
                DpClient = dpClient,
                State = state,
                Logging = new LoggingSettings
                {
                    Level = "Warn",
                    LevelConsole = "Debug",
                }
            });

            //Block
            Thread block = new Thread(Transaction().GetAwaiter().GetResult);
            block.Start();
        }

        static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            System.Console.WriteLine(e.ExceptionObject.ToString());
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddTransient<IWorker>(ctx =>
                        new Worker(ctx.GetService<ILogger<Worker>>(), ctx.GetService<IServiceProvider>()));
            return services;
        }

        private static IConfiguration Configure()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile("appsettings.development.json", optional: false)
                //.AddJsonFile("appsettings.production.json", optional: true)
                .AddEnvironmentVariables()
                .Build();
        }

        private static async Task Transaction()
        {
            while (true)
            {
                // Recomended try catch
                try
                {
                    IWorker service =  serviceProvider.GetRequiredService<IWorker>();
                    await service.TransactionSyncAsync();
                    await Task.Delay(SLEEP_TIME);
                }
                catch (Exception ex)
                {
                    await Task.Delay(SLEEP_TIME);
                }
            }
        }
    }
}