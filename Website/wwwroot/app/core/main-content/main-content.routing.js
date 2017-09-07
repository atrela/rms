"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var router_1 = require("@angular/router");
var chart_component_1 = require("./chart/chart.component");
var routes = [
    { path: 'chart/:name', component: chart_component_1.ChartComponent, runGuardsAndResolvers: 'always' }
];
exports.routing = router_1.RouterModule.forRoot(routes);
//# sourceMappingURL=main-content.routing.js.map