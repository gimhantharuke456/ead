import axios from "axios";

const API_URL = "http://localhost:5053/api"; // Adjust this to your API's base URL

const ShopItemsService = {
  getAllShopItems: () => {
    return axios.get(`${API_URL}/ShopItems`);
  },

  getShopItemById: (id) => {
    return axios.get(`${API_URL}/ShopItems/${id}`);
  },

  updateShopItem: (id, itemData) => {
    return axios.put(`${API_URL}/ShopItems/${id}`, itemData);
  },

  deleteShopItem: (id) => {
    return axios.delete(`${API_URL}/ShopItems/${id}`);
  },

  getShopItemsByShopId: (shopId) => {
    return axios.get(`${API_URL}/ShopItems/shop/${shopId}`);
  },

  createShopItem: (shopId, itemData) => {
    return axios.post(`${API_URL}/ShopItems/${shopId}`, itemData);
  },
};

export default ShopItemsService;
