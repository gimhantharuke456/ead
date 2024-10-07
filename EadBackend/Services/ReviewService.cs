using MongoDB.Driver;
using EadBackend.Models;
using EadBackend.DTOs;
using Microsoft.Extensions.Options;

namespace EadBackend.Services
{
    public class ReviewService
    {
        private readonly IMongoCollection<Review> _reviews;

        public ReviewService(IMongoClient mongoClient, IOptions<MongoDatabaseSettings> databaseSettings)
        {
            var database = mongoClient.GetDatabase(databaseSettings.Value.DatabaseName);
            _reviews = database.GetCollection<Review>("reviews");
        }

        public async Task<ReviewDto> CreateReviewAsync(CreateReviewDto createReviewDto)
        {
            var review = new Review
            {
                UserId = createReviewDto.UserId,
                ShopItemId = createReviewDto.ShopItemId,
                ReviewText = createReviewDto.ReviewText,
                Stars = createReviewDto.Stars,
                CreatedAt = DateTime.UtcNow
            };

            await _reviews.InsertOneAsync(review);

            return MapToDto(review);
        }

        public async Task<ReviewDto> GetReviewAsync(string id)
        {
            var review = await _reviews.Find(r => r.Id == id).FirstOrDefaultAsync();
            return review != null ? MapToDto(review) : null;
        }

        public async Task<IEnumerable<ReviewDto>> GetReviewsByShopItemAsync(string shopItemId)
        {
            var reviews = await _reviews.Find(r => r.ShopItemId == shopItemId).ToListAsync();
            return reviews.Select(MapToDto);
        }

        public async Task<ReviewDto> UpdateReviewAsync(string id, UpdateReviewDto updateReviewDto)
        {
            var update = Builders<Review>.Update
                .Set(r => r.ReviewText, updateReviewDto.ReviewText)
                .Set(r => r.Stars, updateReviewDto.Stars);

            var options = new FindOneAndUpdateOptions<Review, Review>
            {
                ReturnDocument = ReturnDocument.After
            };

            // Use FindOneAndUpdateAsync instead of FindOneAndUpdate
            var updatedReview = await _reviews.FindOneAndUpdateAsync<Review, Review>(r => r.Id == id, update, options);

            return updatedReview != null ? MapToDto(updatedReview) : null;
        }



        public async Task<bool> DeleteReviewAsync(string id)
        {
            var result = await _reviews.DeleteOneAsync(r => r.Id == id);
            return result.DeletedCount > 0;
        }

        private ReviewDto MapToDto(Review review)
        {
            return new ReviewDto
            {
                Id = review.Id,
                UserId = review.UserId,
                ShopItemId = review.ShopItemId,
                ReviewText = review.ReviewText,
                Stars = review.Stars,
                CreatedAt = review.CreatedAt
            };
        }
    }
}