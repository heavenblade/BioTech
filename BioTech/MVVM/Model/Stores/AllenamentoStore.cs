namespace BioTech.MVVM.Model.Stores;

public static class AllenamentoStore
{
    private static Allenamento _currentAllenamento;

    public static Allenamento CurrentAllenamento
    {
        get => _currentAllenamento;
        set
        {
            _currentAllenamento = value;
        }
    }
}