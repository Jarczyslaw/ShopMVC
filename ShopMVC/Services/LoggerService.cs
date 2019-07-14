using NLog;
using System;

namespace ShopMVC.Services
{
    public class LoggerService : ILoggerService
    {
        public ILogger Logger { get; }

        private readonly string noMessage = "No message provided";

        public LoggerService()
        {
            Logger = LogManager.GetCurrentClassLogger();
        }

        public void Debug(string message, params object[] args)
        {
            Logger.Debug(message, args);
        }

        public void Error(Exception exception)
        {
            Logger.Error(exception, noMessage);
        }

        public void Error(Exception exception, string message, params object[] args)
        {
            Logger.Error(exception, message, args);
        }

        public void Error(string message, params object[] args)
        {
            Logger.Error(message, args);
        }

        public void Fatal(Exception exception)
        {
            Logger.Fatal(exception, noMessage);
        }

        public void Fatal(Exception exception, string message, params object[] args)
        {
            Logger.Fatal(exception, message, args);
        }

        public void Fatal(string message, params object[] args)
        {
            Logger.Fatal(message, args);
        }

        public void Info(string message, params object[] args)
        {
            Logger.Info(message, args);
        }

        public void Trace(string message, params object[] args)
        {
            Logger.Trace(message, args);
        }

        public void Warn(string message, params object[] args)
        {
            Logger.Warn(message, args);
        }
    }
}