import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { StatisticService } from '../statistic/statistic.service';
import { HttpModule } from '@angular/http';
import { MenuComponent } from './menu/menu.component';
import { FooterComponent } from './footer/footer.component';
import { ControlSidebarComponent } from './control-sidebar/control-sidebar.component';
import { Routes, RouterModule } from '@angular/router';
import { MainContentModule } from './main-content/main-content.module';


@NgModule({
    imports: [
        CommonModule,
        FormsModule,
        HttpModule,
        RouterModule,
        MainContentModule
    ],
    exports: [
        MenuComponent,
        FooterComponent,
        MainContentModule,
        ControlSidebarComponent
    ],
    declarations: [
        MenuComponent,
        FooterComponent,
        ControlSidebarComponent
    ],
    providers: [
        StatisticService
    ]
})

export class CoreModule {
    constructor() {
      
    }
}
