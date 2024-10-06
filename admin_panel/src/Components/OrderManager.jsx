import React, { useEffect, useState } from "react";
import axios from "axios";
import { Table, Spin, message } from "antd";

// Define the columns for the Antd Table
const columns = [
  {
    title: "Order ID",
    dataIndex: "id",
    key: "id",
  },
  {
    title: "Shop Item ID",
    dataIndex: "shopItemId",
    key: "shopItemId",
  },
  {
    title: "Shop Name",
    dataIndex: "shopName",
    key: "shopName",
  },
  {
    title: "User Name",
    dataIndex: "userName",
    key: "userName",
  },
  {
    title: "Quantity",
    dataIndex: "quantity",
    key: "quantity",
  },
  {
    title: "Address",
    dataIndex: "address",
    key: "address",
  },
  {
    title: "Status",
    dataIndex: "status",
    key: "status",
  },
];

const OrderManager = () => {
  const [orders, setOrders] = useState([]);
  const [loading, setLoading] = useState(false);

  // Fetch orders from API
  const fetchOrders = async () => {
    setLoading(true);
    try {
      const response = await axios.get("http://localhost:5053/api/Orders");
      setOrders(response.data);
      message.success("Orders fetched successfully!");
    } catch (error) {
      message.error("Failed to fetch orders.");
      console.error("Error fetching orders:", error);
    } finally {
      setLoading(false);
    }
  };

  // useEffect to load the orders on component mount
  useEffect(() => {
    fetchOrders();
  }, []);

  return (
    <div>
      <h1>Order Manager</h1>
      {loading ? (
        <Spin size="large" />
      ) : (
        <Table columns={columns} dataSource={orders} rowKey="id" />
      )}
    </div>
  );
};

export default OrderManager;
