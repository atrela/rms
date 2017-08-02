using RMS.IISAgent.Core.Statistics.AdoNet;
using RMS.IISAgent.Core.Statistics.AdoNet.SqlServer;
using RMS.IISAgent.Core.Statistics.AspNet;
using System;

namespace RMS.IISAgent.Core.Web
{
    public class WebApp
    {
        private readonly long id;
        private readonly string name;
        private readonly int processId;

        public WebApp(long id, string name, int processId)
        {
            this.id = id;
            this.processId = processId;
            Name = name;
        }

        public string Name { get; }

        public AdoNetStatistics ReadAdoNetStatistics(DataProvider provider)
        {
            if (provider == DataProvider.SqlServer)
                return new SqlConnectionStatistics(processId).ReadData();

            throw new NotImplementedException($"ADO NET Statistics for given provider {provider.ToString()} are not supported.");
        }

        public ApplicationStatistics ReadApplicationStatistics()
        {
            return new ApplicationStatistics(id, processId).ReadData();
        }
    }
}