   M S B A M L   `   `   `  ����A  =一言, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:一言一言  5          WpfApp1.App   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      &localclr-namespace:一言     5      A =Stylet, Version=1.3.7.0, Culture=neutral, PublicKeyToken=null)s!https://github.com/canton7/Stylet  5        �� 	Resources  5       �� MergedDictionaries �� Source#  Stylet.Xaml.ApplicationLoader   Bootstrapper   一言.Bootstrapper   ToggleButtonStyle1 �� 
TargetType �� Property  	FontBrush �� Value  BackgroundBrush �� 
TargetType ��Name	 �� CornerRadius
 ��Name  ToggleButtonStyle2 �� Triggers P� Property P� Value �� 
TargetName �� RelativeSource �� Path  ComboBoxItemStyle  ComboBoxToggleButton J� SnapsToDevicePixels �� EndPoint �� 
StartPoint � Color � Offset F�Name �� Stretch ^� 
Conditions �� Binding �� AncestorType �� Value  ComboBoxTemplate �Name � ColumnDefinitions �Name � AllowsTransparency  �� Mode! �� MaxDropDownHeight" �� ElementName# ��Name$ �� ClearTypeHint% ��Name& ��Name' K� IsItemsHost-  'System.Windows.Input.KeyboardNavigation(   DirectionalNavigation) d�Name* d� 	IsChecked+ ��Name, �� SelectionBoxItemTemplate- �� SelectionBoxItem#. �� SelectionBoxItemStringFormat/ �� ContentStringFormat0 J� IsHitTestVisible1 ]� 
Conditions2 �� Property3 P� 
SourceName  ComboBoxStyle�� 5       5      �� 5      $6 0/DynamicTheme.Resources;component/DarkTheme.xaml?�6   �� 5      $; 5/DynamicTheme.Resources;component/PropertyTheme .xaml?�6     5       5        5      5      %�  &	        &	 �    &	     &	 0    &	     7  &	     7  �� 5      " d�6&   .�5      ��  � ��# �  6#   �� 5!       � ��# �  6#   �� 5#       � ��# �  6$   �� 5'       � �� 5(      �� 5)      " d�6   .R�5+   	   �� $ border��6   #��z��5,   %   #��z��5-   %   $��1q�5.   %   $	 4��5/   %   ._�51   
   �� $

 text��6   #��z��52   ,   $��Center=�53   ,   $��Center=�54   ,   #��z��55   ,   57   
   5M   	   5O      5P      �� 5S      " d�6&   .�5U      ��  � ��# �  6#   �� 5W       � ��# �  6#   �� 5Y       � ��# �  6$   �� 5\       �@�Tag$ 切换主题2��6   �� 5_       � �� 5`      �� 5a      " d�6   .R�5c   	   �� $ border��6   #��z��5d      #��z��5e      $��1q�5f      $	 4��5g      ._�5i   
   �� $

 text��6   #��z��5j       $��Center=�5k       $��Center=�5l       #��z��5m       5o   
    5r   	   P� 5t   
    �@d�	IsChecked$
 TrueY�6'   . �5v      �� # �  6(    � ���� 5x      # �  6(    � ���� 5z      $
 text��6    64   ��  �� *TemplatedParent+$	 Tag� � ��5{      5}   	   5      5�      �� 5�      " ��6%   .�5�      ��  � ��# �  6#   �� 5�       � ��$ Center=�61   �� 5�       � ��$ 40��6   �� 5�       � �� 5�      �� 5�      " ��6   .R�5�   	   �� $
��Back��6   #��z��5�      $��0,0,0,0q�5�      #���  5�      ._�5�   
   �� #��z��5�   '   $
��Left=�5�   '   $��Center=�5�   '   ��5�      �� *Source+5�   '   5�   
    5�   	   P� 5�   
    �@��IsHighlighted$
 True��6+   . �5�      �� $
 Back��6   # �  5�   !    � ��5�      P� 5�   
    �@��
