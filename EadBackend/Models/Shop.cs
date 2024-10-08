/******************************************************************************
* File: Shop.cs
* Author: KT Navodya (IT21057106)
* Date: [2024-10-07]
* Description: This file contains the Shop model class, which represents
*              a shop in the EAD Backend application's MongoDB database.
******************************************************************************/

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EadBackend.Models
{
    /// <summary>
    /// Represents a shop in the system
    /// </summary>
    public class Shop
    {
        /// <summary>
        /// Unique identifier for the shop
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the shop
        /// </summary>
        [BsonElement("Name")]
        public string Name { get; set; }

        /// <summary>
        /// URL of the shop's image
        /// </summary>
        [BsonElement("ImageUrl")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Identifier of the vendor who owns the shop
        /// </summary>
        [BsonElement("VendorId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string VendorId { get; set; }

        /// <summary>
        /// Physical address of the shop
        /// </summary>
        [BsonElement("Address")]
        public string Address { get; set; }

        /// <summary>
        /// Contact number for the shop
        /// </summary>
        [BsonElement("ContactNumber")]
        public string ContactNumber { get; set; }
    }
}