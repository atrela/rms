import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ChartComponent } from "./chart/chart.component";


const routes: Routes = [

    { path: 'chart/:name', component: ChartComponent, runGuardsAndResolvers: 'always' }
];

export const routing: ModuleWithProviders = RouterModule.forRoot(routes);