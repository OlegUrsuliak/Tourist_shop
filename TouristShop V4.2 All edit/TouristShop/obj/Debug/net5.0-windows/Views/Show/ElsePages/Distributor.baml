   M S B A M L   `   `   `  ����F  BTouristShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:TouristShop.Views.Show.ElsePages TouristShop.Views.Show.ElsePages  5      2    ,TouristShop.Views.Show.ElsePages.Distributor   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:TouristShop.Views.Show.ElsePages     5        N� Title$  Distributor��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5       6!   �� 5!      6!   �� 5"      6!   �� 5#      6!   �� 5$      6!   .+�5(   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dgridMain��5(      $��0��6&   $��0��66   $��11��6C   $��9��6X   
�������$��30q�6|   $��16(�6�      Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      -   5        	colId��,  &System.Windows.Controls.DataGridColumn   Header$ Id��5*   K      
IsReadOnly$
 True��6W      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6i   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *id+6i     5+      -   5        colFullName��$
 Name��5+   W   $
 True��6e   $ * 6w    6:   �� *
fullName+6w     5,      -   5        
colCompany��$ Company��5,   U   $
 True��6f   $ * 6x    69   �� *	company+6x     5-      -   5        colPhoneNumber��$ Phone number��5-   ]   $
 True��6s   $ * 6�    6=   �� *phoneNumber+6�     5.      -   5        
colArrears��$ Arrears��5.   U   $
 True��6f   $ * 6x    69   �� *	arrears+6x     5/      -   5        colNotes��$ Notes��5/   Q   $
 True��6`   $ * 6r    67   �� *notes+6r   51      �� 53   
   -   5        	 ��Name$	 btnAdd��53      $��Додати��6!   $��1��62   $��2��6B   $��9��6V   $��5q�6c   6n   �� 54   
   -	   5        $	 	btnDelete��54      $��Видалити��6$   $��3��68   $��2��6H   $��9��6\   $��5q�6i   6t   �� 55   
   -
   5        $	 btnEdit��55      $��Редагувати��6"   $��5��67   $��2��6G   $��9��6[   $��5q�6h   6s   �� 56   
   -   5        $	 btnExit��56      $��
Вихід��6"   $��8��62   $��2��6B   $��9��6V   $��5q�6c   6n   57      58      