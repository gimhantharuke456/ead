import axios from "axios";

const API_URL = "http://localhost:5053/api";
const token = localStorage.getItem("userToken");

const ShopsService = {
  getAllShops: () => {
    return axios.get(`${API_URL}/Shops`, {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });
  },

  createShop: (shopData) => {
    return axios.post(`${API_URL}/Shops`, shopData, {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });
  },

  getShopById: (id) => {
    return axios.get(`${API_URL}/Shops/${id}`, {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });
  },

  updateShop: (id, shopData) => {
    return axios.put(`${API_URL}/Shops/${id}`, shopData, {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });
  },

  deleteShop: (id) => {
    return axios.delete(`${API_URL}/Shops/${id}`, {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });
  },

  getVendorShops: () => {
    return axios.get(`${API_URL}/Shops/vendor/${localStorage.getItem("id")}`, {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });
  },
};

export default ShopsService;
