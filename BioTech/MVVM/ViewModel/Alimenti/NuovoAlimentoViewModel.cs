using System.Windows.Input;
using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel.Alimenti;

public class NuovoAlimentoViewModel : BaseViewModel
{
    public ICommand NavigateAlimentiCommand { get; }

    public NuovoAlimentoViewModel(NavigationStore navigationStore)
    {
        NavigateAlimentiCommand = new NavigateCommand<AlimentiViewModel>(navigationStore, () => new(navigationStore));
    }
}