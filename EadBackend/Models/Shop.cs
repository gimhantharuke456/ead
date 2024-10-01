using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EadBackend.Models
{
    public class Shop
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("ImageUrl")]
        public string ImageUrl { get; set; }

        [BsonElement("VendorId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string VendorId { get; set; }

        [BsonElement("Address")]
        public string Address { get; set; }

        [BsonElement("ContactNumber")]
        public string ContactNumber { get; set; }
    }
}