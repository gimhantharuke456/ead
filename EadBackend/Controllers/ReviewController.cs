using Microsoft.AspNetCore.Mvc;
using EadBackend.Services;
using EadBackend.DTOs;

namespace EadBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReviewController : ControllerBase
    {
        private readonly ReviewService _reviewService;

        public ReviewController(ReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpPost]
        public async Task<ActionResult<ReviewDto>> CreateReview(CreateReviewDto createReviewDto)
        {
            var review = await _reviewService.CreateReviewAsync(createReviewDto);
            return CreatedAtAction(nameof(GetReview), new { id = review.Id }, review);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReviewDto>> GetReview(string id)
        {
            var review = await _reviewService.GetReviewAsync(id);
            if (review == null)
            {
                return NotFound();
            }
            return review;
        }

        [HttpGet("shopitem/{shopItemId}")]
        public async Task<ActionResult<IEnumerable<ReviewDto>>> GetReviewsByShopItem(string shopItemId)
        {
            var reviews = await _reviewService.GetReviewsByShopItemAsync(shopItemId);
            return Ok(reviews);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ReviewDto>> UpdateReview(string id, UpdateReviewDto updateReviewDto)
        {
            var updatedReview = await _reviewService.UpdateReviewAsync(id, updateReviewDto);
            if (updatedReview == null)
            {
                return NotFound();
            }
            return updatedReview;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReview(string id)
        {
            var result = await _reviewService.DeleteReviewAsync(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}