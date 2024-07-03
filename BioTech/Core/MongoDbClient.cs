using BioTech.MVVM.Model;
using MongoDB.Driver;

namespace BioTech.Core;

public static partial class MongoDbClient
{
    private static MongoClient _client;

    private static IMongoCollection<Allenamento> _allenamentiColl;
    private static IMongoCollection<Dieta> _dieteColl;
    private static IMongoCollection<Persona> _personeColl;
    private static IMongoCollection<Allenamento> _fitTestColl;

    public static void Initialize()
    {
        const string connectionString = "mongodb://localhost:27017/";

        _client = new(connectionString);

        _allenamentiColl = _client.GetDatabase("biotech").GetCollection<Allenamento>("allenamenti");
        _dieteColl = _client.GetDatabase("biotech").GetCollection<Dieta>("diete");
        _personeColl = _client.GetDatabase("biotech").GetCollection<Persona>("persone");
        _fitTestColl = _client.GetDatabase("biotech").GetCollection<Allenamento>("fittest");
    }

    // Allenamenti
    public static List<Allenamento> GetAllenamentiPerCategoria(string categoria)
    {
        FilterDefinition<Allenamento> filter = Builders<Allenamento>.Filter.Eq(x => x.Categoria, categoria);

        return _allenamentiColl.Find(filter).ToList();
    }

    public static bool CheckIfAllenamentoIsPresentByName(string name)
    {
        FilterDefinition<Allenamento> filter = Builders<Allenamento>.Filter.Eq(x => x.Nome, name);

        List<Allenamento>? result = _allenamentiColl.Find(filter).ToList();

        return result.Count > 0;
    }

    public static Allenamento FindAllenamento(string? name, string? categoria)
    {
        FilterDefinition<Allenamento> filter = Builders<Allenamento>.Filter.Eq(x => x.Nome, name);
        filter &= Builders<Allenamento>.Filter.Eq(x => x.Categoria, categoria);

        return _allenamentiColl.Find(filter).FirstOrDefault();
    }

    public static void InsertNuovoAllenamento(Allenamento allenamento)
    {
        _allenamentiColl.InsertOne(allenamento);
    }

    public static void RenameAllenamento(string oldName, string newName)
    {
        FilterDefinition<Allenamento> filter = Builders<Allenamento>.Filter.Eq(x => x.Nome, oldName);

        UpdateDefinition<Allenamento> update = Builders<Allenamento>.Update.Set(x => x.Nome, newName);

        _allenamentiColl.UpdateOne(filter, update);
    }

    public static void UpdateAllenamento(string nome, string categoria, string tabella)
    {
        FilterDefinition<Allenamento> filter = Builders<Allenamento>.Filter.Eq(x => x.Nome, nome);
        filter &= Builders<Allenamento>.Filter.Eq(x => x.Categoria, categoria);

        UpdateDefinition<Allenamento> update = Builders<Allenamento>.Update.Set(x => x.Tabella, tabella);

        _allenamentiColl.UpdateOne(filter, update);
    }

    // Diete
    public static List<Dieta> GetDietePerCategoria(string categoria)
    {
        FilterDefinition<Dieta> filter = Builders<Dieta>.Filter.Eq(x => x.Categoria, categoria);

        return _dieteColl.Find(filter).ToList();
    }

    public static bool CheckIfDietaIsPresentByName(string name)
    {
        FilterDefinition<Dieta> filter = Builders<Dieta>.Filter.Eq(x => x.Nome, name);

        List<Dieta>? result = _dieteColl.Find(filter).ToList();

        return result.Count > 0;
    }

    public static Dieta FindDieta(string? name, string? categoria)
    {
        FilterDefinition<Dieta> filter = Builders<Dieta>.Filter.Eq(x => x.Nome, name);
        filter &= Builders<Dieta>.Filter.Eq(x => x.Categoria, categoria);

        return _dieteColl.Find(filter).FirstOrDefault();
    }

    public static void InsertNuovaDieta(Dieta dieta)
    {
        _dieteColl.InsertOne(dieta);
    }

    public static void RenameDieta(string oldName, string newName)
    {
        FilterDefinition<Dieta> filter = Builders<Dieta>.Filter.Eq(x => x.Nome, oldName);

        UpdateDefinition<Dieta> update = Builders<Dieta>.Update.Set(x => x.Nome, newName);

        _dieteColl.UpdateOne(filter, update);
    }

    // Persone
    public static List<Persona> GetPersone()
    {
        return _personeColl.Find(FilterDefinition<Persona>.Empty).ToList();
    }

    public static Persona FindPersona(string nome, string cognome, string città, string telefono)
    {
        FilterDefinition<Persona> filter = Builders<Persona>.Filter.Eq(x => x.Nome, nome);
        filter &= Builders<Persona>.Filter.Eq(x => x.Cognome, cognome);
        filter &= Builders<Persona>.Filter.Eq(x => x.Città, città);
        filter &= Builders<Persona>.Filter.Eq(x => x.Telefono, telefono);

        Persona? result = _personeColl.Find(filter).First();

        return result;
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

    public static void ModifyPersona(Persona persona)
    {

    }
}