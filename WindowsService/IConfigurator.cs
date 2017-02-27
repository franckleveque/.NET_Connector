using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace MWS.WindowsService
{
    /// <summary>
    /// Description of interface <see cref="IConfigurator"/>
    /// </summary>
    public interface IConfigurator
    {
        #region Database Specific Settings
        string DatabaseDriver { get; }
        string DatabasePath { get; }
        string DatabaseUser { get; }
        string DatabasePassword { get; }
        string DatabaseParameters { get; }
        #endregion

        #region Movilizer Web Service Specific Settings
        long SystemId { get; }
        string SystemPassword { get; }
        string WebServiceHost { get; }
        string WebServiceProtocol { get; }
        string WebServiceProxy { get; }

        /// <summary>
        /// Returns Network credentials to be used in the proxy, null if default credentials are to be used
        /// </summary>
        NetworkCredential WebServiceProxyCredentials { get; }
        #endregion

        #region Windows Server Specific Settings
        int ServiceTimeInterval { get; }
        string DebugOutputPath { get; }
        bool ForceRequeingOnError { get; }
        bool SendToQueues { get; }
        string RequestQueuePath { get; }
        string ResponseQueuePath { get; }
        #endregion
    }
}