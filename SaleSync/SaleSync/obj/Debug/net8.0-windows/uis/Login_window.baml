   M S B A M L   `   `   `  ����C  ?SaleSync, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:esoftprojecttestesoftprojecttest  5   	   #    esoftprojecttest.Login_window   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:esoftprojecttest     5   	     � WindowStartupLocation$  CenterScreen=�5       � WindowStyle$
 None=�6?    � AllowsTransparency$
 True��6R   
������  � Title$ Login_window��5   	   $	��450��6   $	��800��6+   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��1.5* �6   .+�5   
   �� -   5        $��../Resources/close.png��5      $��1��60    K� ZIndex$ 1��6@      imgClose#��[  6i    J� RenderTransformOrigin$ 0.473,0.558&�6�   6�   �� 5   
    �� CornerRadius$ 	10 0 0 10��6   ��5      �� 5       �� 
StartPoint$	 0,0&�6&   	 �� EndPoint$		 1,1&�67   .��5      � 
 � Color$
 #1F5686��6#    � Offset$ 0Q�63   � 5      $
 #3AADA1��6#   $ 1Q�63   5      ._�5      �� $��Center=�6   .+�5      �� $��/Resources/profile.png��6   $	��150��68   $	��150��6D   �� 5      $<��6Enter your Employee or Admin id and enter the password��6     
normalText#��[ 6Z    J� Opacity$ 8Q�6~   $��20 30 q�6�   5      5      �� 5!   
   ���#ffffff$��1��6&   $ 	0 10 10 0��66   ._�5#      �� .+�5%      �� .+�5&      �� $��LOGIN��6      	titleText#��[ 6-   $��70 30q�6P   ���#3AB19B6_   5'      �� 5*      .+�5+      �� $��1q�6   ���#acb0af$��70 9 q�6G   $ 5��6V   ._�5,      � $	��7 9q�6    5-      �� 5.   "   $
��auto �63   �� 5/   "   $��* �63    � RowDefinitions 51      �� 52   "   $
��Auto �60   �� 53   "   $
��Auto �60   .+�55      �� $��/Resources/id-card.png��6$   $��20��6D   �� 56      -   5         ��Name$ textID��56   (   $��ID��6U     hintText#��[ 6_   �� 57      -   5         ��Name$ txtID��57   &     textBox#��[ 6V   58      59      5:      �� 5<      .+�5=      �� $��1q�6   ���#acd0af$
��70 7q�6G   $ 5��6U   ._�5>      � $	��7 9q�6    5?      �� 5@   "   $
��auto �63   �� 5A   "   $��* �63    5C      �� 5D   "   $
��Auto �60   �� 5E   "   $
��Auto �60   .+�5H      �� $��/Resources/off.png��6$   $��20��6@   �� 5I      -   5        $ textPassword��5I   (   $��Password��6b   #��[ 6r   G� 5J      -   5         G�Name$ txtPassword��5J   *   #��[ 6n   5K      5L      5M      �� 5P      -   5        $��LOGIN��5P        
mainbutton#��[ 6)   6M   �� 5Q      -   5        $��SIGNUP��5Q      #��[ 6@   5S      5U      5V      5W      