import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { StatisticService } from './../../statistic/statistic.service';
import { HttpModule } from '@angular/http';
import { DefaultComponent } from './default/default.component';
import { Routes, RouterModule } from '@angular/router';
import { ChartComponent } from './chart/chart.component';
import { routing } from "./main-content.routing";


@NgModule({
    imports: [
        CommonModule,
        FormsModule,
        HttpModule,
        RouterModule,
        routing
   
    ],
    exports: [
        DefaultComponent
    ],
    declarations: [
        ChartComponent,
        DefaultComponent
    ],
    providers: [
        StatisticService
    ]
})

export class MainContentModule {
    constructor() {

        
    }
}
