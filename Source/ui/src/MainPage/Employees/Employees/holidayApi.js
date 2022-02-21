import apiService from "../../../services/apiService";

const getHolidays = () => {
  return apiService.get('/Holidays');
};

export default {
    getHolidays
};