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
} from "antd";
import { PlusOutlined } from "@ant-design/icons";
import ShopItemsService from "../services/shop.item.service";
import { uploadFile } from "../services/uploadFileService"; // Import your file upload logic

const ShopItemManager = () => {
  const [shopItems, setShopItems] = useState([]);
  const [loading, setLoading] = useState(false);
  const [modalVisible, setModalVisible] = useState(false);
  const [form] = Form.useForm();
  const [editingItem, setEditingItem] = useState(null);

  useEffect(() => {
    fetchShopItems();
  }, []);

  const fetchShopItems = async () => {
    setLoading(true);
    try {
      const response = await ShopItemsService.getAllShopItems();
      setShopItems(response.data);
    } catch (error) {
      message.error("Failed to fetch shop items");
    }
    setLoading(false);
  };

  const handleCreate = () => {
    setEditingItem(null);
    form.resetFields();
    setModalVisible(true);
  };

  const handleEdit = (item) => {
    setEditingItem(item);
    form.setFieldsValue(item);
    setModalVisible(true);
  };

  const handleDelete = async (id) => {
    try {
      await ShopItemsService.deleteShopItem(id);
      message.success("Shop item deleted successfully");
      fetchShopItems();
    } catch (error) {
      message.error("Failed to delete shop item");
    }
  };

  const handleModalOk = () => {
    form.validateFields().then(async (values) => {
      try {
        let imageUrl = "";
        const imageList = values.imageUrl;

        if (imageList && imageList.length > 0) {
          const file = imageList[0].originFileObj;
          imageUrl = await uploadFile(file); // Assume uploadFile handles the actual file upload
        } else if (editingItem) {
          imageUrl = editingItem.imageUrl;
        }

        if (editingItem) {
          await ShopItemsService.updateShopItem(editingItem.id, {
            ...values,
            imageUrl: imageUrl || editingItem.imageUrl,
            shopId: localStorage.getItem("shopId"),
          });
          message.success("Shop item updated successfully");
        } else {
          await ShopItemsService.createShopItem(
            localStorage.getItem("shopId"),
            {
              ...values,
              imageUrl,
              shopId: localStorage.getItem("shopId"),
            }
          ); // Replace "shopId" with actual shop ID
          message.success("Shop item created successfully");
        }
        setModalVisible(false);
        fetchShopItems();
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
      title: "Description",
      dataIndex: "description",
      key: "description",
    },
    {
      title: "In Stock",
      dataIndex: "instockAmount",
      key: "instockAmount",
    },
    {
      title: "Price",
      dataIndex: "price",
      key: "price",
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
            title="Are you sure you want to delete this shop item?"
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
        Create Shop Item
      </Button>
      <Table
        columns={columns}
        dataSource={shopItems}
        rowKey="id"
        loading={loading}
      />
      <Modal
        title={editingItem ? "Edit Shop Item" : "Create Shop Item"}
        open={modalVisible}
        onOk={handleModalOk}
        onCancel={() => setModalVisible(false)}
      >
        <Form form={form} layout="vertical">
          <Form.Item
            name="name"
            label="Name"
            rules={[{ required: true, message: "Please input the item name!" }]}
          >
            <Input />
          </Form.Item>
          <Form.Item
            name="description"
            label="Description"
            rules={[
              { required: true, message: "Please input the item description!" },
            ]}
          >
            <Input />
          </Form.Item>
          <Form.Item
            name="instockAmount"
            label="In Stock"
            rules={[
              { required: true, message: "Please input the stock amount!" },
            ]}
          >
            <Input type="number" />
          </Form.Item>
          <Form.Item
            name="price"
            label="Price"
            rules={[{ required: true, message: "Please input price!" }]}
          >
            <Input type="number" />
          </Form.Item>
          <Form.Item name="imageUrl" label="Image">
            <Upload name="logo" listType="picture">
              <Button icon={<PlusOutlined />}>Click to upload</Button>
            </Upload>
          </Form.Item>
        </Form>
      </Modal>
    </div>
  );
};

export default ShopItemManager;
