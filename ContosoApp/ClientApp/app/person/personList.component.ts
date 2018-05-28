import { Component } from "@angular/core";
import { DataService } from "../shared/dataService";
@Component({
    selector: "person-list",
    templateUrl: 'personList.component.html',
    styleUrls: []
})
export class PersonList {
    public persons = [];
    constructor(private data: DataService) {
        this.persons = data.persons;
    }
}
