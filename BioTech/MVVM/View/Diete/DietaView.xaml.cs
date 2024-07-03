using System.Windows;
using System.Windows.Controls;
using BioTech.Core;
using BioTech.MVVM.Model;

namespace BioTech.MVVM.View.Diete;

/// <summary>
///     Interaction logic for GuardaAllenamentoView.xaml
/// </summary>
public partial class DietaView : UserControl
{
    public DietaView() => InitializeComponent();

    private void StampaButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void SalvaButton_Click(object sender, RoutedEventArgs e)
    {
        if (MongoDbClient.CheckIfDietaIsPresentByName(NomeNuovaDieta.Text))
        {
            MessageBox.Show("È già presente nel database una dieta con questo nome.\nModificarlo e riprovare!");

            return;
        }

        var nuovaDieta = new Dieta
        {
            Nome = NomeNuovaDieta.Text,
            Categoria = CategoriaNuovaDieta.Text,
            Programma = ProgrammaNuovaDieta.Text
        };

        try
        {
            MongoDbClient.InsertNuovaDieta(nuovaDieta);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Errore durante l'inserimento della nuova dieta!");

            return;
        }

        MessageBox.Show("La nuova dieta è stata salvata con successo!");
    }
}