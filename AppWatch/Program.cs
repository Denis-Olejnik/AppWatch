using Serilog;
using Serilog.Events;
using Serilog.Extensions.Logging;
using Microsoft.Extensions.Logging;

namespace AppWatch
{
    internal static class Program
    {
        private static readonly ILoggerFactory _loggerFactory = new LoggerFactory().AddSerilog();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string outTemplate = "{Timestamp:HH:mm:ss.ff} [{Level}] {Message}{NewLine}{Exception}";

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Debug(outputTemplate: outTemplate)
                .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day, outputTemplate: outTemplate)
                .CreateLogger();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow(_loggerFactory.CreateLogger<MainWindow>()));

            Log.CloseAndFlush();
        }
    }
}