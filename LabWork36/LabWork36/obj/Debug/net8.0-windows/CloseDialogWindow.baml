   M S B A M L   `   `   `  ����D  @LabWork36, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:LabWork36	LabWork36  5   	   !    LabWork36.CloseDialogWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:LabWork36     5   	     � Title$  DialogWindow��5   	   $	��300��6   $	��550��6+   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $<��6Вы хотите закрыть приложение?��6   $��20(�69   $��2��6G   $��Center=�6[    �� Padding$ 0,35,0,0q�6x   �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $��1��6;   $��10q�6K   .+�5      �� -   5         ��Name$ AcceptClosingButton��5      $
��Да��62   $	��100��6?   $��50��6K   $��20q�6W   $��20(�5      $
��Bold"�6#   
��� � � �� 	IsDefault$
 True��6G   6X   �� 5      -   5        $ CancelClosingButton��5      $��Нет��62   $	��100��6@   $��50��6L   $��20(�5      $
��Bold"�6#   
���  �� �� IsCancel$
 True��6F   5      �� 5   
   $��/question.png��6   $	��100��6'   $��1��63   5      5      