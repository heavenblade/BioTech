using System.Windows;
using System.Windows.Controls;
using BioTech.MVVM.Model;
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
        Dieta dieta = DietaStore.CurrentDieta;

        if (dieta == null)
            return;

        NomeDieta.Text = dieta.Nome;
        ContenutoDieta.Text = dieta.Programma;
    }

    private void StampaButton_Click(object sender, RoutedEventArgs e)
    {

    }
}