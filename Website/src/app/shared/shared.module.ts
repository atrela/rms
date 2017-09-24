import { NgModule } from '@angular/core';

// bootstrap 
import { PanelType } from './bootstrap/panel-type';

// morris
import { LineChartLegend } from './morris/line-chart-legend';

@NgModule({
    imports: [ ],
     exports: [ 
         PanelType,
         LineChartLegend,
     ],
     declarations: [ 
        PanelType,
        LineChartLegend
     ],
     providers: [ ]
})
export class SharedModule {
    
}