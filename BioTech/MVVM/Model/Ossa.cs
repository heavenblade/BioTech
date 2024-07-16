using MongoDB.Bson.Serialization.Attributes;

namespace BioTech.MVVM.Model;

public class Ossa
{
    [BsonElement("polso")]
    public double Polso { get; set; }

    [BsonElement("ginocchio")]
    public double Ginocchio { get; set; }

    [BsonElement("caviglia")]
    public double Caviglia { get; set; }
}