import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { NgModule } from '@angular/core';
import { System } from 'systemjs';
//import { ChartComponent } from './chart.component';
import { HttpModule } from '@angular/http';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { routing } from './chart.routing';
import { StatisticService } from './../../../statistic/statistic.service';

@NgModule({
   // declarations: [ChartComponent],
    bootstrap: [],
    imports: [routing,HttpModule, CommonModule, FormsModule],
    exports: [],
    providers: [StatisticService],
})
export class ChartModule {
    constructor() {

    }
}

