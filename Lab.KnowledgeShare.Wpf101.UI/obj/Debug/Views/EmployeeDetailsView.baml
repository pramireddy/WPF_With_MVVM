   M S B A M L   `   `   `  ����W  SLab.KnowledgeShare.Wpf101.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Lab.KnowledgeShare.Wpf101.UI.Views"Lab.KnowledgeShare.Wpf101.UI.Views  5   	   <    6Lab.KnowledgeShare.Wpf101.UI.Views.EmployeeDetailsView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:Lab.KnowledgeShare.Wpf101.UI.Views     5   	     � Title$  EmployeeDetails��5   	   $	��300��6!   $	��600��6.    � DataContext 5	   	   ��    viewModelLocator �� Source# [   �� Path$ EmployeeDetailsViewModel�.��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   $��0��6>   $	��400��6K   .+�5      �� $��FirstName: ��6   $
��Bold"�6*   $��0��6<   $��0��6L   �� 5      $��1��6O   ��6   �� *SelectedEmployee.FirstName+ �� Mode$ TwoWay=�6O   5      �� 5   
   $ 
Horizontal=�6   $��0��6.   $��1��6>   $	��400��6K   .+�5      �� $��
Position: ��6   $
��Bold"�6)   $��0��6;   $��1��6K   �� 5      $��1��6N   $��1��6^   ��6   �� *SelectedEmployee.Position+$ TwoWay=�6^   5      �� 5   
   $ 
Horizontal=�6   $��0��6.   $��2��6>   $	��400��6K   .+�5      �� $��Salary: ��6   $
��Bold"�6'   $��0��69   $��2��6I   �� 5      $��1��6{   $��2��6�   ��6   �� *SelectedEmployee.Salary+$ TwoWay=�  localPriceConverter �� 	Converter# [ 6�   5      5       5!      