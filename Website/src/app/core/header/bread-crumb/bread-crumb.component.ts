import { Component, Input } from '@angular/core';
import { BreadCrumbItem } from './bread-crumb-item';

@Component({
    selector: 'bread-crumb',
    templateUrl: 'bread-crumb.component.html'
})


export class BreadCrumbComponent {

    breadCrumbs: Array<BreadCrumbItem> = [
        new BreadCrumbItem('Main'),
        new BreadCrumbItem('Dashboard')
    ];

  
}



