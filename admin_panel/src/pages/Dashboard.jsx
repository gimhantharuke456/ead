import React, { useState } from "react";
import { Layout, Menu } from "antd";
import {
  UserOutlined,
  ShopOutlined,
  AppstoreOutlined,
} from "@ant-design/icons";
import UserManager from "../Components/UserManager";

const { Sider, Content } = Layout;

const Dashboard = () => {
  const [activeIndex, setActiveIndex] = useState(1);
  const [collapsed, setCollapsed] = useState(false);

  const onCollapse = (collapsed) => {
    setCollapsed(collapsed);
  };

  return (
    <Layout style={{ minHeight: "100vh" }}>
      <Sider collapsible collapsed={collapsed} onCollapse={onCollapse}>
        <Menu theme="dark" defaultSelectedKeys={["1"]} mode="inline">
          <Menu.Item
            onClick={() => {
              setActiveIndex(1);
            }}
            key="1"
            icon={<UserOutlined />}
          >
            User Management
          </Menu.Item>
          <Menu.Item
            onClick={() => {
              setActiveIndex(2);
            }}
            key="2"
            icon={<ShopOutlined />}
          >
            Vendor Management
          </Menu.Item>
          <Menu.Item
            onClick={() => {
              setActiveIndex(3);
            }}
            key="3"
            icon={<AppstoreOutlined />}
          >
            Item Management
          </Menu.Item>
        </Menu>
      </Sider>
      <Layout className="site-layout">
        <Content style={{ margin: "16px" }}>
          <div style={{ padding: 24, minHeight: 360, background: "#fff" }}>
            {activeIndex === 1 && <UserManager />}
          </div>
        </Content>
      </Layout>
    </Layout>
  );
};

export default Dashboard;
