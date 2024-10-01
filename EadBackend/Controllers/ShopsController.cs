using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EadBackend.DTOs;
using EadBackend.Services;
using System.Security.Claims;

namespace EadBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ShopsController : ControllerBase
    {
        private readonly IShopService _shopService;

        public ShopsController(IShopService shopService)
        {
            _shopService = shopService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ShopDto>>> GetAll()
        {
            var shops = await _shopService.GetAllAsync();
            return Ok(shops);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<ShopDto>> GetById(string id)
        {
            var shop = await _shopService.GetByIdAsync(id);
            if (shop == null)
                return NotFound();
            return Ok(shop);
        }

        [HttpGet("vendor")]
        [Authorize(Roles = "Vendor")]
        public async Task<ActionResult<IEnumerable<ShopDto>>> GetByVendor()
        {
            var vendorId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var shops = await _shopService.GetByVendorIdAsync(vendorId);
            return Ok(shops);
        }

        [HttpPost]
        [Authorize(Roles = "Vendor")]
        public async Task<ActionResult<ShopDto>> Create(CreateShopDto createShopDto)
        {
            var vendorId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var shop = await _shopService.CreateAsync(vendorId, createShopDto);
            return CreatedAtAction(nameof(GetById), new { id = shop.Id }, shop);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Vendor")]
        public async Task<ActionResult<ShopDto>> Update(string id, UpdateShopDto updateShopDto)
        {
            var vendorId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            try
            {
                var shop = await _shopService.UpdateAsync(id, vendorId, updateShopDto);
                return Ok(shop);
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