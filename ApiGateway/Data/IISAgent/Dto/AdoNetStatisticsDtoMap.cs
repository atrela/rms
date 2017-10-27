using AutoMapper;
using Logs.Agents.IIS.Model;

namespace ApiGateway.Data.IISAgent.Dto
{
    /// <summary>
    ///     Represents mapping profile for <see cref="AdoNetStatistics"/> data model.
    /// </summary>
    public class AdoNetStatisticsDtoMap : Profile
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AdoNetStatisticsDtoMap"/> class.
        /// </summary>
        public AdoNetStatisticsDtoMap()
        {
            CreateMap<AdoNetStatistics, AdoNetStatisticsDto>().ReverseMap();
        }
    }
}
