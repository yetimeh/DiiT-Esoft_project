   M S B A M L   `   `   `  ����C  ?SaleSync, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SaleSync.uisSaleSync.uis  5   	       SaleSync.uis.profile_page   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:SaleSync.uis     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5       � WindowStyle$
 None=�6@    � AllowsTransparency$
 True��6g   
������  � Title$ profile_page��5   	   $	��450��6   $	��800��6+   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��.8* �6   �� 5      $	��.5* �6   .+�5   
   �� $��../Resources/close.png��6   $��1��60    K� ZIndex$ 1��6@      imgClose#��[  5       J� RenderTransformOrigin$ 0.473,0.558&�62   6X   �� 5   
    �� CornerRadius$ 
10 0 0 10 ��6   ���#ffffff._�5      �� .+�5      ]� .+�5      �� $��Profile Information��6      	titleText#��[ 6;   
���   �6^   5      ]� 5      $��20q�6   .+�5      �� $��Name of the user :      ��6      
normalText#��[ 6@   
���   �6f   �� 5      -   5         ��Name$ 	user_name��5       $
��Left=�64   $
��Left=�6O   $�� ��6e   #��[ 6m   
���   �6�   5      ]� 5      $��20q�6   .+�5      �� $*��$National Identity Card(NIC)  :      ��6    #��[ 6L   
���   �6r   �� 5      -   5        $ user_nic��5       $
��Left=�62   $
��Left=�6M   $�� ��6c   #��[ 6k   
���   �6�   5       ]� 5#      $��20q�6   .+�5$      �� $��Phone Number :      ��6    #��[ 6<   
���   �6b   �� 5%      -   5        $ user_phonenumber��5%       $
��Left=�6:   $
��Left=�6U   $�� ��6k   #��[ 6s   
���   �6�   5&      �� 5(      -   5        $��10 10q�5(   *   $
��Back��69     dashbordbuttons#��[ 6H   6s   5+      5,      �� 5.   
   $ 
0 10 10 0 ��6   $	��450��6,   ���#ffffff$��1��6N   ._�5/      �� .+�50      �� -   5        	 ��Name$	 proPic��50      $��\Resources/profile.png��6(   $	��150��6H   $	��200��6T   �� 51      -   5        $��Bottom=�51      $��Center=�64   $��\Resources/logout.png��6Q     	imgLogout#��[ 6p   6�   52      54      55      56      