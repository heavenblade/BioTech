using MongoDB.Bson.Serialization.Attributes;

namespace BioTech.MVVM.Model;

[BsonIgnoreExtraElements]
public class Dieta
{
    [BsonElement("nome")]
    public string Nome { get; set; }

    [BsonElement("categoria")]
    public string Categoria { get; set; }

    [BsonElement("programma")]
    public string? Programma { get; set; }
}