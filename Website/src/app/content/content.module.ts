import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

// core module components
import { HeaderComponent } from '../core/header/header.component';
import { BreadCrumbComponent } from '../core/header/bread-crumb/bread-crumb.component';

// content module components
import { MainDashboardComponent } from './main-dashboard/main-dashboard.component';
import { PartitionTileComponent } from './main-dashboard/partition-tile.component';
import { FaultsChartComponent } from './main-dashboard/faults-chart.component';

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
    ],
    declarations: [
        HeaderComponent,
        BreadCrumbComponent,
        MainDashboardComponent,
        PartitionTileComponent,
        FaultsChartComponent,
    ],
    providers: [

    ]
})
export class ContentModule {

}