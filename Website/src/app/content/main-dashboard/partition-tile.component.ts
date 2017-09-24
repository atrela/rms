import { Component, Input } from '@angular/core';
import { PartitionTile } from './partition-tile';

@Component({
    selector: 'partition-tile',
    templateUrl: 'partition-tile.component.html'
})
export class PartitionTileComponent {
    @Input() model: PartitionTile;
}