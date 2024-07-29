using System.Windows.Input;
using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel.Alimenti;

public class GuardaAlimentoViewModel : BaseViewModel
{
    public ICommand NavigateAlimentiCommand { get; }

    public GuardaAlimentoViewModel(NavigationStore navigationStore)
    {
        NavigateAlimentiCommand = new NavigateCommand<AlimentiViewModel>(navigationStore, () => new(navigationStore));
    }
}