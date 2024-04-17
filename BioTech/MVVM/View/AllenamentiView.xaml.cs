using System.Windows;
using System.Windows.Controls;
using BioTech.Core;
using BioTech.MVVM.ViewModel;

namespace BioTech.MVVM.View
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
            var categoria = CategoriaFilterStackRadio.Children.OfType<RadioButton>()
               .First(r => r.IsChecked.HasValue && r.IsChecked.Value).Content.ToString();

            if (categoria == null) 
                return;
            
            ListaAllenamenti.ItemsSource = MongoDbClient.GetAllenamentiPerCategoria(categoria).Select(x => x.Nome).ToList();
        }

        private void ButtonNuovo_Click(object sender, RoutedEventArgs e)
        {
            AllenamentiViewModel
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
