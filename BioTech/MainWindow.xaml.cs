using System.Windows;
using System.Windows.Input;
using BioTech.Core;
using BioTech.MVVM.ViewModel;
using BioTech.MVVM;

namespace BioTech;

/// <summary>
///     Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        NavigationStore navigationStore = new NavigationStore();

        navigationStore.CurrentView = new HomeViewModel(navigationStore);

        DataContext = new HomeViewModel(navigationStore);

        InitializeComponent();

        MongoDbClient.Initialize();
    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
        Application.Current.MainWindow = this;
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

    private void ButtonMinimizeHoverOn(object sender, RoutedEventArgs e) { }

    private void ButtonMinimizeHoverOff(object sender, RoutedEventArgs e) { }

    private void ButtonMaximizeHoverOn(object sender, RoutedEventArgs e) { }

    private void ButtonMaximizeHoverOff(object sender, RoutedEventArgs e) { }

    private void ButtonCloseHoverOn(object sender, RoutedEventArgs e) { }

    private void ButtonCloseHoverOff(object sender, RoutedEventArgs e) { }

    private void RadioButton_Checked(object sender, RoutedEventArgs e)
    {

    }
}