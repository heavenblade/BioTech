   M S B A M L   `   `   `  ����B  >BioTech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:BioTech.MVVM.ModelBioTech.MVVM.Model  5      /    )BioTech.MVVM.View.Diete.ModificaDietaView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2model clr-namespace:BioTech.MVVM.Model     5      
������ .��5	      �   � RowDefinitions  5
   
   �� 5      �� 5      $��80 �6   .+�5   
   ��  � 	Resources 5      '   !BioTech.MVVM.Model.CategorieDiete   	categorie��%   &	          5      6'   5      .+�5      �� $��	10,10,0,0q�6   $��30(�5      
�������
Nome dieta5   7   �� 5      -   5        $��	NomeDieta��5      $	��400��6'   $
��Left=�63   $��0,5, 0,0q�6N   $��22(�5      �� 5      $��	10,10,0,0q�6   $��30(�5      
�������	Categoria5   6   �� 5      -   5        $��CategoriaDieta��5      $
��Left=�5       #��[  5!       �� Text$ 	Seleziona��5"       �� 
IsReadOnly$
 True��5#      $	��400��6)   $��0,5,0,0q�5$      $��22(�5%      �� 5'      $��	10,10,0,0q�6   $��30(�5(      
�������Dieta5)   2   �� 5+      -   5        $��ProgrammaDieta��5+      $
��Left=�5,      $��0,5,0,0q�5-       �� TextWrapping$
 Wrap=�5.      $�� ��5/      $	��Top=�50      $	��780��51      $	��420��6"   $��22(�52       �� AcceptsReturn$
 True��53       �� 
AcceptsTab$
 True��54      55      �� 56   
   $��0��6   $��1��6%    �� Orientation$ 
Horizontal=�62   $��Center=�6K   $��80��6h   $��10, 10, 0, 0q�6t   .+�57      �� -   5        $
��Esci��57        MainWindowButtonTheme#��[ 6$   ��6S   �� *NavigateDieteCommand+6|   �� 58      -   5        $��Stampa��58      #��[ 6&   6U   �� 59      -   5        $��Salva��59      #��[ 6%   6T   5:      5<      5=      