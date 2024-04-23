using System.Windows.Input;
using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel.Diete;

public class GuardaDietaViewModel : BaseViewModel
{
    public ICommand NavigateDieteCommand { get; }

    public GuardaDietaViewModel(NavigationStore navigationStore)
    {
        NavigateDieteCommand = new NavigateCommand<DieteViewModel>(navigationStore, () => new(navigationStore));
    }
}