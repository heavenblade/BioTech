namespace BioTech.MVVM.Model.Stores;

public static class FitTestStore
{
    private static FitTest? _currentFitTest;

    public static FitTest? CurrentFitTest
    {
        get => _currentFitTest;
        set => _currentFitTest = value;
    }
}