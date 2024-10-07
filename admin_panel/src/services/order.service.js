/*******************************************************************************
 * File: Models.cs
 * Author: RPGT Rajapaksha (IT21048500)
 * Date: 2024-10-07
 * Description: This file contains the model classes for ShopItem and User
 *              in the EAD Backend application.
 ******************************************************************************/

import axios from "axios";

const API_URL = "http://localhost:5053/api";
const token = localStorage.getItem("userToken");

const OrdersService = {
  getAllOrders: () => {
    return axios.get(`${API_URL}/Orders`, {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });
  },

  createOrder: (orderData) => {
    return axios.post(`${API_URL}/Orders`, orderData, {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });
  },

  getOrderById: (id) => {
    return axios.get(`${API_URL}/Orders/${id}`, {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });
  },

  updateOrder: (id, orderData) => {
    return axios.put(`${API_URL}/Orders/${id}`, orderData, {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });
  },

  deleteOrder: (id) => {
    return axios.delete(`${API_URL}/Orders/${id}`, {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });
  },
};

export default OrdersService;
