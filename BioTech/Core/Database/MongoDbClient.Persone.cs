using BioTech.MVVM.Model;
using MongoDB.Driver;

namespace BioTech.Core.Database;

public static partial class MongoDbClient
{
    public static List<Persona> GetPersone()
    {
        return _personeColl.Find(FilterDefinition<Persona>.Empty).ToList();
    }

    public static Persona GetPersona(string refId)
    {
        FilterDefinition<Persona> filter = Builders<Persona>.Filter.Eq(x => x.RefId, refId);

        Persona result = _personeColl.Find(filter).First();

        return result;
    }

    public static Persona? FindPersona(string nome, string cognome, string città, string telefono)
    {
        FilterDefinition<Persona> filter = Builders<Persona>.Filter.Eq(x => x.Nome, nome);
        filter &= Builders<Persona>.Filter.Eq(x => x.Cognome, cognome);
        filter &= Builders<Persona>.Filter.Eq(x => x.Città, città);
        filter &= Builders<Persona>.Filter.Eq(x => x.Telefono, telefono);

        Persona? result = _personeColl.Find(filter).FirstOrDefault();

        return result;
    }

    public static List<Persona> GetPersoneWithFilter(string ricerca)
    {
        FilterDefinition<Persona>? filter = Builders<Persona>.Filter.Or(
            Builders<Persona>.Filter.Where(x => x.Nome.ToLower().Contains(ricerca)),
            Builders<Persona>.Filter.Where(x => x.Cognome.ToLower().Contains(ricerca)),
            Builders<Persona>.Filter.Where(x => x.Città.ToLower().Contains(ricerca)));

        return _personeColl.Find(filter).ToList();
    }

    public static bool CheckIfPersonaIsPresente(Persona persona)
    {
        FilterDefinition<Persona> filter = Builders<Persona>.Filter.Eq(x => x.Nome, persona.Nome);
        filter &= Builders<Persona>.Filter.Eq(x => x.Cognome, persona.Cognome);
        filter &= Builders<Persona>.Filter.Eq(x => x.DataNascita, persona.DataNascita);
        filter &= Builders<Persona>.Filter.Eq(x => x.Città, persona.Città);
        filter &= Builders<Persona>.Filter.Eq(x => x.Telefono, persona.Telefono);

        List<Persona>? result = _personeColl.Find(filter).ToList();

        return result.Count > 0;
    }

    public static void InsertNuovaPersona(Persona persona)
    {
        _personeColl.InsertOne(persona);
    }

    public static void UpdatePersona(Persona persona)
    {
        FilterDefinition<Persona> filter = Builders<Persona>.Filter.Eq(x => x.Nome, persona.Nome);
        filter &= Builders<Persona>.Filter.Eq(x => x.Cognome, persona.Cognome);
        filter &= Builders<Persona>.Filter.Eq(x => x.DataNascita, persona.DataNascita);
        filter &= Builders<Persona>.Filter.Eq(x => x.Città, persona.Città);
        filter &= Builders<Persona>.Filter.Eq(x => x.Telefono, persona.Telefono);

        UpdateDefinition<Persona> update = Builders<Persona>.Update.Set(x => x.Altezza, persona.Altezza)
           .Set(x => x.Peso, persona.Peso)
           .Set(x => x.Sesso, persona.Sesso)
           .Set(x => x.Indirizzo, persona.Indirizzo)
           .Set(x => x.Professione, persona.Professione)
           .Set(x => x.Sport, persona.Sport);

        _personeColl.UpdateOne(filter, update);
    }

    public static void DeletePersona(Persona persona)
    {
        FilterDefinition<Persona> filter = Builders<Persona>.Filter.Eq(x => x.Nome, persona.Nome);
        filter &= Builders<Persona>.Filter.Eq(x => x.Cognome, persona.Cognome);
        filter &= Builders<Persona>.Filter.Eq(x => x.DataNascita, persona.DataNascita);
        filter &= Builders<Persona>.Filter.Eq(x => x.Città, persona.Città);
        filter &= Builders<Persona>.Filter.Eq(x => x.Telefono, persona.Telefono);

        _personeColl.DeleteOne(filter);
    }
}