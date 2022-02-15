import axios from "axios";

const resolveApiUrl = () => 'https://reqres.in/api'; // Change it based on your local API configuraion

const headers = {
  'Content-Type': 'application/json'
};

const apiService = axios.create({
  baseURL: resolveApiUrl(),
  headers
});