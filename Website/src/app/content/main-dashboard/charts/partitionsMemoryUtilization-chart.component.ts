import { Component, OnInit } from '@angular/core';
import { LineChartLegend } from '../../../shared/morris/line-chart-legend';

declare var $: any;
declare var Morris: any;

@Component({
    selector: 'partitions-memory-chart',
    templateUrl: 'partitionsMemoryUtilization-chart.component.html'
})
export class PartitionsMemoryUtilizationChartComponent {

    legendLabels: Array<LineChartLegend> = [
        new LineChartLegend('Partition A', '#D2AB99'),
        new LineChartLegend('Partition B', '#3F7CAC'),
        new LineChartLegend('Partition C', '#227C48'),
        new LineChartLegend('Partition D', '#F99D3E'),
    ]

    ngOnInit() {
        Morris.Line({
            element: 'partitionsMemoryUtilizationChart',
            data: [
                { time: '2017-09-24 13:20', a: 65, b: 15, c: 23, d: 45 },
                { time: '2017-09-24 13:21', a: 60, b: 17, c: 20, d: 40 },
                { time: '2017-09-24 13:22', a: 57, b: 12, c: 25, d: 42 },
                { time: '2017-09-24 13:23', a: 69, b: 13, c: 24, d: 41 },
                { time: '2017-09-24 13:24', a: 63, b: 19, c: 17, d: 42 },
                { time: '2017-09-24 13:25', a: 66, b: 21, c: 26, d: 38 },
                { time: '2017-09-24 13:26', a: 71, b: 16, c: 29, d: 35 },
                { time: '2017-09-24 13:27', a: 62, b: 15, c: 25, d: 44 },
                { time: '2017-09-24 13:28', a: 62, b: 19, c: 30, d: 45 },
                { time: '2017-09-24 13:30', a: 58, b: 25, c: 24, d: 45 },
                { time: '2017-09-24 13:31', a: 59, b: 23, c: 23, d: 41 },
                { time: '2017-09-24 13:32', a: 64, b: 22, c: 28, d: 47 },
                { time: '2017-09-24 13:33', a: 64, b: 19, c: 29, d: 42 },
                { time: '2017-09-24 13:34', a: 71, b: 20, c: 32, d: 38 },
                { time: '2017-09-24 13:35', a: 72, b: 21, c: 30, d: 37 },
                { time: '2017-09-24 13:36', a: 75, b: 17, c: 31, d: 38 },
                { time: '2017-09-24 13:37', a: 65, b: 19, c: 28, d: 35 },
               { time: '2017-09-24 13:38', a: 60, b: 20, c: 27, d: 37 }
              ],
              xkey: 'time',
              xLabels: 'minute',
              ykeys: ['a', 'b', 'c', 'd'],
              continuousLine: false,
              pointSize: 0,
              hideHover: 'always',
              lineColors: [
                  this.legendLabels[0].color,
                  this.legendLabels[1].color,
                  this.legendLabels[2].color,
                  this.legendLabels[3].color,
              ]
        });
    }
}