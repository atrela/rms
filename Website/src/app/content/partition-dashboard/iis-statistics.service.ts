import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/map';
import 'rxjs/add/observable/throw';

import { IIISStatistic } from  './iis-statistics';

@Injectable()
export class IISStatisticService {
    //private _statisticsUrl = 'service/statistics.json';
    private _statisticsUrl = 'http://rmsapi-dev.azurewebsites.net/iisagent/log';
    private _statisticUrl = 'service/statistic.json';

    constructor(private _http: Http) { }

    getStatistics(): Observable<IIISStatistic[]> {
        return this._http.get(this._statisticsUrl)
            .map((response: Response) => <IIISStatistic[]>response.json())
            .do(data => console.log((data)))
            .catch(this.handleError);
    }

   
    getStatistic(name: string): Observable<IIISStatistic> {
        return this._http.get(this._statisticUrl)
            .map((response: Response) => <IIISStatistic>response.json())
            .catch(this.handleError);

    }

    getStatisticByName(name: string): Observable<IIISStatistic> {
      
        var one = this.getStatistics()
                    .map(items => {
                        return items.find(x=>x.appName===name)
                    }).do(data => console.log((data)))

        return one;     
    }

    getStatisticById(id: number): Observable<IIISStatistic> {
        
          var one = this.getStatistics()
                      .map(items => {
                          return items.find(x=>x.id===id)
                      }).do(data => console.log((data)))
  
          return one;
  
          
      }

    private handleError(error: Response) {
        console.error(error);
        return Observable.throw(error.json().error || 'Server error');
    }
}