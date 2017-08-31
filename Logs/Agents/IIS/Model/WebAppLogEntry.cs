using Logs.Agents.IIS.Model;
using Logs.IISAgent.Base;

namespace Logs.IISAgent.Model
{
    public class WebAppLogEntry : MongoDocument
    {
        public string AppName { get; set; }
        public AdoNetStatistics AdoNetStatistics { get; set; }
        public ApplicationStatistics ApplicationStatistics { get; set; }
    }
}