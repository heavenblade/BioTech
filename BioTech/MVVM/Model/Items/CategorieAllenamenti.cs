﻿using System.Collections.ObjectModel;

namespace BioTech.MVVM.Model.Items;

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