/*******************************************************************************
 * File: IOrderService.cs
 * Author: KT Navodya (IT21057106)
 * Date: [2024-10-07]
 * Description: This file contains the IOrderService interface, which defines
 *              the contract for order-related business operations in the EAD Backend application.
 ******************************************************************************/

using EadBackend.DTOs;

namespace EadBackend.Services
{
    /// <summary>
    /// Interface for order service operations
    /// </summary>
    public interface IOrderService
    {
        /// <summary>
        /// Retrieves an order by its unique identifier
        /// </summary>
        /// <param name="id">The unique identifier of the order</param>
        /// <returns>The order DTO if found, otherwise null</returns>
        Task<OrderDto> GetByIdAsync(string id);

        /// <summary>
        /// Retrieves all orders in the system
        /// </summary>
        /// <returns>An enumerable collection of all order DTOs</returns>
        Task<IEnumerable<OrderDto>> GetAllAsync();

        /// <summary>
        /// Creates a new order in the system
        /// </summary>
        /// <param name="userId">The unique identifier of the user creating the order</param>
        /// <param name="createOrderDto">The DTO containing the order creation information</param>
        /// <returns>The created order DTO</returns>
        Task<OrderDto> CreateAsync(string userId, CreateOrderDto createOrderDto);

        /// <summary>
        /// Updates an existing order in the system
        /// </summary>
        /// <param name="id">The unique identifier of the order to be updated</param>
        /// <param name="userId">The unique identifier of the user updating the order</param>
        /// <param name="updateOrderDto">The DTO containing the updated order information</param>
        /// <returns>The updated order DTO</returns>
        Task<OrderDto> UpdateAsync(string id, string userId, UpdateOrderDto updateOrderDto);

        /// <summary>
        /// Deletes an order from the system
        /// </summary>
        /// <param name="id">The unique identifier of the order to be deleted</param>
        /// <param name="userId">The unique identifier of the user deleting the order</param>
        Task DeleteAsync(string id, string userId);
    }
}