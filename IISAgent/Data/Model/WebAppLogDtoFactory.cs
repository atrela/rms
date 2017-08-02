using AutoMapper;
using RMS.IISAgent.Core.Statistics.AdoNet;
using RMS.IISAgent.Core.Statistics.AspNet;

namespace RMS.IISAgent.Data.Model
{
    internal class WebAppLogDtoFactory
    {
        public WebAppLogDto Create(AdoNetStatistics adoNetStats, ApplicationStatistics appStats)
        {
            var adoNetStatsDto = Mapper.Map<AdoNetStatistics, AdoNetStatisticsDto>(adoNetStats);
            var appStatsDto = Mapper.Map<ApplicationStatistics, ApplicationStatisticsDto>(appStats);

            return new WebAppLogDto
            {
                AdoNetStatistics = adoNetStatsDto,
                ApplicationStatistics = appStatsDto
            };
        }
    }
}