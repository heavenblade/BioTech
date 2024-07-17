using System.Windows;
using System.Windows.Controls;
using BioTech.Core.Database;
using BioTech.MVVM.Model;

namespace BioTech.MVVM.View.Alimenti;

/// <summary>
///     Interaction logic for GuardaAllenamentoView.xaml
/// </summary>
public partial class NuovoAlimentoView : UserControl
{
    public NuovoAlimentoView() => InitializeComponent();

    private void StampaButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void SalvaButton_Click(object sender, RoutedEventArgs e)
    {
        if (MongoDbClient.CheckIfAlimentoIsPresente(NomeNuovoAlimento.Text))
        {
            MessageBox.Show("È già presente nel database un alimento con questo nome.\nModificarlo e riprovare!");

            return;
        }

        var alimento = new Alimento
        {
            Nome = NomeNuovoAlimento.Text,
            Tipologia = TipologiaNuovoAlimento.Text,
            Kcal = double.Parse(Energia.Text),
            GrassiInsaturi = double.Parse(GrassiInsaturi.Text),
            GrassiSaturi = double.Parse(GrassiSaturi.Text),
            Fibre = double.Parse(Fibre.Text),
            Carboidrati = double.Parse(Carboidrati.Text),
            Zuccheri = double.Parse(Zuccheri.Text),
            Proteine = double.Parse(Proteine.Text),
            Sale = double.Parse(Sale.Text)
        };

        try
        {
            MongoDbClient.InsertAlimento(alimento);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Errore durante l'inserimento del nuovo alimento!");

            return;
        }

        MessageBox.Show("Il nuovo alimento è stata salvato con successo!");
    }
}