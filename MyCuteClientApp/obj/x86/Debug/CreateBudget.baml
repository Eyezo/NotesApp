   M S B A M L   `   `   `  ����J  FMyCuteClientApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:MyCuteClientApp.CuteServiceMyCuteClientApp.CuteService  5   �   "    MyCuteClientApp.CreateBudget   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   H   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   8my)clr-namespace:MyCuteClientApp.CuteService     6�   -   5          � Title$  CreateBudget��5   	   $	��500��6   $	��500��6+    � 	Resources 5         budgetViewSource��%   &	        �� 5   
   6   5      .��5      � -   5        $��CBScreen��5      $
��Auto��6   .+�5	   
   ��   RadialBrush#��[ 6   ._�5
      �  � DataContext# [  6   .+�5      �� -   5        $��txtBudgetId��5   U   $��23��6   $
��Left=�6&   $��
238,53,0,0q�6A   $	��Top=�6h   $	��120��6�   ��6�   ��  �� Path$ budgetId� �� Mode$ TwoWay=� �� ValidatesOnExceptions .  �� NotifyOnValidationError . �� 5      -   5        $��textBlockBudgetId��5   V   $��23��6   $
��Left=�6(   $��	47,56,0,0q�6C   $��enter budget ID��6o   $	��Top=�6�   $	��124��6�   �� 5      -   5        $��txtBudgetItem��5   U   $��23��6   $
��Left=�6&   $��
238,97,0,0q�6A   $	��Top=�6j   $	��120��6�   ��6�   �� $ 
budgetItem�$ TwoWay=� .  . �� 5      -   5        $��textBlockBudgetItem��5   W   $��23��6   $
��Left=�6(   $��
47,100,0,0q�6C   $��enter Item name��6r   $	��Top=�6�   $	��124��6�   �� 5      -   5        $��txtBudgetItemPrice��5   V   $��23��6   $
��Left=�6&   $��238,144,0,0q�6A   $	��Top=�6p   $	��120��6�   ��6�   �� $ budgetPrice�$ TwoWay=� .  . �� 5      -   5        $��textBlockBudgetItemPrice��5   W   $��23��6   $
��Left=�6(   $��
47,147,0,0q�6C   $��enter Item price��6w   $	��Top=�6�   $	��124��6�   �� 5      -	   5        $��txtStudentId��5   V   $��23��6   $
��Left=�6&   $��238,182,0,0q�6A   $	��Top=�6j   $	��120��6�   ��6�   �� $ 	studentId�$ TwoWay=� .  . �� 5      -
   5        $��textBlockStudentId��5   W   $��23��6   $
��Left=�6(   $��
47,185,0,0q�6C   $��enter student ID��6q   $	��Top=�6�   $	��124��6�   &   System.Windows.Controls.DataGrid  5      -   5        $��budgetDataGrid��5   �      AutoGenerateColumns .     EnableRowVirtualization . $	��172��6V   $
��Left=�6c   $��	6,270,0,0q�6�   	   RowDetailsVisibilityMode$	 VisibleWhenSelected=�6�   $	��Top=�6�   $	��287��6  ���	#FFCDCFE8���	#FFDCE8EB��6~   �� 
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        budgetIdColumn��,  &System.Windows.Controls.DataGridColumn   Header$ 	budget Id��5   g      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� $ budgetId�6z     5      -   5        budgetItemColumn��$ budget Item��5   k   $ SizeToHeader 6�    6G   �� $ 
budgetItem�6�     5      -   5        budgetPriceColumn��$ budget Price��5   m   $ SizeToHeader 6�    6H   �� $ budgetPrice�6�     5      -   5        studentIdColumn��$ 
student Id��5   i   $ SizeToHeader 6}    6F   �� $ 	studentId�6}   5      �� 5      -   5        $��btnSave��5   c   $
��Save��6   $��23��6(   $
��Left=�64   $��
47,232,0,0q�6O   $	��Top=�6r   $	��124��6�   ���	#FF8D8DD4���	#FF7BABDF$
��Bold"�6�   $��Italic$�6�   5      5      5      5       