IsSelected$
 True��6(   . �5�      �� $
 Back��6    � �� �	#FFCBE3FE5�   !   5�      5�   	   5�      5�      �� 5�      " d�6(   .�5�      ��  �@�OverridesDefaultStyle$
 true��6.   �� 5�       � ��$ false��6"   �� 5�       � |�$ false��6"   �� 5�       �@��	ClickMode$ Press=�6"   �� 5�       � �� 5�      �� 5�      " d�6   .R�5�   	   �� $ templateRoot��6   $	 4��6&   $
 true��67   #��z��5�      #��z��5�      #���  5�      ._�5�   
   �� $ splitBorder��6   $	 4��6&   $��40��67   $
 true��6B   $��0q�5�      $��Right=�6(   #��z��5�      #���  5�      ��5�      �� 5�      $	 0,1&�6    $	 0,0&�6/   .��5�      � # � ��6   $ 0Q�6]   � 5�      # � ��6   $
 0.75Q�6]   5�      ._�5�      F� $ arrow��6   $��Center=�6   $��9,0,0,0q�6:   $
 Fill=�5�      $��12��6.   $��16��6:   $
��Left=�6E   #���  5�      "�����������        � ��    	6H   5�      5�   
    5�   	   ^� 5�   
    5�      �� 5�       6   �� *
IsEditable+ �� " �� true6u   �� 5�       6   �� *IsMouseOver+ �� *Self+	 false6\   �� 5�       6   �� *	IsPressed+ �� *Self+	 false6Z   �� 5�       6   �� *	IsEnabled+ �� *Self+ true6Z   .0�5�      �� $ templateRoot��6)   # �  6C    � ��5�      P� 5�   
    � {�$ false��6'   . �5�      �� $ arrow��6"   # �  65    � ���� 5�      $ templateRoot��6)   # �  6C    � ��5      5  	   5     5     �� 5     " ��6.   .R�5     � $ templateRoot��6   $
 true��6!    5     �� 5     �� 5     $��0 �6   .+�5     � $ 
PART_Popup��6   $
 true��6!   $��2��6;   $��1q�6�   #��� .�5     $��Bottom=�6q   ��5  O   �� *IsDropDownOpen+$  TwoWay=� �� *TemplatedParent+.��5     �� $ dropDownBorder��6   #��� ��6'   $��1q�6s   #��� ��6�   #��z! 5     ��6M   �� *ActualWidth+$" templateRoot��._�5  	   �� $# DropDownScrollViewer��6   .��5  
   � $
 grid��6   $$ Enabled=�6   .+�5     �� $% canvas��6   $
��Left=�6"   $��0��6=   $	��Top=�6H   $��0��6`   .+�5     �� $& 
opaqueRect��6   ��6*   �� *
Background+$" dropDownBorder����6b   �� *ActualHeight+$" dropDownBorder����6�   �� *ActualWidth+$" dropDownBorder��5     �� 5     $
' True��6   $( Continue=�6)   #��� ��6]   5      5!  
   5"  	   5#     �� 5$     $��2��6   #��z��6"   #��z��6N   $	 4��6�   ._�5%     � .+�5&  	   d� $) toggleButton��6   #��z��6,   $��0q�6X   #��z��6l   $��2��6�   8��  * 5'  '   �� *IsDropDownOpen+$  TwoWay=� �� *TemplatedParent+6�   �� 5(  	   $+ contentPresenter��6   #��z, 64   #��z��6q   #��z- 5)  +   #/ z. 6X   #��z��6�   $0 false��5*  +   #��z��6D   # z 6g   #��z��6�   5+  	   5,     5-      5.     P� 53      �@��HasItems$ false��6#   . �54     �� $ dropDownBorder��6!    � ��$ 95��6=   55     ]� 56     1 57     �� 58  	   2 �@��
IsGrouping$
 true��6)   �� 59  	   "2 �@%�IsVirtualizingWhenGrouping$ false��6K   ./�5;     ��  � ��$ false��68   5<     P� 5=     $3 DropDownScrollViewer��68    � ��$ false��6Z   . �5>     �� $ 
opaqueRect��6%    6=   �� *VerticalOffset+$" DropDownScrollViewer�� �@��Top�� 5?     $ 
opaqueRect��6&    6>   �� *HorizontalOffset+$" DropDownScrollViewer�� �@��Left5@     5B     �� 5E     " ��6!   .�5F     ��  � �� 5G     �� 5H     $	 0,1&�6   $	 0,0&�6+   .��5I  	   � # � ��6   $ 0Q�6Y   � 5J  	   # � ��6   $
 0.75Q�6Y   5K  	   5M     �� 5N      � ��# �  6$   �� 5O      � ��# � ��6#   �� 5P      � ��$ 1q�6(   �� 5Q      � ��$
 Auto=�6C   �� 5R      � ��$
 Auto=�6A   �� 5S      � ��$ 6,3,5,3q�6    �� 5T      � ��$
 true��66   �� 5U      �@��PanningMode$
 Both=�61   �� 5V      �@��IsFlicksEnabled$ False��6/   �� 5W      � ��$ Center=�61   �� 5X      � ��# �  6+   �� 5Y      � ��8   6!   5Z     5\     5_     