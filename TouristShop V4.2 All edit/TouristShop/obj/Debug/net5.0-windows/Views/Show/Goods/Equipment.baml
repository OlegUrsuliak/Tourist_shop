   M S B A M L   `   `   `  ����F  BTouristShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:TouristShop.Views.Show.GoodsTouristShop.Views.Show.Goods  5      ,    &TouristShop.Views.Show.Goods.Equipment   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:TouristShop.Views.Show.Goods     5        N� Title$  	Equipment��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5       6!   �� 5!      6!   �� 5"      6!   �� 5#      6!   �� 5$      6!   .+�5&   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dgridMain��5&      $��0��6&   $��0��66   $��11��6C   $��9��6X   
�������$��30q�6|   $��16(�6�      Columns 5'      0  *System.Windows.Controls.DataGridTextColumn  5(      -   5        	colId��,  &System.Windows.Controls.DataGridColumn   Header$ Id��5(   K      
IsReadOnly$
 True��6W      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6i   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *id+6i     5)      -   5        colName��$
 Name��5)   O   $
 True��6]   $ * 6o    66   �� *name+6o     5*      -   5        	colNumber��$ Number��5*   S   $
 True��6c   $ * 6u    68   �� *number+6u     5+      -   5        colMass��$
 Mass��5+   O   $
 True��6]   $ * 6o    66   �� *mass+6o     5,      -   5        colPrice��$ Price��5,   Q   $
 True��6`   $ * 6r    67   �� *price+6r     5-      -   5        colDescription��$ Description��5-   ]   $
 True��6r   $ * 6�    6=   �� *description+6�     5.      -   5        colDistributorId��$ Distributor id��5.   b   $
 True��6z   $ * 6�    6?   �� *distributor_id+6�   50      �� 52   
   -	   5        	 ��Name$	 btnAdd��52      $��Додати��6!   $��1��62   $��2��6B   $��9��6V   $��5q�6c   6n   �� 53   
   -
   5        $	 	btnDelete��53      $��Видалити��6$   $��3��68   $��2��6H   $��9��6\   $��5q�6i   6t   �� 54   
   -   5        $	 btnEdit��54      $��Редагувати��6"   $��5��67   $��2��6G   $��9��6[   $��5q�6h   6s   �� 55   
   -   5        $	 btnExit��55      $��
Вихід��6"   $��8��62   $��2��6B   $��9��6V   $��5q�6c   6n   56      57      