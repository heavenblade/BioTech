using System.Windows;
using System.Windows.Controls;
using BioTech.MVVM.Model;
using BioTech.MVVM.Model.Stores;

namespace BioTech.MVVM.View.Allenamenti;

/// <summary>
///     Interaction logic for GuardaAllenamentoView.xaml
/// </summary>
public partial class GuardaAllenamentoView : UserControl
{
    public GuardaAllenamentoView()
    {
        InitializeComponent();

        PrepareContent();
    }

    private void PrepareContent()
    {
        Allenamento allenamento = AllenamentoStore.CurrentAllenamento;

        if (allenamento == null)
            return;

        NomeTabella.Text = allenamento.Nome;
        ContenutoTabella.Text = allenamento.Tabella;
    }

    private void StampaButton_Click(object sender, RoutedEventArgs e)
    {

    }
}