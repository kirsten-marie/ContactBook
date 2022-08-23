"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.ContactTableComponent = void 0;
var ContactTableComponent = /** @class */ (function () {
    function ContactTableComponent(contacts) {
        this._contacts = [];
        this.contacts = contacts;
    }
    Object.defineProperty(ContactTableComponent.prototype, "contacts", {
        get: function () {
            return this._contacts;
        },
        set: function (v) {
            this._contacts = v;
        },
        enumerable: false,
        configurable: true
    });
    ContactTableComponent.prototype.AddtoList = function (contact) {
        this.contacts.push(contact);
        this.contacts.sort();
    };
    ContactTableComponent.prototype.refresh = function () {
        // refresh the list
    };
    return ContactTableComponent;
}());
exports.ContactTableComponent = ContactTableComponent;
