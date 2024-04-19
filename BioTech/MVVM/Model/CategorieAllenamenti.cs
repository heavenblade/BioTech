using System.Collections.ObjectModel;

namespace BioTech.MVVM.Model;

public class CategorieAllenamenti : ObservableCollection<string>
{
    public CategorieAllenamenti()
    {
        Add("BodyBuilding");
        Add("Donne");
        Add("Fitness");
        Add("Sport vari");
        Add("Riabilitazione");
    }
}