using MongoDB.Bson.Serialization.Attributes;

namespace BioTech.MVVM.Model;

public class Dati
{
    [BsonElement("altezza")]
    public double Altezza { get; set; }

    [BsonElement("peso")]
    public double Peso { get; set; }

    [BsonElement("bodyFat")]
    public double BodyFat { get; set; }
}