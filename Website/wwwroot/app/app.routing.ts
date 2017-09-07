import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ChartComponent } from "./core/main-content/chart/chart.component";
import { MenuComponent } from "./core/menu/menu.component";


const routes: Routes = [

    //  { path: 'chart/:name', component: ChartComponent },
   // { path: 'chart', component: MenuComponent }
];

export const routing: ModuleWithProviders = RouterModule.forRoot(routes);