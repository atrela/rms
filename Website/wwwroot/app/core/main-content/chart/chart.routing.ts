import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ChartComponent } from './chart.component';

const routes: Routes = [
    { path: '', component: ChartComponent },
    { path: 'chart', component: ChartComponent }
];

export const routing: ModuleWithProviders = RouterModule.forChild(routes);