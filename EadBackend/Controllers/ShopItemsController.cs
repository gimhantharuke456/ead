/******************************************************************************
* File: ShopItemsController.cs
* Author: KT Navodya (IT21057106)
* Date: [Current Date]
* Description: This file contains the ShopItemsController class, which handles
*              HTTP requests related to shop item management in the EAD Backend application.
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
    public class ShopItemsController : ControllerBase
    {
        private readonly IShopItemService _shopItemService;

        public ShopItemsController(IShopItemService shopItemService)
        {
            _shopItemService = shopItemService;
        }

        /// <summary>
        /// Retrieves all shop items
        /// </summary>
        /// <returns>A list of all shop items</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShopItemDto>>> GetAll()
        {
            var shopItems = await _shopItemService.GetAllAsync();
            return Ok(shopItems);
        }

        /// <summary>
        /// Retrieves a specific shop item by its ID
        /// </summary>
        /// <param name="id">The ID of the shop item to retrieve</param>
        /// <returns>The requested shop item if found, otherwise a 404 Not Found response</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<ShopItemDto>> GetById(string id)
        {
            var shopItem = await _shopItemService.GetByIdAsync(id);
            if (shopItem == null)
                return NotFound();
            return Ok(shopItem);
        }

        /// <summary>
        /// Retrieves all shop items for a specific shop
        /// </summary>
        /// <param name="shopId">The ID of the shop</param>
        /// <returns>A list of shop items belonging to the specified shop</returns>
        [HttpGet("shop/{shopId}")]
        public async Task<ActionResult<IEnumerable<ShopItemDto>>> GetByShopId(string shopId)
        {
            var shopItems = await _shopItemService.GetByShopIdAsync(shopId);
            return Ok(shopItems);
        }

        /// <summary>
        /// Creates a new shop item for a specific shop
        /// </summary>
        /// <param name="shopId">The ID of the shop to which the item will be added</param>
        /// <param name="createShopItemDto">The data for creating the new shop item</param>
        /// <returns>The created shop item</returns>
        [HttpPost("{shopId}")]
        [Authorize(Roles = "Vendor")]
        public async Task<ActionResult<ShopItemDto>> Create(string shopId, CreateShopItemDto createShopItemDto)
        {
            try
            {
                var shopItem = await _shopItemService.CreateAsync(shopId, "", createShopItemDto);
                return CreatedAtAction(nameof(GetById), new { id = shopItem.Id }, shopItem);
            }
            catch (UnauthorizedAccessException)
            {
                return Forbid();
            }
        }

        /// <summary>
        /// Updates an existing shop item
        /// </summary>
        /// <param name="id">The ID of the shop item to update</param>
        /// <param name="updateShopItemDto">The updated shop item data</param>
        /// <returns>The updated shop item if found, otherwise a 404 Not Found response</returns>
        [HttpPut("{id}")]
        [Authorize(Roles = "Vendor")]
        public async Task<ActionResult<ShopItemDto>> Update(string id, UpdateShopItemDto updateShopItemDto)
        {
            var vendorId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            try
            {
                var shopItem = await _shopItemService.UpdateAsync(id, vendorId, updateShopItemDto);
                return Ok(shopItem);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
            catch (UnauthorizedAccessException)
            {
                return Forbid();
            }
        }

        /// <summary>
        /// Deletes an existing shop item
        /// </summary>
        /// <param name="id">The ID of the shop item to delete</param>
        /// <returns>A 204 No Content response if successful, otherwise a 404 Not Found response</returns>
        [HttpDelete("{id}")]
        [Authorize(Roles = "Vendor")]
        public async Task<IActionResult> Delete(string id)
        {
            var vendorId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            try
            {
                await _shopItemService.DeleteAsync(id, vendorId);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
            catch (UnauthorizedAccessException)
            {
                return Forbid();
            }
        }
    }
}