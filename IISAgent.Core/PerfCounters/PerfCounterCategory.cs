using System.ComponentModel;

namespace RMS.IISAgent.Core.PerfCounters
{
    public enum PerfCounterCategory
    {
        [Description(".NET Data Provider for SqlServer")]
        SqlServerDataProvider,

        OracleDataProvider,

        [Description("ASP.NET Applications")]
        AspNetApplications
    }
}