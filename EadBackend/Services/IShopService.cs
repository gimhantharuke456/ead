/*******************************************************************************
 * File: IShopService.cs
 * Author: KT Navodya (IT21057106)
 * Date: [Current Date]
 * Description: This file contains the IShopService interface, which defines
 *              the contract for shop-related business operations in the EAD Backend application.
 ******************************************************************************/

using EadBackend.DTOs;

namespace EadBackend.Services
{
    /// <summary>
    /// Interface for shop service operations
    /// </summary>
    public interface IShopService
    {
        /// <summary>
        /// Retrieves a shop by its unique identifier
        /// </summary>
        /// <param name="id">The unique identifier of the shop</param>
        /// <returns>The shop DTO if found, otherwise null</returns>
        Task<ShopDto> GetByIdAsync(string id);

        /// <summary>
        /// Retrieves all shops in the system
        /// </summary>
        /// <returns>An enumerable collection of all shop DTOs</returns>
        Task<IEnumerable<ShopDto>> GetAllAsync();

        /// <summary>
        /// Retrieves all shops for a specific vendor
        /// </summary>
        /// <param name="vendorId">The unique identifier of the vendor</param>
        /// <returns>An enumerable collection of shop DTOs for the specified vendor</returns>
        Task<IEnumerable<ShopDto>> GetByVendorIdAsync(string vendorId);

        /// <summary>
        /// Creates a new shop in the system
        /// </summary>
        /// <param name="vendorId">The unique identifier of the vendor creating the shop</param>
        /// <param name="createShopDto">The DTO containing the shop creation information</param>
        /// <returns>The created shop DTO</returns>
        Task<ShopDto> CreateAsync(string vendorId, CreateShopDto createShopDto);

        /// <summary>
        /// Updates an existing shop in the system
        /// </summary>
        /// <param name="id">The unique identifier of the shop to be updated</param>
        /// <param name="vendorId">The unique identifier of the vendor updating the shop</param>
        /// <param name="updateShopDto">The DTO containing the updated shop information</param>
        /// <returns>The updated shop DTO</returns>
        Task<ShopDto> UpdateAsync(string id, string vendorId, UpdateShopDto updateShopDto);

        /// <summary>
        /// Deletes a shop from the system
        /// </summary>
        /// <param name="id">The unique identifier of the shop to be deleted</param>
        /// <param name="vendorId">The unique identifier of the vendor deleting the shop</param>
        Task DeleteAsync(string id, string vendorId);
    }
}