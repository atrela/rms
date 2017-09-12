import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ChartComponent } from "./core/main-content/chart/chart.component";
import { MenuComponent } from "./core/menu/menu.component";
import { DefaultComponent } from "./core/main-content/default/default.component";


const routes: Routes = [

   { path: '', component: DefaultComponent }
];

export const routing: ModuleWithProviders = RouterModule.forRoot(routes);