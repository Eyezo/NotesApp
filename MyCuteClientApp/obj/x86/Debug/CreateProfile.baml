   M S B A M L   `   `   `  ����J  FMyCuteClientApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:MyCuteClientApp.CuteServiceMyCuteClientApp.CuteService  5   �   #    MyCuteClientApp.CreateProfile   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   I   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   8my)clr-namespace:MyCuteClientApp.CuteService     6�   -   5          � Title$  CreateProfile��5   	   $	��500��6   $	��500��6,    � 	Resources 5         studentDetailViewSource  studentViewSource1��%:   &	        &	      �� 5   
   6   �� 5   
   6   5	      .��5
      � -   5        $��CPScreen��5
      $
��Auto��6    � DataContext# [  6)   .+�5   
   ��   RadialBrush#��[ 6   ._�5      � -   5        $��createProfile��5      # [  6(   .+�5      �� -   5        $��txtEnterStudentName��5   U   $��23��6   $
��Left=�6&   $��
269,94,0,0q�6A   $	��Top=�6p   $	��120��6�   �� 5      -   5        $��txtBlockEnterStudentName��5   V   $��23��6   $
��Left=�6(   $��	62,97,0,0q�6C   $��enter student Name��6v   $	��Top=�6�   $	��120��6�   �� 5      -   5        $��txtStudentPassword��5   V   $��23��6   $
��Left=�6&   $��269,123,0,0q�6A   $	��Top=�6p   $	��120��6�   �� 5      -   5        $��txtBlockStudentPassword��5   W   $��26��6   $
��Left=�6(   $��
62,126,0,0q�6C   $��enter Password��6v   $	��Top=�6�   $��96��6�   �� 5      -   5        $��btnSave��5   c   $
��Save��6   $��23��6(   $
��Left=�64   $��
62,174,0,0q�6O   $	��Top=�6r   $	��120��6�   $
��Bold"�6�   $��Italic$�6�   ���	#FF7BABDF���	#FF8D8DD46�   &   System.Windows.Controls.DataGrid  5      -	   5        $��studentDataGrid��5   �      AutoGenerateColumns .     EnableRowVirtualization . $	��200��6V   $
��Left=�6c   $��
30,253,0,0q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   $	��Top=�6  $	��264��63  ���	#FFCDCFE8���	#FFDCE8EB��6~   ��  �� Source# [    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -
   5        studentIdColumn��,  &System.Windows.Controls.DataGridColumn   Header$ 
student Id��5   i   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 SizeToHeader 6}   
   
IsReadOnly
 . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   ��  �� Path$ 	studentId�6�     5      -   5        studentNameColumn��$ Student Name��5   m   $	 SizeToHeader 6�   
 .  6H   �� $ StudentName�6�     5      -   5        studentPasswordColumn��$ Student Password��5   u   $	 SizeToHeader 6�      
Visibility$ Hidden=�6�    6L   �� $ StudentPassword�6�   5      �� 5      -   5        $��txtstudentNumber��5   U   $��23��6   $
��Left=�6&   $��
269,65,0,0q�6A   $	��Top=�6m   $	��120��6�   ��6�   �� $ 	studentId� �� Mode$ TwoWay=� �� ValidatesOnExceptions .  �� NotifyOnValidationError . # [ �� 5      -   5        $��textBlockStudentNumber��5   V   $��23��6   $
��Left=�6(   $��	62,68,0,0q�6C   $��enter student number��6t   $	��Top=�6�   $	��120��6�   5      5      5      5      