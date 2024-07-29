using MongoDB.Bson.Serialization.Attributes;

namespace BioTech.MVVM.Model;

[BsonIgnoreExtraElements]
public class Alimento
{
    [BsonElement("nome")]
    public string Nome { get; set; }

    [BsonElement("tipologia")]
    public string Tipologia { get; set; }

    [BsonElement("unitàDiMisura")]
    public string UnitàDiMisura { get; set; }

    [BsonElement("energia")]
    public double Energia { get; set; }

    [BsonElement("grassiInsaturi")]
    public double GrassiInsaturi { get; set; }

    [BsonElement("grassiSaturi")]
    public double GrassiSaturi { get; set; }

    [BsonElement("carboidrati")]
    public double Carboidrati { get; set; }

    [BsonElement("zuccheri")]
    public double Zuccheri { get; set; }

    [BsonElement("fibre")]
    public double Fibre { get; set; }

    [BsonElement("proteine")]
    public double Proteine { get; set; }

    [BsonElement("sale")]
    public double Sale { get; set; }
}