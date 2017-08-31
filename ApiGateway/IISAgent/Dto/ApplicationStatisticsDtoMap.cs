using AutoMapper;
using Logs.Agents.IIS.Model;

namespace ApiGateway.IISAgent.Dto
{
    /// <summary>
    ///     Represents mapping profile for <see cref="ApplicationStatistics"/> data model.
    /// </summary>
    public class ApplicationStatisticsDtoMap:Profile
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ApplicationStatisticsDtoMap"/> class.
        /// </summary>
        public ApplicationStatisticsDtoMap()
        {
            CreateMap<ApplicationStatistics, ApplicationStatisticsDto>().ReverseMap();
        }
    }
}
