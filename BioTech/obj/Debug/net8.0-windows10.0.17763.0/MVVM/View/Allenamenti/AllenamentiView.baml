   M S B A M L   `   `   `  ����  BioTech3    -BioTech.MVVM.View.Allenamenti.AllenamentiView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      �   � RowDefinitions  5	   
   �� 5
      �� 5      $	��130 �6    � ColumnDefinitions 5   
   �� 5      �� 5      $	��200 �6   .+�5   
   �� $��10,0,0,0q�6   $��30(�5      
�������Allenamenti5   4   �� 5   
   -   5         ��Name$ ListaAllenamenti��5      $��20(�5      $��
0,45,25,25q�5         CustomListViewItemStyle#��[  5      5      �� 5   
   -   5         ��Name$ CategoriaFilter��5   2   $��1��6   $��0��6%   $��10,101,-10,75q�6K   .+�5      	� -   5        $��BodyBuilding��5        CategoriaRadioButtonTheme#��[ 61   $��Center=�6�    d� 	IsChecked$
 TrueY�6�   	� 5       -   5        $��Donne��5       #��[ 6*   $��Center=�6}   	� 5!      -   5        $��Fitness��5!      #��[ 6,   $��Center=�6   	� 5"      -   5        $��
Sport vari��5"      #��[ 6/   $��Center=�6�   	� 5#      -   5        $��Riabilitazione��5#      #��[ 63   $��Center=�6�   5$      �� 5&   
   $��0��6   $��1��6%   .+�5'      ��  �� Orientation$ 
Horizontal=�6   $��	20,15,0,0q�62   .+�5(      �� -   5        $��ButtonGuarda��5(      $��Guarda��6-     MainWindowButtonTheme#��[ 6>   ${�False��6�   ��6m   �� *" NavigateGuardaAllenamentoCommand+6�   �� 5)      -	   5        $��Copia��5)      #��[ 6)   6X   �� 5*      -
   5        $��ButtonModifica��5*      $��Modifica��6/   #��[ 6B   ${�False��6�   ��6q   �� *$"NavigateModificaAllenamentoCommand+6�   5+      �� 5,      $ 
Horizontal=�6   $��	20,15,0,0q�62   .+�5-      �� $��Nuovo��6   #��[ 6)   ��6X   �� *!NavigateNuovoAllenamentoCommand+�� 5.      -   5        $��Copia��5.      #��[ 6)   6X   �� 5/      -   5        $��Stampa��5/      #��[ 6*   6Y   �� 50      -   5        $��Ricerca��50      $	��300��6*   $
��Left=�66   $��	10,4, 0,5q�6Q   $��26(�6d   6�   �� 51      -   5        $��Reset��51      #��[ 6)   6X   52      53      55      56      