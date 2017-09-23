import { NgModule } from '@angular/core';

import { AppRouteModule } from '../app.routing';

// core components
import { NavBarComponent } from './nav/navbar.component';
import { NavbarLeftComponent } from './nav/navbar-left.component';
import { NavbarTopComponent } from './nav/navbar-top.component';
import { MainContentComponent } from './main/main-content.component';

@NgModule({
    imports: [
       AppRouteModule
    ],
    exports: [
        NavBarComponent,
        NavbarLeftComponent,
        NavbarTopComponent,
        MainContentComponent,
    ],
    declarations: [
        NavBarComponent,
        NavbarLeftComponent,
        NavbarTopComponent,
        MainContentComponent,
    ],
    providers: [

    ]
})
export class CoreModule {

}