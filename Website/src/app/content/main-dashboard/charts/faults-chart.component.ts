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
                { y: '2017-09-17', a: 100 },
                { y: '2017-09-18', a: 75 },
                { y: '2017-09-19', a: 50 },
                { y: '2017-09-21', a: 75 },
                { y: '2017-09-22', a: 50 },
                { y: '2017-09-23', a: 75 },
                { y: '2017-09-24', a: 100 }
              ],
              xkey: 'y',
              ykeys: ['a'],
              labels: ['Number of faults'],
              pointSize: 0,
              lineColors: [
                  '#FC5130'
              ]
        })
    }
}