using BioTech.MVVM.Model;
using MongoDB.Driver;

namespace BioTech.Core;

public static class MongoDbClient
{
    private static MongoClient _client;

    public static void Initialize()
    {
        const string connectionString = "mongodb://localhost:27017/";

        _client = new(connectionString);
    }

    public static List<Allenamento> GetAllenamentiPerCategoria(string categoria)
    {
        IMongoCollection<Allenamento> coll = _client.GetDatabase("biotech").GetCollection<Allenamento>("allenamenti");

        FilterDefinition<Allenamento> filter = Builders<Allenamento>.Filter.Eq(x => x.Categoria, categoria);

        return coll.Find(filter).ToList();
    }

}