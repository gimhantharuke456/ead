using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EadBackend.Models
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("ShopItemId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ShopItemId { get; set; }

        [BsonElement("ShopId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ShopId { get; set; }

        [BsonElement("UserId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string UserId { get; set; }

        [BsonElement("Quantity")]
        public int Quantity { get; set; }

        [BsonElement("Address")]
        public string Address { get; set; }

        [BsonElement("Status")]
        public string Status { get; set; }
    }
}
