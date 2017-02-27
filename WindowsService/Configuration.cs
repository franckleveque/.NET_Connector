using System;
using System.Security.Cryptography;

using MWS.Helper;
using System.Net;

namespace MWS.WindowsService
{
    public static class Configuration
    {
        #region Database Specific Settings

        private static string _databaseDriver;
        private static string _databasePath;
        private static string _databaseUser;
        private static string _databasePassword;
        private static string _databaseParameters;


        public static string GetDatabaseDriver()
        {
            return _databaseDriver;
        }

        public static string GetDatabasePath()
        {
            return _databasePath;
        }

        public static string GetDatabaseUser()
        {
            return _databaseUser;
        }

        public static string GetDatabasePassword()
        {
            return _databasePassword;
        }

        public static string GetDatabaseParameters()
        {
            return _databaseParameters;
        }

        #endregion


        #region Movilizer Web Service Specific Settings

        private static long _systemId;
        private static string _systemPassword;
        private static string _encryptionAlgorithm;
        private static string _encryptionPassword;
        private static string _webServiceHost;
        private static string _webServiceProxy;
        private static NetworkCredential _webServiceProxyCredential;
        private static string _webServiceProtocol;
        private static bool _forceRequeingOnError;

        public static long GetSystemId()
        {
            return _systemId;
        }

        public static string GetSystemPassword()
        {
            return _systemPassword;
        }

        public static string GetEncryptionAlgorithm()
        {
            return _encryptionAlgorithm;
        }

        public static string GetEncryptionPassword()
        {
            return _encryptionPassword;
        }

        public static string GetWebServiceHost()
        {
            return _webServiceHost;
        }

        public static string GetWebServiceProtocol()
        {
            return _webServiceProtocol;
        }

        public static string GetWebServiceProxy()
        {
            return _webServiceProxy;
        }

        public static NetworkCredential GetWebServiceProxyCredential() 
        {
            return _webServiceProxyCredential;
        }

        public static bool ForceRequeingOnError()
        {
            return _forceRequeingOnError;
        }

        #endregion


        #region Windows Server Specific Settings

        private static int _serviceTimeInterval;        
        private static string _debugOutputPath;


        public static int GetServiceTimeInterval()
        {
            return _serviceTimeInterval;
        }

        public static string GetDebugOutputPath()
        {
            return _debugOutputPath;
        }



        #endregion

        #region QueuesManager
        private static bool _sendToQueues;
        private static string _RequestQueue;
        private static string _ResponseQueue;

        public static bool GetSendToQueues()
        {
            return _sendToQueues;
        }

        public static string GetRequestQueue()
        {
            return _RequestQueue;
        }

        public static string GetResponseQueue()
        {
            return _ResponseQueue;
        }

        #endregion 

        public static void ReadConfiguration(IConfigurator configurator)
        {
            try
            {
                // database specific settings
                _databaseDriver = configurator.DatabaseDriver;
                _databasePath = configurator.DatabasePath;
                _databaseUser = configurator.DatabaseUser;
                _databasePassword = configurator.DatabasePassword;
                _databaseParameters = configurator.DatabaseParameters;

                // movilizer web service specific settings
                _systemId = configurator.SystemId;
                _systemPassword = configurator.SystemPassword;
                _webServiceProtocol = configurator.WebServiceProtocol;
                _webServiceHost = configurator.WebServiceHost;
                _webServiceProxy = configurator.WebServiceProxy;

                // windows service settings
                _serviceTimeInterval = configurator.ServiceTimeInterval;
                _debugOutputPath = configurator.DebugOutputPath;
                _forceRequeingOnError = configurator.ForceRequeingOnError;
                _sendToQueues = configurator.SendToQueues;
                _RequestQueue = configurator.RequestQueuePath;
                _ResponseQueue = configurator.ResponseQueuePath;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
