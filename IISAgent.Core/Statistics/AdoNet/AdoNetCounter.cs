namespace RMS.IISAgent.Core.Statistics.AdoNet
{
    internal enum AdoNetCounter
    {
        /// <summary>
        ///     The total number of connection pools.
        /// </summary>
        NumberOfActiveConnectionPools,

        /// <summary>
        ///     The number of inactive connection pools that have not had any recent activity and are waiting to be disposed.
        /// </summary>
        NumberOfInactiveConnectionPools,

        /// <summary>
        ///     The number of active connections that are being managed by the connection pooling infrastructure.
        /// </summary>
        NumberOfPooledConnections,

        /// <summary>
        ///     The number of active connections that are not pooled.
        /// </summary>
        NumberOfNonPooledConnections,

        /// <summary>
        ///     The number of active connections that are currently in use.
        ///     This performance counter is not enabled by default. To enable this performance counter,
        ///     see https://msdn.microsoft.com/en-us/library/ms254503(v=vs.110).aspx#ActivatingOffByDefault
        /// </summary>
        NumberOfActiveConnections,

        /// <summary>
        ///     The number of active connections that are currently in use.
        ///     This performance counter is not enabled by default. To enable this performance counter,
        ///     see https://msdn.microsoft.com/en-us/library/ms254503(v=vs.110).aspx#ActivatingOffByDefault
        /// </summary>
        NumberOfFreeConnections,

        /// <summary>
        ///     The number of connections that have been reclaimed through garbage collection where
        ///     Close or Dispose was not called by the application. Not explicitly closing or disposing connections
        ///     hurts performance.
        /// </summary>
        NumberOfReclaimedConnections,

        /// <summary>
        ///     The number of active connections being pulled from the connection pool.
        ///     This performance counter is not enabled by default. To enable this performance counter,
        ///     see https://msdn.microsoft.com/en-us/library/ms254503(v=vs.110).aspx#ActivatingOffByDefault
        /// </summary>
        SoftConnectsPerSecond,

        /// <summary>
        ///     The number of active connections that are being returned to the connection pool.
        ///     This performance counter is not enabled by default. To enable this performance counter,
        ///     see https://msdn.microsoft.com/en-us/library/ms254503(v=vs.110).aspx#ActivatingOffByDefault
        /// </summary>
        SoftDisconnectsPerSecond
    }
}