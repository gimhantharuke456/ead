/******************************************************************************
* File: OrderDTOs.cs
* Author: KT Navodya (IT21057106)
* Date: [Current Date]
* Description: This file contains Data Transfer Object (DTO) classes related to
*              order management in the EAD Backend application.
******************************************************************************/

namespace EadBackend.DTOs
{
    /// <summary>
    /// Represents an order in the system
    /// </summary>
    public class OrderDto
    {
        /// <summary>
        /// Unique identifier for the order
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Identifier of the shop item being ordered
        /// </summary>
        public string ShopItemId { get; set; }

        /// <summary>
        /// Identifier of the shop the item belongs to
        /// </summary>
        public string ShopId { get; set; }

        /// <summary>
        /// Identifier of the user placing the order
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Quantity of the item being ordered
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Delivery address for the order
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Current status of the order
        /// </summary>
        public string Status { get; set; }
    }

    /// <summary>
    /// Represents the data required to create a new order
    /// </summary>
    public class CreateOrderDto
    {
        /// <summary>
        /// Identifier of the shop item being ordered
        /// </summary>
        public string ShopItemId { get; set; }

        /// <summary>
        /// Identifier of the shop the item belongs to
        /// </summary>
        public string ShopId { get; set; }

        /// <summary>
        /// Quantity of the item being ordered
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Delivery address for the order
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Initial status of the order
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Identifier of the user placing the order
        /// </summary>
        public string UserId { get; set; }
    }

    /// <summary>
    /// Represents the data that can be updated for an existing order
    /// </summary>
    public class UpdateOrderDto
    {
        /// <summary>
        /// Updated quantity of the item being ordered
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Updated delivery address for the order
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Updated status of the order
        /// </summary>
        public string Status { get; set; }
    }
}