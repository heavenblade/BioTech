   M S B A M L   `   `   `  ����B  >BioTech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:BioTech.MVVM.Model.ItemsBioTech.MVVM.Model.Items  5      7    1BioTech.MVVM.View.Allenamenti.ModificaTabellaView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8items&clr-namespace:BioTech.MVVM.Model.Items     5      .��5      �   � RowDefinitions  5	   
   �� 5
      �� 5      $��80 �6   .+�5   
   ��  � 	Resources 5      3   -BioTech.MVVM.Model.Items.CategorieAllenamenti   	categorie��%   &	          5      6-   5      .+�5      �� $��	10,10,0,0q�6   $��30(�5      
�������Nome allenamento5   =   �� 5      -   5        $��NomeAllenamento��5      $	��400��6-   $
��Left=�69   $��0,5, 0,0q�6T   $��22(�5      �� 5      $��	10,10,0,0q�6   $��30(�5      
�������	Categoria5   6   �� 5      -   5        $��CategoriaAllenamento��5      $
��Left=�5      #��[  5        �� Text$ 	Seleziona��5!       �� 
IsReadOnly$
 True��5"      $	��400��6)   $��0,5,0,0q�5#      $��22(�5$      �� 5&      $��	10,10,0,0q�6   $��30(�5'      
�������	Tabella5(   4   �� 5*      -   5        $��Tabella��5*      $
��Left=�5+      $��0,5,0,0q�5,       �� TextWrapping$
 Wrap=�5-      $�� ��5.      $	��Top=�5/      $	��780��50      $	��450��6"   $��22(�51       �� AcceptsReturn$
 True��52       �� 
AcceptsTab$
 True��53      " �� VerticalScrollBarVisibility$ Visible=�54      56      �� 57   
   $��0��6   $��1��6%    �� Orientation$ 
Horizontal=�62   $��Center=�6K   $��80��6h   $��10, 10, 0, 0q�6t   .+�58      �� -   5        $
��Esci��58        MainWindowButtonTheme#��[ 6$   ��6n   �� *NavigateAllenamentiCommand+�� 59      -   5        $��Stampa��59      #��[ 6&   6U   �� 5:      -   5        $��Salva��5:      #��[ 6%   6T   5;      5<      5=      