using System.Windows.Input;
using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel.Allenamenti;

public class NuovoAllenamentoViewModel : BaseViewModel
{
    public ICommand NavigateAllenamentiCommand { get; }

    public NuovoAllenamentoViewModel(NavigationStore navigationStore)
    {
        NavigateAllenamentiCommand = new NavigateCommand<AllenamentiViewModel>(navigationStore, () => new(navigationStore));
    }
}