import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
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
   BrowserModule,
        CoreModule,
        routing
    ],
    exports: []
})
export class AppModule { }