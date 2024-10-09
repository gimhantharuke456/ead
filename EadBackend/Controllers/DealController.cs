using EadBackend.Models;
using EadBackend.DTOs;
using EadBackend.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EadBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DealsController : ControllerBase
    {
        private readonly DealService _dealService;

        public DealsController(DealService dealService)
        {
            _dealService = dealService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Deal>>> GetAllDeals()
        {
            var deals = await _dealService.GetAllDealsAsync();
            return Ok(deals);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Deal>> GetDealById(string id)
        {
            var deal = await _dealService.GetDealByIdAsync(id);
            if (deal == null)
            {
                return NotFound();
            }
            return Ok(deal);
        }

        [HttpPost]
        public async Task<ActionResult<Deal>> CreateDeal(CreateDealDto dealDto)
        {
            var createdDeal = await _dealService.CreateDealAsync(dealDto);
            return CreatedAtAction(nameof(GetDealById), new { id = createdDeal.Id }, createdDeal);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDeal(string id, UpdateDealDto dealDto)
        {
            var result = await _dealService.UpdateDealAsync(id, dealDto);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeal(string id)
        {
            var result = await _dealService.DeleteDealAsync(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}