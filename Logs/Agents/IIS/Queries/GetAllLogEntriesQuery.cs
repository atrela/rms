using Logs.IISAgent.Model;
using MediatR;
using System.Collections.Generic;

namespace Logs.Agents.IIS.Queries
{
    public class GetAllLogEntriesQuery : IRequest<IEnumerable<WebAppLogEntry>>
    {
    }
}