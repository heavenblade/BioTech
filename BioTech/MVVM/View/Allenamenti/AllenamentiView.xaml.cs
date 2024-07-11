using System.Windows;
using System.Windows.Controls;
using BioTech.Core;
using BioTech.MVVM.Model.Stores;

namespace BioTech.MVVM.View.Allenamenti;

/// <summary>
///     Interaction logic for AllenamentiView.xaml
/// </summary>
public partial class AllenamentiView : UserControl
{
    public AllenamentiView() => InitializeComponent();

    private void Button_Click(object sender, RoutedEventArgs e) { }

    private void BuildListaAllenamenti(object sender, RoutedEventArgs e)
    {
        var categoria = CategoriaFilter.Children.OfType<RadioButton>()
           .First(r => r.IsChecked.HasValue && r.IsChecked.Value).Content.ToString();

        if (categoria == null)
            return;

        LoadListaAllenamenti(categoria);
    }

    private void LoadListaAllenamenti(string categoria) => 
        ListaAllenamenti.ItemsSource = MongoDbClient.GetAllenamentiPerCategoria(categoria).Select(x => x.Nome).ToList();

    private void LoadListaAllenamentiWithFilter(string categoria, string ricerca) =>
        ListaAllenamenti.ItemsSource = MongoDbClient.GetAllenamentiPerCategoriaWithFilter(categoria, ricerca).Select(x => x.Nome).ToList();

    private void OnSelectedAllenamento(object sender, RoutedEventArgs e)
    {
        ButtonGuarda.IsEnabled = true;
        ButtonModifica.IsEnabled = true;
    }

    private void LoadTabella_OnClick(object sender, RoutedEventArgs e)
    {
        var nome = (string)ListaAllenamenti.SelectedItem;

        var categoria = CategoriaFilter.Children.OfType<RadioButton>()
           .FirstOrDefault(r => r.IsChecked.HasValue && (bool)r.IsChecked)!.Content.ToString();

        AllenamentoStore.CurrentAllenamento = MongoDbClient.FindAllenamento(nome, categoria);
    }

    private void ButtonReset_OnClick(object sender, RoutedEventArgs e)
    {
        var categoria = CategoriaFilter.Children.OfType<RadioButton>()
           .FirstOrDefault(r => r.IsChecked.HasValue && (bool)r.IsChecked)!.Content.ToString();

        Ricerca.Text = "";
        
        LoadListaAllenamenti(categoria);
    }

    private void Ricerca_TextChanged(object sender, TextChangedEventArgs e)
    {
        var categoria = CategoriaFilter.Children.OfType<RadioButton>()
           .FirstOrDefault(r => r.IsChecked.HasValue && (bool)r.IsChecked)!.Content.ToString();

        string ricerca = Ricerca.Text;

        if (ricerca.Length == 0)
        {
            LoadListaAllenamenti(categoria);

            return;
        }

        LoadListaAllenamentiWithFilter(categoria, ricerca.ToLower());
    }
}