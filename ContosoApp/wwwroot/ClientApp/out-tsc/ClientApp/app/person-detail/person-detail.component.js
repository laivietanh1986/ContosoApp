"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var router_1 = require("@angular/router");
var common_1 = require("@angular/common");
var dataService_1 = require("../shared/dataService");
var Person_1 = require("../shared/Person");
var PersonDetailComponent = /** @class */ (function () {
    function PersonDetailComponent(route, location, data) {
        this.route = route;
        this.location = location;
        this.data = data;
    }
    PersonDetailComponent.prototype.ngOnInit = function () {
        this.getPerson();
    };
    PersonDetailComponent.prototype.getPerson = function () {
        var _this = this;
        var id = +this.route.snapshot.paramMap.get('id');
        this.data.getPerson(id)
            .subscribe(function (success) {
            if (success) {
                _this.person = _this.data.person;
            }
        });
    };
    __decorate([
        core_1.Input(),
        __metadata("design:type", Person_1.Person)
    ], PersonDetailComponent.prototype, "person", void 0);
    PersonDetailComponent = __decorate([
        core_1.Component({
            selector: 'app-person-detail',
            templateUrl: './person-detail.component.html',
            styleUrls: ['./person-detail.component.css']
        }),
        __metadata("design:paramtypes", [router_1.ActivatedRoute,
            common_1.Location,
            dataService_1.DataService])
    ], PersonDetailComponent);
    return PersonDetailComponent;
}());
exports.PersonDetailComponent = PersonDetailComponent;
//# sourceMappingURL=person-detail.component.js.map