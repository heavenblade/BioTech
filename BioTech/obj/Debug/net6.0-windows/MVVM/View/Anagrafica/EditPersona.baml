   M S B A M L   `   `   `  ����  BioTech.    (BioTech.MVVM.View.Anagrafica.EditPersona   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      
������ .��5      � .+�5
   
   �� .+�5      �� $��	10,10,0,0q�6   $��34(�5      
�������Inserimento scheda anagrafica5   J   �� 5        �� Orientation$  
Horizontal=�6   .+�5      �� .+�5      �� $��10, 10, 0,0q�6    $��26(�5       
�������Nome5   9   �� 5      $��10, 10, 0,0q�6    $��26(�5       
�������	Cognome5   <   �� 5      $��10, 10, 0,0q�6    $��26(�5       
�������	Altezza5   <   �� 5      $��10, 10, 0,0q�6    $��26(�5       
�������Peso5    9   �� 5"      $��10, 10, 0,0q�6    $��26(�5#       
�������Sesso5$   :   �� 5&      $��10, 10, 0,0q�6    $��26(�5'       
�������Data di nascita5(   D   �� 5*      $��10, 10, 0,0q�6    $��26(�5+       
�������	Indirizzo5,   >   �� 5.      $��10, 10, 0,0q�6    $��26(�5/       
�������Città50   :   �� 52      $��10, 10, 0,0q�6    $��26(�53       
�������Professione54   @   �� 56      $��10, 10, 0,0q�6    $��26(�57       
�������Sport58   :   �� 5:      $��10, 10, 0,0q�6    $��26(�5;       
�������
Telefono5<   =   5=      �� 5?      .+�5A      �� -   5         ��Name$
 Nome��5A      $	��300��6,   $
��Left=�68   $��
10,10, 0,5q�6S   $��26(�6g   �� 5C      -   5        $��Cognome��5C      $	��300��6-   $
��Left=�69   $��
10, 2, 0,5q�6T   $��26(�6h   �� 5E      -   5        $��Altezza��5E      $	��100��6-   $
��Left=�69   $��	10,2, 0,5q�6T   $��26(�6g   �� 5G      -   5        $
��Peso��5G      $	��100��6*   $
��Left=�66   $��	10,4, 0,5q�6Q   $��26(�6d   �� 5I      -   5         ��Name$ Sesso��5J   !   $  
Horizontal=�5I   !   $��10,4,0,5q�5K   !   .+�5L      	� $��Maschio��6&    	� 	GroupName$ Sesso��68   
�������$��26(�6]   $��Center=�6k    d� 	IsChecked$
 TrueY�6�   	� 5M      $��Femmina��6&   $ Sesso��68   
�������$��26(�6]   $��Center=�6k   $��	15, 0,0,0q�6�   5N      (  "System.Windows.Controls.DatePicker  5P      -   5        $��DataNascita��5P   !   $	��300��64   $
��Left=�6@   $��	10,5, 0,5q�6[   $��26(�6n   �� 5R      -   5        $��	Indirizzo��5R      $	��300��6/   $
��Left=�6;   $��	10,4, 0,5q�6V   $��26(�6i   �� 5T      -   5        $��Città��5T      $	��300��6+   $
��Left=�67   $��	10,3, 0,5q�6R   $��26(�6e   �� 5V      -	   5        $��Professione��5V      $	��300��61   $
��Left=�6=   $��	10,2, 0,5q�6X   $��26(�6k   �� 5X      -
   5        $��Sport��5X      $	��300��6+   $
��Left=�67   $��	10,3, 0,5q�6R   $��26(�6e   �� 5Z      -   5        $��Telefono��5Z      $	��300��6.   $
��Left=�6:   $��	10,3, 0,5q�6U   $��26(�6h   5[      5\      �� 5^      $  
Horizontal=�6   $��Center=�62   $��80��6O   $��10, 10, 0, 0q�6[   .+�5_      �� -   5        $
��Esci��5_         MainWindowButtonTheme#��[  6(   ��6r   �� *NavigateAnagraficaCommand+�� 5`      -   5        $��Stampa��5`      #��[  6*   6Y   �� 5a      -   5        $��Salva��5a      #��[  6)   ��6r   �� *NavigateAnagraficaCommand+5b      5c      5e      5f      