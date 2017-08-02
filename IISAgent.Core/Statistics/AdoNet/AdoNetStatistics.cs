using RMS.IISAgent.Core.Extensions;
using RMS.IISAgent.Core.PerfCounters;
using System.Diagnostics;
using System.Linq;

namespace RMS.IISAgent.Core.Statistics.AdoNet
{
    public abstract class AdoNetStatistics
    {
        public AdoNetStatistics(int processId)
        {
            ProcessId = processId;
        }

        protected abstract PerfCounterCategory CounterCategory { get; }

        protected int ProcessId { get; }

        public int NumberOfActiveConnectionPools { get; protected set; }
        public int NumberOfInactiveConnectionPools { get; protected set; }
        public int NumberOfPooledConnections { get; protected set; }
        public int NumberOfNonPooledConnections { get; protected set; }
        public int NumberOfActiveConnections { get; protected set; }
        public int NumberOfFreeConnections { get; protected set; }
        public int NumberOfReclaimedConnections { get; protected set; }
        public int SoftConnectsPerSecond { get; protected set; }
        public int SoftDisconnectsPerSecond { get; protected set; }

        protected static string GetWorkerInstanceName(int id, PerfCounterCategory category)
        {
            var counterCategory = new PerformanceCounterCategory(category.GetDescription());

            var pidString = $"[{id}]"; // e.g. [2345]

            var iisProcessIdentifierString = "_lm_w3svc_";

            var instances = counterCategory.GetInstanceNames();

            var instance = counterCategory.GetInstanceNames().SingleOrDefault(i =>
                i.StartsWith(iisProcessIdentifierString) &&
                i.EndsWith(pidString));

            return instance;
        }
    }
}