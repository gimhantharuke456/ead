/*******************************************************************************
 * File: ShopItemDTOs.cs
 * Author: RPGT Rajapaksha (IT21048500)
 * Date: 2024-10-07
 * Description: This file contains the Data Transfer Objects (DTOs) related to
 *              shop items in the EAD Backend application.
 ******************************************************************************/

namespace EadBackend.DTOs
{
    /// <summary>
    /// DTO for representing a shop item
    /// </summary>
    public class ShopItemDto
    {
        /// <summary>
        /// Unique identifier for the shop item
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Name of the shop item
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Current stock amount of the item
        /// </summary>
        public int InstockAmount { get; set; }

        /// <summary>
        /// Description of the shop item
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// URL of the item's image
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// ID of the shop this item belongs to
        /// </summary>
        public string ShopId { get; set; }

        /// <summary>
        /// Price of the shop item
        /// </summary>
        public double Price { get; set; }
    }

    /// <summary>
    /// DTO for creating a new shop item
    /// </summary>
    public class CreateShopItemDto
    {
        /// <summary>
        /// Name of the new shop item
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Initial stock amount of the new item
        /// </summary>
        public int InstockAmount { get; set; }

        /// <summary>
        /// Description of the new shop item
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// URL of the new item's image
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Price of the new shop item
        /// </summary>
        public double Price { get; set; }
    }

    /// <summary>
    /// DTO for updating an existing shop item
    /// </summary>
    public class UpdateShopItemDto
    {
        /// <summary>
        /// Updated name of the shop item
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Updated stock amount of the item
        /// </summary>
        public int InstockAmount { get; set; }

        /// <summary>
        /// Updated description of the shop item
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Updated URL of the item's image
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Updated price of the shop item
        /// </summary>
        public double Price { get; set; }
    }
}