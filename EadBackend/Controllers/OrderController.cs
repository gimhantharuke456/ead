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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDto>>> GetAll()
        {
            var orders = await _orderService.GetAllAsync();
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDto>> GetById(string id)
        {
            var order = await _orderService.GetByIdAsync(id);
            if (order == null)
                return NotFound();
            return Ok(order);
        }

        [HttpPost]
        public async Task<ActionResult<OrderDto>> Create(CreateOrderDto createOrderDto)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var order = await _orderService.CreateAsync(userId, createOrderDto);
            return CreatedAtAction(nameof(GetById), new { id = order.Id }, order);
        }

        [HttpPut("{id}")]
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

        [HttpDelete("{id}")]

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
