namespace BioTech.MVVM.Model.Stores;

public static class DietaStore
{
    private static Dieta? _currentDieta;

    public static Dieta? CurrentDieta
    {
        get => _currentDieta;
        set => _currentDieta = value;
    }
}