   M S B A M L   `   `   `  ����A  =Libray, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LibrayLibray  5          Libray.Admin   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Libray     5        N� Title$  Admin��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��50 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��	DGridBook��5   N      AutoGenerateColumns .     
IsReadOnly . $
��auto��6A      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6%      Header$ Шифр��62   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *Cipher+6]     5      $
 auto 6%   $ Наименование��62    6H   �� *	Name_book+6h     5      $
 auto 6%   $ 
Автор��62    6A   �� *Author+6^     5      $
 auto 6%   $ Жанр��62    6@   �� *Genre+6\     5      $
 auto 6%   $) #Количество страниц��62    6N   �� *Number_of_pages+6t     5      $
 auto 6%   $ Издательство��62    6H   �� *Publishing_house+6o   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)      CellTemplate 5      �� 5      .R�5      �� -   5        $��5q�5   %   $��30��60   $��Center=�6<   
��� ���.��6   Редактировать6�   5      5      5       �� 5!   
   -   5        $��1��5!   '   $��Right=�64   .��6P   Удалить6Y   5"      5#      