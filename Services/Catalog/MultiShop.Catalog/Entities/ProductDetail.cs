﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entities
{
    public class ProductDetail
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductDetailId { get; set; }
        public string ProductDetailDescription { get; set; }
        public string ProductDetailInfo { get; set; }
        public string ProdutcId { get; set; }

		[BsonIgnore]
		public Product Product { get; set; }
        
    }
}
