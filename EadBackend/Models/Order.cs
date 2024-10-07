/******************************************************************************
* File: Order.cs
* Author: KT Navodya (IT21057106)
* Date: [Current Date]
* Description: This file contains the Order model class, which represents
*              an order in the EAD Backend application's MongoDB database.
******************************************************************************/

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EadBackend.Models
{
    /// <summary>
    /// Represents an order in the system
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Unique identifier for the order
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        /// <summary>
        /// Identifier of the shop item being ordered
        /// </summary>
        [BsonElement("ShopItemId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ShopItemId { get; set; }

        /// <summary>
        /// Identifier of the shop the item belongs to
        /// </summary>
        [BsonElement("ShopId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ShopId { get; set; }

        /// <summary>
        /// Identifier of the user placing the order
        /// </summary>
        [BsonElement("UserId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string UserId { get; set; }

        /// <summary>
        /// Quantity of the item being ordered
        /// </summary>
        [BsonElement("Quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Delivery address for the order
        /// </summary>
        [BsonElement("Address")]
        public string Address { get; set; }

        /// <summary>
        /// Current status of the order
        /// </summary>
        [BsonElement("Status")]
        public string Status { get; set; }
    }
}