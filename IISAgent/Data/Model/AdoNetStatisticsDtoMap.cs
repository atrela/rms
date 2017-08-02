using AutoMapper;
using RMS.IISAgent.Core.Statistics.AdoNet;

namespace RMS.IISAgent.Data.Model
{
    internal class AdoNetStatisticsDtoMap : Profile
    {
        public AdoNetStatisticsDtoMap()
        {
            CreateMap<AdoNetStatistics, AdoNetStatisticsDto>();
        }
    }
}