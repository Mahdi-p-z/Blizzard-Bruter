   M S B A M L   `   `   `  ����K  GBlizzard Bruter1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Blizzard_Bruter1Blizzard_Bruter1  5   	       Blizzard_Bruter1.Window2   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Blizzard_Bruter1     5   	   -   5          � Title$  Brute Setting��5   	   $	��200��6   $	��350��6,    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	   ���#05678F � WindowStartupLocation$ CenterScreen=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   � -   5        ���#0f0f2d$��2��5       5      �� 5      $	��56* �6#   �� 5      $	��11* �6#   �� 5       $
��199* �6#   �� 5!      $	��18* �6#   �� 5"      $	��66* �6#   .+�5%      �� $��Brute Setting��6   
�������$��2��5'      $��Center=�5(      $��Center=�5)      $��Font/#Dosis)�5*      $��15(�5+      $��Medium"�5,      $��25��6,   $��67.8,5,34.4,0.4q�68   $��97��6Q   �� 5.      -   5        $
��Exit��5.      $��4��5/      
�������$��Medium"�51      $��12.579,0,2.821,0q�6)   ��55      �� 56       �� 
TargetType" ��6   .�57      ��  �� Property � �� �� Value$ Font/#dosis)�6C   �� 58       � �� �#80000067   �� 59       �@�Cursor$
 Hand��63   	 �� Triggers	 5:      P� 5;      
 P� Property
 �@J�IsMouseOver P� Value . . �5<   "   ��  � �� �#FF00006?   5=      5?      ��5A      �� 5B       �� 
TargetType" ��6&   .R�5C      �� $��45��6!   $��22��6,    �� CornerRadius$ 6��5D   !   #��z��5E   !   ._�5G      �� $��Center=�6/   $��Center=�5H   /   5J      5K      5M      5N      �� 5O   
   -   5        $��comboboxProxy��5O      ���#00B8F0$��1��6j   $
��Left=�6z   $��26.8,21.6,0,0q�6�   $��1��6�   $	��Top=�6�   $	��130��6�    �� SelectedIndex$ 0��6�   .@�5P      �� $��Http/s��6   �� 5Q      $��Socks4��6   �� 5R      $��Socks5��6   5S      �� 5T   
   -   5        $��	lblThread��5T      $��
Thread: 50��6!   $
��Left=�66   $��38,57.6,0,0q�6Q   $��1��6f   $	��Top=�6s   $��85��6�   $��25��6�   �� 5U   
   -   5        $��sliderThread��5U   :   $��1��6N   $
��Left=�6^   $��26.8,100.6,0,0q�6y   $��1��6�   $	��Top=�6�   $	��130��6�    � Maximum$	 150Q�6�    � Minimum$ 1Q�6�    � Value$ 50Q�6�    � SmallChange$ 1Q�6�    � LargeChange$ 10Q�6�    �� TickFrequency$ 1Q�6   �� IsSnapToTickEnabled . 6  5V      5W      