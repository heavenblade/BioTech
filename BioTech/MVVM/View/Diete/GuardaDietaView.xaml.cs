using System.Windows;
using System.Windows.Controls;
using BioTech.MVVM.Model.Stores;

namespace BioTech.MVVM.View.Diete;

/// <summary>
///     Interaction logic for GuardaAllenamentoView.xaml
/// </summary>
public partial class GuardaDietaView : UserControl
{
    public GuardaDietaView() 
    {
        InitializeComponent();

        PrepareContent();
    }

    private void PrepareContent()
    {
        NomeDieta.Text = DietaStore.CurrentDieta!.Nome;
        CategoriaDieta.Text = DietaStore.CurrentDieta.Categoria;
        ProgrammaDieta.Text = DietaStore.CurrentDieta.Programma;
    }

    private void CleanAndExit_Click(object sender, RoutedEventArgs e)
    {
        DietaStore.CurrentDieta = null;
    }

    private void StampaButton_Click(object sender, RoutedEventArgs e)
    {

    }
}