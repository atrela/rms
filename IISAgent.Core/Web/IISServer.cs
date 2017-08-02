using Microsoft.Web.Administration;
using System.Collections.Generic;
using System.Linq;

namespace RMS.IISAgent.Core.Web
{
    public class IISServer : IWebServer
    {
        public IEnumerable<WebAppPool> ActiveAppPools
        {
            get
            {
                using (var serverManager = new ServerManager())
                {
                    var appPools = new List<WebAppPool>();

                    foreach (var appPool in serverManager.ApplicationPools)
                    {
                        var workerProcess = serverManager.WorkerProcesses.SingleOrDefault((worker => worker.AppPoolName.Equals(appPool.Name)));
                        if (workerProcess == null)
                            continue;

                        var webAppPool = new WebAppPool(appPool.Name, workerProcess.ProcessId);

                        appPools.Add(webAppPool);
                    }

                    return appPools;
                }
            }
        }

        public IEnumerable<WebApp> ActiveApps
        {
            get
            {
                using (var serverManager = new ServerManager())
                {
                    var webApps = new List<WebApp>();

                    foreach (var site in serverManager.Sites)
                    {
                        var workerProcess = serverManager.WorkerProcesses.SingleOrDefault(worker => worker.AppPoolName.Equals(site.Name));
                        if (workerProcess == null)
                            continue;

                        var webApp = new WebApp(site.Id, site.Name, workerProcess.ProcessId);

                        webApps.Add(webApp);
                    }

                    return webApps;
                }
            }
        }
    }
}