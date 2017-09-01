"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var router_1 = require("@angular/router");
var chart_component_1 = require("./chart.component");
var routes = [
    { path: '', component: chart_component_1.ChartComponent },
    { path: 'chart', component: chart_component_1.ChartComponent }
];
exports.routing = router_1.RouterModule.forChild(routes);
//# sourceMappingURL=chart.routing.js.map