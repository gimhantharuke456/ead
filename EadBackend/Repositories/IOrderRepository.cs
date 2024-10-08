/******************************************************************************
* File: IOrderRepository.cs
* Author: KT Navodya (IT21057106)
* Date: [2024-10-07]
* Description: This file contains the IOrderRepository interface, which defines
*              the contract for order data access operations in the EAD Backend application.
******************************************************************************/

using EadBackend.Models;

namespace EadBackend.Repositories
{
    /// <summary>
    /// Interface for order repository operations
    /// </summary>
    public interface IOrderRepository
    {
        /// <summary>
        /// Retrieves an order by its unique identifier
        /// </summary>
        /// <param name="id">The unique identifier of the order</param>
        /// <returns>The order if found, otherwise null</returns>
        Task<Order> GetByIdAsync(string id);

        /// <summary>
        /// Retrieves all orders in the system
        /// </summary>
        /// <returns>An enumerable collection of all orders</returns>
        Task<IEnumerable<Order>> GetAllAsync();

        /// <summary>
        /// Creates a new order in the system
        /// </summary>
        /// <param name="order">The order to be created</param>
        Task CreateAsync(Order order);

        /// <summary>
        /// Updates an existing order in the system
        /// </summary>
        /// <param name="id">The unique identifier of the order to be updated</param>
        /// <param name="order">The updated order information</param>
        Task UpdateAsync(string id, Order order);

        /// <summary>
        /// Deletes an order from the system
        /// </summary>
        /// <param name="id">The unique identifier of the order to be deleted</param>
        Task DeleteAsync(string id);
    }
}