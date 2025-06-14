using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entities
{
    public class Category
    {
        [BsonId] // MongoDB'de bu alanın belge kimliği (Id) olduğunu belirtir.

        [BsonRepresentation(BsonType.ObjectId)] // MongoDB'de ObjectId olarak saklanır, C# tarafında string olarak kullanılır.

        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
