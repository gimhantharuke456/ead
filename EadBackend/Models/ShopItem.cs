using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EadBackend.Models
{
    public class ShopItem
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("InstockAmount")]
        public int InstockAmount { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }

        [BsonElement("ImageUrl")]
        public string ImageUrl { get; set; }

        [BsonElement("ShopId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ShopId { get; set; }
    }
}