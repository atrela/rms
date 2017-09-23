import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

// content module components
import { MainDashboardComponent } from './content/main-dashboard/main-dashboard.component';

const appRoutes: Routes = [
    { path: '', component: MainDashboardComponent }
];

export const AppRouteModule: ModuleWithProviders = RouterModule.forRoot(appRoutes);