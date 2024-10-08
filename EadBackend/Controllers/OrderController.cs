/******************************************************************************
* File: OrdersController.cs
* Author: KT Navodya (IT21057106)
* Date: [2024-10-07]
* Description: This file contains the OrdersController class, which handles
*              HTTP requests related to order management in the EAD Backend application.
******************************************************************************/

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EadBackend.DTOs;
using EadBackend.Services;
using System.Security.Claims;

namespace EadBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        /// <summary>
        /// Retrieves all orders
        /// </summary>
        /// <returns>A list of all orders</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDto>>> GetAll()
        {
            var orders = await _orderService.GetAllAsync();
            return Ok(orders);
        }

        /// <summary>
        /// Retrieves a specific order by its ID
        /// </summary>
        /// <param name="id">The ID of the order to retrieve</param>
        /// <returns>The requested order if found, otherwise a 404 Not Found response</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDto>> GetById(string id)
        {
            var order = await _orderService.GetByIdAsync(id);
            if (order == null)
                return NotFound();
            return Ok(order);
        }

        /// <summary>
        /// Creates a new order
        /// </summary>
        /// <param name="createOrderDto">The data for creating the new order</param>
        /// <returns>The created order</returns>
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<OrderDto>> Create(CreateOrderDto createOrderDto)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var order = await _orderService.CreateAsync(userId, createOrderDto);
            return CreatedAtAction(nameof(GetById), new { id = order.Id }, order);
        }

        /// <summary>
        /// Updates an existing order
        /// </summary>
        /// <param name="id">The ID of the order to update</param>
        /// <param name="updateOrderDto">The updated order data</param>
        /// <returns>The updated order if found, otherwise a 404 Not Found response</returns>
        [HttpPut("{id}")]
        [Authorize]
        public async Task<ActionResult<OrderDto>> Update(string id, UpdateOrderDto updateOrderDto)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            try
            {
                var order = await _orderService.UpdateAsync(id, userId, updateOrderDto);
                return Ok(order);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Deletes an existing order
        /// </summary>
        /// <param name="id">The ID of the order to delete</param>
        /// <returns>A 204 No Content response if successful, otherwise a 404 Not Found response</returns>
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(string id)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            try
            {
                await _orderService.DeleteAsync(id, userId);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
    }
}