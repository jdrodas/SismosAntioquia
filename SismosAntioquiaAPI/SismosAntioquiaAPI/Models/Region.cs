using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace SismosAntioquiaAPI.Models
{
    public class Region
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [BsonElement("nombre")]
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; } = null!;
    }
}
