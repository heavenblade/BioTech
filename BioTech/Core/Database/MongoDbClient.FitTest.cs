using BioTech.MVVM.Model;
using MongoDB.Driver;

namespace BioTech.Core.Database;

public static partial class MongoDbClient
{
    public static List<FitTest> GetFitTest()
    {
        return _fitTestColl.Find(FilterDefinition<FitTest>.Empty).ToList();
    }

    public static List<FitTest> GetFitTestWithFilter(string ricerca)
    {
        FilterDefinition<FitTest>? filter = Builders<FitTest>.Filter.Or(
            Builders<FitTest>.Filter.Where(x => x.Nome.ToLower().Contains(ricerca)),
            Builders<FitTest>.Filter.Where(x => x.Cognome.ToLower().Contains(ricerca)));

        return _fitTestColl.Find(filter).ToList();
    }

    public static List<FitTest> GetAllFitTestOfPerson(string refId)
    {
        FilterDefinition<FitTest>? filter = Builders<FitTest>.Filter.Eq(x => x.RefId, refId);

        return _fitTestColl.Find(filter).ToList();
    }

    public static FitTest FindFitTest(string nome, string cognome, DateTime data)
    {
        FilterDefinition<FitTest> filter = Builders<FitTest>.Filter.Eq(x => x.Nome, nome);
        filter &= Builders<FitTest>.Filter.Eq(x => x.Cognome, cognome);
        filter &= Builders<FitTest>.Filter.Eq(x => x.Data, data);

        FitTest? result = _fitTestColl.Find(filter).First();

        return result;
    }

    public static void InsertFitTest(FitTest fitTest)
    {
        _fitTestColl.InsertOne(fitTest);
    }

    public static void UpdateFitTest(FitTest fitTest)
    {
        FilterDefinition<FitTest> filter = Builders<FitTest>.Filter.Eq(x => x.Nome, fitTest.Nome);
        filter &= Builders<FitTest>.Filter.Eq(x => x.Cognome, fitTest.Cognome);
        filter &= Builders<FitTest>.Filter.Eq(x => x.Data, fitTest.Data);

        UpdateDefinition<FitTest> update = Builders<FitTest>.Update.Set(x => x.Pliche, fitTest.Pliche)
           .Set(x => x.Circonferenze, fitTest.Circonferenze);

        var res = _fitTestColl.UpdateOne(filter, update);
    }
}