using System.Windows;
using System.Windows.Controls;
using BioTech.Core.Database;
using BioTech.MVVM.Model;

namespace BioTech.MVVM.View.Allenamenti;

/// <summary>
///     Interaction logic for GuardaAllenamentoView.xaml
/// </summary>
public partial class NuovoAllenamentoView : UserControl
{
    public NuovoAllenamentoView() => InitializeComponent();

    private void StampaButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void SalvaButton_Click(object sender, RoutedEventArgs e)
    {
        if (MongoDbClient.CheckIfAllenamentoIsPresentByName(NomeNuovaTabella.Text))
        {
            MessageBox.Show("È già presente nel database una tabella con questo nome.\nModificarlo e riprovare!");

            return;
        }

        var nuovoAllenamento = new Allenamento
        {
            Nome = NomeNuovaTabella.Text,
            Categoria = CategoriaNuovoAllenamento.Text,
            Tabella = TabellaNuovoAllenamento.Text
        };

        try
        {
            MongoDbClient.InsertNuovoAllenamento(nuovoAllenamento);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Errore durante l'inserimento della nuova tabella!");

            return;
        }

        MessageBox.Show("La nuova tabella è stata salvata con successo!");

        return;
    }
}