namespace EadBackend.DTOs
{
    public class CreateReviewDto
    {
        public string UserId { get; set; }
        public string ShopItemId { get; set; }
        public string ReviewText { get; set; }
        public int Stars { get; set; }
    }

    public class UpdateReviewDto
    {
        public string ReviewText { get; set; }
        public int Stars { get; set; }
    }

    public class ReviewDto
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string ShopItemId { get; set; }
        public string ReviewText { get; set; }
        public int Stars { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}