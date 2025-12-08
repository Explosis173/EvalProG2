import './assets/main.css'
import './assets/style.css'

import { createPinia } from 'pinia'
import router from './router'

import { createApp } from 'vue'
import App from './App.vue'

import PrimeVue from 'primevue/config';
import  Aura from '@primevue/themes/aura'
import 'primeicons/primeicons.css';

import Button from 'primevue/button';
import DatePicker from 'primevue/datepicker';
import DataTable from 'primevue/datatable';
import Column from 'primevue/column';
import InputText from 'primevue/inputtext';
import Textarea from 'primevue/textarea';




const app = createApp(App);
app.use(PrimeVue, {
    theme: {
        preset: Aura
    },
    ripple: true,
});
app.use(createPinia())
app.use(router)

app.component('Button', Button);
app.component('DatePicker', DatePicker);
app.component('DataTable', DataTable);
app.component('Column', Column);
app.component('InputText', InputText)
app.component('Textarea', Textarea)

app.mount('#app')
