import { Component, OnInit } from '@angular/core';

declare var $: any;
declare var Morris: any;

@Component({
    selector: 'faults-chart',
    templateUrl: 'faults-chart.component.html'
})
export class FaultsChartComponent {
    
    
    ngOnInit() {
        Morris.Area({
            element: 'faultsChart',
            data: [
                { y: '2017-09-17', a: 100, b: 90 },
                { y: '2017-09-18', a: 75,  b: 65 },
                { y: '2017-09-19', a: 50,  b: 40 },
                { y: '2017-09-21', a: 75,  b: 65 },
                { y: '2017-09-22', a: 50,  b: 40 },
                { y: '2017-09-23', a: 75,  b: 65 },
                { y: '2017-09-24', a: 100, b: 90 }
              ],
              xkey: 'y',
              ykeys: ['a', 'b'],
              labels: ['Series A', 'Series B'],
              pointSize: 0
        })
    }
}