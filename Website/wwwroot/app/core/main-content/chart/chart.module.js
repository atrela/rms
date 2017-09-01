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
//import { ChartComponent } from './chart.component';
var http_1 = require("@angular/http");
var common_1 = require("@angular/common");
var forms_1 = require("@angular/forms");
var chart_routing_1 = require("./chart.routing");
var statistic_service_1 = require("./../../../statistic/statistic.service");
var ChartModule = (function () {
    function ChartModule() {
    }
    return ChartModule;
}());
ChartModule = __decorate([
    core_1.NgModule({
        // declarations: [ChartComponent],
        bootstrap: [],
        imports: [chart_routing_1.routing, http_1.HttpModule, common_1.CommonModule, forms_1.FormsModule],
        exports: [],
        providers: [statistic_service_1.StatisticService],
    }),
    __metadata("design:paramtypes", [])
], ChartModule);
exports.ChartModule = ChartModule;
//# sourceMappingURL=chart.module.js.map