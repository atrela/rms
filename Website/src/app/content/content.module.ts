import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

// core module components
import { HeaderComponent } from '../core/header/header.component';
import { BreadCrumbComponent } from '../core/header/bread-crumb.component';

// module components
import { MainDashboardComponent } from './main-dashboard/main-dashboard.component';

@NgModule({
    imports: [
        BrowserModule
    ],
    exports: [
        HeaderComponent,
        BreadCrumbComponent,
        MainDashboardComponent
    ],
    declarations: [
        HeaderComponent,
        BreadCrumbComponent,
        MainDashboardComponent
    ],
    providers: [

    ]
})
export class ContentModule {

}