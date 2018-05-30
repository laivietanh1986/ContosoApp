import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Person } from "./Person";

import { map } from 'rxjs/operators';
import { Observable } from "rxjs";
@Injectable()
export class DataService {
    constructor(private http: HttpClient) {

    }
    public persons: Person[] = [];
    loadPerson(): Observable<boolean> {
        return this.http.get('/api/person')
            .pipe(map((data: Person[]) => {
                this.persons = data;
                return true;
            }));
    }

}
