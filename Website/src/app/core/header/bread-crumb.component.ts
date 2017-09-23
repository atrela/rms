import { Component, Input } from '@angular/core';

@Component({
    selector: 'bread-crumb',
    templateUrl: 'bread-crumb.component.html'
})
export class BreadCrumbComponent {
    breadCrumbs: Array<BreadCrumbItem> = [
        new BreadCrumbItem('fa fa-dashboard','Main'),
        new BreadCrumbItem('fa fa-dashboard','Dashboard')
    ];
}

export class BreadCrumbItem {
    public icon: string;
    public name: string;

    constructor(icon: string, name: string) {
        this.icon = icon;
        this.name = name;
    }
}