import http from "../../../services/apiService";

const getAll = () => {
  return http.get("/users");
};

export default {
  getAll
};