   M S B A M L   `   `   `  ����B  >BioTech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:BioTech.MVVM.Model.ItemsBioTech.MVVM.Model.Items  5      2    ,BioTech.MVVM.View.Alimenti.NuovoAlimentoView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8items&clr-namespace:BioTech.MVVM.Model.Items     5      
������ .��5	      �   � RowDefinitions  5
   
   �� 5      �� 5      $��80 �6   .+�5   
   ��  � 	Resources 5      0   *BioTech.MVVM.Model.Items.TipologieAlimenti   	tipologie5   /BioTech.MVVM.Model.Items.UnitàDiMisuraAlimenti  unitàDiMisura��%:   &	        &	        5      6*     5      6.   5      .+�5      �� $��	10,10,0,0q�6   $��30(�5      
�������Nome nuovo alimento5   @   �� 5      -   5        $��NomeNuovoAlimento��5      $	��400��5      $
��Left=�5      $��0,5,0,0q�5      $��22(�5      5      �� 5       $��	10,10,0,0q�6   $��30(�5!      
�������	Tipologia5"   6   �� 5$      -   5        $��TipologiaNuovoAlimento��5$      $
��Left=�5%      #��[  5&       �� Text$ 	Seleziona��5'       �� 
IsReadOnly$
 True��5(      $	��400��6)   $��0,5,0,0q�5)      $��22(�5*      5+      �� 5-      $��	10,10,0,0q�6   $��30(�5.      
�������Unità di misura5/   <   �� 51      -   5        $��UnitàDiMisura��51      $
��Left=�52      #��[ 53      $
 True��54      $	��400��6)   $��0,5,0,0q�55      $��22(�56      57      �� 59      $��	10,10,0,0q�6   $��30(�5:      
�������Valori nutrizionali5;   @   �� 5=       �� Orientation$ 
Horizontal=�6   .+�5>      �� $ 
Horizontal=�6   .+�5?      �� .+�5@      �� $��	10,15,0,0q�6$   $��26(�5A   $   
�������	Energia5B   @   �� 5C      $��	10,15,0,0q�6$   $��26(�5D   $   
�������Grassi insaturi5E   H   �� 5F      $��	10,15,0,0q�6$   $��26(�5G   $   
�������Grassi saturi5H   F   �� 5I      $��	10,15,0,0q�6$   $��26(�5J   $   
�������Fibre5K   >   5L      �� 5M      .+�5N      �� -   5        $��Energia��5N   "   $	��100��5O   "   $
��Left=�5P   "   $��	10,15,0,0q�5Q   "   $��26(�5R   "    �� TextAlignment$ Right=�5S   "   5T   "   �� 5U      -   5        $��GrassiInsaturi��5U   "   $	��100��5V   "   $
��Left=�5W   "   $��	10,13,0,0q�5X   "   $��26(�5Y   "   $ Right=�5Z   "   5[   "   �� 5\      -   5        $��GrassiSaturi��5\   "   $	��100��5]   "   $
��Left=�5^   "   $��	10,13,0,0q�5_   "   $��26(�5`   "   $ Right=�5a   "   5b   "   �� 5c      -   5        $��Fibre��5c   "   $	��100��5d   "   $
��Left=�5e   "   $��	10,13,0,0q�5f   "   $��26(�5g   "   $ Right=�5h   "   5i   "   5j      �� 5k      .+�5l      �� $��	10,15,0,0q�6$   $��26(�5m   $   
�������Kcal5n   =   �� 5o      $��	10,15,0,0q�6$   $��26(�5p   $   
�������gr5q   ;   �� 5r      $��	10,15,0,0q�6$   $��26(�5s   $   
�������gr5t   ;   �� 5u      $��	10,15,0,0q�6$   $��26(�5v   $   
�������gr5w   ;   5x      5y      �� 5z      $ 
Horizontal=�6   .+�5{      �� .+�5|      �� $��
100,15,0,0q�6$   $��26(�5}   $   
�������Carboidrati5~   D   �� 5      $��
100,15,0,0q�6$   $��26(�5�   $   
�������
Zuccheri5�   A   �� 5�      $��
100,15,0,0q�6$   $��26(�5�   $   
�������
Proteine5�   A   �� 5�      $��
100,15,0,0q�6$   $��26(�5�   $   
�������Sale5�   =   5�      �� 5�      .+�5�      �� -   5        $��Carboidrati��5�   "   $	��100��5�   "   $
��Left=�5�   "   $��	10,15,0,0q�5�   "   $��26(�5�   "   $ Right=�5�   "   5�   "   �� 5�      -	   5        $��Zuccheri��5�   "   $	��100��5�   "   $
��Left=�5�   "   $��	10,13,0,0q�5�   "   $��26(�5�   "   $ Right=�5�   "   5�   "   �� 5�      -
   5        $��Proteine��5�   "   $	��100��5�   "   $
��Left=�5�   "   $��	10,13,0,0q�5�   "   $��26(�5�   "   $ Right=�5�   "   5�   "   �� 5�      -   5        $
��Sale��5�   "   $	��100��5�   "   $
��Left=�5�   "   $��	10,13,0,0q�5�   "   $��26(�5�   "   $ Right=�5�   "   5�   "   5�      �� 5�      .+�5�      �� $��	10,15,0,0q�6$   $��26(�5�   $   
�������gr5�   ;   �� 5�      $��	10,15,0,0q�6$   $��26(�5�   $   
�������gr5�   ;   �� 5�      $��	10,15,0,0q�6$   $��26(�5�   $   
�������gr5�   ;   �� 5�      $��	10,15,0,0q�6$   $��26(�5�   $   
�������gr5�   ;   5�      5�      5�      5�      �� 5�   
   $��0��6   $��1��6%   $ 
Horizontal=�62   $��Center=�6K   $��80��6h   $��	10,10,0,0q�6t   .+�5�      �� $
��Esci��6     MainWindowButtonTheme#��[ 6$   ��6S   �� *NavigateAlimentiCommand+�� 5�      -   5        $��Stampa��5�      #��[ 6&   6U   �� 5�      -   5        $��SalvaButton��5�      $��Salva��6(   #��[ 68   ${�False��6�   5�      5�      5�      