   M S B A M L   `   `   `  ����F  BLab_4-5_Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Lab_4_5_WpfLab_4_5_Wpf  5	   	   ;"clr-namespace:Lab_4_5_Wpf.CommandsLab_4_5_Wpf.Commands  5
   	   U QSystem.Runtime, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a7,clr-namespace:System;assembly=System.RuntimeSystem 5   	   E'clr-namespace:Lab_4_5_Wpf.CustomControlLab_4_5_Wpf.CustomControl  5   	       Lab_4_5_Wpf.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   'localclr-namespace:Lab_4_5_Wpf   5	   	   3commands"clr-namespace:Lab_4_5_Wpf.Commands   5
   	   8sys,clr-namespace:System;assembly=System.Runtime   5   	   >ControlButtons'clr-namespace:Lab_4_5_Wpf.CustomControl   5   	     � Icon$  /Images/icon_main.png��5   	    � Cursor$d ^C:\Users\Admin\Desktop\labs\labs 2_2\ООТПиСП\Lab_4-5_Wpf\Lab_4-5_Wpf\Images\emerald.cur��5   	    � Title$ 
MainWindow��5   	   $	��600��5   	   $	��920��5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ CanResizeWithGrip=�5   	   
������  � AllowsTransparency$
 True��5   	    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$. (commands:AplicationCommand.ChangeCommand��5      6L     5   
   -   5        $. (commands:AplicationCommand.RemoveCommand��5      6L     5   
   -   5        $+ %commands:AplicationCommand.AddCommand��5      6I   .��5      �� -   5         ��Name$ WindowBorder��5   	   	 �� CornerRadius$	 20��5      ._�5   
   � 
 � ColumnDefinitions
 5      �� 5      $	��200 �6#   �� 5        � RowDefinitions 5"      �� 5#      $��25 �6    �� 5$      $��75 �6    �� 5%      .+�5'      �� $��0 0 20 0q�5(       �� Orientation$ 
Horizontal=�5)      $��2��5*      $��RightToLeft=�5+      .+�5,      �� -   5         ��Name$ CloseForm_Button��5,      $��25��63   ��5-      �� 5.       �� 
TargetType" ��6*   .R�5/      �� $ Bd��6%   
������ ._�50   "   F�  F�Name$ Pt��6'   =����        �@ @ � 5  5 �@  5 � 5 @ �@B @B 	 �� Stretch$ Uniform=�51      
���   �$��2��68   52       �� Triggers 53      P� 54   "    P� Property �@J�IsMouseOver P� Value$
 True��6A   . �55   &   ��  �� 
TargetName$ Bd��6-    �� Property � �� �� Value
 �  ��6S   �� 56   &   $ Pt��6-    � ��
 �����6O   57   #   59      5;      5<      �� 5=      $��Fo0tballShop��6   $��1��5>      $��Center=�5?      $
��Left=�5@      
�������$��22(�5B      $��20,0,0,0q�5C      $��/Fonts/#Poppins)�5D      �� 5E      $��2��6   .+�5F      	�    
Loc_Tittle#���   6   $��50��5G      
�������$��14(�5I      $��/Fonts/#Poppins)�5J        MenuButtonTheme#��[ 5K      	� 5L      -   5        $��Русский��5L      $��50��5M      
�������$��14(�5O      $��/Fonts/#Poppins)�5P      #��[ 5Q      6G   	� 5R      -   5        $��English��5R      $��50��5S      
�������$��14(�5U      $��/Fonts/#Poppins)�5V      #��[ 5W      6G   5X      �� 5Z      $
��Left=�5[      $��5q�5\      $��1��5]      $��1��5^      $	 10��5_      ���#353340$	��200��5a      $��40��5b      ._�5c      � .+�5d      �� $��1��6    �� 5e      -   5         ��Name$ 	SearchBox��5k   &   $��1q�5e      $��0q�5f   &   
������ $��Center=�5h   &   $��5q�5i   &   ���#CFCFCF5l      �� 5m      -	   5         ��Name$ Search_TextBlock��5m        J� IsHitTestVisible$ False��5n         Loc_SearchButton#���  5o   (   $��Center=�5p   (   $
��Left=�5q   (   $��10,0,0,0q�5r   (   $��11(�5s   (   
�������$��/Fonts/#Poppins)�5u   (   $��1��5v   (   $��1��5w   (   ��5x      �� 5y       �� 
TargetType" ��6$    �� Triggers 5z   "   �� 5{   &    �� Binding 62   �� *Text+ �� ElementName$ 	SearchBox�� �� Value  6b   .a�5|   *   ��  � y�$ Visible=�6G   5}   '   .�5   "   ��  � y�$ Hidden=�6?   5�      5�      5�      5�      &   System.Windows.Controls.DataGrid  5�      -
   5          Name$ ProductsDataGrid��5�        DataGridRowStyle1    RowStyle#  �  5�        DataGridColumnHeaderStyle1!   ColumnHeaderStyle#! �  5�        DataGridCellStyle1"   	CellStyle#" �  5�        DataGridStyle1#���  5�      $��2��5�      $��1��5�      $��20 20 20 20q�5�      #   Columns# 5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      -   5        DescriptionColumn��,  &System.Windows.Controls.DataGridColumn$   
IsReadOnly$
$ True��5�   H   %   MinWidth$	% 230Q�6Z   &   Width5  /System.Windows.Controls.DataGridLengthConverter$& 3* 6i   '   CellTemplate' 5�      �� 5�      .R�5�   "   �� $ 
Horizontal=�6-   .+�5�   &   �� $��2q�5�   )   
����� �( �� Padding$( 2 2 2 2q�5�   )   $	 2��5�   )   ._�5�   *   �� $	��100��60   $	��100��6<   ��6I   �� *Image+5�   '   �� 5�   &   ) �� Padding$) 3 0 15 0q�60   $	��110��6C   $
��Wrap=�6R   ��6f   �� *Description+5�   #   5�      5�        5�      -   5        ID_Title_Column��$
$ True��5�   F   $& 3* 6X   ' 5�      �� 5�      .R�5�   "   �� $ Vertical=�6-   .+�5�   &   �� $
��Wrap=�61   ��6E   �� *ID+�� 5�   &   �� 5�   &   $
��Wrap=�61   ��6E   �� *Title+5�   #   5�      5�      0  *System.Windows.Controls.DataGridTextColumn  5�      -   5        Price_Column��$
$ True��5�   Y   $& * 6k   1  +System.Windows.Controls.DataGridBoundColumn*   Binding* 6?   �� *Price+6k     5�      -   5        Type_Column��$
$ True��5�   X   $& 2* 6j   * 6?   �� *Type+6j     5�      -   5        Operations_Column��$
$ True��5�   I   $
& auto 6[   ' 5�      �� 5�      .R�5�   "   �� $ 
Horizontal=�6-   .+�5�   &   �� $.��(commands:AplicationCommand.ChangeCommand��5�   )     gridEditButton#��[ 5�   )   .��5�   *   .  (MahApps.Metro.IconPacks.PackIconMaterial  +   Kind$+ PencilOutline=�6@     gridButtonIcon#��[ 6U   5�   '   �� 5�   &   $.��(commands:AplicationCommand.RemoveCommand��5�   )   $��5 0 0 0q�5�   )    	 gridRemoveButton#��[	 6:   .��5�   *     $+ DeleteOutline=�6@   #��[ 6U   5�   '   5�   #   5�      5�      5�      �� 5�      -   5        $ 	addButton��5�      $��0��5�      $��2��5�      $	��100��5�      $��50��5�      $+��%commands:AplicationCommand.AddCommand��5�       
 	AddButton#��[
 5�        Loc_AddMainButton#���  5�      �� 5�      -   5        , ��Name$, styleBox��5�      $��0��5�      $��2��5�      $	��100��5�      $��30��5�      $��	0 150 0 0q�5�      2	   ,Lab_4_5_Wpf.CustomControl.UserControlButtons	  5�      5�      5�      5�      