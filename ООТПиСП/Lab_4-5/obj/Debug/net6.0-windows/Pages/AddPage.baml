   M S B A M L   `   `   `  ����B  >Lab_4-5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Lab_4_5Lab_4_5  5          Lab_4_5.AddPage   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Lab_4_5     5        � Title$  AddPage��5	      .��5      � $��25q�6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �  5      �� 5      $
��Auto �6#   �� 5      $��* �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��1��6   $��0��6%   $&�� Введите описание:��65   �� 5       -   5         ��Name$ descriptionField��5    F   $��1��6   $��1��6#   $��0,0,0,20q�63   $	��200��6`    �� TextWrapping$
 Wrap=�6l   6�   �� 5"      $��3��6   $��0��6%   $.��(Выберите изображение:��65   �� 5#      -   5        $��3��5#      $��1��6"   $��
15,0,15,20q�62   $��Выбрать��6G   6Y   �� 5%      -   5        $��4��5%      $��1��6"   $��Добавить��63   6F   5&      �� 5(   
   -   5         ��Name$ productImage��5(      $��1��6&   $��15q�66   $y�	Collapsed=�6B   5)      5*      