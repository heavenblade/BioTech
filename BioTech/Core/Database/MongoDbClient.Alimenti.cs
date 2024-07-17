using BioTech.MVVM.Model;
using MongoDB.Driver;

namespace BioTech.Core.Database;

public static partial class MongoDbClient
{
    public static List<Alimento> GetAlimenti()
    {
        return _alimentiColl.Find(FilterDefinition<Alimento>.Empty).ToList();
    }

    public static List<Alimento> GetAlimentiWithFilter(string ricerca)
    {
        FilterDefinition<Alimento> filter = Builders<Alimento>.Filter.Or(
            Builders<Alimento>.Filter.Where(x => x.Nome.ToLower().Contains(ricerca)),
            Builders<Alimento>.Filter.Where(x => x.Tipologia.ToLower().Contains(ricerca)));

        return _alimentiColl.Find(filter).ToList();
    }

    public static bool CheckIfAlimentoIsPresente(string nome)
    {
        FilterDefinition<Alimento> filter = Builders<Alimento>.Filter.Eq(x => x.Nome, nome);

        List<Alimento>? result = _alimentiColl.Find(filter).ToList();

        return result.Any();
    }

    public static void InsertAlimento(Alimento alimento)
    {
        _alimentiColl.InsertOne(alimento);
    }

    public static Alimento? FindAlimento(string nome, string tipologia)
    {
        FilterDefinition<Alimento> filter = Builders<Alimento>.Filter.Eq(x => x.Nome, nome);
        filter &= Builders<Alimento>.Filter.Eq(x => x.Tipologia, tipologia);

        return _alimentiColl.Find(filter).FirstOrDefault();
    }
}