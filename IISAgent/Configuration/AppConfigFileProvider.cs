using System.Configuration;

namespace RMS.IISAgent.Configuration
{
    public class AppConfigFileProvider : IConfigurationProvider
    {
        public string ServiceName
        {
            get { return ConfigurationManager.AppSettings[nameof(ServiceName)]; }
        }

        public string ServiceDisplayName
        {
            get { return ConfigurationManager.AppSettings[nameof(ServiceDisplayName)]; }
        }

        public string ServiceDescription
        {
            get { return ConfigurationManager.AppSettings[nameof(ServiceDescription)]; }
        }

        public double MonitorTimerInterval
        {
            get
            {
                return new MonitorSection().GetSection(MonitorSection.SectionName).TimerInterval;
            }
        }

        public string GatewayUrl
        {
            get
            {
                return new MonitorSection().GetSection(MonitorSection.SectionName).GatewayUrl;
            }
        }
    }
}