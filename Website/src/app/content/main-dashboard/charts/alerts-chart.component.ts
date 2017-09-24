import { Component, OnInit } from '@angular/core';

declare var $: any;
declare var Morris: any;

@Component({
    selector: 'alerts-chart',
    templateUrl: 'alerts-chart.component.html'
})
export class AlertsChartComponent {
    ngOnInit() {
        Morris.Donut({
            element: 'alertsChart',
            data: [
                { label: "Warnings", value: 60 },
                { label: "Errors", value: 20 },
                { label: "Fatals", value: 30 },
            ],
            colors: [
                '#FFE548',
                '#FF4B3E',
                '#582707'
            ]
        });
    }
}