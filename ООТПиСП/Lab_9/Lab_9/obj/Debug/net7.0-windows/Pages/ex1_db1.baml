   M S B A M L   `   `   `  ����@  <Lab_9, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Lab_9.PagesLab_9.Pages  5          Lab_9.Pages.ex1_db1   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Lab_9.Pages     5        N� Title$  ex1_db1��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
peopleGrid��5   /      AutoGenerateColumns$ False��6      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly$
 True��6<      Header$ ID��6N      Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 6Z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *ID+6Z     5      $ Имя��6>   $	 150 6K    6%   �� *Name+6K     5      $ 
Адрес��6@   $	 150 6O    6%   �� *adress+6O   5      �� 5   
   $��Center=�6   $��1��63   	 �� Orientation$	 
Horizontal=�6@   .+�5      �� -   5        
 ��Name$
 updateButton��5   4    � Cursor$
 Hand��6   $��0 5 0 0q�6#   $��Обновить��6J   6]   �� 5      -   5        $
 deleteButton��5   5   $
 Hand��6   $��20 5 0 0q�6#   $��Удалить��6K   6]   5      5      5      