using System.Windows.Input;
using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel.FitTest;

public class FitTestPlicheViewModel : BaseViewModel
{
    public ICommand NavigateFitTestCommand { get; }
    public ICommand NavigateFitTestGeneralitàCommand { get; }
    public ICommand NavigateFitTestCirconferenzeCommand { get; }

    public FitTestPlicheViewModel(NavigationStore navigationStore)
    {
        NavigateFitTestCommand = new NavigateCommand<FitTestViewModel>(navigationStore, () => new(navigationStore));
        NavigateFitTestGeneralitàCommand = new NavigateCommand<FitTestGeneralitàViewModel>(navigationStore, () => new(navigationStore));
        NavigateFitTestCirconferenzeCommand = new NavigateCommand<FitTestCirconferenzeViewModel>(navigationStore, () => new(navigationStore));
    }
}