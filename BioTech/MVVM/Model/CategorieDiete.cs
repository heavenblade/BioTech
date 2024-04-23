using System.Collections.ObjectModel;

namespace BioTech.MVVM.Model;

public class CategorieDiete : ObservableCollection<string>
{
    public CategorieDiete()
    {
        Add("BodyBuilding");
        Add("Fitness");
        Add("Sport vari");
        Add("Diete+Patologie");
    }
}