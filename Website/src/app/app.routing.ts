import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

// content module components
import { MainDashboardComponent } from './content/main-dashboard/main-dashboard.component';
import { AgentsConfigComponent } from './content/configuration/agents-config.component';

const appRoutes: Routes = [
    { path: '', component: MainDashboardComponent },
    { path: 'config/agents', component: AgentsConfigComponent }
];

export const AppRouteModule: ModuleWithProviders = RouterModule.forRoot(appRoutes);