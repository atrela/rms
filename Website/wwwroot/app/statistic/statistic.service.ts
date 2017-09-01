﻿import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/map';
import 'rxjs/add/observable/throw';

import { IStatistic } from './statistic';

@Injectable()
export class StatisticService {
    private _statisticsUrl = 'service/statistics.json';
    private _statisticUrl = 'service/statistic.json';

    constructor(private _http: Http) { }

    getStatistics(): Observable<IStatistic[]> {
        return this._http.get(this._statisticsUrl)
            .map((response: Response) => <IStatistic[]>response.json())
            .do(data => console.log((data)))
            .catch(this.handleError);
    }

   
    getStatistic(name: string): Observable<IStatistic> {
        return this._http.get(this._statisticUrl)
            .map((response: Response) => <IStatistic>response.json())
            .catch(this.handleError);

    }

    private handleError(error: Response) {
        console.error(error);
        return Observable.throw(error.json().error || 'Server error');
    }
}