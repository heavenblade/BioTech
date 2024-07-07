using System.Windows;
using System.Windows.Input;
using BioTech.Core;
using BioTech.MVVM.Model.Stores;
using BioTech.MVVM.ViewModel;
using BioTech.MVVM.ViewModel.Navigation;

namespace BioTech;

/// <summary>
///     Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        var navigationStore = new NavigationStore();

        navigationStore.CurrentView = new HomeViewModel(navigationStore);

        DataContext = new HomeViewModel(navigationStore);

        InitializeComponent();

        MongoDbClient.Initialize();
    }

    private void BorderMouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.LeftButton == MouseButtonState.Pressed) 
            DragMove();
    }

    private void ButtonMinimizeClick(object sender, RoutedEventArgs e) => 
        Application.Current.MainWindow.WindowState = WindowState.Minimized;

    private void ButtonResizeClick(object sender, RoutedEventArgs e) => 
        Application.Current.MainWindow.WindowState = Application.Current.MainWindow.WindowState != WindowState.Maximized ? WindowState.Maximized : WindowState.Normal;

    private void ButtonCloseClick(object sender, RoutedEventArgs e) => 
        Application.Current.Shutdown();

    private void ChangeTab_Click(object sender, RoutedEventArgs e)
    {
        PersonaStore.CurrentPersona = null;
        FitTestStore.CurrentFitTest = null;
        AllenamentoStore.CurrentAllenamento = null;
        DietaStore.CurrentDieta = null;
    }

    private void RadioButton_Checked(object sender, RoutedEventArgs e)
    {

    }

}