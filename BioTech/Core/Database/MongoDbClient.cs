using BioTech.MVVM.Model;
using MongoDB.Driver;

namespace BioTech.Core.Database;

public static partial class MongoDbClient
{
    private static MongoClient _client;
    
    private static IMongoCollection<Allenamento> _allenamentiColl;
    private static IMongoCollection<Dieta> _dieteColl;
    private static IMongoCollection<Persona> _personeColl;
    private static IMongoCollection<FitTest> _fitTestColl;
    private static IMongoCollection<Alimento> _alimentiColl;

    public static void Initialize()
    {
        const string connectionString = "mongodb://localhost:27017/";

        _client = new(connectionString);

        _allenamentiColl = _client.GetDatabase("biotech").GetCollection<Allenamento>("allenamenti");
        _dieteColl = _client.GetDatabase("biotech").GetCollection<Dieta>("diete");
        _personeColl = _client.GetDatabase("biotech").GetCollection<Persona>("persone");
        _fitTestColl = _client.GetDatabase("biotech").GetCollection<FitTest>("fittest");
        _alimentiColl = _client.GetDatabase("biotech").GetCollection<Alimento>("alimenti");
    }
}