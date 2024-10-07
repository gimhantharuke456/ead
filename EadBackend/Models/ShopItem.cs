/*******************************************************************************
 * File: Models.cs
 * Author: RPGT Rajapaksha (IT21048500)
 * Date: 2024-10-07
 * Description: This file contains the model classes for ShopItem and User
 *              in the EAD Backend application.
 ******************************************************************************/

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EadBackend.Models
{
    /// <summary>
    /// Represents a shop item in the system
    /// </summary>
    public class ShopItem
    {
        /// <summary>
        /// Unique identifier for the shop item
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the shop item
        /// </summary>
        [BsonElement("Name")]
        public string Name { get; set; }

        /// <summary>
        /// Current stock amount of the item
        /// </summary>
        [BsonElement("InstockAmount")]
        public int InstockAmount { get; set; }

        /// <summary>
        /// Price of the shop item
        /// </summary>
        [BsonElement("Price")]
        public double Price { get; set; }

        /// <summary>
        /// Description of the shop item
        /// </summary>
        [BsonElement("Description")]
        public string Description { get; set; }

        /// <summary>
        /// URL of the item's image
        /// </summary>
        [BsonElement("ImageUrl")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// ID of the shop this item belongs to
        /// </summary>
        [BsonElement("ShopId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ShopId { get; set; }
    }


}