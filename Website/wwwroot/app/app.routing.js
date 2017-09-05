"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var router_1 = require("@angular/router");
var chart_component_1 = require("./core/main-content/chart/chart.component");
var main_content_component_1 = require("./core/main-content/main-content.component");
var routes = [
    { path: 'chart/:name', component: chart_component_1.ChartComponent },
    { path: '', component: main_content_component_1.MainContentComponent }
];
exports.routing = router_1.RouterModule.forRoot(routes);
//# sourceMappingURL=app.routing.js.map