   M S B A M L   `   `   `  ����@  <Lab_8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Lab_8.FramesLab_8.Frames  5          Lab_8.Frames.PageAdd   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Lab_8.Frames     5        N� Title$  PageAdd��5	      .��5      � -   5           WindowAddStyle#���   5       � ColumnDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      .+�5   
   �� $
��Type��6   $��5 5 0 0q�6    �� 5   
   -   5         ��Name$ 	typeInput��5      $��22��6%   $	��Top=�61   $
��Left=�6I   $��5 25 0 0q�6d   $	��150��6v   .@�5      �� .��6   Пассажирский6(   �� 5      .��6   Грузовой6$   �� 5      .��6   Военный6#   5      �� 5   
   $��Model��6   $��5 55 0 0q�6!   �� 5   
   -   5         ��Name$ 
inputModel��5      $��22��6&   $	��Top=�62   $
��Left=�6J   $��5 75 0 0q�6e   $	��150��6w   6�   �� 5   
   $��
Count seat��6   $��	5 105 0 0q�6&   �� 5   
   -   5        $ inputCountSeat��5      $��22��6*   $	��Top=�66   $
��Left=�6N   $��	5 125 0 0q�6i   $	��150��6|   6�   �� 5   
   $��Year of issue��6   $��	5 155 0 0q�6)   �� 5   
   -   5        $ inputYearOfIssue��5      $��22��6,   $	��Top=�68   $
��Left=�6P   $��	5 175 0 0q�6k   $	��150��6~   6�   �� 5!   
   $��Capacity of load��6   $��	5 205 0 0q�6,   �� 5"   
   -   5        $ InputCapacity��5"      $��22��6)   $	��Top=�65   $
��Left=�6M   $��	5 225 0 0q�6h   $	��150��6{   6�   �� 5$   
   $��
Date of TO��6   $��	5 255 0 0q�6&   (  "System.Windows.Controls.DatePicker  5%   
   -   5          Name$ 	InputDate��5%   #    � Cursor$
 Hand��6   $	��Top=�66   $
��Left=�6N   $��	5 275 0 0q�6i   $	��150��6|   6�   �� 5'   
   -   5        $
 Hand��5'      $��Choose image��6   $��	5 318 0 0q�66   $	��150��6I   $��22��6U   $	��Top=�6a   $
��Left=�6y   6�   �� 5(   
   -	   5        $
 Hand��5(      $��Add crew members��6   $��	5 360 0 0q�6:   $	��150��6M   $��22��6Y   $	��Top=�6e   $
��Left=�6}   6�   �� 5)   
   -
   5         ��Name$ TextWithInf��5)      $��1��6)   $��10q�69   
�������6E   �� 5*   
   -   5        $
 Hand��5*      $��Добавить��6   $
��Bold"�62   
���E��$��	5 400 0 0q�6]   $	��150��6p   $��22��6|   $	��Top=�6�   $
��Left=�6�   6�   �� 5+   
   -   5         ��Name$ imgField��5+      $��1��6"   $	��Top=�62   $��Right=�6J   $��10q�6f   $	��180��6r   $	��150��6~   5,      5-      