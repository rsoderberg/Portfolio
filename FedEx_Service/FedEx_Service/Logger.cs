using FedEx_Service.RateService_v28;
using NLog;
using System;

namespace FedEx_Service
{
    public class Logger
    {
        public static void LogNotifications(RateReply reply)
        {
            string logOutput = $"Notifications:";
            for (int i = 0; i < reply.Notifications.Length; i++)
            {
                Notification notification = reply.Notifications[i];
                logOutput += $"Notification no. {i} - ";
                logOutput += $" Severity: {notification.Severity}, ";
                logOutput += $" Code: {notification.Code}, ";
                logOutput += $" Message: {notification.Message}, ";
                logOutput += $" Source: {notification.Source}";
            }

            NLog.Logger dbLogger = LogManager.GetLogger("databaseLogger");
            NLog.Logger fileLogger = LogManager.GetLogger("fileLogger");

            dbLogger.Info($"{logOutput}");
        }

        public void ExceptionOutput(string ex)
        {
            NLog.Logger dbLogger = LogManager.GetLogger("databaseLogger");
            NLog.Logger fileLogger = LogManager.GetLogger("fileLogger");

            dbLogger.Error($"FedEx Rate Exception: {ex}");
        }

        internal void LogValue(string message)
        {
            NLog.Logger dbLogger = LogManager.GetLogger("databaseLogger");
            NLog.Logger fileLogger = LogManager.GetLogger("fileLogger");

            dbLogger.Error($"{message}");
        }
    }
}