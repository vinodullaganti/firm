import axios from "axios";
const baseURI = "https://reqres.in/api"; // Sample Working Api
// const baseURI = "http://localhost:5000/"; // Change it based on your local system configuraion
const resolveApiUrl = () => 'https://reqres.in/api';


const headers = {
  'Content-Type': 'application/json'
};

export default axios.create({
  baseURL: baseURI,
  headers
});

const apiService = axios.create({
  baseURL: resolveApiUrl(),
  headers
});