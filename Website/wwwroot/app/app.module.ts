
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { HashLocationStrategy, LocationStrategy } from '@angular/common';
import { CoreModule } from './core/core.module';
import { routing } from './app.routing';

@NgModule({
    declarations: [
        AppComponent
    ],
    bootstrap: [AppComponent],
    providers: [{ provide: LocationStrategy, useClass: HashLocationStrategy }],
    imports: [
        CoreModule,
        routing
    ],
    exports: []
})
export class AppModule { }