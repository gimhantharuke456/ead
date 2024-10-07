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

const ShopItemsService = {
  getAllShopItems: () => {
    return axios.get(`${API_URL}/ShopItems`, {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });
  },

  getShopItemById: (id) => {
    return axios.get(`${API_URL}/ShopItems/${id}`, {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });
  },

  updateShopItem: (id, itemData) => {
    return axios.put(`${API_URL}/ShopItems/${id}`, itemData, {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });
  },

  deleteShopItem: (id) => {
    return axios.delete(`${API_URL}/ShopItems/${id}`, {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });
  },

  getShopItemsByShopId: (shopId) => {
    return axios.get(`${API_URL}/ShopItems/shop/${shopId}`, {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });
  },

  createShopItem: (shopId, itemData) => {
    return axios.post(`${API_URL}/ShopItems/${shopId}`, itemData, {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });
  },
};

export default ShopItemsService;
