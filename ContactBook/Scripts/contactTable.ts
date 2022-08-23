import { Contact } from "./Contact";

export class ContactTableComponent {
    private _contacts: Contact[] = [];

    public get contacts(): Contact[] {
        return this._contacts;
    }

    public set contacts(v: Contact[]) {
        this._contacts = v;
    }

    public constructor(contacts: Contact[]){
        this.contacts = contacts;
    }

    public AddtoList(contact: Contact) {
        this.contacts.push(contact);
        this.contacts.sort();
    }

    public refresh() {
        // refresh the list
    }
}