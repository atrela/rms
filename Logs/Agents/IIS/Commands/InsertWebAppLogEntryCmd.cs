using Logs.IISAgent.Model;
using MediatR;

namespace Logs.Agents.IIS.Commands
{
    public class InsertWebAppLogEntryCmd : IRequest
    {
        public InsertWebAppLogEntryCmd(WebAppLogEntry logEntry)
        {
            LogEntry = logEntry;
        }

        public WebAppLogEntry LogEntry { get; }
    }
}