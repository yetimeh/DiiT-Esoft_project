   M S B A M L   `   `   `  ����C  ?SaleSync, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SaleSync.uisSaleSync.uis  5   	       SaleSync.uis.history   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:SaleSync.uis     5   	     � WindowStyle$
  None=�5       � AllowsTransparency$
 True��6.    � WindowStartupLocation$ CenterScreen=�6H   
������  � Title$ history��5	   	   $	��723��6   $
��1300��6&   .��5
      �  � RowDefinitions 5   
   �� 5      $
��1.5* �6   �� 5      $	��.5* �6   .+�5   
   �� -   5        $��../Resources/close.png��5       K� ZIndex$ 1��6F      imgClose#��[  6X    J� RenderTransformOrigin$ 0.473,0.558&�6z   $
��Left=�6�   $��1257,13,0,0q�6�   �� 5   
    �� CornerRadius$ 
10 10 0 0 ��6   ���#ffffff$��0��6@   ._�5      �� .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ sold_items_table��5      $��50 10q�65   $	��500��6D   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ItemCode��6-      MinWidth$	 150Q�6?     5      $
 ItemName��6-   $	 150Q�6?     5      $
 Purchased Price��6-   $	 150Q�6F     5      $
 PurchasedQuantity��6-   $	 110Q�6H     5      $
 SellingPrice��6-   $	 150Q�6C     5      $
 Sold Quantity��6-   $	 100Q�6D     5      $
 Profit Earned��6-   $	 150Q�6D   5       5!      5"      �� 5$   
   $ 
0 0 10 10 ��6   ���#ffffff$��1��6@   ._�5%      �  � ColumnDefinitions 5&      �� 5'      $
��1.5* �6'   �� 5(      $	��5.* �6'   .+�5+      �� $��0��6   ._�5,      �� .+�5-      �� $��Select Month : ��6$     
normalText#��[ 6;   
���   �6t   �� 5.      $��20q�6#   $	��150��6/   $��30��6;   .@�5/      �� $��January��6+   �� 50      $��February��6+   �� 51      $��March��6+   �� 52      $��April��6+   �� 53      $	��May��6+   �� 54      $
��June��6+   �� 55      $
��July��6+   �� 56      $��August��6+   �� 57      $��	September��6+   �� 58      $��Octomber��6+   �� 59      $��November��6+   �� 5:      $��December��6+   5;      �� 5=      $��10 10q�6!   $
��Back��60     dashbordbuttons#��[ 6?   6j   5?      5A      5B      5E      5F      5G      