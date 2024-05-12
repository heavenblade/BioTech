using MongoDB.Bson.Serialization.Attributes;

namespace BioTech.MVVM.Model;

[BsonIgnoreExtraElements]
public class Persona
{
    [BsonElement("nome")]
    public string Nome { get; set; }

    [BsonElement("cognome")]
    public string Cognome { get; set; }
    
    [BsonElement("altezza")]
    public double Altezza { get; set; }
    
    [BsonElement("peso")]
    public double Peso { get; set; }

    [BsonElement("sesso")]
    public string? Sesso { get; set; }
    
    [BsonElement("dataNascita")]
    public string DataNascita { get; set; }
    
    [BsonElement("indirizzo")]
    public string Indirizzo { get; set; }

    [BsonElement("città")]
    public string Città { get; set; }

    [BsonElement("professione")]
    public string Professione { get; set; }

    [BsonElement("sport")]
    public string Sport { get; set; }

    [BsonElement("telefono")]
    public string Telefono { get; set; }
}