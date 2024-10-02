import React, { useState } from "react";
import { Layout, Menu } from "antd";
import {
  UserOutlined,
  ShopOutlined,
  AppstoreOutlined,
} from "@ant-design/icons";
import UserManager from "../Components/UserManager";
import { useNavigate } from "react-router-dom";
import ShopManager from "../Components/ShopManager";

const { Sider, Content } = Layout;

const Dashboard = () => {
  const role = localStorage.getItem("userRole");
  const [activeIndex, setActiveIndex] = useState(1);
  const [collapsed, setCollapsed] = useState(false);
  const navigate = useNavigate();
  const onCollapse = (collapsed) => {
    setCollapsed(collapsed);
  };

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
                setActiveIndex(3);
              }}
              key="3"
              icon={<AppstoreOutlined />}
            >
              Item Management
            </Menu.Item>
          )}
          <Menu.Item
            onClick={() => {
              setActiveIndex(2);
            }}
            key="5"
            icon={<ShopOutlined />}
          >
            Order Management
          </Menu.Item>
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
          </div>
        </Content>
      </Layout>
    </Layout>
  );
};

export default Dashboard;
