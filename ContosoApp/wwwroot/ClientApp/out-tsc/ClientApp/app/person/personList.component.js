"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var PersonList = /** @class */ (function () {
    function PersonList() {
        this.persons = [
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
    PersonList = __decorate([
        core_1.Component({
            selector: "person-list",
            templateUrl: 'personList.component.html',
            styleUrls: []
        })
    ], PersonList);
    return PersonList;
}());
exports.PersonList = PersonList;
//# sourceMappingURL=personList.component.js.map