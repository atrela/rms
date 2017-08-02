using RMS.IISAgent.Configuration;
using RMS.IISAgent.Core.Statistics.AdoNet;
using RMS.IISAgent.Core.Web;
using RMS.IISAgent.Data.Model;
using RMS.IISAgent.Data.Service;
using System.Timers;

namespace RMS.IISAgent.Monitoring
{
    public class IISService : IService
    {
        private readonly Timer timer;
        private readonly IWebServer webServer;
        private readonly IConfigurationProvider configurationProvider;
        private readonly IGatewayClient gatewayClient;

        public IISService(IWebServer webServer, IConfigurationProvider configurationProvider,
            IGatewayClient gatewayClient)
        {
            this.webServer = webServer;
            this.configurationProvider = configurationProvider;
            this.gatewayClient = gatewayClient;

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

                // gatewayClient.PushData(dataDto);
            }
        }
    }
}