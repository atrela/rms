export interface IAdoNetStatistics {
    numberOfActiveConnectionPools: number;
    numberOfInactiveConnectionPools: number;
    numberOfPooledConnections: number;
    numberOfNonPooledConnections: number;
    numberOfActiveConnections: number;
    numberOfFreeConnections: number;
    numberOfReclaimedConnections: number;
    softConnectsPerSecond: number;
    softDisconnectsPerSecond: number;
}

export interface IApplicationStatistics {
    requestsPerSecond: number;
    totalRequests: number;
}

export interface IIISStatistic {
    appName: string;
    adoNetStatistics: IAdoNetStatistics;
    applicationStatistics: IApplicationStatistics;
    id: number;
}