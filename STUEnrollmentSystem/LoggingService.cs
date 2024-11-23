using Serilog;
using Serilog.Sinks.MSSqlServer;
using System;

namespace STUEnrollmentSystem
{
    internal static class LoggingService
    {
        private static readonly ILogger _logger;

        static LoggingService()
        {
            try
            {
                Serilog.Debugging.SelfLog.Enable(Console.Out);

                _logger = new LoggerConfiguration()
                    .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day) 
                    .WriteTo.MSSqlServer(
                        connectionString: ConnectionFactory.GetConnectionString(),
                        sinkOptions: new MSSqlServerSinkOptions
                        {
                            TableName = "Logs",
                            AutoCreateSqlTable = true
                        })
                    .CreateLogger();

                _logger.Information("Logging service initialized successfully. Test log.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"LoggingService initialization failed: {ex.Message}");
                throw;
            }
        }

        // Public method to expose the logger
        public static ILogger GetLogger() => _logger;

        // Helper methods to log directly from this service
        public static void LogInformation(string message) => _logger.Information(message);
        public static void LogError(string message, Exception ex = null) => _logger.Error(ex, message);
        public static void LogWarning(string message) => _logger.Warning(message);
        public static void Shutdown() => Log.CloseAndFlush();
    }
}
