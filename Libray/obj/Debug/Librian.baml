   M S B A M L   `   `   `  ����A  =Libray, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LibrayLibray  5          Libray.Librian   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Libray     5      -   5          N� Title$  Librian��5	      .��5      �� .��5   
   �  � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $��50 �6    .+�5      &   System.Windows.Controls.DataGrid  -   5        $��	DGridBook��5   R      AutoGenerateColumns .     
IsReadOnly . $
��auto��6E      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6)      Header$ Шифр��66   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *Cipher+6a     5      $
 auto 6)   $ Наименование��66    6L   �� *	Name_book+6l     5      $
 auto 6)   $ 
Автор��66    6E   �� *Author+6b     5      $
 auto 6)   $ Жанр��66    6D   �� *Genre+6`     5      $
 auto 6)   $) #Количество страниц��66    6R   �� *Number_of_pages+6x     5      $
 auto 6)   $ Издательство��66    6L   �� *Publishing_house+6s   5      �� 5      -   5        $��1��5   )   $��Right=�66   .��6R   Добавить6\   5      5      5      