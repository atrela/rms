using RMS.IISAgent.Core.Extensions;
using RMS.IISAgent.Core.PerfCounters;
using System;

namespace RMS.IISAgent.Core.Statistics.AdoNet.SqlServer
{
    internal class SqlConnectionStatistics : AdoNetStatistics
    {
        public SqlConnectionStatistics(int processId) : base(processId)
        {
        }

        protected override PerfCounterCategory CounterCategory
        {
            get { return PerfCounterCategory.SqlServerDataProvider; }
        }

        public SqlConnectionStatistics ReadData()
        {
            var dataProvider = new PerfCounterValueProvider();
            var workerInstanceName = GetWorkerInstanceName(ProcessId, PerfCounterCategory.SqlServerDataProvider);

            NumberOfActiveConnectionPools = Convert.ToInt32(
                dataProvider.GetValue(CounterCategory, AdoNetCounter.NumberOfActiveConnectionPools.GetDescription(), workerInstanceName));

            NumberOfInactiveConnectionPools = Convert.ToInt32(
                dataProvider.GetValue(CounterCategory, AdoNetCounter.NumberOfInactiveConnectionPools.GetDescription(), workerInstanceName));

            NumberOfPooledConnections = Convert.ToInt32(
                dataProvider.GetValue(CounterCategory, AdoNetCounter.NumberOfPooledConnections.GetDescription(), workerInstanceName));

            NumberOfNonPooledConnections = Convert.ToInt32(
                dataProvider.GetValue(CounterCategory, AdoNetCounter.NumberOfNonPooledConnections.GetDescription(), workerInstanceName));

            NumberOfActiveConnections = Convert.ToInt32(
                dataProvider.GetValue(CounterCategory, AdoNetCounter.NumberOfActiveConnections.GetDescription(), workerInstanceName));

            NumberOfFreeConnections = Convert.ToInt32(
                dataProvider.GetValue(CounterCategory, AdoNetCounter.NumberOfFreeConnections.GetDescription(), workerInstanceName));

            NumberOfReclaimedConnections = Convert.ToInt32(
                dataProvider.GetValue(CounterCategory, AdoNetCounter.NumberOfReclaimedConnections.GetDescription(), workerInstanceName));

            SoftConnectsPerSecond = Convert.ToInt32(
                dataProvider.GetValue(CounterCategory, AdoNetCounter.SoftConnectsPerSecond.GetDescription(), workerInstanceName));

            SoftDisconnectsPerSecond = Convert.ToInt32(
                dataProvider.GetValue(CounterCategory, AdoNetCounter.SoftDisconnectsPerSecond.GetDescription(), workerInstanceName));

            return this;
        }
    }
}