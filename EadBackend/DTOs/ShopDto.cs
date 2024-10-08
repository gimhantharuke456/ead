/******************************************************************************
* File: ShopDTOs.cs
* Author: KT Navodya (IT21057106)
* Date: [2024-10-07]
* Description: This file contains Data Transfer Object (DTO) classes related to
*              shop management in the EAD Backend application.
******************************************************************************/

namespace EadBackend.DTOs
{
    /// <summary>
    /// Represents a shop in the system
    /// </summary>
    public class ShopDto
    {
        /// <summary>
        /// Unique identifier for the shop
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Name of the shop
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// URL of the shop's image
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Identifier of the vendor who owns the shop
        /// </summary>
        public string VendorId { get; set; }

        /// <summary>
        /// Physical address of the shop
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Contact number for the shop
        /// </summary>
        public string ContactNumber { get; set; }
    }

    /// <summary>
    /// Represents the data required to create a new shop
    /// </summary>
    public class CreateShopDto
    {
        /// <summary>
        /// Name of the new shop
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// URL of the new shop's image
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Physical address of the new shop
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Contact number for the new shop
        /// </summary>
        public string ContactNumber { get; set; }

        /// <summary>
        /// Identifier of the vendor creating the shop
        /// </summary>
        public string VendorId { get; set; }
    }

    /// <summary>
    /// Represents the data that can be updated for an existing shop
    /// </summary>
    public class UpdateShopDto
    {
        /// <summary>
        /// Updated name of the shop
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Updated URL of the shop's image
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Updated physical address of the shop
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Updated contact number for the shop
        /// </summary>
        public string ContactNumber { get; set; }

        /// <summary>
        /// Updated identifier of the vendor who owns the shop
        /// </summary>
        public string VendorId { get; set; }
    }
}