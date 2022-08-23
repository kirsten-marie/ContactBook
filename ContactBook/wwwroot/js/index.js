import { ContactTableComponent } from './contactTable';
const contactEndPoint = 'https://localhost:7119/api/contacts/get';
const populateTable = function (contacts) {
    var contactTable = new ContactTableComponent(contacts);
};
//Goes with /api/ContactPreference/get and will be used in the dropdown
const mapContactFrequencies = new Map();
