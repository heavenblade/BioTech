﻿using BioTech.MVVM.Commands;
using System.Windows.Input;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech.MVVM.ViewModel.Anagrafica;

public class AnagraficaViewModel : BaseViewModel
{
    public ICommand NavigateNuovaPersonaCommand { get; }
    public ICommand NavigateEditPersonaCommand { get; }

    public AnagraficaViewModel(NavigationStore navigationStore)
    {
        NavigateNuovaPersonaCommand = new NavigateCommand<NuovaPersonaViewModel>(navigationStore, () => new(navigationStore));
        NavigateEditPersonaCommand = new NavigateCommand<EditPersonaViewModel>(navigationStore, () => new(navigationStore));
    }

}