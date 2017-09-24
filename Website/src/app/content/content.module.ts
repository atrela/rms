import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

// core module components
import { HeaderComponent } from '../core/header/header.component';
import { BreadCrumbComponent } from '../core/header/bread-crumb/bread-crumb.component';

// content module components
import { MainDashboardComponent } from './main-dashboard/main-dashboard.component';
import { PartitionTileComponent } from './main-dashboard/partition-tile.component';
import { FaultsChartComponent } from './main-dashboard/charts/faults-chart.component';
import { AlertsChartComponent } from './main-dashboard/charts/alerts-chart.component';
import { PartitionsCpuUtilizationChartComponent } from './main-dashboard/charts/partitionsCpuUtilization-chart.component';
import { PartitionsMemoryUtilizationChartComponent } from './main-dashboard/charts/partitionsMemoryUtilization-chart.component';

@NgModule({
    imports: [
        BrowserModule
    ],
    exports: [
        HeaderComponent,
        BreadCrumbComponent,
        MainDashboardComponent,
        PartitionTileComponent,
        FaultsChartComponent,
        AlertsChartComponent,
        PartitionsCpuUtilizationChartComponent,
        PartitionsMemoryUtilizationChartComponent,
    ],
    declarations: [
        HeaderComponent,
        BreadCrumbComponent,
        MainDashboardComponent,
        PartitionTileComponent,
        FaultsChartComponent,
        AlertsChartComponent,
        PartitionsCpuUtilizationChartComponent,
        PartitionsMemoryUtilizationChartComponent
    ],
    providers: [

    ]
})
export class ContentModule {

}