"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var statistic_service_1 = require("./../../../statistic/statistic.service");
var ChartComponent = (function () {
    function ChartComponent(_httpService) {
        this._httpService = _httpService;
        this.chartLength = 11;
        this.numberOfActiveConnectionPools = [];
        this.numberOfInactiveConnectionPools = [];
        this.numberOfPooledConnections = [];
        this.numberOfNonPooledConnections = [];
        this.numberOfActiveConnections = [];
        this.numberOfFreeConnections = [];
        this.numberOfReclaimedConnections = [];
        this.softConnectsPerSecond = [];
        this.softDisconnectsPerSecond = [];
        this.totalRequests = [];
        this.requestsPerSecond = [];
    }
    ChartComponent.prototype.ngOnInit = function () {
        var _this = this;
        this._httpService.getStatistics()
            .subscribe(function (statistics) {
            _this.statistics = statistics;
            setInterval(function () {
                _this.performUpdate();
            }, 1000);
            _this.name = 'Test app Ola';
            _this.getStatistic(_this.name);
        }, function (error) { return _this.errorMessage = error; });
    };
    ChartComponent.prototype.getStatistic = function (name) {
        var _this = this;
        this._httpService.getStatistic(name).subscribe(function (statistic) { return _this.statistic = statistic; }, function (error) { return _this.errorMessage = error; });
    };
    ChartComponent.prototype.performUpdate = function () {
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
            xJS.updateChartValues(numberOfActiveConnectionPools, numberOfInactiveConnectionPools, numberOfPooledConnections, numberOfNonPooledConnections, numberOfActiveConnections, numberOfFreeConnections, numberOfReclaimedConnections, softConnectsPerSecond, softDisconnectsPerSecond, requestsPerSecond, totalRequests);
        });
    };
    ChartComponent.prototype.checkLength = function (arr) {
        if (arr.length > this.chartLength)
            arr.shift();
    };
    return ChartComponent;
}());
ChartComponent = __decorate([
    core_1.Component({
        templateUrl: './chart.component.html',
        styleUrls: ['./chart.component.css'],
        selector: 'app-chart',
    }),
    __metadata("design:paramtypes", [statistic_service_1.StatisticService])
], ChartComponent);
exports.ChartComponent = ChartComponent;
//# sourceMappingURL=chart.component.js.map