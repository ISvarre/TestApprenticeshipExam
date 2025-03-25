import { createApp } from 'vue'
import './style.css'
import VueButton from './components/VueButton.vue';

console.log('Hello World')
const app = createApp({});
  app.component('FfVueButton', VueButton);
  app.mount('#app');
