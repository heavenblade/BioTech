using BioTech.MVVM.Model.Stores;
using System.Windows;
using System.Windows.Controls;
using BioTech.Core.Database;

namespace BioTech.MVVM.View.Diete;

/// <summary>
///     Interaction logic for DieteView.xaml
/// </summary>
public partial class DieteView : UserControl
{
    public DieteView() => InitializeComponent();

    private void Button_Click(object sender, RoutedEventArgs e) { }

    private void BuildListaDiete(object sender, RoutedEventArgs e)
    {
        var categoria = CategoriaFilter.Children.OfType<RadioButton>()
           .First(r => r.IsChecked.HasValue && r.IsChecked.Value).Content.ToString();

        if (categoria == null)
            return;

        LoadListaDiete(categoria);
    }

    private void LoadListaDiete(string categoria) =>
        ListaDiete.ItemsSource = MongoDbClient.GetDietePerCategoria(categoria).Select(x => x.Nome).ToList();

    private void LoadListaDieteWithFilter(string categoria, string ricerca) =>
        ListaDiete.ItemsSource = MongoDbClient.GetDietePerCategoriaWithFilter(categoria, ricerca).Select(x => x.Nome).ToList();

    private void OnSelectedDieta(object sender, RoutedEventArgs e)
    {
        ButtonCopia.IsEnabled = true;
        ButtonGuarda.IsEnabled = true;
        ButtonModifica.IsEnabled = true;
    }

    private void LoadDieta(object sender, RoutedEventArgs e)
    {
        var nome = (string)ListaDiete.SelectedItems[0]!;
        var categoria = CategoriaFilter.Children.OfType<RadioButton>()
           .FirstOrDefault(r => r.IsChecked.HasValue && (bool)r.IsChecked)!.Content.ToString();

        DietaStore.CurrentDieta = MongoDbClient.FindDieta(nome, categoria);
    }

    private void ButtonReset_Click(object sender, RoutedEventArgs e)
    {
        var categoria = CategoriaFilter.Children.OfType<RadioButton>()
           .FirstOrDefault(r => r.IsChecked.HasValue && (bool)r.IsChecked)!.Content.ToString();

        Ricerca.Text = "";

        LoadListaDiete(categoria);
    }

    private void Ricerca_TextChanged(object sender, TextChangedEventArgs e)
    {
        var categoria = CategoriaFilter.Children.OfType<RadioButton>()
           .FirstOrDefault(r => r.IsChecked.HasValue && (bool)r.IsChecked)!.Content.ToString();

        string ricerca = Ricerca.Text;

        if (ricerca.Length == 0)
        {
            LoadListaDiete(categoria);

            return;
        }

        LoadListaDieteWithFilter(categoria, ricerca.ToLower());
    }
}