using System.ComponentModel;

namespace RMS.IISAgent.Core.Statistics.AspNet
{
    internal enum AspNetAppCounter
    {
        [Description("Requests Total")]
        TotalRequests,

        [Description("Requests/Sec")]
        RequestsPerSecond
    }
}