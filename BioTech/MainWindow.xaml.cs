using System.Windows;
using System.Windows.Input;
using BioTech.Core;

namespace BioTech;

/// <summary>
///     Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        MongoDbClient.Initialize();

        InitializeComponent();
    }

    private void BorderMouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.LeftButton == MouseButtonState.Pressed) DragMove();
    }

    private void ButtonMinimizeClick(object sender, RoutedEventArgs e) => Application.Current.MainWindow.WindowState = WindowState.Minimized;

    private void ButtonResizeClick(object sender, RoutedEventArgs e) => Application.Current.MainWindow.WindowState = Application.Current.MainWindow.WindowState != WindowState.Maximized ? WindowState.Maximized : WindowState.Normal;

    private void ButtonCloseClick(object sender, RoutedEventArgs e) => Application.Current.Shutdown();

    private void ButtonMinimizeHoverOn(object sender, RoutedEventArgs e) { }

    private void ButtonMinimizeHoverOff(object sender, RoutedEventArgs e) { }

    private void ButtonMaximizeHoverOn(object sender, RoutedEventArgs e) { }

    private void ButtonMaximizeHoverOff(object sender, RoutedEventArgs e) { }

    private void ButtonCloseHoverOn(object sender, RoutedEventArgs e) { }

    private void ButtonCloseHoverOff(object sender, RoutedEventArgs e) { }
}