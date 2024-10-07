using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EadBackend.Models
{
    public class Review
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("userId")]
        public string UserId { get; set; }

        [BsonElement("shopItemId")]
        public string ShopItemId { get; set; }

        [BsonElement("review")]
        public string ReviewText { get; set; }

        [BsonElement("stars")]
        public int Stars { get; set; }

        [BsonElement("createdAt")]
        public DateTime CreatedAt { get; set; }
    }
}