   M S B A M L   `   `   `  ����J  FMyCuteClientApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:MyCuteClientApp.CuteServiceMyCuteClientApp.CuteService  5   �       MyCuteClientApp.ViewNote   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   D   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   8my)clr-namespace:MyCuteClientApp.CuteService     6�   -   5          � Title$  ViewNote��5   	   $	��300��6   $	��300��6'    � 	Resources 5         noteDetailViewSource��%   &	        �� 5   
   6   5      .��5      � -   5        $��NScreen��5      $
��Auto��6   .+�5	   
   ��   RadialBrush#��[ 6   ._�5
      �  � DataContext# [  6   $	��221��6G   $	��264��6T    J� Opacity$ 1Q�6`   .+�5      �� -   5        $��	txtNoteId��5   U   $��23��6   $
��Left=�6&   $��
138,15,0,0q�6A   $	��Top=�6f   $	��100��6~   ��6�   ��  �� Path$ noteId� �� Mode$ TwoWay=� �� ValidatesOnExceptions .  �� NotifyOnValidationError . �� 5      -   5        $��textBlockNoteId��5   V   $��23��6   $
��Left=�6(   $��	15,18,0,0q�6C   $��enter note ID��6m   $	��Top=�6�   $	��104��6�   �� 5      -   5        $��txtNoteContent��5   U   $��23��6   $
��Left=�6&   $��
138,44,0,0q�6A   $	��Top=�6k   $	��100��6�   {�.  ��6�   �� $ noteContent�$ TwoWay=� .  . 6�   �� 5      -   5        $��textBlockNoteContent��5   V   $��23��6   $
��Left=�6(   $��	15,47,0,0q�6C   $��	make note��6r   $	��Top=�6�   $	��104��6�   �� 5      -   5        $��txtStudentId��5   U   $��23��6   $
��Left=�6&   $��
138,73,0,0q�6A   $	��Top=�6i   $	��100��6�   {�.  ��6�   �� $ 	studentId�$ TwoWay=� .  . 6�   �� 5      -   5        $��textBlockStudentId��5   V   $��23��6   $
��Left=�6(   $��	15,76,0,0q�6C   $��enter student ID��6p   $	��Top=�6�   $	��104��6�   �� 5      -	   5        $��	btnSearch��5   e   $��Search��6   $��23��6*   $
��Left=�66   $��
15,117,0,0q�6Q   $	��Top=�6v   $	��104��6�   ���	#FF8D8DD4���	#FF7BABDF$
��Bold"�6�   $��Italic$�6�   $	 100Q�6  �� 5      -
   5        $��btnSave��5   k   $��Save changes��6   $��23��60   $
��Left=�6<   $��
15,146,0,0q�6W   $	��Top=�6z   $	��104��6�   ���	#FF8D8DD4���	#FF7BABDF$
��Bold"�6�   $��Italic$�6�   $	 100Q�6  5      5      5      5      