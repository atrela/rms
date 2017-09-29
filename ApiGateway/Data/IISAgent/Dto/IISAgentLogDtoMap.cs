using AutoMapper;
using Logs.IISAgent.Model;

namespace ApiGateway.Data.IISAgent.Dto
{
    /// <summary>
    ///     Represents mapping profile for <see cref="WebAppLogEntry"/> data model.
    /// </summary>
    public class IISAgentLogDtoMap:Profile
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="IISAgentLogDtoMap"/> class.
        /// </summary>
        public IISAgentLogDtoMap()
        {
            CreateMap<WebAppLogEntry, IISAgentLogDto>().ReverseMap();
        }
    }
}
