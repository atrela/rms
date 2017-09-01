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
var common_1 = require("@angular/common");
var forms_1 = require("@angular/forms");
var statistic_service_1 = require("./../../statistic/statistic.service");
var http_1 = require("@angular/http");
var main_content_component_1 = require("./main-content.component");
var router_1 = require("@angular/router");
var chart_component_1 = require("./chart/chart.component");
var MainContentModule = (function () {
    function MainContentModule() {
    }
    return MainContentModule;
}());
MainContentModule = __decorate([
    core_1.NgModule({
        imports: [
            common_1.CommonModule,
            forms_1.FormsModule,
            http_1.HttpModule,
            router_1.RouterModule.forChild([
                {
                    path: 'chart/:name',
                    component: chart_component_1.ChartComponent
                }
            ])
        ],
        exports: [
            chart_component_1.ChartComponent,
            main_content_component_1.MainContentComponent
        ],
        declarations: [
            chart_component_1.ChartComponent,
            main_content_component_1.MainContentComponent
        ],
        providers: [
            statistic_service_1.StatisticService
        ]
    }),
    __metadata("design:paramtypes", [])
], MainContentModule);
exports.MainContentModule = MainContentModule;
//# sourceMappingURL=main-content.module.js.map