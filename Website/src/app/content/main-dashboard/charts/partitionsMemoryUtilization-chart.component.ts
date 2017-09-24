import { Component, OnInit } from '@angular/core';


declare var $: any;
declare var Morris: any;

@Component({
    selector: 'partitions-memory-chart',
    templateUrl: 'partitionsMemoryUtilization-chart.component.html'
})
export class PartitionsMemoryUtilizationChartComponent {
    ngOnInit() {
        Morris.Area({
            element: 'partitionsMemoryUtilizationChart',
            data: [
                { y: '2017-09-17', a: 100, b: 90, c: 12, d: 10 },
                { y: '2017-09-18', a: 75,  b: 65, c: 56, d: 34 },
                { y: '2017-09-19', a: 50,  b: 40, c: 32, d: 12 },
                { y: '2017-09-20', a: 75,  b: 65, c: 98, d: 67 },
                { y: '2017-09-21', a: 50,  b: 40, c: 27, d: 49 },
                { y: '2017-09-22', a: 75,  b: 65, c: 56, d: 12 },
                { y: '2017-09-23', a: 100, b: 90, c: 14, d: 11 }
              ],
              xkey: 'y',
              ykeys: ['a', 'b', 'c', 'd'],
              labels: ['Partition 1', 'Partition 2', 'Partition 3', 'Partition 4']
        });
    }
}