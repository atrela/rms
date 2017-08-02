using AutoMapper;
using RMS.IISAgent.Core.Statistics.AspNet;

namespace RMS.IISAgent.Data.Model
{
    internal class ApplicationStatisticsDtoMap : Profile
    {
        public ApplicationStatisticsDtoMap()
        {
            CreateMap<ApplicationStatistics, ApplicationStatisticsDto>();
        }
    }
}