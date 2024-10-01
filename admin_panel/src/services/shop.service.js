import axios from "axios";

const API_URL = "http://localhost:5053/api"; // Adjust this to your API's base URL

const ShopsService = {
  getAllShops: () => {
    return axios.get(`${API_URL}/Shops`);
  },

  createShop: (shopData) => {
    return axios.post(`${API_URL}/Shops`, shopData);
  },

  getShopById: (id) => {
    return axios.get(`${API_URL}/Shops/${id}`);
  },

  updateShop: (id, shopData) => {
    return axios.put(`${API_URL}/Shops/${id}`, shopData);
  },

  deleteShop: (id) => {
    return axios.delete(`${API_URL}/Shops/${id}`);
  },

  getVendorShops: () => {
    return axios.get(`${API_URL}/Shops/vendor`);
  },
};

export default ShopsService;
