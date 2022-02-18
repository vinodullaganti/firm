import axios from "axios";

const baseURI = "http://localhost:5000"; 
const resolveApiUrl = () => 'http://localhost:5000';
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

export const httpGet = (url)=>{
  return apiService.get(url);
}