using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ApiCocktails.Models
{
    public class Cocktel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("nombre")]
        public string? Nombre { get; set; }
        
        [BsonElement("nombreCategoria")]
        public string? NombreCategoria { get; set; }

        [BsonElement("informacion")]
        public string? Informacion { get; set; }

        [BsonElement("ingredientes")]
        public string? Ingredientes { get; set; }

        [BsonElement("instrucciones")]
        public string? Instrucciones { get; set; }

        [BsonElement("nombreVidrio")]
        public string? NombreVidrio { get; set; }
        
        [BsonElement("urlFoto")]
        public string? UrlFoto { get; set; }
        
        [BsonElement("disponibleBar")]
        public List<Bar>? DisponibleBar { get; set; }
    }
}