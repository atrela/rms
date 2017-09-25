import { Component, OnInit } from '@angular/core';
import { BreadCrumbItem } from '../../core/header/bread-crumb/bread-crumb-item';

@Component({
    selector: 'agents-config',
    templateUrl: 'agents-config.component.html'
})
export class AgentsConfigComponent {
    breadCrumbs: Array<BreadCrumbItem>;

    ngOnInit() {
        this.initBreadCrumbs();
    }

    initBreadCrumbs() {
        this.breadCrumbs = [
            new BreadCrumbItem("Configuration"),
            new BreadCrumbItem("Agents")
        ];
    }
}