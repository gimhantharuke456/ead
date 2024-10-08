/*******************************************************************************
 * File: IShopItemService.cs
 * Author: KT Navodya (IT21057106)
 * Date: [2024-10-07]
 * Description: This file contains the IShopItemService interface, which defines
 *              the contract for shop item-related business operations in the EAD Backend application.
 ******************************************************************************/

using EadBackend.DTOs;

namespace EadBackend.Services
{
    /// <summary>
    /// Interface for shop item service operations
    /// </summary>
    public interface IShopItemService
    {
        /// <summary>
        /// Retrieves a shop item by its unique identifier
        /// </summary>
        /// <param name="id">The unique identifier of the shop item</param>
        /// <returns>The shop item DTO if found, otherwise null</returns>
        Task<ShopItemDto> GetByIdAsync(string id);

        /// <summary>
        /// Retrieves all shop items in the system
        /// </summary>
        /// <returns>An enumerable collection of all shop item DTOs</returns>
        Task<IEnumerable<ShopItemDto>> GetAllAsync();

        /// <summary>
        /// Retrieves all shop items for a specific shop
        /// </summary>
        /// <param name="shopId">The unique identifier of the shop</param>
        /// <returns>An enumerable collection of shop item DTOs for the specified shop</returns>
        Task<IEnumerable<ShopItemDto>> GetByShopIdAsync(string shopId);

        /// <summary>
        /// Creates a new shop item in the system
        /// </summary>
        /// <param name="shopId">The unique identifier of the shop</param>
        /// <param name="vendorId">The unique identifier of the vendor creating the shop item</param>
        /// <param name="createShopItemDto">The DTO containing the shop item creation information</param>
        /// <returns>The created shop item DTO</returns>
        Task<ShopItemDto> CreateAsync(string shopId, string vendorId, CreateShopItemDto createShopItemDto);

        /// <summary>
        /// Updates an existing shop item in the system
        /// </summary>
        /// <param name="id">The unique identifier of the shop item to be updated</param>
        /// <param name="vendorId">The unique identifier of the vendor updating the shop item</param>
        /// <param name="updateShopItemDto">The DTO containing the updated shop item information</param>
        /// <returns>The updated shop item DTO</returns>
        Task<ShopItemDto> UpdateAsync(string id, string vendorId, UpdateShopItemDto updateShopItemDto);

        /// <summary>
        /// Deletes a shop item from the system
        /// </summary>
        /// <param name="id">The unique identifier of the shop item to be deleted</param>
        /// <param name="vendorId">The unique identifier of the vendor deleting the shop item</param>
        Task DeleteAsync(string id, string vendorId);
    }
}