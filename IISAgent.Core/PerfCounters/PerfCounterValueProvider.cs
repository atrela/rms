using RMS.IISAgent.Core.Extensions;
using System.Diagnostics;

namespace RMS.IISAgent.Core.PerfCounters
{
    internal class PerfCounterValueProvider
    {
        public float GetValue(PerfCounterCategory category, string counterName, string instanceName)
        {
            var perfCounter = new PerformanceCounter
            {
                CategoryName = category.GetDescription(),
                InstanceName = instanceName,
                CounterName = counterName
            };

            return perfCounter.NextValue();
        }
    }
}