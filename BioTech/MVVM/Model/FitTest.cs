using MongoDB.Bson.Serialization.Attributes;

namespace BioTech.MVVM.Model;

[BsonIgnoreExtraElements]
public class FitTest
{
    [BsonElement("persRefId")]
    public string RefId { get; set; }

    [BsonElement("nome")]
    public string Nome { get; set; }

    [BsonElement("cognome")]
    public string Cognome { get; set; }

    [BsonElement("data")]
    public DateTime Data { get; set; }

    [BsonElement("ossa")]
    public Ossa Ossa { get; set; }

    [BsonElement("pliche")]
    public Pliche Pliche { get; set; }

    [BsonElement("circonferenze")]
    public Circonferenze Circonferenze { get; set; }
}