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
var statistic_service_1 = require("../statistic/statistic.service");
var http_1 = require("@angular/http");
var menu_component_1 = require("./menu/menu.component");
var footer_component_1 = require("./footer/footer.component");
var control_sidebar_component_1 = require("./control-sidebar/control-sidebar.component");
var router_1 = require("@angular/router");
var main_content_module_1 = require("./main-content/main-content.module");
var CoreModule = (function () {
    function CoreModule() {
    }
    return CoreModule;
}());
CoreModule = __decorate([
    core_1.NgModule({
        imports: [
            common_1.CommonModule,
            forms_1.FormsModule,
            http_1.HttpModule,
            router_1.RouterModule,
            main_content_module_1.MainContentModule
        ],
        exports: [
            menu_component_1.MenuComponent,
            footer_component_1.FooterComponent,
            main_content_module_1.MainContentModule,
            control_sidebar_component_1.ControlSidebarComponent
        ],
        declarations: [
            menu_component_1.MenuComponent,
            footer_component_1.FooterComponent,
            control_sidebar_component_1.ControlSidebarComponent
        ],
        providers: [
            statistic_service_1.StatisticService
        ]
    }),
    __metadata("design:paramtypes", [])
], CoreModule);
exports.CoreModule = CoreModule;
//# sourceMappingURL=core.module.js.map