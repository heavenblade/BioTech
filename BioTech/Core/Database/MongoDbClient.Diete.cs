using BioTech.MVVM.Model;
using MongoDB.Driver;

namespace BioTech.Core.Database;

public static partial class MongoDbClient
{
    public static List<Dieta> GetDietePerCategoria(string categoria)
    {
        FilterDefinition<Dieta> filter = Builders<Dieta>.Filter.Eq(x => x.Categoria, categoria);

        return _dieteColl.Find(filter).ToList();
    }

    public static List<Dieta> GetDietePerCategoriaWithFilter(string categoria, string ricerca)
    {
        FilterDefinition<Dieta> filter = Builders<Dieta>.Filter.And(
            Builders<Dieta>.Filter.Eq(x => x.Categoria, categoria),
            Builders<Dieta>.Filter.Where(x => x.Nome.ToLower().Contains(ricerca)));

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

    public static void UpdateDieta(Dieta dieta)
    {
        FilterDefinition<Dieta> filter = Builders<Dieta>.Filter.Eq(x => x.Nome, dieta.Nome);
        filter &= Builders<Dieta>.Filter.Eq(x => x.Categoria, dieta.Categoria);

        UpdateDefinition<Dieta> update = Builders<Dieta>.Update.Set(x => x.Programma, dieta.Programma);

        _dieteColl.UpdateOne(filter, update);
    }

    public static void DeleteDieta(Dieta dieta)
    {
        FilterDefinition<Dieta> filter = Builders<Dieta>.Filter.Eq(x => x.Nome, dieta.Nome);
        filter &= Builders<Dieta>.Filter.Eq(x => x.Categoria, dieta.Categoria);

        _dieteColl.DeleteOne(filter);
    }
}