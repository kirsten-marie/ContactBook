interface Address {
    street: string,
    city: string,
    state: string,
    zip: number;
}

interface Contact {
    firstName: string,
    lastName: string,
    address: Address,
    phone: string,
    contactFrequency: string
};