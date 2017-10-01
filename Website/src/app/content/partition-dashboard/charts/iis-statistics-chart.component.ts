import { Component, OnInit, Input,OnDestroy, AfterViewInit } from '@angular/core';
import { LineChartLegend } from '../../../shared/morris/line-chart-legend';
import { Router, ActivatedRoute} from '@angular/router';
import { IIISStatistic } from './../iis-statistics';
import { IISStatisticService } from './../iis-statistics.service';

declare var $: any;
declare var Morris: any;

@Component({
    selector: 'iis-statistics-chart',
    templateUrl: 'iis-statistics-chart.component.html'
})
export class IISStatisticsChartComponent implements OnInit, OnDestroy,AfterViewInit{

    private sub: any;
    private errorMessage: string;
    private statistic: IIISStatistic;
    private adoNetStatiscticId: string;
    private applicationStatisticId: string;
    private adoNetLegendLabels: Array<LineChartLegend>;
    private applicationLegendLabels: Array<LineChartLegend>;

    @Input() id: number;
   
    ngOnInit() {
        
                this.adoNetStatiscticId='iis-adonet-statistic-'+ this.id;
                this.applicationStatisticId='iis-application-statistic-'+ this.id;
        
                this.adoNetLegendLabels = [
                    new LineChartLegend('Number of active connection pools', '#3F7CAC'),
                    new LineChartLegend('Number of inactive connection pools', '#E12525'),
                    new LineChartLegend('Number of pooled connections', '#E86AF0'),
                    new LineChartLegend('Number of non pooled connections','#999999'),
                    new LineChartLegend('Number of active connections', '#D2AB99'),
                    new LineChartLegend('Number of free connections', '#3399FF'),
                    new LineChartLegend('Number of reclaimed connections', '#FFBF00'),
                    new LineChartLegend('Soft connects per second', '#00B159'),
                    new LineChartLegend('Soft disconnects per second', '#9E379F'),
                ]

                this.applicationLegendLabels = [
                    new LineChartLegend('Requests per second','#FF6F69'),
                    new LineChartLegend('Total requests', '#88D8B0'),    
                ]
        
            }

    ngAfterViewInit()
    {
        Morris.Line({
            element: this.adoNetStatiscticId,
            data: [
                { time: '2017-09-24 13:20', a: 65, b: 15, c: 23, d: 45, e:32, f:25, g:44, h:8, i: 6},
                { time: '2017-09-24 13:21', a: 60, b: 17, c: 20, d: 45, e:32, f:25, g:41, h:10, i: 4},
                { time: '2017-09-24 13:22', a: 57, b: 12, c: 25, d: 45, e:32, f:25, g:43, h:11, i: 2},
                { time: '2017-09-24 13:23', a: 69, b: 13, c: 24, d: 45, e:32, f:25, g:38, h:8, i: 3},
              ],
              xkey: 'time',
              xLabels: 'minute',
              ykeys: ['a','b','c','d','e','f','g','h','i'],
                                  
              ylabels: [
              'Number of active connection pools', 
              'Number of inactive connection pools',
              'Number of pooled connections',
              'Number of non pooled connections',
              'Number of active connections',
              'Number of free connections',
              'Number of reclaimed connections',
              'Soft connects per second',
              'Soft disconnects per second'],     

              continuousLine: false,
              pointSize: 0,
              hideHover: 'always',
              lineColors: [
                this.adoNetLegendLabels[0].color,
                this.adoNetLegendLabels[1].color,
                this.adoNetLegendLabels[2].color,
                this.adoNetLegendLabels[3].color,
                this.adoNetLegendLabels[4].color,
                this.adoNetLegendLabels[5].color,
                this.adoNetLegendLabels[6].color,
                this.adoNetLegendLabels[7].color,
                this.adoNetLegendLabels[8].color            
            ]
              
        });

        Morris.Line({
            element: this.applicationStatisticId,
            data: [
                { time: '2017-09-24 13:20', a: 45, b: 17},
                { time: '2017-09-24 13:21', a: 40, b: 7},
                { time: '2017-09-24 13:22', a: 54, b: 52},
                { time: '2017-09-24 13:23', a: 49, b: 23},
              ],
              xkey: 'time',
              xLabels: 'minute',
              ykeys: ['a','b'],
                                  
              ylabels: [
              'Requests per second', 
              'Total requests'],     

              continuousLine: false,
              pointSize: 0,
              hideHover: 'always',
              lineColors: [
                this.applicationLegendLabels[0].color,
                this.applicationLegendLabels[1].color        
            ]
             
        });
    }

    ngOnDestroy() {
        this.sub.unsubscribe();
    }
}
