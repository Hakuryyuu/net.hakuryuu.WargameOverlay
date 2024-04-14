using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using net.hakuryuu.WargameOverlay.Services;
using net.hakuryuu.WargameOverlay.Views;
using System.Data;

namespace net.hakuryuu.WargameOverlay
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<Form1>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddSingleton<net.hakuryuu.WargameOverlay.Services.IDataReader, DataReader>();
                    services.AddTransient<IDataExtractor, DataExtractor>();
                    services.AddTransient<Form1>();
                    services.AddTransient<Overlay>();
                });
        }
    }
}