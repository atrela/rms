import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';

import { AppConfig } from '../../../app.config';
import { AgentModel } from './agent.model';
import { MyAgentModel } from './my-agent.model';

@Injectable()
export class MyAgentsService {
    url: string;

    constructor(private http: Http) {
        this.url = AppConfig.API_ENDPOINT + '/webadmin/configuration/agent/my'
    }

    public getAgents(): Observable<MyAgentModel> {
        return this.http.get(this.url)
            .map(response => response.json());
    }
}   