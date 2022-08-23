import { Contact } from './Contact';
import { Address } from './Address';
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
const mapContactFrequencies = new Map<number,string>();



const form: HTMLFormElement = document.querySelector('#contactForm');


form.onsubmit = () => {
  const formData = new FormData(form);

  const text = formData.get('textInput') as string;
  console.log(text);
  return false; // prevent reload
};