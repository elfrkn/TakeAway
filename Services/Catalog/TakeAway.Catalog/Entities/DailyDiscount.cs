﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TakeAway.Catalog.Entities
{
    public class DailyDiscount
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string DailyDiscountId { get; set; }
        public string MainTitle { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}