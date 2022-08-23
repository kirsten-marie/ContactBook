"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var axios_1 = require("axios");
var contactTable_1 = require("./contactTable");
var contactEndPoint = 'https://localhost:7119/api/contacts/get';
axios_1.default.get(contactEndPoint).then(function (response) {
    var contacts = response.data;
    var contactTable = new contactTable_1.ContactTableComponent(contacts);
});
//Goes with /api/ContactPreference/get and will be used in the dropdown
var mapContactFrequencies = new Map();
