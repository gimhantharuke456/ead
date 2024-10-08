/******************************************************************************
 * File: OrdersController.cs
 * Author: RPGT Rajapaksha (IT21048500)
 * Date: [2024-10-07]
 * Description: This file contains the OrdersController class, which handles
 *              HTTP requests related to order management in the EAD Backend application.
 ******************************************************************************/

import React, { useState, useEffect } from "react";
import {
  Table,
  Button,
  Modal,
  Form,
  Input,
  Popconfirm,
  message,
  Upload,
  Select,
} from "antd";
import { PlusOutlined } from "@ant-design/icons";
import ShopsService from "../services/shop.service";
import { uploadFile } from "../services/uploadFileService";
import UsersService from "../services/user.service";

const { Option } = Select;

const ShopManager = () => {
  const [shops, setShops] = useState([]);
  const [loading, setLoading] = useState(false);
  const [modalVisible, setModalVisible] = useState(false);
  const [form] = Form.useForm();
  const [editingShop, setEditingShop] = useState(null);
  const [users, setUsers] = useState([]);

  useEffect(() => {
    fetchShops();
  }, []);

  const fetchShops = async () => {
    setLoading(true);
    try {
      const [response, userResponse] = await Promise.all([
        ShopsService.getAllShops(),
        UsersService.getAllUsers(),
      ]);

      setUsers(userResponse.data.filter((user) => user.role === "Vendor"));
      setShops(response.data);
    } catch (error) {
      message.error("Failed to fetch shops");
    }
    setLoading(false);
  };

  const handleCreate = () => {
    setEditingShop(null);
    form.resetFields();
    setModalVisible(true);
  };

  const handleEdit = (shop) => {
    setEditingShop(shop);
    form.setFieldsValue(shop);
    setModalVisible(true);
  };

  const handleDelete = async (id) => {
    try {
      await ShopsService.deleteShop(id);
      message.success("Shop deleted successfully");
      fetchShops();
    } catch (error) {
      message.error("Failed to delete shop");
    }
  };

  const handleModalOk = () => {
    form.validateFields().then(async (values) => {
      try {
        let url = "";
        console.log(values);

        const imageList = values.imageUrl;
        if (imageList) {
          if (imageList.length > 0) {
            const file = imageList[0].originFileObj;
            url = await uploadFile(file);
          } else {
            url = editingShop.imageUrl;
          }
        }

        if (editingShop) {
          await ShopsService.updateShop(editingShop.id, {
            ...values,
            imageUrl: url,
          });
          message.success("Shop updated successfully");
        } else {
          await ShopsService.createShop({ ...values, imageUrl: url });
          message.success("Shop created successfully");
        }
        setModalVisible(false);
        fetchShops();
      } catch (error) {
        console.error(error);
        message.error("Operation failed");
      }
    });
  };

  const columns = [
    {
      title: "Name",
      dataIndex: "name",
      key: "name",
    },
    {
      title: "Address",
      dataIndex: "address",
      key: "address",
    },
    {
      title: "Contact Number",
      dataIndex: "contactNumber",
      key: "contactNumber",
    },
    {
      title: "Actions",
      key: "actions",
      render: (_, record) => (
        <span>
          <Button onClick={() => handleEdit(record)} style={{ marginRight: 8 }}>
            Edit
          </Button>
          <Popconfirm
            title="Are you sure you want to delete this shop?"
            onConfirm={() => handleDelete(record.id)}
            okText="Yes"
            cancelText="No"
          >
            <Button danger>Delete</Button>
          </Popconfirm>
        </span>
      ),
    },
  ];

  return (
    <div>
      <Button
        onClick={handleCreate}
        type="primary"
        style={{ marginBottom: 16 }}
      >
        Create Shop
      </Button>
      <Table
        columns={columns}
        dataSource={shops}
        rowKey="id"
        loading={loading}
      />
      <Modal
        title={editingShop ? "Edit Shop" : "Create Shop"}
        open={modalVisible}
        onOk={handleModalOk}
        onCancel={() => setModalVisible(false)}
      >
        <Form form={form} layout="vertical">
          <Form.Item
            name="vendorId"
            label="Owner"
            rules={[{ required: true, message: "Please input the shop name!" }]}
          >
            <Select>
              {users.map((user) => (
                <Option value={user.id} key={user.id}>
                  {user.username}
                </Option>
              ))}
            </Select>
          </Form.Item>
          <Form.Item
            name="name"
            label="Name"
            rules={[{ required: true, message: "Please input the shop name!" }]}
          >
            <Input />
          </Form.Item>
          <Form.Item
            name="address"
            label="Address"
            rules={[
              { required: true, message: "Please input the shop address!" },
            ]}
          >
            <Input />
          </Form.Item>
          <Form.Item
            name="contactNumber"
            label="Contact Number"
            rules={[
              { required: true, message: "Please input the contact number!" },
            ]}
          >
            <Input />
          </Form.Item>
          {!editingShop && (
            <Form.Item
              name="imageUrl"
              label="Image"
              valuePropName="fileList"
              getValueFromEvent={(e) => {
                if (Array.isArray(e)) {
                  return e;
                }
                return e && e.fileList;
              }}
            >
              <Upload name="logo" listType="picture">
                <Button icon={<PlusOutlined />}>Click to upload</Button>
              </Upload>
            </Form.Item>
          )}
        </Form>
      </Modal>
    </div>
  );
};

export default ShopManager;
