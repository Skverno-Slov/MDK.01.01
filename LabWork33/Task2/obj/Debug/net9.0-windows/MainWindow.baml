   M S B A M L   `   `   `  ����@  <Task2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task2Task2  5   	       Task2.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5
         CopyPasswordTemplate��%x   &	        �� 5   
   .R�5      �� -   5        $)��#Скопировать пароль��5      62   5      5      .��5      �� .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ UsersDataGrid��5         CanUserAddRows$ False��5         CanUserDeleteRows$ False��5         GridLinesVisibility$ 
Horizontal=�5         AutoGenerateColumns$ False��5         Columns 5      5  /System.Windows.Controls.DataGridHyperlinkColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Адрес��6*   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 69   �� *	Address+0  *System.Windows.Controls.DataGridTextColumn  5      $ 
Логин��6%   	 64   �� *Login+  5      $ Пароль��6%   
   
IsReadOnly$

 True��65   	 6G   �� *HiddenPassword+  5      $ Категория��6%   	 68   �� *
Category+4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $ Архивный��6)   	 6;   �� *
IsArchived+4  .System.Windows.Controls.DataGridTemplateColumn  5      $) #Скопировать пароль��6)      CellTemplate# [  6E   5      5      5       