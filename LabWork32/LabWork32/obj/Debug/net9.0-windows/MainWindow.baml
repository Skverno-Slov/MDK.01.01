   M S B A M L   `   `   `  ����D  @LabWork32, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:LabWork32	LabWork32  5   	       LabWork32.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:LabWork32     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
      �� 5   
   $	��300 �6   �� 5   
   $	��350 �6   �� 5   
   $��* �6    � RowDefinitions 5      �� 5   
   $��50 �6   �� 5   
   $	��100 �6   �� 5   
   $��* �6   .+�5      �� $��2��6   .+�5   
   �� $"Категория товаров:6(   �� 5   
   -   5         ��Name$ CategoriesListBox��5      $��Center=�5      ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   5      5      5      �� 5!      $��1��6   .+�5"   
   �� Сортировка:6!   �� 5#      -   5         ��Name$ SortingComboBox��5#      .@�5$      ��  �� 
IsSelected$
 True��6   .��61   #!Сначала недорогие6D   �� 5%      .��6   Сначала дорогие60   �� 5&      .��6   По новинкам6,   �� 5'      .��6   По скидке6*   �� 5(      .��6   *(По количеству отзывов66   �� 5)      .��6   /-Сначала с лучшей оценкой69   5*      5+      �� 5-   
   $��2��6   .+�5.   
   �� Наличие:6   �� 5/      -   5        $ AvailabilityCheckBox��5/      .@�50      �� $��В наличии��6    d� 	IsChecked$
 TrueY�6/   �� 51      $'��!Под заказ: сегодня��6   $
 TrueY�68   �� 52      $%��Под заказ: завтра��6   $
 TrueY�67   �� 53      $#��Под заказ: позже��6   $
 TrueY�66   �� 54      $��Нет в продаже��6   55      56      �� 58   
   $��1��6   $��1��6"   .+�59      �� -   5        $��CategoryTextBlock��59      �� 5:      -   5        $��SortingTextBlock��5:      �� 5;      -   5        $��AvailabilityTextBlock��5;      5<      d� 5=   
   -   5         d�Name$ SortingToggleButton��5=      $��1��64   $��1��6D   $��50��6Q   $��25��6\   5>      5?      