import { Component, OnInit } from '@angular/core';
import { PartitionTile } from './partition-tile';
import { PanelType } from '../../shared/bootstrap/panel-type';
import { BreadCrumbItem } from '../../core/header/bread-crumb/bread-crumb-item';

@Component({
    selector: 'main-dashboard',
    templateUrl: 'main-dashboard.component.html'
})
export class MainDashboardComponent {
    breadCrumbs: Array<BreadCrumbItem>;
    partitionTiles: Array<PartitionTile>;

    ngOnInit() {
        this.initBreadCrumbs();
        this.initPartitionTiles();
    }

    initBreadCrumbs() {
        this.breadCrumbs = [
            new BreadCrumbItem("Main"),
            new BreadCrumbItem("Dashboard")
        ];
    }

    initPartitionTiles() {
        this.partitionTiles = [
            new PartitionTile('Partition 1', 'View Details', 3, PanelType.primary),
            new PartitionTile('Partition 2', 'View Details', 1, PanelType.green),
            new PartitionTile('Partition 3', 'View Details', 5, PanelType.yellow),
            new PartitionTile('Partition 4', 'View Details', 7, PanelType.red)
        ]
    }
}