   M S B A M L   `   `   `  ����B  >BioTech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:BioTech.MVVM.Model.ItemsBioTech.MVVM.Model.Items  5      8    2BioTech.MVVM.View.Allenamenti.NuovoAllenamentoView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8items&clr-namespace:BioTech.MVVM.Model.Items     5      
������ .��5	      �   � RowDefinitions  5
   
   �� 5      �� 5      $��80 �6   .+�5   
   ��  � 	Resources 5      3   -BioTech.MVVM.Model.Items.CategorieAllenamenti   	categorie��%   &	          5      6-   5      .+�5      �� $��	10,10,0,0q�6   $��30(�5      
�������Nome nuova tabella5   ?   �� 5      -   5        $��NomeNuovaTabella��5      $	��400��6.   $
��Left=�6:   $��0,5, 0,0q�6U   $��20(�5      �� 5      $��	10,10,0,0q�6   $��30(�5      
�������	Categoria5   6   �� 5      -   5        $��CategoriaNuovoAllenamento��5      $
��Left=�5       #��[  5!       �� Text$ 	Seleziona��5"       �� 
IsReadOnly$
 True��5#      $	��400��6)   $��0,5,0,0q�5$      $��20(�5%      �� 5'      $��	10,10,0,0q�6   $��30(�5(      
�������	Tabella5)   4   �� 5+      -   5        $��TabellaNuovoAllenamento��5+      $
��Left=�5,      $��0,5,0,0q�5-       �� TextWrapping$
 Wrap=�5.      $�� ��5/      $	��Top=�50      $	��780��51      $	��420��6"   $��20(�52       �� AcceptsReturn$
 True��53       �� 
AcceptsTab$
 True��54      55      �� 56   
   $��0��6   $��1��6%    �� Orientation$ 
Horizontal=�62   $��Center=�6K   $��80��6h   $��10, 10, 0, 0q�6t   .+�57      �� $
��Esci��6     MainWindowButtonTheme#��[ 6$   ��6S   �� *NavigateAllenamentiCommand+�� 58      -   5        $��Stampa��58      #��[ 6&   6U   �� 59      -   5        $��Salva��59      #��[ 6%   6T   5:      5<      5=      