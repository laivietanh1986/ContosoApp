import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

import { map } from 'rxjs/operators';
@Injectable()
export class DataService {
    constructor(private http: HttpClient) {

    }
    public persons = [];
    loadPerson() {
        return this.http.get('/api/person')
            .pipe(map((data: any[]) => {
                this.persons = data;
                return true;
            }));
    }

}
