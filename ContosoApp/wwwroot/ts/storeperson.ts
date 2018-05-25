
export class StorePerson {
    public visits: number = 1;
    public ShowName(name: string): boolean {
        alert(name);
        return true;
    }

}
let person = new StorePerson();
person.visits = 10;

