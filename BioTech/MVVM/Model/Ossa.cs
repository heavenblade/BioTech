using MongoDB.Bson.Serialization.Attributes;

namespace BioTech.MVVM.Model;

public class Ossa
{
    [BsonElement("polso")]
    public double Polso { get; set; }

    [BsonElement("ginocchia")]
    public double Ginocchia { get; set; }

    [BsonElement("caviglia")]
    public double Caviglia { get; set; }
}