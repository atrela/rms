using System.Configuration;

namespace RMS.IISAgent.Configuration
{
    public static class SectionExtensions
    {
        public static T GetSection<T>(this T section, string sectionName) where T : ConfigurationSection
        {
            var configurationFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            return (T)configurationFile.Sections[sectionName];
        }
    }
}