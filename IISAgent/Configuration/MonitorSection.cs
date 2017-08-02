using System.Configuration;

namespace RMS.IISAgent.Configuration
{
    public class MonitorSection : ConfigurationSection
    {
        public const string SectionName = "monitor";

        public const string TimerIntervalProperty = "timerInterval";

        [ConfigurationProperty(TimerIntervalProperty, IsRequired = true, DefaultValue = 5000d)]
        public double TimerInterval
        {
            get { return (double)this[TimerIntervalProperty]; }
            set { this[TimerIntervalProperty] = value; }
        }

        public const string GatewayUrlProperty = "gatewayUrl";

        [ConfigurationProperty(GatewayUrlProperty, IsRequired = true)]
        public string GatewayUrl
        {
            get { return (string)this[GatewayUrlProperty]; }
            set { this[GatewayUrlProperty] = value; }
        }
    }
}