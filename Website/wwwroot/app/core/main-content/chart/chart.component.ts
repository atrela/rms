import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { Router} from '@angular/router';
import { IStatistic } from './../../../statistic/statistic';
import { StatisticService } from './../../../statistic/statistic.service';
import { Observable } from "rxjs/Observable";

declare var System: any; 

@Component({
    templateUrl: './chart.component.html',
    styleUrls: ['./chart.component.css'],
    selector: 'app-chart',
})

export class ChartComponent implements OnInit {
        
    constructor(private _httpService: StatisticService, private _router: Router) { }
    chartLength: number = 11;
    statistics: IStatistic[];
    appName: string;
    errorMessage: string;
    statistic: IStatistic;
    numberOfActiveConnectionPools: number[] = [];
    numberOfInactiveConnectionPools: number[] = [];
    numberOfPooledConnections: number[] = [];
    numberOfNonPooledConnections: number[] = [];
    numberOfActiveConnections: number[] = [];
    numberOfFreeConnections: number[] = [];
    numberOfReclaimedConnections: number[] = [];
    softConnectsPerSecond: number[] = [];
    softDisconnectsPerSecond: number[] = [];
    totalRequests: number[] = [];
    requestsPerSecond: number[] = [];
   // private sub: Subscription;


    ngOnInit() {

        //this.sub = this._route.params.subscribe(
        //    params => {
        //        let name = +params['name'];
        //        this.getStatistic(name);
        //    });

      
        this._httpService.getStatistics()
            .subscribe(statistics => {
                this.statistics = statistics;
                setInterval(() => {
                   this.performUpdate();
                }, 1000);
                this.appName = 'Test app Ola';
             this.getStatistic(this.appName);
                },
            error => this.errorMessage = <any>error);
    }

    getStatistic(name: string) {
        this._httpService.getStatistic(name).subscribe(
            statistic => this.statistic = statistic,
            error => this.errorMessage = <any>error);    
    }

    performUpdate()
    {
       this.getStatistic('Ola');

        this.numberOfActiveConnectionPools.push(this.statistic.adoNetStatistics.numberOfActiveConnectionPools);
        this.numberOfInactiveConnectionPools.push(this.statistic.adoNetStatistics.numberOfInactiveConnectionPools);
        this.numberOfPooledConnections.push(this.statistic.adoNetStatistics.numberOfPooledConnections);
        this.numberOfNonPooledConnections.push(this.statistic.adoNetStatistics.numberOfNonPooledConnections);
        this.numberOfActiveConnections.push(this.statistic.adoNetStatistics.numberOfActiveConnections);
        this.numberOfFreeConnections.push(this.statistic.adoNetStatistics.numberOfFreeConnections);
        this.numberOfReclaimedConnections.push(this.statistic.adoNetStatistics.numberOfReclaimedConnections);
        this.softConnectsPerSecond.push(this.statistic.adoNetStatistics.softConnectsPerSecond);
        this.softDisconnectsPerSecond.push(this.statistic.adoNetStatistics.softDisconnectsPerSecond);

        this.requestsPerSecond.push(this.statistic.applicationStatistics.requestsPerSecond);
        this.totalRequests.push(this.statistic.applicationStatistics.totalRequests);

        this.checkLength(this.numberOfActiveConnectionPools);
        this.checkLength(this.numberOfInactiveConnectionPools);
        this.checkLength(this.numberOfPooledConnections);
        this.checkLength(this.numberOfNonPooledConnections);
        this.checkLength(this.numberOfActiveConnections);
        this.checkLength(this.numberOfFreeConnections);
        this.checkLength(this.numberOfReclaimedConnections);
        this.checkLength(this.softConnectsPerSecond);
        this.checkLength(this.softDisconnectsPerSecond);

        this.checkLength(this.requestsPerSecond);
        this.checkLength(this.totalRequests);

        var numberOfActiveConnectionPools = this.numberOfActiveConnectionPools;
        var numberOfInactiveConnectionPools = this.numberOfInactiveConnectionPools;
        var numberOfPooledConnections = this.numberOfPooledConnections;
        var numberOfNonPooledConnections = this.numberOfNonPooledConnections;
        var numberOfActiveConnections = this.numberOfActiveConnections;
        var numberOfFreeConnections = this.numberOfFreeConnections;
        var numberOfReclaimedConnections = this.numberOfReclaimedConnections;
        var softConnectsPerSecond = this.softConnectsPerSecond;
        var softDisconnectsPerSecond = this.softDisconnectsPerSecond;
        var requestsPerSecond = this.requestsPerSecond;
        var totalRequests = this.totalRequests;

        System.import("scripts/chart/dynamic-chart.js")
            .then(function (xJS) {

                xJS.updateChartValues
                    (
                    numberOfActiveConnectionPools,
                    numberOfInactiveConnectionPools,
                    numberOfPooledConnections,
                    numberOfNonPooledConnections,
                    numberOfActiveConnections,
                    numberOfFreeConnections,
                    numberOfReclaimedConnections,
                    softConnectsPerSecond,
                    softDisconnectsPerSecond,
                    requestsPerSecond,
                    totalRequests
                    );
            });  
    }

    checkLength(arr: Array<number>)
    {
        if (arr.length > this.chartLength)
            arr.shift();
    }
   
}
