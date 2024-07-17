using BioTech.MVVM.Model;
using MongoDB.Driver;

namespace BioTech.Core.Database;

public static partial class MongoDbClient
{
    public static List<Allenamento> GetAllenamentiPerCategoria(string categoria)
    {
        FilterDefinition<Allenamento> filter = Builders<Allenamento>.Filter.Eq(x => x.Categoria, categoria);

        return _allenamentiColl.Find(filter).ToList();
    }

    public static List<Allenamento> GetAllenamentiPerCategoriaWithFilter(string categoria, string ricerca)
    {
        FilterDefinition<Allenamento> filter = Builders<Allenamento>.Filter.And(
            Builders<Allenamento>.Filter.Eq(x => x.Categoria, categoria),
            Builders<Allenamento>.Filter.Where(x => x.Nome.ToLower().Contains(ricerca)));

        return _allenamentiColl.Find(filter).ToList();
    }

    public static bool CheckIfAllenamentoIsPresente(string name, string categoria)
    {
        FilterDefinition<Allenamento> filter = Builders<Allenamento>.Filter.Eq(x => x.Nome, name);
        filter &= Builders<Allenamento>.Filter.Eq(x => x.Categoria, categoria);

        List<Allenamento>? result = _allenamentiColl.Find(filter).ToList();

        return result.Any();
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

    public static void UpdateAllenamento(Allenamento allenamento)
    {
        FilterDefinition<Allenamento> filter = Builders<Allenamento>.Filter.Eq(x => x.Nome, allenamento.Nome);
        filter &= Builders<Allenamento>.Filter.Eq(x => x.Categoria, allenamento.Nome);

        UpdateDefinition<Allenamento> update = Builders<Allenamento>.Update.Set(x => x.Tabella, allenamento.Tabella);

        _allenamentiColl.UpdateOne(filter, update);
    }

    public static void DeleteAllenamento(Allenamento allenamento)
    {
        FilterDefinition<Allenamento> filter = Builders<Allenamento>.Filter.Eq(x => x.Nome, allenamento.Nome);
        filter &= Builders<Allenamento>.Filter.Eq(x => x.Categoria, allenamento.Nome);

        _allenamentiColl.DeleteOne(filter);
    }
}