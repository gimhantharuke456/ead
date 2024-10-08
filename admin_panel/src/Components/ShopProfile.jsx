/******************************************************************************
 * File: OrdersController.cs
 * Author: KT Navodya (IT21057106)
 * Date: [2024-10-07]
 * Description: This file contains the OrdersController class, which handles
 *              HTTP requests related to order management in the EAD Backend application.
 ******************************************************************************/

import React, { useEffect, useState } from "react";
import { Card, Button, Form, Input, Modal, message } from "antd";
import ShopsService from "../services/shop.service";

const ShopProfile = () => {
  const [shop, setShop] = useState();
  const [isEditing, setIsEditing] = useState(false);
  const [isDeleting, setIsDeleting] = useState(false);
  const [form] = Form.useForm();

  // Fetch the shop profile data
  useEffect(() => {
    ShopsService.getVendorShops()
      .then((res) => {
        if (res.data && res.data.length > 0) {
          setShop(res.data[0]);
        }
      })
      .catch((err) => {
        console.error(err);
        message.error("Failed to load shop profile.");
      });
  }, []);

  // Handle shop update
  const handleUpdate = (values) => {
    ShopsService.updateShop(shop.id, {
      ...values,
      vendorId: localStorage.getItem("id"),
    })
      .then(() => {
        message.success("Shop updated successfully!");
        setIsEditing(false);
        setShop((prev) => ({ ...prev, ...values }));
      })
      .catch((err) => {
        console.error(err);
        message.error("Failed to update shop.");
      });
  };

  // Handle shop deletion
  const handleDelete = () => {
    ShopsService.deleteShop(shop.id)
      .then(() => {
        message.success("Shop deleted successfully!");
        setIsDeleting(false);
        setShop(null); // Clear shop profile
      })
      .catch((err) => {
        console.error(err);
        message.error("Failed to delete shop.");
      });
  };

  return (
    <div style={{ maxWidth: 600, margin: "0 auto", padding: "20px" }}>
      {shop ? (
        <Card
          title={shop.name}
          cover={<img alt={shop.name} src={shop.imageUrl} />}
          actions={[
            <Button onClick={() => setIsEditing(true)} type="primary">
              Edit
            </Button>,
            <Button onClick={() => setIsDeleting(true)} danger>
              Delete
            </Button>,
          ]}
        >
          <p>
            <strong>Address: </strong> {shop.address}
          </p>
          <p>
            <strong>Contact Number: </strong> {shop.contactNumber}
          </p>
        </Card>
      ) : (
        <p>No shop profile found.</p>
      )}

      {/* Edit Shop Modal */}
      <Modal
        title="Edit Shop Profile"
        visible={isEditing}
        onCancel={() => setIsEditing(false)}
        onOk={() => form.submit()}
      >
        <Form
          form={form}
          layout="vertical"
          initialValues={shop}
          onFinish={handleUpdate}
        >
          <Form.Item
            name="name"
            label="Shop Name"
            rules={[{ required: true, message: "Please enter shop name" }]}
          >
            <Input />
          </Form.Item>
          <Form.Item
            name="address"
            label="Address"
            rules={[{ required: true, message: "Please enter address" }]}
          >
            <Input />
          </Form.Item>
          <Form.Item
            name="contactNumber"
            label="Contact Number"
            rules={[{ required: true, message: "Please enter contact number" }]}
          >
            <Input />
          </Form.Item>
          <Form.Item
            name="imageUrl"
            label="Image URL"
            rules={[{ required: true, message: "Please enter image URL" }]}
          >
            <Input />
          </Form.Item>
        </Form>
      </Modal>

      {/* Delete Confirmation Modal */}
      <Modal
        title="Delete Shop"
        visible={isDeleting}
        onOk={handleDelete}
        onCancel={() => setIsDeleting(false)}
        okText="Yes, Delete"
        cancelText="Cancel"
      >
        <p>Are you sure you want to delete this shop profile?</p>
      </Modal>
    </div>
  );
};

export default ShopProfile;
