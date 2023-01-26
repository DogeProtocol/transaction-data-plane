using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using dp.write.transaction;

namespace dp.write.api
{
    /// <summary>
    /// Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        public static async Task Main(string[] args)
        {
            IWebHost host = CreateWebHostBuilder(args).Build();

            ////DI.Migrate(host.Services);

            await host.RunAsync();
        }

        /// <summary>
        /// Create the web host builder.
        /// </summary>
        /// <param name="args"></param>
        /// <returns>IWebHostBuilder</returns>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
             .ConfigureAppConfiguration((hostingContext, configuration) =>
             {
                 configuration.Sources.Clear();

                 IHostEnvironment env = hostingContext.HostingEnvironment;

                 if (args.Length > 0)
                 {
                     configuration.AddJsonFile(args[0], optional: false);
                 }
                 else
                 {
                     configuration
                         .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                         //.AddJsonFile("appsettings.development.json", optional: false);
                         //.AddJsonFile("appsettings.production.json", optional: true);
                 }


                 IConfigurationRoot configurationRoot = configuration.Build();

                 QueueSettings queue = new();
                 //DpClientSettings dpClient = new();
                 StateSettings state = new();
                 //LoggingSettings logging = new();

                 configurationRoot.GetSection("Queue")
                   .Bind(queue);

                 //configurationRoot.GetSection("HttpDpClient")
                 //   .Bind(dpClient);

                 configurationRoot.GetSection("State")
                  .Bind(state);

                // configurationRoot.GetSection("Logging")
                 //    .Bind(logging);

                 Config.Create(new Settings
                 {
                     Queue = queue,
                    // DpClient = dpClient,
                     State = state,
                   //  Logging = new LoggingSettings
                    // {
                    //     Level = "Warn",
                    //     LevelConsole = "Debug",
                    // }
                 });


             }).UseStartup<Startup>();
    }
}
