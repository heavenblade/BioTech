using MongoDB.Bson.Serialization.Attributes;

namespace BioTech.MVVM.Model;

[BsonIgnoreExtraElements]
public class Allenamento
{
    [BsonElement("nome")]
    public string Nome { get; set; }

    [BsonElement("categoria")]
    public string Categoria { get; set; }
    
    [BsonElement("tabella")]
    public string Tabella { get; set; }
}