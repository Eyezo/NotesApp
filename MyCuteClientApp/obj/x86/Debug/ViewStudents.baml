   M S B A M L   `   `   `  ����J  FMyCuteClientApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:MyCuteClientApp.CuteServiceMyCuteClientApp.CuteService  5   �   "    MyCuteClientApp.ViewStudents   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   H   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   8my)clr-namespace:MyCuteClientApp.CuteService     6�   -   5          � Title$  ViewStudents��5   	   $	��300��6   $	��300��6+    � 	Resources 5         studentDetailViewSource��%   &	        �� 5   
   6   5      .��5      � -   5        $��SScreen��5      $
��Auto��6   .+�5	   
   ��   RadialBrush#��[ 6   ._�5
      �  � DataContext# [  6   .+�5      �� -   5        $��txtStudentId��5   U   $��23��6   $
��Left=�6&   $��
169,19,0,0q�6A   $	��Top=�6i   $��92��6�   ��6�   ��  �� Path$ 	studentId� �� Mode$ TwoWay=� �� ValidatesOnExceptions .  �� NotifyOnValidationError . �� 5      -   5        $��textBlockStudentId��5   V   $��23��6   $
��Left=�6(   $��	37,22,0,0q�6C   $��enter student ID��6p   $	��Top=�6�   $	��115��6�   �� 5      -   5        $��txtStudentName��5   U   $��23��6   $
��Left=�6&   $��
169,48,0,0q�6A   $	��Top=�6k   $��92��6�   {�.  ��6�   �� $ StudentName�$ TwoWay=� .  . 6�   �� 5      -   5        $��textBlockStudentName��5   V   $��23��6   $
��Left=�6(   $��	37,51,0,0q�6C   $��enter student name��6r   $	��Top=�6�   $	��115��6�   �� 5      -   5        $��txtStudentPassword��5   U   $��23��6   $
��Left=�6&   $��
169,77,0,0q�6A   $	��Top=�6o   $��92��6�   {�.  ��6�   �� $ StudentPassword�$ TwoWay=� .  . 6�   �� 5      -   5        $��textBlockStudentPassword��5   V   $��23��6   $
��Left=�6(   $��	37,80,0,0q�6C   $��enter password��6v   $	��Top=�6�   $	��115��6�   �� 5      -	   5        $��	btnSearch��5   d   $��Search��6   $��23��6*   $
��Left=�66   $��	6,109,0,0q�6Q   $	��Top=�6u   $	��115��6�   ���	#FF8D8DD4���	#FF7BABDF$
��Bold"�6�   $��Italic$�6�   �� 5      -
   5        $��btnSave��5   j   $��Save changes��6   $��23��60   $
��Left=�6<   $��	6,138,0,0q�6W   $	��Top=�6y   $	��115��6�   ���	#FF8D8DD4���	#FF7BABDF$
��Bold"�6�   $��Italic$�6�   �� 5      -   5        $��	btnDelete��5   l   $��Delete student��6   $��23��62   $
��Left=�6>   $��	6,167,0,0q�6Y   $	��Top=�6}   $	��115��6�   ���	#FF8D8DD4���	#FF7BABDF$
��Bold"�6�   $��Italic$�6�   �� 5      -   5        $��	txtNumber��5   V   $��23��6   $
��Left=�6&   $��182,125,0,0q�6A   $	��Top=�6g   $��79��6   �� 5      -   5        $��
txtMessage��5   V   $��23��6   $
��Left=�6&   $��182,154,0,0q�6A   $	��Top=�6h   $��79��6�   �� 5      -   5        $��btnSend��5   h   $��Send msg��6   $��23��6,   $
��Left=�68   $��182,183,0,0q�6S   $	��Top=�6w   $��75��6�   ���	#FF8D8DD4���	#FF7BABDF$��Italic$�6�   �� 5      -   5        $��textBlockNumber��5   X   $��23��6   $
��Left=�6(   $��151,128,0,0q�6C   $	��To:��6o   $	��Top=�6z   $��25��6�   �� 5      -   5        $��textBlockMessage��5   X   $��23��6   $
��Left=�6(   $��151,157,0,0q�6C   $
��Msg:��6p   $	��Top=�6|   $��28��6�   �� 5      -   5        $��txtEmailAdd��5   T   $��23��6   $
��Left=�6&   $��	6,201,0,0q�6A   $	��Top=�6g   $	��115��6   �� 5      -   5        $��txtEmail��5   T   $��23��6   $
��Left=�6&   $��	6,230,0,0q�6A   $	��Top=�6d   $	��115��6|   �� 5      -   5        $��btnSendEmail��5   j   $��
Send Email��6   $��23��6.   $
��Left=�6:   $��182,229,0,0q�6U   $	��Top=�6~   $��75��6�   ���	#FF8D8DD4���	#FF7BABDF$��Italic$�6�   6�   5      5      5      5       