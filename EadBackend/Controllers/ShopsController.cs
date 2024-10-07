/*******************************************************************************
 * File: ShopsController.cs
 * Author: RPGT Rajapaksha (IT21048500)
 * Date: 2024-10-07
 * Description: This file contains the ShopsController class, which handles
 *              HTTP requests related to shop operations in the EAD Backend application.
 ******************************************************************************/

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EadBackend.DTOs;
using EadBackend.Services;
using System.Security.Claims;
using System.Diagnostics;

namespace EadBackend.Controllers
{
    /// <summary>
    /// Controller for handling shop-related operations
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ShopsController : ControllerBase
    {
        private readonly IShopService _shopService;

        /// <summary>
        /// Constructor for ShopsController
        /// </summary>
        /// <param name="shopService">The shop service dependency</param>
        public ShopsController(IShopService shopService)
        {
            _shopService = shopService;
        }

        /// <summary>
        /// Retrieves all shops
        /// </summary>
        /// <returns>A list of all shops</returns>
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ShopDto>>> GetAll()
        {
            var shops = await _shopService.GetAllAsync();
            return Ok(shops);
        }

        /// <summary>
        /// Retrieves a specific shop by its ID
        /// </summary>
        /// <param name="id">The ID of the shop to retrieve</param>
        /// <returns>The requested shop if found, otherwise a 404 Not Found response</returns>
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<ShopDto>> GetById(string id)
        {
            var shop = await _shopService.GetByIdAsync(id);
            if (shop == null)
                return NotFound();
            return Ok(shop);
        }

        /// <summary>
        /// Retrieves all shops for a specific vendor
        /// </summary>
        /// <param name="id">The ID of the vendor</param>
        /// <returns>A list of shops belonging to the specified vendor</returns>
        [HttpGet("vendor/{id}")]
        [Authorize(Roles = "Vendor")]
        public async Task<ActionResult<IEnumerable<ShopDto>>> GetByVendor(string id)
        {
            var shops = await _shopService.GetByVendorIdAsync(id);
            return Ok(shops);
        }

        /// <summary>
        /// Creates a new shop
        /// </summary>
        /// <param name="createShopDto">The shop creation data</param>
        /// <returns>The created shop</returns>
        [HttpPost]
        [Authorize(Roles = "Admin,Vendor")]
        public async Task<ActionResult<ShopDto>> Create(CreateShopDto createShopDto)
        {
            var vendorId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var shop = await _shopService.CreateAsync(vendorId, createShopDto);
            return CreatedAtAction(nameof(GetById), new { id = shop.Id }, shop);
        }

        /// <summary>
        /// Updates an existing shop
        /// </summary>
        /// <param name="id">The ID of the shop to update</param>
        /// <param name="updateShopDto">The updated shop data</param>
        /// <returns>The updated shop if successful, otherwise a 403 Forbidden response</returns>
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin,Vendor")]
        public async Task<ActionResult<ShopDto>> Update(string id, UpdateShopDto updateShopDto)
        {
            try
            {
                var shop = await _shopService.UpdateAsync(id, updateShopDto.VendorId, updateShopDto);
                return Ok(shop);
            }
            catch (UnauthorizedAccessException)
            {
                return Forbid();
            }
        }

        /// <summary>
        /// Deletes a shop
        /// </summary>
        /// <param name="id">The ID of the shop to delete</param>
        /// <returns>A 204 No Content response if successful, otherwise a 403 Forbidden response</returns>
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin,Vendor")]
        public async Task<IActionResult> Delete(string id)
        {
            var vendorId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            try
            {
                await _shopService.DeleteAsync(id, vendorId);
                return NoContent();
            }
            catch (UnauthorizedAccessException)
            {
                return Forbid();
            }
        }
    }
}