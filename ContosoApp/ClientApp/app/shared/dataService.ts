import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Person } from "./Person";

import { map } from 'rxjs/operators';
import { Observable } from "rxjs";
@Injectable()
export class DataService {    
    constructor(private http: HttpClient) {
        this.person = new Person();
    }
    public persons: Person[] = [];
    public person: Person ;
    loadPerson(): Observable<boolean> {
        return this.http.get('/api/person')
            .pipe(map((data: Person[]) => {
                this.persons = data;
                return true;
            }));
    }
    getPerson(id: Number): Observable<boolean> {
        return this.http.get('/api/person/' + id)
            .pipe(map((data: Person) => {
                this.person = data;
                return true;
            }))
    }

}
