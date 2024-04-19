using System.Windows;
using System.Windows.Controls;
using BioTech.Core;
using BioTech.MVVM.Model.Stores;

namespace BioTech.MVVM.View.Allenamenti
{
    /// <summary>
    /// Interaction logic for AllenamentiView.xaml
    /// </summary>
    public partial class AllenamentiView : UserControl
    {


        public AllenamentiView()
        {
            InitializeComponent();
        }

        private void BuildListaAllenamenti(object sender, RoutedEventArgs e)
        {
            var categoria = CategoriaFilter.Children.OfType<RadioButton>()
               .First(r => r.IsChecked.HasValue && r.IsChecked.Value).Content.ToString();

            if (categoria == null) 
                return;
            
            ListaAllenamenti.ItemsSource = MongoDbClient.GetAllenamentiPerCategoria(categoria).Select(x => x.Nome).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void GuardaTabella_OnClick(object sender, RoutedEventArgs e)
        {
            if (ListaAllenamenti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selezionare prima una tabella dalla lista!");

                return;
            }

            var nome = (string)ListaAllenamenti.SelectedItems[0]!;
            var categoria = CategoriaFilter.Children.OfType<RadioButton>()
               .FirstOrDefault(r => r.IsChecked.HasValue && (bool)r.IsChecked)!.Content.ToString();

            AllenamentoStore.CurrentAllenamento = MongoDbClient.FindAllenamento(nome, categoria);
        }
    }
}
