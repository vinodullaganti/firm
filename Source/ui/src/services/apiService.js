import axios from "axios";

const resolveApiUrl = () => 'http://localhost:5000/'; // Change it based on your local API configuraion

const headers = {
  'Content-Type': 'application/json'
};

export const apiService = axios.create({
  baseURL: resolveApiUrl(),
  headers
});

export const httpGet = (url)=>{
  return apiService.get(url);
}