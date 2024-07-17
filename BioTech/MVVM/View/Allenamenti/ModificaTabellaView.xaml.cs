using System.Windows;
using System.Windows.Controls;
using BioTech.Core.Database;
using BioTech.MVVM.Model;
using BioTech.MVVM.Model.Stores;

namespace BioTech.MVVM.View.Allenamenti;

/// <summary>
///     Interaction logic for GuardaAllenamentoView.xaml
/// </summary>
public partial class ModificaTabellaView : UserControl
{
    public ModificaTabellaView()
    {
        InitializeComponent();

        PrepareContent();
    }

    private void PrepareContent()
    {
        Allenamento allenamento = AllenamentoStore.CurrentAllenamento;

        if (allenamento == null)
            return;

        NomeAllenamento.Text = allenamento.Nome;
        CategoriaAllenamento.Text = allenamento.Categoria;
        Tabella.Text = allenamento.Tabella;
    }

    private void CleanAndExit_Click(object sender, RoutedEventArgs e)
    {
        AllenamentoStore.CurrentAllenamento = null;
    }

    private void StampaButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void SalvaButton_Click(object sender, RoutedEventArgs e)
    {
        Allenamento allenamento = new()
        {
            Nome = NomeAllenamento.Text,
            Categoria = CategoriaAllenamento.Text,
            Tabella = Tabella.Text
        };

        if (BaseDataChanged(AllenamentoStore.CurrentAllenamento!, allenamento))
        {
            try
            {
                MongoDbClient.InsertNuovoAllenamento(allenamento);

                MongoDbClient.DeleteAllenamento(AllenamentoStore.CurrentAllenamento!);
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
                MongoDbClient.UpdateAllenamento(allenamento);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante l'aggiornamento!");

                return;
            }
        }

        MessageBox.Show("Allenamento salvato con successo!");
    }

    private static bool BaseDataChanged(Allenamento saved, Allenamento current)
    {
        if (!saved.Nome.Equals(current.Nome))
            return true;

        if (!saved.Categoria.Equals(current.Categoria))
            return true;

        return false;
    }
}