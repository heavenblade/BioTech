using System.Windows.Input;
using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel.FitTest;

public class FitTestPlicheViewModel : BaseViewModel
{
    public ICommand NavigateFitTestGeneralitàCommand { get; }
    //avanti

    public FitTestPlicheViewModel(NavigationStore navigationStore)
    {
        NavigateFitTestGeneralitàCommand = new NavigateCommand<FitTestGeneralitàViewModel>(navigationStore, () => new(navigationStore));
    }
}