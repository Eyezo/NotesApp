   M S B A M L   `   `   `  ����J  FMyCuteClientApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:MyCuteClientApp.CuteServiceMyCuteClientApp.CuteService  5   �        MyCuteClientApp.ViewBudget   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   F   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   8my)clr-namespace:MyCuteClientApp.CuteService     6�   -   5          � Title$  
ViewBudget��5   	   $	��300��6   $	��300��6)    � 	Resources 5         budgetDetailViewSource��%   &	        �� 5   
   6   5      .��5      � -   5        $��BScreen��5      $
��Auto��6   .+�5	   
   ��   RadialBrush#��[ 6   ._�5
      �  � DataContext# [  6   .+�5      �� -   5        $��txtBudgetId��5   T   $��23��6   $
��Left=�6&   $��	152,6,0,0q�6A   $	��Top=�6g   $��86��6   ��6�   ��  �� Path$ budgetId� �� Mode$ TwoWay=� �� ValidatesOnExceptions .  �� NotifyOnValidationError . �� 5      -   5        $��textBlockBudhetId��5   U   $��23��6   $
��Left=�6(   $��14,9,0,0q�6C   $��enter budget ID��6n   $	��Top=�6�   $��97��6�   �� 5      -   5        $��txtBudgetItem��5   U   $��23��6   $
��Left=�6&   $��
150,35,0,0q�6A   $	��Top=�6j   $��88��6�   {�.  ��6�   �� $ 
budgetItem�$ TwoWay=� .  . 6�   �� 5      -   5        $��textBlockBudhetItem��5   V   $��23��6   $
��Left=�6(   $��	14,38,0,0q�6C   $��
enter Item��6q   $	��Top=�6�   $��97��6�   �� 5      -   5        $��txtBudgetItemPrice��5   U   $��23��6   $
��Left=�6&   $��
150,64,0,0q�6A   $	��Top=�6o   $��88��6�   {�.  ��6�   �� $ budgetPrice�$ TwoWay=� .  . 6�   �� 5      -   5        $��textBlockBudgetItemPrice��5   V   $��23��6   $
��Left=�6(   $��	14,67,0,0q�6C   $��enter Item Price��6v   $	��Top=�6�   $��97��6�   �� 5      -	   5        $��txtStudentId��5   U   $��23��6   $
��Left=�6&   $��
150,93,0,0q�6A   $	��Top=�6i   $��88��6�   {�.  ��6�   �� $ 	studentId�$ TwoWay=� .  . 6�   �� 5      -
   5        $��textBlockStudentId��5   =   $��23��6   $��14,96,165,0q�6(   $��
student ID��6W   $	��Top=�6i   �� 5      -   5        $��	btnSearch��5   e   $��Search��6   $��23��6*   $
��Left=�66   $��
14,133,0,0q�6Q   $	��Top=�6v   $	��105��6�   ���	#FF8D8DD4���	#FF7BABDF$
��Bold"�6�   $��Italic$�6�    J� Opacity$	 100Q�6  �� 5      -   5        $��btnSave��5   k   $��Save changes��6   $��23��60   $
��Left=�6<   $��
14,162,0,0q�6W   $	��Top=�6z   $	��105��6�   ���	#FF7BABDF���	#FF8D8DD4$
��Bold"�6�   $��Italic$�6�   $	 100Q�6  5      5      5      5      