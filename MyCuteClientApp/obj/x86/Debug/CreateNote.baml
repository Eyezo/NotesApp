   M S B A M L   `   `   `  ����J  FMyCuteClientApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:MyCuteClientApp.CuteServiceMyCuteClientApp.CuteService  5   �        MyCuteClientApp.CreateNote   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   F   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   8my)clr-namespace:MyCuteClientApp.CuteService     6�   -   5          � Title$  
CreateNote��5   	   $	��500��6   $	��500��6)    � 	Resources 5         noteViewSource��%   &	        �� 5   
   6   5      .��5      � -   5        $��CNScrean��5      $
��Auto��6   .+�5	   
   ��   RadialBrush#��[ 6   ._�5
      �  � DataContext# [  6   .+�5      �� -   5        $��	txtNoteId��5   U   $��23��6   $
��Left=�6&   $��
215,56,0,0q�6A   $	��Top=�6f   $	��120��6~   ��6�   ��  �� Path$ noteId� �� Mode$ TwoWay=� �� ValidatesOnExceptions .  �� NotifyOnValidationError . �� 5      -   5        $��txtStudentId��5   V   $��23��6   $
��Left=�6&   $��215,185,0,0q�6A   $	��Top=�6j   $	��120��6�   ��6�   �� $ 	studentId�$ TwoWay=� .  . �� 5      -   5        $��textBlockNoteId��5   V   $��23��6   $
��Left=�6(   $��	36,59,0,0q�6C   $��enter note ID��6m   $	��Top=�6�   $	��107��6�   �� 5      -   5        $��textBlockNoteContent��5   W   $��23��6   $
��Left=�6(   $��
36,101,0,0q�6C   $��	make note��6s   $	��Top=�6�   $	��107��6�   �� 5      -   5        $��textBlockStudentId��5   W   $��23��6   $
��Left=�6(   $��
36,188,0,0q�6C   $��
student ID��6q   $	��Top=�6�   $	��107��6�   �� 5      -   5        $��txtNoteContent��5   V   $��39��6   $
��Left=�6&   $��215,101,0,0q�6A   $	��Top=�6l   $	��120��6�   ��6�   �� $ noteContent�$ TwoWay=� .  . &   System.Windows.Controls.DataGrid  5      -	   5        $��noteDataGrid��5   �      AutoGenerateColumns .     EnableRowVirtualization . $	��200��6V   $
��Left=�6c   $��	6,253,0,0q�6�   	   RowDetailsVisibilityMode$	 VisibleWhenSelected=�6�   $	��Top=�6�   $	��200��6  ���	#FFCDCFE8���	#FFDCE8EB��6~   �� 
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      -
   5        noteContentColumn��,  &System.Windows.Controls.DataGridColumn   Header$ note Content��5   m      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   �� $ noteContent�6�     5      -   5        noteIdColumn��$ note Id��5   c   $ SizeToHeader 6t    6C   �� $ noteId�6t     5      -   5        studentIdColumn��$ 
student Id��5   i   $ SizeToHeader 6}    6F   �� $ 	studentId�6}   5      �� 5      -   5        $��btnSave��5   c   $
��Save��6   $��27��6(   $
��Left=�64   $��
36,217,0,0q�6O   $	��Top=�6r   $��75��6�   ���	#FF8D8DD4���	#FF7BABDF$��Italic$�6�   $
��Bold"�6�   5      5      5      5      