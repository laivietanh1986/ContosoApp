import { Component, OnInit } from "@angular/core";
import { DataService } from "../shared/dataService";
import { Person } from "../shared/Person";
@Component({
    selector: "person-list",
    templateUrl: 'personList.component.html',
    styleUrls: []
})
export class PersonList implements OnInit {
    public persons:Person[] = [];
    constructor(private data: DataService) {
        this.persons = data.persons;
    }
    ngOnInit(): void {
        this.data.loadPerson()
            .subscribe(success => {
                if (success) {
                    this.persons = this.data.persons;
                }
            })
    }
}
