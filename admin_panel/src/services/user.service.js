import axios from "axios";

const API_URL = "http://localhost:5053/api";

const UsersService = {
  getAllUsers: () => {
    return axios.get(`${API_URL}/Users`);
  },

  createUser: (userData) => {
    return axios.post(`${API_URL}/Users`, userData);
  },

  getUserById: (id) => {
    return axios.get(`${API_URL}/Users/${id}`);
  },

  updateUser: (id, userData) => {
    return axios.put(`${API_URL}/Users/${id}`, userData);
  },

  deleteUser: (id) => {
    return axios.delete(`${API_URL}/Users/${id}`);
  },

  login: (loginData) => {
    return axios.post(`${API_URL}/Users/login`, loginData);
  },
};

export default UsersService;
