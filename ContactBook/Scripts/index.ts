import axios from 'axios';
import { Contact } from './Contact';
import { Address } from './Address';
import { ContactTableComponent } from './contactTable';


const contactEndPoint = 'https://localhost:7119/api/contacts/get'

axios.get(contactEndPoint).then(response => {
    const contacts = response.data as Contact[];

    const contactTable = new ContactTableComponent(contacts);
});

//Goes with /api/ContactPreference/get and will be used in the dropdown
const mapContactFrequencies = new Map<number,string>();
