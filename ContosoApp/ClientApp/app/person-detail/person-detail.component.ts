import { Component, OnInit,Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { DataService } from "../shared/dataService";
import { Person } from "../shared/Person"

@Component({
  selector: 'app-person-detail',
  templateUrl: './person-detail.component.html',
  styleUrls: ['./person-detail.component.css']
})
export class PersonDetailComponent implements OnInit {
    @Input() person: Person;  
    constructor(
        private route: ActivatedRoute,
        private location: Location,
        private data: DataService) {}
    ngOnInit():void {
        this.getPerson();
    }
    getPerson(): void {
    const id = +this.route.snapshot.paramMap.get('id');
    this.data.getPerson(id)
        .subscribe(success => {
            if (success) {
                this.person = this.data.person;
            }
        });

    }

}
