//import {add, all, byId} from 'data'; same like below
import * as db from 'data';

export function seed() {
    db.add({ name: "Pesho", age: 33 });
    db.add({ name: "Maria", age: 13 });
    db.add({ name: "Gosho", age: 23 });
}