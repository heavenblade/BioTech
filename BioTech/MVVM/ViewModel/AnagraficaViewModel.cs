using BioTech.MVVM.Commands;
using System.Windows.Input;

namespace BioTech.MVVM.ViewModel;

class AnagraficaViewModel : BaseViewModel
{
    public ICommand NavigateHomeCommand { get; }

    public AnagraficaViewModel(NavigationStore navigationStore)
    {
        NavigateHomeCommand = new NavigateCommand<HomeViewModel>(navigationStore, () => new(navigationStore));
    }

}