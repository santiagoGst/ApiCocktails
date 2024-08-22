using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ApiCocktails.Models
{
    public class Bar
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("nombre")]
        public string? Nombre { get; set; }
        
        [BsonElement("direccion")]
        public string? Direccion { get; set; }

        [BsonElement("latitud")]
        public double Latitud { get; set; }
        
        [BsonElement("longitud")]
        public double Longitud { get; set; }
    }
}