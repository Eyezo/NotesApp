   M S B A M L   `   `   `  ����J  FMyCuteClientApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:MyCuteClientApp.CuteServiceMyCuteClientApp.CuteService  5   �       MyCuteClientApp.Info   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   @   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6}   8my)clr-namespace:MyCuteClientApp.CuteService     6�   -   5          � Title$
  Info��5   	   $	��300��6   $	��479��6#    � 	Resources 5         projectDetailsViewSource��%   &	        �� 5   
   6   5      .��5      �  � DataContext# [  6   .+�5	   
   ��   RadialBrush#��[ 6   ._�5
      &   System.Windows.Controls.DataGrid  -   5        $��projectDetailsDataGrid��5
   w      AutoGenerateColumns .     EnableRowVirtualization . $	��200��6R      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   $	��399��6�   ���	#FFCDCFE8���	#FFDCE8EB��6_   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        groupNameColumn��,  &System.Windows.Controls.DataGridColumn   Header$ 
group Name��5   e      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6y   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6B   �� 
 �� Path$
 	groupName�6y     5      -   5        projectDescColumn��$ project Desc��5   i   $ SizeToHeader 6   	 6D   �� $
 projectDesc�6     5      -   5        projectIdColumn��$ 
project Id��5   e   $ SizeToHeader 6y   	 6B   �� $
 	projectId�6y     5      -   5        projectNameColumn��$ project Name��5   i   $ SizeToHeader 6   	 6D   �� $
 projectName�6     5      -   5        studentNumberColumn��$ student Number��5   m   $ SizeToHeader 6�   	 6F   �� $
 studentNumber�6�   5      5      5      5      