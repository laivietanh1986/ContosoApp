"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var StorePerson = /** @class */ (function () {
    function StorePerson() {
        this.visits = 1;
    }
    StorePerson.prototype.ShowName = function (name) {
        alert(name);
        return true;
    };
    return StorePerson;
}());
exports.StorePerson = StorePerson;
var person = new StorePerson();
person.visits = 10;
//# sourceMappingURL=storeperson.js.map