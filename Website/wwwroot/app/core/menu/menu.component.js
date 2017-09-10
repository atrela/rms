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
var router_1 = require("@angular/router");
var statistic_service_1 = require("../../statistic/statistic.service");
var MenuComponent = (function () {
    function MenuComponent(_httpService, _router) {
        this._httpService = _httpService;
        this._router = _router;
    }
    MenuComponent.prototype.ngOnInit = function () {
        var _this = this;
        this._httpService.getStatistics()
            .subscribe(function (statistics) {
            _this.statistics = statistics;
        }, function (error) { return _this.errorMessage = error; });
    };
    return MenuComponent;
}());
MenuComponent = __decorate([
    core_1.Component({
        templateUrl: './menu.component.html',
        styleUrls: ['./menu.component.css'],
        selector: 'app-menu',
    }),
    __metadata("design:paramtypes", [statistic_service_1.StatisticService, router_1.Router])
], MenuComponent);
exports.MenuComponent = MenuComponent;
//# sourceMappingURL=menu.component.js.map