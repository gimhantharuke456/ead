import axios from "axios";

const API_URL = "http://localhost:5053/api"; // Adjust this to your API's base URL

const OrdersService = {
  getAllOrders: () => {
    return axios.get(`${API_URL}/Orders`);
  },

  createOrder: (orderData) => {
    return axios.post(`${API_URL}/Orders`, orderData);
  },

  getOrderById: (id) => {
    return axios.get(`${API_URL}/Orders/${id}`);
  },

  updateOrder: (id, orderData) => {
    return axios.put(`${API_URL}/Orders/${id}`, orderData);
  },

  deleteOrder: (id) => {
    return axios.delete(`${API_URL}/Orders/${id}`);
  },
};

export default OrdersService;
