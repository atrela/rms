import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { Router, Routes } from '@angular/router';
import { IStatistic } from '../../statistic/statistic';
import { StatisticService } from '../../statistic/statistic.service';
import { Observable } from "rxjs/Observable";

@Component({
    templateUrl: './menu.component.html',
    styleUrls: ['./menu.component.css'],
    selector: 'app-menu',
})

export class MenuComponent implements OnInit {

    constructor(private _httpService: StatisticService, private _router: Router) { }
    statistics: IStatistic[];
    statistic: IStatistic;
    errorMessage: string;


    ngOnInit() {
       this._httpService.getStatistics()
           .subscribe(statistics =>
           {

               this.statistics = statistics;
               },
                   error => this.errorMessage = <any>error
              
           );
        
    }  
}

