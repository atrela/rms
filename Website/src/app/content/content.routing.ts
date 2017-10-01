import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PartitionDashboardComponent } from  './partition-dashboard/partition-dashboard.component';


const routes: Routes = [

    { path: 'partition/:id', component: PartitionDashboardComponent, runGuardsAndResolvers: 'always' }
];

export const routing: ModuleWithProviders = RouterModule.forRoot(routes);