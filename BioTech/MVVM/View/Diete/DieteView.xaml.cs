using BioTech.Core;
using BioTech.MVVM.Model.Stores;
using System.Windows;
using System.Windows.Controls;

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
        ButtonGuarda.IsEnabled = true;
    }

    private void GuardaDieta_OnClick(object sender, RoutedEventArgs e)
    {
        var nome = (string)ListaDiete.SelectedItems[0]!;
        var categoria = CategoriaFilter.Children.OfType<RadioButton>()
           .FirstOrDefault(r => r.IsChecked.HasValue && (bool)r.IsChecked)!.Content.ToString();

        DietaStore.CurrentDieta = MongoDbClient.FindDieta(nome, categoria);

    }

    private void RinominaDieta_OnClick(object sender, RoutedEventArgs e)
    {
        if (ListaDiete.SelectedItems.Count == 0)
        {
            MessageBox.Show("Selezionare prima una dieta dalla lista!");

            return;
        }

        var oldName = (string)ListaDiete.SelectedItems[0]!;

        string newName = Microsoft.VisualBasic.Interaction.InputBox("Inserire il nuovo nome per la dieta selezionata:",
            "Rinomina", "");

        MongoDbClient.RenameDieta(oldName, newName);

        var categoria = CategoriaFilter.Children.OfType<RadioButton>()
           .First(r => r.IsChecked.HasValue && r.IsChecked.Value).Content.ToString();

        if (categoria == null)
            return;

        LoadListaDiete(categoria);
    }

    private void ButtonReset_OnClick(object sender, RoutedEventArgs e)
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