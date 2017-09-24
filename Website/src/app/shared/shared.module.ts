import { NgModule } from '@angular/core';

// bootstrap 
import { PanelType } from './bootstrap/panel-type';

@NgModule({
    imports: [ ],
     exports: [ 
         PanelType,
     ],
     declarations: [ 
        PanelType,
     ],
     providers: [ ]
})
export class SharedModule {
    
}