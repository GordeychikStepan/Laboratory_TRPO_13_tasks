   M S B A M L   `   `   `  ����A  =Images, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ImagesImages  5          Images.ElementUserControl   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Images     5      .��5
      �� $	��170��6   $��20q�6   
�������  J� Effect  5      -  'System.Windows.Media.Effects.BlurEffect  5      -   5        
blur_1��5   "    � Triggers 5      :� 5       :� RoutedEvent$ 
MouseLeave��6   .[�5      �� .��5      �� .��5      W�  �� 
TargetName$ blur_1��6    �� TargetProperty$ Radius�67   	 W� To 56Z    g� Duration$ 0:0:1D�6a   W� 5      $ scale_1��6   $ ScaleX�68    16[   $ 0:0:1D�6b   W� 5      $ scale_1��6   $ ScaleY�68    16[   $ 0:0:1D�6b   5      5      5      .+�5      �� -   5         ��Name$ textbox��5      �� 5      -   5         ��Name$ image��5   #   $	��170��6
   $	��190��6    5      :� 5      $ 
MouseEnter��6   .[�5      �� .��5      �� .��5   	   W� $ blur_1��6   $ Radius�68    06[   $ 0:0:1D�6b   W� 5    	   $ scale_1��6   $ ScaleX�69    1.756\   $ 0:0:1D�6f   W� 5!   	   $ scale_1��6   $ ScaleY�69    1.756\   $ 0:0:1D�6f   5"   	   5#      5$      z�5&      �� 5'      -   5        
rotate��	 �� CenterX$	 85Q�5'   '   
 �� CenterY$
 55Q�64   5)      �� 5*       �� Orientation$ 
Horizontal=�6   $��0,0,0,10q�6(   .+�5+      �� 
�������$��30��6    $��30��6+   $
��35 0q�67   .��5,      �� $��ImagesSrc/left.png��6    5-      :� 5.      $ MouseLeftButtonDown��6   .[�5/   	   �� .��50   
   �� .��51      W� $ rotate��6   $ Angle�6:   	 W� By -906\   $ 0:0:0.1D�6e   52      53   
   54   	   56      57      �� 58      
�������$��30��6   $��30��6*   .��59      �� $��ImagesSrc/right.png��6    5:      :� 5;      $ MouseLeftButtonDown��6   .[�5<   	   �� .��5=   
   �� .��5>      W� $ rotate��6   $ Angle�6:    906\   $ 0:0:0.1D�6d   5?      5@   
   5A   	   5C      5E      5F      z�5G      V� 5H      .~�5I      �� -   5        scale_1�� �� ScaleX$ 1Q�5I   &    �� ScaleY$ 1Q�61   5J      5L      5M      