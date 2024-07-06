using MongoDB.Bson.Serialization.Attributes;

namespace BioTech.MVVM.Model;

public class Circonferenze
{
    [BsonElement("braccio")]
    public double Braccio { get; set; }

    [BsonElement("spalle")]
    public double Spalle { get; set; }

    [BsonElement("torace")]
    public double Torace { get; set; }

    [BsonElement("vita")]
    public double Vita { get; set; }

    [BsonElement("fianchi")]
    public double Fianchi { get; set; }

    [BsonElement("gamba")]
    public double Gamba { get; set; }
}