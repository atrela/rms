import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ChartComponent } from "./core/main-content/chart/chart.component";
import { MainContentComponent } from "./core/main-content/main-content.component";

const routes: Routes = [

    { path: 'chart/:name', component: ChartComponent },
    { path: '', component: MainContentComponent }
   
];

export const routing: ModuleWithProviders = RouterModule.forRoot(routes);