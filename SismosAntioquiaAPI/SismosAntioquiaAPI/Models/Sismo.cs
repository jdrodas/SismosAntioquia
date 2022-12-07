using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace SismosAntioquiaAPI.Models
{
    public class Sismo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [BsonElement("region")]
        [JsonPropertyName("region")]
        public string Region { get; set; } = null!;

        [BsonElement("fechaHora")]
        [JsonPropertyName("fechaHora")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime FechaHora { get; set; }

        [BsonElement("magnitud")]
        [JsonPropertyName("magnitud")]
        public double Magnitud { get; set; }

        [BsonElement("profundidad")]
        [JsonPropertyName("profundidad")]
        public double Profundidad { get; set; }

        [BsonElement("longitud")]
        [JsonPropertyName("longitud")]
        public double Longitud { get; set; }

        [BsonElement("latitud")]
        [JsonPropertyName("latitud")]
        public double Latitud { get; set; }
    }
}
