   M S B A M L   `   `   `  ����F  BLab_4-5_Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Lab_4_5_WpfLab_4_5_Wpf  5      b ^PresentationFramework.Aero2, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 5          Lab_4_5_Wpf.App   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      'localclr-namespace:Lab_4_5_Wpf   5      YthemeKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2   5        �� 	Resources  5       �� MergedDictionaries �� Source   PinkBorderTheme �� 
TargetType �� Property �� Value  DarkBorderTheme  gridEditButton �� 
TargetType �� CornerRadius �� Padding	 �� Triggers
 P� Property P� Value  gridRemoveButton �� BasedOn  gridButtonIcon.  (MahApps.Metro.IconPacks.PackIconMaterial  DataGridRowStyle1)  #System.Windows.Controls.DataGridRow ��Name J� SnapsToDevicePixels?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid � ColumnDefinitions � RowDefinitions?  9System.Windows.Controls.Primitives.DataGridCellsPresenter   
ItemsPanelA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter   DetailsVisibility$   SelectiveScrollingOrientation&   System.Windows.Controls.DataGrid#   RowDetailsScrollingConverter �� 	Converter;  5System.Windows.Controls.SelectiveScrollingOrientation   Vertical �� ConverterParameter �� RelativeSource �� AncestorType:  4System.Windows.Controls.Primitives.DataGridRowHeader!   HeadersVisibilityConverter7	  1System.Windows.Controls.DataGridHeadersVisibility
 	  Row ]� 
Conditions �� Property �� Value  ColumnHeaderGripperStyle �� Color  �� 
ResourceId! �� TypeInTargetAssembly" ��Name# �Name$ J� Opacity% � Points& �� Stretch' �� Triggers( �� 
TargetName  DataGridStyle15
  /System.Windows.Controls.DataGridLengthConverter) ��Name*   SelectAllCommand
+ 	  AllG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter,  Name- 	  Column. ��Name/ �� CanContentScroll0 ��Name1 �� ScrollableHeight2 � Maximum3 �� Orientation4 �� ViewportHeight5 �� ViewportSize*6 �� #ComputedVerticalScrollBarVisibility7 � Value8 �� Mode9 �� ScrollableWidth: �� ViewportWidth,; �� %ComputedHorizontalScrollBarVisibility  DataGridCellStyle1*  $System.Windows.Controls.DataGridCell 	 DataGridColumnHeaderStyle1=  7System.Windows.Controls.Primitives.DataGridColumnHeader3  -Microsoft.Windows.Themes.DataGridHeaderBorder<   	IsPressed= J� IsMouseOver>   	IsHovered?   CanUserSort@   IsClickableA   SortDirectionB   SortDirectionC   SeparatorVisibilityD   SeparatorVisibilityE   SeparatorBrushF   SeparatorBrushG n�Name 
 	AddButtonH :� RoutedEventI �� TargetPropertyJ g� Duration	K W� ToL g� AutoReverse�� 5	   
    5
      �� 5      $  Theme/MenuButtonTheme.xaml?�6%   �� 5      $# Theme/SearchTextBoxTheme.xaml?�6%   %�   &	        &	 J     &	 �     &	 �    7  &	 �    &	 m    &	 l
    (�� ~    5      *DataGrid.FocusBorderBrushKey+)(�� �    5�      $"  DataGridSelectAllButtonStyle��"!  )&	 b    &	 O    &		 �    7  7  &	
 �    �� 5      " ��6,   .�5      ��  � ��
 �����6/   5      �� 5      " ��6,   .�5      ��  � �� �#2725376/   5      �� 5      " ��6+   .�5      ��  � �� �#512da86/   �� 5       � �� �#4a148c60   �� 5       � �� �#ffffff6/   �� 5       �@�FocusVisualStyle 65   Z� �� 5       � ��$ Center=�66   �� 5       � �� 5      �� 5      " ��6*   .R�5      �� #��z��6%   $ 5��6O   $ 5q�6`   $��1q�6l   #��z��6�   ._�5    "   �� $��Center=�63   $��Center=�6P   5!      5"      5$      	 5&      P� 5'      
 �@J�IsMouseOver$
 True��65   . �5(      ��  � �� �#673ab767   5)      5+      �� 5,      " ��6-   8   .�5-      ��  � �� �#d32f2f6/   �� 5.       � �� �#b71c1c60   	 50      P� 51      
 �@J�IsMouseOver$
 True��65   . �52      ��  � �� �#f4433667   53      55      �� 57      "  6+   .�58      ��  � ��$ 12��6*   �� 59       � ��$ 12��6+   �� 5:       � ��$ Center=�66   5;      �� 5?      "  6.   .�5@      ��  � ��$ 0 4 0 0q�6+   �� 5A       � �� �#FFFFFF6/   �� 5B       �@J�SnapsToDevicePixels$
 true��68   �� 5C       �@=�ErrorTemplate 6=   Z� �� 5D       �@ ValidationErrorTemplate 5E      �� 5F      .R�5G      �� 
���  ��$��2,0,0,0q�69   $��!��6J   $��Center=�6S   5H      5J      �� 5K       � �� 5L      �� 5M      "  6*   .R�5N      �� $ 
DGR_Border��6%   $	 0 8q�69   $ 5��6G   #��z��6X   $��0q�6�   $
 True��6�   ._�5O   "      5P   &   �� 5Q   *   $
��Auto �6;   �� 5R   *   $��* �6;    5T   &   �� 5U   *   $��* �68   �� 5V   *   $
��Auto �68   .+�5X   &     $��1��6=   #��z 6M   # z 6w     5Y   &   $��1��6?   $��1��6O   #y�z 6s   6\   �� *AreRowDetailsFrozen+# Z # Z  �� "  6s    5Z   &   $��2��68   $ Vertical=�6I   y�6�   �� *HeadersVisibility+# Z # Z  �� "  5[   #   5\      5]      5_      	 5a      P� 5b      
 �@J�IsMouseOver$
 True��65   . �5c      ��  � �� �#623ED067   �� 5d       � �� �#ffffff67   5e      P� 5f      
 �@ 
IsSelected$
 True��64   . �5g      ��  � �� �#623ED067   �� 5h       � �� �#ffffff67   5i      ]� 5j       5k      �� 5l       �@ 
IsSelected$
 true��6>   �� 5m       �@��IsSelectionActive$ false��6N   ./�5o      ��  � �� �#dfdfdf67   5p      5r      �� 5s      " n�65   .�5t      ��  � ��$ 8��6*   �� 5u       � ��
 ���� 6/   �� 5v       �@�Cursor$ SizeWE��6+   �� 5w       � �� 5x      �� 5y      " n�6*   .R�5z      �� #��z��6%   # z��6O   5{      5}      5~      �� 5      $ 	#FF000000��6N   �� 5�      " ��6�   .�5�      ��  � �� 5�      �� 5�      " ��6*   .R�5�      � .+�5�   "   �� $" Border��6,   #��� ��6<   $
 True��6}   � 5�   "   $# Arrow��6*   
