using MongoDB.Bson.Serialization.Attributes;

namespace BioTech.MVVM.Model;

public class Pliche
{
    [BsonElement("bicipite")]
    public double Bicipite { get; set; }

    [BsonElement("tricipite")]
    public double Tricipite { get; set; }

    [BsonElement("torace")]
    public double Torace { get; set; }

    [BsonElement("sottoscapola")]
    public double Sottoscapola { get; set; }

    [BsonElement("soprailio")]
    public double Soprailio { get; set; }

    [BsonElement("ombelico")]
    public double Ombelico { get; set; }

    [BsonElement("coscia")]
    public double Coscia { get; set; }

    [BsonElement("cosciaEsterna")]
    public double CosciaEsterna { get; set; }
}