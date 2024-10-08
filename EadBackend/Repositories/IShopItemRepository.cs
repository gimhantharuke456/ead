/*******************************************************************************
 * File: IShopItemRepository.cs
 * Author: KT Navodya (IT21057106)
 * Date: [2024-10-07]
 * Description: This file contains the IShopItemRepository interface, which defines
 *              the contract for shop item data access operations in the EAD Backend application.
 ******************************************************************************/

using EadBackend.Models;

namespace EadBackend.Repositories
{
    /// <summary>
    /// Interface for shop item repository operations
    /// </summary>
    public interface IShopItemRepository
    {
        /// <summary>
        /// Retrieves a shop item by its unique identifier
        /// </summary>
        /// <param name="id">The unique identifier of the shop item</param>
        /// <returns>The shop item if found, otherwise null</returns>
        Task<ShopItem> GetByIdAsync(string id);

        /// <summary>
        /// Retrieves all shop items in the system
        /// </summary>
        /// <returns>An enumerable collection of all shop items</returns>
        Task<IEnumerable<ShopItem>> GetAllAsync();

        /// <summary>
        /// Retrieves all shop items for a specific shop
        /// </summary>
        /// <param name="shopId">The unique identifier of the shop</param>
        /// <returns>An enumerable collection of shop items for the specified shop</returns>
        Task<IEnumerable<ShopItem>> GetByShopIdAsync(string shopId);

        /// <summary>
        /// Creates a new shop item in the system
        /// </summary>
        /// <param name="shopItem">The shop item to be created</param>
        Task CreateAsync(ShopItem shopItem);

        /// <summary>
        /// Updates an existing shop item in the system
        /// </summary>
        /// <param name="id">The unique identifier of the shop item to be updated</param>
        /// <param name="shopItem">The updated shop item information</param>
        Task UpdateAsync(string id, ShopItem shopItem);

        /// <summary>
        /// Deletes a shop item from the system
        /// </summary>
        /// <param name="id">The unique identifier of the shop item to be deleted</param>
        Task DeleteAsync(string id);
    }
}