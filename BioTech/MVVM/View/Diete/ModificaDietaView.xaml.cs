using BioTech.MVVM.Model.Stores;
using System.Windows;
using System.Windows.Controls;
using BioTech.MVVM.Model;
using BioTech.Core;

namespace BioTech.MVVM.View.Diete;

/// <summary>
///     Interaction logic for GuardaAllenamentoView.xaml
/// </summary>
public partial class ModificaDietaView : UserControl
{
    public ModificaDietaView()
    {
        InitializeComponent();

        PrepareContent();
    }

    private void PrepareContent()
    {
        NomeDieta.Text = DietaStore.CurrentDieta!.Nome;
        CategoriaDieta.Text = DietaStore.CurrentDieta.Categoria;
        ProgrammaDieta.Text = DietaStore.CurrentDieta.Programma;
    }

    private void CleanAndExit_Click(object sender, RoutedEventArgs e)
    {
        DietaStore.CurrentDieta = null;
    }

    private void StampaButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void SalvaButton_Click(object sender, RoutedEventArgs e)
    {
        Dieta dieta = new()
        {
            Nome = NomeDieta.Text,
            Categoria = CategoriaDieta.Text,
            Programma = ProgrammaDieta.Text
        };

        if (BaseDataChanged(DietaStore.CurrentDieta!, dieta))
        {
            try
            {
                MongoDbClient.InsertNuovaDieta(dieta);

                MongoDbClient.DeleteDieta(DietaStore.CurrentDieta!);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante l'aggiornamento!");

                return;
            }
        }
        else
        {
            try
            {
                MongoDbClient.UpdateDieta(dieta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante l'aggiornamento!");

                return;
            }
        }

        MessageBox.Show("Persona salvata con successo!");

        return;
    }

    private static bool BaseDataChanged(Dieta saved, Dieta current)
    {
        if (!saved.Nome.Equals(current.Nome))
            return true;

        if (!saved.Categoria.Equals(current.Categoria))
            return true;

        return false;
    }
}