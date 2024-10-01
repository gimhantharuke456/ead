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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShopItemDto>>> GetAll()
        {
            var shopItems = await _shopItemService.GetAllAsync();
            return Ok(shopItems);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ShopItemDto>> GetById(string id)
        {
            var shopItem = await _shopItemService.GetByIdAsync(id);
            if (shopItem == null)
                return NotFound();
            return Ok(shopItem);
        }

        [HttpGet("shop/{shopId}")]
        public async Task<ActionResult<IEnumerable<ShopItemDto>>> GetByShopId(string shopId)
        {
            var shopItems = await _shopItemService.GetByShopIdAsync(shopId);
            return Ok(shopItems);
        }

        [HttpPost("{shopId}")]
        [Authorize(Roles = "Vendor")]
        public async Task<ActionResult<ShopItemDto>> Create(string shopId, CreateShopItemDto createShopItemDto)
        {
            var vendorId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            try
            {
                var shopItem = await _shopItemService.CreateAsync(shopId, vendorId, createShopItemDto);
                return CreatedAtAction(nameof(GetById), new { id = shopItem.Id }, shopItem);
            }
            catch (UnauthorizedAccessException)
            {
                return Forbid();
            }
        }

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