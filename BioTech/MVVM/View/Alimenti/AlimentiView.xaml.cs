using System.Windows;
using System.Windows.Controls;
using BioTech.Core.Database;
using BioTech.MVVM.Model;
using BioTech.MVVM.Model.Stores;

namespace BioTech.MVVM.View.Alimenti;

/// <summary>
///     Interaction logic for AlimentiView.xaml
/// </summary>
public partial class AlimentiView : UserControl
{
    public AlimentiView()
    {
        InitializeComponent();

        BuildListaAlimenti(Ricerca.Text);
    }

    private void BuildListaAlimenti(string ricerca) =>
        ListaAlimenti.ItemsSource = ricerca.Equals("") ? MongoDbClient.GetAlimenti() : MongoDbClient.GetAlimentiWithFilter(ricerca);

    private void OnSelectedAlimento(object sender, RoutedEventArgs e)
    {
        ButtonGuarda.IsEnabled = true;
    }

    private void NuovoAlimento_Click(object sender, RoutedEventArgs e)
    {

    }

    private void LoadAlimento(object sender, RoutedEventArgs e)
    {
        var selectedAlimento = ListaAlimenti.SelectedItem as Alimento;

        string nome = selectedAlimento!.Nome;
        string tipologia = selectedAlimento.Tipologia;

        AlimentoStore.CurrentAlimento = MongoDbClient.FindAlimento(nome, tipologia);
    }

    private void Ricerca_TextChanged(object sender, TextChangedEventArgs e) =>
        BuildListaAlimenti(Ricerca.Text);

    private void ButtonReset_Click(object sender, RoutedEventArgs e)
    {
        Ricerca.Text = "";
        BuildListaAlimenti(Ricerca.Text);
    }
}