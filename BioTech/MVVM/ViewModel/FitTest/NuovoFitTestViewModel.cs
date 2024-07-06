using System.Windows.Input;
using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel.FitTest;

public class NuovoFitTestViewModel : BaseViewModel
{
    public ICommand NavigateFitTestCommand { get; }

    public NuovoFitTestViewModel(NavigationStore navigationStore)
    {
        NavigateFitTestCommand = new NavigateCommand<FitTestViewModel>(navigationStore, () => new(navigationStore));
    }
}