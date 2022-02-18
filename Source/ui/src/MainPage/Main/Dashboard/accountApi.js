import apiService from "../../../services/apiService";

const getAllAccounts = () => {
  return apiService.get("/getAccounts");
};

export default {
    getAllAccounts
};