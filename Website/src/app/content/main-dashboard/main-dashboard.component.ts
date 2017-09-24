import { Component } from '@angular/core';
import { PartitionTile } from './partition-tile';
import { PanelType } from '../../shared/bootstrap/panel-type';

@Component({
    selector: 'main-dashboard',
    templateUrl: 'main-dashboard.component.html'
})
export class MainDashboardComponent {
    public title: string;

    constructor() {
        this.title= 'Title';
    }

    partitionTiles: Array<PartitionTile> = [
        new PartitionTile('Partition 1', 'View Details', 3, PanelType.primary),
        new PartitionTile('Partition 2', 'View Details', 1, PanelType.green),
        new PartitionTile('Partition 3', 'View Details', 5, PanelType.yellow),
        new PartitionTile('Partition 4', 'View Details', 7, PanelType.red)
    ]
}