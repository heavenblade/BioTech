using System.Windows.Input;
using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel.Allenamenti;

class AllenamentiViewModel : BaseViewModel
{
    public ICommand NavigateNuovoAllenamentoCommand { get; }
    public ICommand NavigateGuardaAllenamentoCommand { get; }

    public AllenamentiViewModel(NavigationStore navigationStore)
    {
        NavigateNuovoAllenamentoCommand = new NavigateCommand<NuovoAllenamentoViewModel>(navigationStore, () => new(navigationStore));
        NavigateGuardaAllenamentoCommand = new NavigateCommand<GuardaAllenamentoViewModel>(navigationStore, () => new(navigationStore));
    }

}