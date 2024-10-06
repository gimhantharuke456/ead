import React, { useEffect, useState } from "react";
import { Layout, Menu, message } from "antd";
import {
  UserOutlined,
  ShopOutlined,
  AppstoreOutlined,
} from "@ant-design/icons";
import UserManager from "../Components/UserManager";
import { useNavigate } from "react-router-dom";
import ShopManager from "../Components/ShopManager";
import ShopProfile from "../Components/ShopProfile";
import ShopItemManager from "../Components/ShopItemManager";
import ShopsService from "../services/shop.service";
import OrderManager from "../Components/OrderManager";

const { Sider, Content } = Layout;

const Dashboard = () => {
  const role = localStorage.getItem("userRole");
  const [activeIndex, setActiveIndex] = useState(1);
  const [collapsed, setCollapsed] = useState(false);
  const navigate = useNavigate();
  const onCollapse = (collapsed) => {
    setCollapsed(collapsed);
  };

  useEffect(() => {
    if (role === "Vendor") {
      ShopsService.getVendorShops()
        .then((res) => {
          if (res.data && res.data.length > 0) {
            localStorage.setItem("shopId", res.data[0].id);
          }
        })
        .catch((err) => {
          console.error(err);
          message.error("Failed to load shop profile.");
        });
    }
  }, [role]);

  return (
    <Layout style={{ minHeight: "100vh" }}>
      <Sider collapsible collapsed={collapsed} onCollapse={onCollapse}>
        <Menu theme="dark" defaultSelectedKeys={["1"]} mode="inline">
          {role === "Admin" && (
            <Menu.Item
              onClick={() => {
                setActiveIndex(1);
              }}
              key="1"
              icon={<UserOutlined />}
            >
              User Management
            </Menu.Item>
          )}
          {role === "Admin" && (
            <Menu.Item
              onClick={() => {
                setActiveIndex(2);
              }}
              key="2"
              icon={<ShopOutlined />}
            >
              Vendor Management
            </Menu.Item>
          )}
          {role === "Vendor" && (
            <Menu.Item
              onClick={() => {
                setActiveIndex(6);
              }}
              key="6"
              icon={<AppstoreOutlined />}
            >
              Shop Profile
            </Menu.Item>
          )}
          {role === "Vendor" && (
            <Menu.Item
              onClick={() => {
                setActiveIndex(3);
              }}
              key="3"
              icon={<AppstoreOutlined />}
            >
              Item Management
            </Menu.Item>
          )}
          {role === "Vendor" && (
            <Menu.Item
              onClick={() => {
                setActiveIndex(4);
              }}
              key="12"
              icon={<AppstoreOutlined />}
            >
              Order Management
            </Menu.Item>
          )}
          <Menu.Item
            onClick={() => {
              localStorage.clear();
              navigate("/login");
            }}
            key="4"
            icon={<AppstoreOutlined />}
          >
            Logout
          </Menu.Item>
        </Menu>
      </Sider>
      <Layout className="site-layout">
        <Content style={{ margin: "16px" }}>
          <div style={{ padding: 24, minHeight: 360, background: "#fff" }}>
            {activeIndex === 1 && <UserManager />}
            {activeIndex === 2 && <ShopManager />}
            {activeIndex === 3 && <ShopItemManager />}
            {activeIndex === 4 && <OrderManager />}
            {activeIndex === 6 && <ShopProfile />}
          </div>
        </Content>
      </Layout>
    </Layout>
  );
};

export default Dashboard;
