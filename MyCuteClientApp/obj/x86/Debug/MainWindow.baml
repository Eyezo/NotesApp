   M S B A M L   `   `   `  ����J  FMyCuteClientApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:MyCuteClientApp.CuteServiceMyCuteClientApp.CuteService  5   �        MyCuteClientApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   F   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   8my)clr-namespace:MyCuteClientApp.CuteService     6�   -   5          � Title$  
MainWindow��5   	   $	��335��6   $	��345��6)    � 	Resources 5         studentDetailViewSource  studentViewSource 
 Rotate	 W� To g� AccelerationRatio g� AutoReverse g� DecelerationRatio g� Duration g� RepeatBehavior �� 
TargetName��%�   &	        &	      &	 &    �� 5   
   6   �� 5   
   6   W� 5	   
   $	 360X�5      $	 0.5Q�5       . $	 0.5Q�5      $ 0:0:5D�5      $ Forever��5      $ textBlockStudentId��5      5      .��5   
   � -   5        $��gMain��5      $
��Auto��6   .+�5   
   ��   RadialBrush#��[ 6   ._�5      � -   5        $��
getStudent��5      	 � DataContext#	 [  6%   $	��258��6\   
 � ColumnDefinitions
 5      �� 5      $
��Auto �6'   �� 5       � RowDefinitions 5!      �� 5"      $��85 �6$   �� 5#      $��22 �6$   �� 5$      $	��202 �6$   .+�5&      �� -   5        $��txtBlockName��5&   7   $
��Left=�6   $��UserName��6K   $	��Top=�6[   $��	13,60,0,0q�6s   $	��113��6�   �� 5'      -   5        $��txtBlockPassword��5'   D   $��1��6   $
��Left=�6)   $��Password��6\   $��Bottom=�6l   $��13,0,0,0q�6�   $	��113��6�   �� 5(      -   5        $��txtUserName��5(   E   $��1��6   $
��Left=�6*   $��Bottom=�6X   $��85��6s   $��0,0,0,9q�6~   ��6�   ��  �� Path$ StudentName� �� Mode$ TwoWay=� �� ValidatesOnExceptions .  �� NotifyOnValidationError .  �� Source# [ �� 5)      -   5        $��txtPassword��5)   R   $��1��6   $��1��6*   $
��Left=�67   $��Bottom=�6e   $��85��6�   ��6�   �� $ StudentPassword�$ TwoWay=� .  . # [ �� 5*      -   5        $��	btnsignIn��5*   C   $��2��6   $��Center=�6&   $��SignIn��6T   $��
6,0,44,113q�6e   $	��113��6y   $��23��6�   $��Bottom=�6�   ���	#FF8D8DD4���	#FF7BABDF$
��Bold"�6�   $��Italic$�6  �� 5+      -	   5        $��btnCreateProfile��5+   C   $��2��6   $��Center=�6&   $��Create profile��6[   $��	6,0,44,84q�6t   $	��113��6�   $��23��6�   $��Bottom=�6�   ���	#FF8D8DD4���	#FF7BABDF$
��Bold"�6  $��Italic$�6  �� 5,      -
   5        $��txtStudentId��5,   c   $��1��6   $��23��6*   $
��Left=�66   $��0,17,0,0q�6Q   $	��Top=�6w   $��85��6�   ��6�   �� $ 	studentId�$ TwoWay=� .  . # [ �� 5-      -   5        $��textBlockStudentId��5-   V   $��23��6   $
��Left=�6(   $��	13,20,0,0q�6C   $��enter student id��6p   $	��Top=�6�   $	��113��6�   �� 5.      -   5        $��canMain��5.   -   }�. .+�5/      �� -   5        $��tb��5/       6,   50      51      53      57      5:      