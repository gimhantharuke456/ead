/******************************************************************************
 * File: OrdersController.cs
 * Author: KT Navodya (IT21057106)
 * Date: [Current Date]
 * Description: This file contains the OrdersController class, which handles
 *              HTTP requests related to order management in the EAD Backend application.
 ******************************************************************************/

import axios from "axios";

const API_URL = "http://localhost:5053/api";
const token = localStorage.getItem("userToken");

const UsersService = {
  getAllUsers: () => {
    return axios.get(`${API_URL}/Users`, {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });
  },

  createUser: (userData) => {
    return axios.post(`${API_URL}/Users`, userData, {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });
  },

  getUserById: (id) => {
    return axios.get(`${API_URL}/Users/${id}`, {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });
  },

  updateUser: (id, userData) => {
    return axios.put(`${API_URL}/Users/${id}`, userData, {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });
  },

  deleteUser: (id) => {
    return axios.delete(`${API_URL}/Users/${id}`, {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });
  },

  login: (loginData) => {
    return axios.post(`${API_URL}/Users/login`, loginData); // No token needed for login
  },
};

export default UsersService;
