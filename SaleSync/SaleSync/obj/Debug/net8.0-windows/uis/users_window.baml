   M S B A M L   `   `   `  ����C  ?SaleSync, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SaleSync.uisSaleSync.uis  5   	       SaleSync.uis.users_window   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:SaleSync.uis     5   	     � WindowStyle$
  None=�5       � WindowStartupLocation$ CenterScreen=�6.    � AllowsTransparency$
 True��6S   
������  � Title$ users_window��5   	   $	��450��6   $
��1000��6+   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��1* �6   .+�5   
   �� -   5        $��../Resources/close.png��5      $��1��60    K� ZIndex$ 1��6@      imgClose#��[  6e    J� RenderTransformOrigin$ 0.473,0.558&�6�   6�   �� 5   
   ���#ffffff �� CornerRadius$ 10 10 10 10��6&   ._�5      �� .+�5      �� $��
USER TABLE��6     	titleText#��[ 6.   
���   �6f   &   System.Windows.Controls.DataGrid  5      $	��300��6   $��20q�6)      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 User_ID��6-   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 150 6>     5      $	 password��6-   $	
 150 6?     5      $	 	Full_Name��6-   $	
 150 6@     5      $	 Phone_Number��6-   $	
 150 6C     5      $		 NIC��6-   $	
 100 6:     5      $	 
Image_Path��6-   $	
 150 6A     5      $	 Admin��6-   $	
 150 6<   5      ]� 5       $��260 10q�6   .+�5!      �� $��10q�6   $
��Back��6*     dashbordbuttons#��[ 69   6d   �� 5"      $	�� 10q�6   $��Delete User��6+   #��[ 6A   6l   5#      5%      5'      5(      5)      