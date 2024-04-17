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

    public static bool InsertOne()
    {


        return true;
    }

}