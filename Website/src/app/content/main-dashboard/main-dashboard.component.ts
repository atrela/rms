import { Component } from '@angular/core';

@Component({
    selector: 'main-dashboard',
    templateUrl: 'main-dashboard.component.html'
})
export class MainDashboardComponent {
    public title: string;

    constructor() {
        this.title= 'Title';
    }
}