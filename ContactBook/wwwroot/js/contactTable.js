export class ContactTableComponent {
    constructor(contacts) {
        this._contacts = [];
        this.contacts = contacts;
    }
    get contacts() {
        return this._contacts;
    }
    set contacts(v) {
        this._contacts = v;
    }
    AddtoList(contact) {
        this.contacts.push(contact);
        this.contacts.sort();
    }
    refresh() {
        // refresh the list
    }
}
