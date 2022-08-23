// Import stylesheets
import './style.css';
const contact = {
    firstName: 'Kirsten',
    lastName: 'McCain',
    address: {
        street: '1137 Gilbert Station Ln',
        city: 'Knoxville',
        state: 'TN',
        zip: 37932
    },
    phone: '8653877802',
    contactFrequency: 'Account'
};
//Goes with /api/ContactPreference/get and will be used in the dropdown
const mapContactFrequencies = new Map();
const form = document.querySelector('#contactForm');
form.onsubmit = () => {
    const formData = new FormData(form);
    const text = formData.get('textInput');
    console.log(text);
    return false; // prevent reload
};
//# sourceMappingURL=index.js.map