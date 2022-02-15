import apiService from "../../../services/apiService";

const getAll = () => {
  return apiService.get("/users");
};

export default {
  getAll
};