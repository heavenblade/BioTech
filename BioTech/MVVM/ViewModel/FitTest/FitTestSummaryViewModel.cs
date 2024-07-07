using System.Windows.Input;
using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel.FitTest;

public class FitTestSummaryViewModel : BaseViewModel
{
    public ICommand NavigateFitTestCirconferenzeCommand { get; }
    public ICommand NavigateFitTestCommand { get; }

    public FitTestSummaryViewModel(NavigationStore navigationStore)
    {
        NavigateFitTestCirconferenzeCommand = new NavigateCommand<FitTestCirconferenzeViewModel>(navigationStore, () => new(navigationStore));
        NavigateFitTestCommand = new NavigateCommand<FitTestViewModel>(navigationStore, () => new(navigationStore));
    }
}