���   �$��Right=�6F   $��8,8,3,3q�6b   $
$ 0.15Q�6s   % �   ��� ��� ��� ��� $& Uniform=�6�   $��Bottom=�6�   5�      ' 5�      P� 5�   "   
 �@J�IsMouseOver$
 True��6A   . �5�   &   �� $( Border��6?   # � ��6S    � ��5�   #   P� 5�   "   
 � ��$
 True��6?   . �5�   &   �� $( Border��6=   # � ��6Q    � ��5�   #   P� 5�   "   
 � {�$ False��6?   . �5�   &   �� $( Arrow��6C    � y�$ 	Collapsed=�6V   5�   #   5�      5�      5�      �� 5�      "  6+   .�5�      ��  � ��
 ���� 6/   �� 5�       � �� �#2225286/   �� 5�       � ��$ 0q�64   �� 5�        �@ RowDetailsVisibilityMode$ VisibleWhenSelected=�6=   �� 5�       � ��$
 true��6B   �� 5�       �@��PanningMode$
 Both=�6=   �� 5�       �@��IsFlicksEnabled$ False��6;   �� 5�       �@ AutoGenerateColumns$ False��68   �� 5�       �@ HeadersVisibility$ Column=�66   �� 5�       � ��$ 0 10 0 0q�6+   �� 5�       �@ SelectionMode$ Single=�62   �� 5�       �@ SelectionUnit$ FullRow=�62   �� 5�       �@ CanUserAddRows$ False��63   �� 5�       �@ CanUserDeleteRows$ False��66   �� 5�       �@ CanUserResizeRows$ False��66   �� 5�       �@ CanUserReorderColumns$ False��6:   �� 5�       � ��$ 13(�6-   �� 5�       �@ ColumnWidth$ *
 60   �� 5�       �@ GridLinesVisibility$
 None=�68   �� 5�       � �� 5�      �� 5�      "  6*   .R�5�      �� #��z��6%   #��z��6O   #��z��6{   # z��6�   $
 True��6�   ._�5�   "   �� $) DG_ScrollViewer��6/   $|�false��6H   ��5�   &   �� 5�   *   " ��6:   .R�5�   .   �  5�   2   �� 5�   6   $
��Auto �6G   �� 5�   6   $��* �6G   �� 5�   6   $
��Auto �6G    5�   2   �� 5�   6   $
��Auto �6D   �� 5�   6   $��* �6D   �� 5�   6   $
��Auto �6D   .+�5�   2   �� #��Z* 69   $|�false��6h   ��6z   C� *�� $"  DataGridSelectAllButtonStyle��"!  +y�6�   �� *HeadersVisibility+# Z+ # Z  �� "  ��6�  �� *CellsPanelHorizontalOffset+ �� "    5�   2   $!, PART_ColumnHeadersPresenter��6Q   $��1��6v   y�6�   �� *HeadersVisibility+# Z- # Z  �� "  �� 5�   2   $!. PART_ScrollContentPresenter��6I   #/ z��6n   $��2��6�   $��1��6�   �� 5�   2   $0 PART_VerticalScrollBar��6<   $��2��6\   #2 z1 6l   $3 Vertical=�6�   $��1��6�   #5 z4 6  #y�z6 6L  7 6�   �� *VerticalOffset+$8 OneWay=� �� *TemplatedParent+6L  � 5�   2   $��1��67   $��2��6G    5�   6   �� 5�   :   ��6K   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "  �� 5�   :   $��* �6K   .+�5�   6   �� $0 PART_HorizontalScrollBar��6@   $��1��6b   #2 z9 6r   $3 
Horizontal=�6�   #5 z: 6  #y�z; 6G  7 6�   �� *HorizontalOffset+$8 OneWay=� �� *TemplatedParent+6G  5�   3   5�   /   5�   +   .��5�   &   �� # z 65   5�   #   5�      5�      5�      	 5�      ]� 5�       5�      �� 5�       �@��
IsGrouping$
 true��6>   �� 5�      " �@%�IsVirtualizingWhenGrouping$ false��6`   ./�5�      ��  � ��$ false��6J   5�      5�      �� 5�      "  6/   .�5�      ��  � ��
 ���� 6/   �� 5�       � ��$ Center=�66   �� 5�       �@�FocusVisualStyle 65   Z� �� 5�       � ��$
 15 0q�6+   �� 5�       � �� 5�      �� 5�      "  6*   .R�5�      �� #��z��6%   $��0q�6O   $
 True��6c   ._�5�   "   �� # z 63   5�      5�      5�      5�      �� 5�      "  67   .�5�      ��  � ��$ Center=�6=   �� 5�       � ��
 ���� 6/   �� 5�       � �� �#69717d6/   �� 5�       � ��$ 
15 0 15 10q�6+   �� 5�       � ��$ /Fonts/#Poppins)�6/   �� 5�       � �� 5�      �� 5�      "  6*   .R�5�      � .+�5�   "     #��z��6=   #��z��6g   #��z��6�   #< z��6�   #> z= 6�   #@ z? 6  # z��6E  #B zA 6i  #D zC 6�  #F zE 6�  ._�5�   &   �� #��z��67   $
��True��6z   # z 6�   #��z��6�   5�   #   n� 5�   "   $G PART_LeftHeaderGripper��6(   $
��Left=�6H   8��  6c   n� 5�   "   $G PART_RightHeaderGripper��6(   $��Right=�6I   8�� 6e   5�      5�      5�      5�      �� 5      " ��5     .�5     ��  � ��$ Fonts/#Poppins)�6/   	 5     ]� 5      5     �� 5      �@J�IsMouseOver$
 True��6?   �� 5      � ��$
 True��6=   /�5	     �� 5
      � ��$ 14(�69   �� 5      � ��
 �  ��6;   5     :� 5     $H Click��6#   [�5     �� 5     .��5  "   �� .��5  &   W� $I Width�66   $J 0:0:1D�6X   K 1606i   $
L True��6r   W� 5  &   $I Height�66   $J 0:0:1D�6Y   K 1006j   $
L True��6s   5  #   5     5     5     5     5     