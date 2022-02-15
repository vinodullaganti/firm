import apiService from "../../../services/apiService";

const getAllAccounts = () => {
  return apiService.get("/accounts");
};

export default {
    getAllAccounts
};