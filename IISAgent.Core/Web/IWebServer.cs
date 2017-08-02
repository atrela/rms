using System.Collections.Generic;

namespace RMS.IISAgent.Core.Web
{
    /// <summary>
    ///     Provides contract of the web server.
    /// </summary>
    public interface IWebServer
    {
        /// <summary>
        ///     Gets collection of active application pools on the server.
        /// </summary>
        IEnumerable<WebAppPool> ActiveAppPools { get; }

        /// <summary>
        ///     Gets collection of active applications on the server.
        /// </summary>
        IEnumerable<WebApp> ActiveApps { get; }
    }
}