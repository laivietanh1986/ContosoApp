import { Component } from "@angular/core";

@Component({
    selector: "person-list",
    templateUrl: 'personList.component.html',
    styleUrls: []
})
export class PersonList {
    public persons = [
        {
        BusinessEntityId: 1,
        FullName: 'Viet Anh'
        },
        {
            BusinessEntityId: 2,
            FullName: 'Hai Tung'
        },
        {
            BusinessEntityId: 1,
            FullName: 'Nguyen Hoang'
        },
    ];
}
