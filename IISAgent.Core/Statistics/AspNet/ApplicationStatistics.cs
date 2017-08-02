using RMS.IISAgent.Core.Extensions;
using RMS.IISAgent.Core.PerfCounters;
using System;
using System.Diagnostics;
using System.Linq;

namespace RMS.IISAgent.Core.Statistics.AspNet
{
    public class ApplicationStatistics
    {
        /// <summary>
        ///     Represents id of the application.
        /// </summary>
        private readonly long webAppId;

        /// <summary>
        ///     Represents id of the w3wp worker process.
        /// </summary>
        private readonly int processId;

        /// <summary>
        ///     Initializes a new instance of the <see cref="ApplicationStatistics"/> class.
        /// </summary>
        /// <param name="processId">Id of the w3wp worker process</param>
        /// <param name="webAppId">Id of the application</param>
        public ApplicationStatistics(long webAppId, int processId)
        {
            this.webAppId = webAppId;
            this.processId = processId;
        }

        /// <summary>
        ///     Gets instance name of the application worker process.
        /// </summary>
        private string WorkerInstanceName
        {
            get
            {
                var counterCategory = new PerformanceCounterCategory(PerfCounterCategory.AspNetApplications.GetDescription());

                var instanceIdentifier = $"_LM_W3SVC_{webAppId}";

                var instanceName = counterCategory.GetInstanceNames().SingleOrDefault(i => i.ToLower().StartsWith(instanceIdentifier.ToLower()));

                return instanceName;
            }
        }

        /// <summary>
        ///     Gets number of requests executed per second.
        /// </summary>
        public int RequestsPerSecond { get; private set; }

        /// <summary>
        ///     Gets total number of requests since that application was started.
        /// </summary>
        public int TotalRequests { get; private set; }

        /// <summary>
        ///     Reads data from performance counters
        /// </summary>
        /// <returns>Returns statistics for web application.</returns>
        public ApplicationStatistics ReadData()
        {
            var dataProvider = new PerfCounterValueProvider();

            RequestsPerSecond = Convert.ToInt32(
                dataProvider.GetValue(PerfCounterCategory.AspNetApplications, AspNetAppCounter.RequestsPerSecond.GetDescription(), WorkerInstanceName));

            TotalRequests = Convert.ToInt32(
                dataProvider.GetValue(PerfCounterCategory.AspNetApplications, AspNetAppCounter.TotalRequests.GetDescription(), WorkerInstanceName));

            return this;
        }
    }
}