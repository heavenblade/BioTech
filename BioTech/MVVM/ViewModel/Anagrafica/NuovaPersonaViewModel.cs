using System.Windows.Input;
using BioTech.MVVM.Commands;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel.Anagrafica;

public class NuovaPersonaViewModel : BaseViewModel
{
    public ICommand NavigateAnagraficaCommand { get; }

    public NuovaPersonaViewModel(NavigationStore navigationStore)
    {
        NavigateAnagraficaCommand = new NavigateCommand<AnagraficaViewModel>(navigationStore, () => new(navigationStore));
    }
}