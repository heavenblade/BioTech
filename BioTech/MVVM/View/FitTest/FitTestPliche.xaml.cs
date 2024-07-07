using BioTech.MVVM.Model.Stores;
using System.Windows;
using System.Windows.Controls;

namespace BioTech.MVVM.View.FitTest;

/// <summary>
///     Interaction logic for GuardaAllenamentoView.xaml
/// </summary>
public partial class FitTestPliche : UserControl
{
    public FitTestPliche()
    {
        InitializeComponent();
    }

    private void CleanAndExit_Click(object sender, RoutedEventArgs e)
    {
        FitTestStore.CurrentFitTest = null;
        PersonaStore.CurrentPersona = null;
    }

    private void Avanti_Click(object sender, RoutedEventArgs e)
    {
        
    }
}