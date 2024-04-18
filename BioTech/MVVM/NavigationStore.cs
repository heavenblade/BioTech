namespace BioTech.MVVM;

public class NavigationStore
{
    public event Action CurrentViewModelChanged; 

    private object _currentView;

    public object CurrentView
    {
        get => _currentView;
        set {
            _currentView = value;
            OnCurrentViewModelChanged();
        }
    }

    private void OnCurrentViewModelChanged()
    {
        CurrentViewModelChanged?.Invoke();
    }
}