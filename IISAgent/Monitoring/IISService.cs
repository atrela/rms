using AgentSDK.ServiceBase;
using AgentSDK.WebApi;
using RMS.IISAgent.Configuration;
using RMS.IISAgent.Core.Statistics.AdoNet;
using RMS.IISAgent.Core.Web;
using RMS.IISAgent.Data.Model;
using System;
using System.Timers;

namespace RMS.IISAgent.Monitoring
{
    public class IISService : IService
    {
        private readonly Timer timer;
        private readonly IWebServer webServer;
        private readonly IConfigurationProvider configurationProvider;
        private readonly IApiClient<WebAppLogDto> apiClient;

        public IISService(IWebServer webServer, IConfigurationProvider configurationProvider,
            IApiClient<WebAppLogDto> apiClient)
        {
            this.webServer = webServer;
            this.configurationProvider = configurationProvider;
            this.apiClient = apiClient;

            timer = new Timer(configurationProvider.MonitorTimerInterval);
            timer.Elapsed += Timer_Elapsed;
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public void Pause()
        {
            timer.Stop();
        }

        public void Continue()
        {
            timer.Start();
        }

        public void Shutdown()
        {
            timer.Stop();
            timer.Dispose();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            foreach (var app in webServer.ActiveApps)
            {
                var adoNetStats = app.ReadAdoNetStatistics(DataProvider.SqlServer);
                var appStats = app.ReadApplicationStatistics();

                var dataDto = new WebAppLogDtoFactory().Create(adoNetStats, appStats);

                var agentLogResource = "iisagent/log"; // move to app config
                var uri = new Uri($"{configurationProvider.GatewayUrl}/{agentLogResource}");

                apiClient.PostData(uri, dataDto);
            }
        }
    }
}