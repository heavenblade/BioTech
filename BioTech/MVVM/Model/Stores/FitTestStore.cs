namespace BioTech.MVVM.Model.Stores;

public static class FitTestStore
{
    private static FitTest? _currentFitTest;
    private static bool _saved;

    public static FitTest? CurrentFitTest
    {
        get => _currentFitTest;
        set => _currentFitTest = value;
    }

    public static bool Saved
    {
        get => _saved;
        set => _saved = value;
    }
}