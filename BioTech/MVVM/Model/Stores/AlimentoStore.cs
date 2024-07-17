namespace BioTech.MVVM.Model.Stores;

public static class AlimentoStore
{
    private static Alimento? _currentAlimento;

    public static Alimento? CurrentAlimento
    {
        get => _currentAlimento;
        set => _currentAlimento = value;
    }
}