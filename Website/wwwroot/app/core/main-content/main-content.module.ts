import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { StatisticService } from './../../statistic/statistic.service';
import { HttpModule } from '@angular/http';
import { MainContentComponent } from './main-content.component';
import { Routes, RouterModule } from '@angular/router';
import { ChartComponent } from './chart/chart.component';

@NgModule({
    imports: [
        CommonModule,
        FormsModule,
        HttpModule,
        RouterModule.forChild([
            {
                path: 'chart/:name',
                component: ChartComponent
            }
        ])
    ],
    exports: [
        ChartComponent,
        MainContentComponent
    ],
    declarations: [
        ChartComponent,
        MainContentComponent
    ],
    providers: [
        StatisticService
    ]
})

export class MainContentModule {
    constructor() {
      
    }
}
