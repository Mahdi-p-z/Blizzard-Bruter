   M S B A M L   `   `   `  ����K  GBlizzard Bruter1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Blizzard_Bruter1Blizzard_Bruter1  5   	   !    Blizzard_Bruter1.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Blizzard_Bruter1     5   	   -   5          � Title$  Blizzard Bruter��5   	   $	��300��6!   $	��500��6.    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	   ���#0f0f2d � Icon$ Image/download.png��5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   � -   5        ���#05678F$��2��5       5      �� 5      $	��56* �6#   �� 5       $	��11* �6#   �� 5!      $
��199* �6#   �� 5"      $	��18* �6#   �� 5#      $	��66* �6#   .+�5&      �� $#��Blizzard Bruter v2.1 [Ariaei]��6   
�������$��2��5(      $��Center=�5)      $��Center=�5*      $��Font/#Dosis)�5+      $��17(�5,      $��Medium"�5-      $��25��6,   $��18.8,5,0.4,0q�68   $	��180��6N   �� 5/      -   5        $
��Menu��5/      $��0��50      
�������$��Medium"�52      $��10,0,1,0q�6)   ��56      �� 57       �� 
TargetType" ��6   .�58      ��  �� Property � ��	 �� Value$	 Font/#dosis)�6C   �� 59       � ��	 �#39385d67   �� 5:       �@�Cursor$
	 Hand��63   
 �� Triggers
 5;      P� 5<       P� Property �@J�IsMouseOver P� Value . . �5=   "   ��  � ��	 �#3A39526?   5>      5@      ��5B      �� 5C       �� 
TargetType" ��6&   .R�5D      �� $��45��6!   $��22��6,    �� CornerRadius$ 6��5E   !   #��z��5F   !   ._�5H      �� $��Center=�6/   $��Center=�5I   /   5K      5L      5N      �� 5P      -   5        $
��Exit��5P      $��4��5Q      
�������$��Medium"�5S      $��12.579,0,2.821,0q�6)   ��5W      �� 5X      " ��6   .�5Y      ��  � ��$	 Font/#dosis)�6C   �� 5Z       � ��	 �#80000067   �� 5[       �@�Cursor$
	 Hand��63   
 5\      P� 5]       �@J�IsMouseOver . . �5^   "   ��  � ��	 �#FF00006?   5_      5a      ��5c      �� 5d      " ��6&   .R�5e      �� $��45��6!   $��22��6,   $ 6��5f   !   #��z��5g   !   ._�5i      �� $��Center=�6/   $��Center=�5j   /   5l      5m      5o      5p      �� 5q   
   $��0,0,0,0q�6   $��1��6&   .+�5r      ��  �� Orientation$ 
Horizontal=�6   .+�5s      �� -   5        $��btnStart��5y      $��Start��5s      $��	25,15,0,0q�5t      
�������$��Medium"�5v      $��12(�5w      ��5|      �� 5}      " ��6    .�5~      ��  � ��$	 Font/#dosis)�6G   �� 5       � ��	 �#402A9A6;   �� 5�       �@�Cursor$
	 Hand��67   
 5�      P� 5�   "    �@J�IsMouseOver . . �5�   &   ��  � ��	 �#3A39526C   5�   #   5�      ��5�      �� 5�      " ��6*   .R�5�      �� $	��120��6%   $��40��61   $ 12��5�   !   #��z��5�   !   ._�5�   "   �� $��Center=�63   $��Center=�5�   /   5�      5�      5�      5�      5�      �� 5�   
   $��0,0,0,0q�6   $��2��6&   $��1��6:   .+�5�      �� $ 
Horizontal=�6   .+�5�      �� -   5        $��btnBase��5�      $��	Load Base��5�      $��	25,70,0,0q�5�      
�������$��Medium"�5�      $��12(�5�      ��5�      �� 5�      " ��6    .�5�      ��  � ��$	 Font/#dosis)�6G   �� 5�       � ��	 �#402A9A6;   �� 5�       �@�Cursor$
	 Hand��67   
 5�      P� 5�   "    �@J�IsMouseOver . . �5�   &   ��  � ��	 �#3A39526C   5�   #   5�      ��5�      �� 5�      " ��6*   .R�5�      �� $	��120��6%   $��40��61   $ 12��5�   !   #��z��5�   !   ._�5�   "   �� $��Center=�63   $��Center=�5�   /   5�      5�      5�      5�      5�      �� 5�   
   $��0,0,0,0q�6   $��2��6&   $��1��6:   .+�5�      �� $ 
Horizontal=�6   .+�5�      �� -   5        $��btnIP��5�      $��Load IP��5�      $��
25,125,0,0q�5�      
�������$��Medium"�5�      $��12(�5�      ��5�      �� 5�      " ��6    .�5�      ��  � ��$	 Font/#dosis)�6G   �� 5�       � ��	 �#402A9A6;   �� 5�       �@�Cursor$
	 Hand��67   
 5�      P� 5�   "    �@J�IsMouseOver . . �5�   &   ��  � ��	 �#3A39526C   5�   #   5�      ��5�      �� 5�      " ��6*   .R�5�      �� $	��120��6%   $��40��61   $ 12��5�   !   #��z��5�   !   ._�5�   "   �� $��Center=�63   $��Center=�5�   /   5�      5�      5�      5�      5�      �� 5�   
   $��0,0,0,0q�6   $��2��6&   $��1��6:   .+�5�      �� $ 
Horizontal=�6   .+�5�      �� -   5        $��
textboxAPI��5�      $
��API:��5�      $��
20,190,0,0q�5�      $	��130��5�      $��17��5�      
�������{�.  .��5�   ?   ��5�      �� 5�      " ��6    .�5�      ��  � ��$	 Font/#dosis)�6G   �� 5�       � ��	 �#1D425C6;   �� 5�       �@�Cursor$
	 Hand��67   5�      .��5�   %   5�      5�      5�      �� 5�   
   $��0q�6   $��2��6    $��1��64   .+�5�      �� $ 
Horizontal=�6   .+�5�      �� -	   5        $��checkboxAPI��5�      $��Use IP From API��5�      $��
40,230,0,0q�5�      
������� � Cursor$
 Hand��5�      $��Font/#Dosis)�5�      ���#875ACF��5     �� 5     " ��6    
 5     P� 5  "    �@J�IsMouseOver . . �5	  &   ��  � ��	 �#7751B46C   5
  #   5     5     5     5     �� 5  
   $��0,0,0.4,-0.6q�6   $��1��6+   .+�5     �� $ 
Horizontal=�6   .+�5     �� $��Checked:��6   $��
165,15,0,0q�5     ���#fc6586$��Medium"�5     5     5     5     �� 5  
   $��1��5     $��2.6,0,0,-0.6q�6%   $��1��6;   .+�5     �� $ 
Horizontal=�6   .+�5     �� -
   5        $��
lblChecked��5#     $��0��5     $��Right=�5     ���#fc6586$��Medium"�5!     $��150,15,15,0q�5"     $��71��6-   5%     5&     5'     �� 5(  
   $��0,0,0.4,-0.6q�6   $��1��6+   .+�5)     �� $ 
Horizontal=�6   .+�5*     �� $��
Remaining:��6   $��
165,57,0,0q�5+     
�������$��Medium"�5-     5/     50     51     �� 52  
   $��1��53     $��2.6,0,0,-0.6q�6%   $��1��6;   .+�54     �� $ 
Horizontal=�6   .+�55     �� -   5        $��lblRemaining��5:     $��0��55     $��Right=�56     
�������$��Medium"�58     $��150,57,15,0q�59     $��71��6-   5<     5=     5>     �� 5?  
   $��0,0,0.4,-0.6q�6   $��1��6+   .+�5@     �� $ 
Horizontal=�6   .+�5A     �� $
��Hit:��6   $��
165,99,0,0q�5B     
��� � �$��Medium"�5D     5F     5G     5H     �� 5I  
   $��1��5J     $��2.6,0,0,-0.6q�6%   $��1��6;   .+�5K     �� $ 
Horizontal=�6   .+�5L     �� -   5        $��lblGood��5Q     $��0��5L     $��Right=�5M     
��� � �$��Medium"�5O     $��150,99,15,0q�5P     $��71��6-   5S     5T     5U     �� 5V  
   $��0,0,0.4,-0.6q�6   $��1��6+   .+�5W     �� $ 
Horizontal=�6   .+�5X     �� $
��2FA:��6   $��165,141,0,0q�5Y     
���i��$��Medium"�5[     5]     5^     5_     �� 5`  
   $��1��5a     $��2.6,0,0,-0.6q�6%   $��1��6;   .+�5b     �� $ 
Horizontal=�6   .+�5c     �� -   5        $��lbl2FA��5h     $��0��5c     $��Right=�5d     
���i��$��Medium"�5f     $��150,141,15,0q�5g     $��71��6.   5j     5k     5l     �� 5m  
   $��0,0,0.4,-0.6q�6   $��1��6+   .+�5n     �� $ 
Horizontal=�6   .+�5o     �� $��Fail:��6   $��165,183,0,0q�5p     
���  ��$��Medium"�5r     5t     5u     5v     �� 5w  
   $��1��5x     $��2.6,0,0,-0.6q�6%   $��1��6;   .+�5y     �� $ 
Horizontal=�6   .+�5z     �� -   5        $��lblBad��5     $��0��5z     $��Right=�5{     
���  ��$��Medium"�5}     $��150,183,15,0q�5~     $��71��6.   5�     5�     5�     �� 5�  
   $��0,0,0.4,-0.6q�6   $��1��6+   .+�5�     �� $ 
Horizontal=�6   .+�5�     �� $��Retry:��6   $��165,225,0,0q�5�     
��� ���$��Medium"�5�     5�     5�     5�     �� 5�  
   $��1��6   $��2.6,0,0,-0.6q�6%   $��1��6;   .+�5�     �� $ 
Horizontal=�6   .+�5�     �� -   5        $��lblError��5�     $��0��5�     $��Right=�5�     
��� ���$��Medium"�5�     $��150,225,15,0q�5�     $��71��6.   5�     5�     5�     �� 5�  
   -   5        $��	panelMenu��5�  a   $
��Left=�6   $	��106��60   $	��Top=�6=   $	��117��6U   ���#05678F$y�Hidden=�6�   $��1��6�   .+�5�     �� -   5        $��
btnSetting��5�     $��Setting��5�     
���   �$��3,3,3,0q�5�     $��10(�5�     $��Medium"�5�     ��5�     �� 5�     " ��6   .�5�     ��  � ��$	 Font/#dosis)�6C   �� 5�      � ��	 �#0692CB67   �� 5�      �@�Cursor$
	 Hand��63   
 5�     P� 5�      �@J�IsMouseOver . . �5�  "   ��  � ��
	 ���f�6?   5�     5�     ��5�     �� 5�     " ��6&   .R�5�     �� $	��110��6!   $��22��6-   $ 10��5�  !   #��z��5�  !   ._�5�     �� $��Center=�6/   $��Center=�5�  /   5�     5�     5�     �� 5�     -   5        $��
btnRestart��5�     $��Restart��5�     
���   �$��3,3,3,0q�5�     $��10(�5�     $��Medium"�5�     ��5�     �� 5�     " ��6   .�5�     ��  � ��$	 Font/#dosis)�6C   �� 5�      � ��	 �#85929E67   �� 5�      �@�Cursor$
	 Hand��63   
 5�     P� 5�      �@J�IsMouseOver . . �5�  "   ��  � ��	 �#2E40536?   5�     5�     ��5�     �� 5�     " ��6&   .R�5�     �� $	��110��6!   $��22��6-   $ 10��5�  !   #��z��5�  !   ._�5�     �� $��Center=�6/   $��Center=�5�  /   5�     5�     5�     �� 5�     -   5        $��btnMinimize��5�     $��Minimize��5�     
���   �$��3,3,3,0q�5�     $��10(�5�     $��Medium"�5�     ��5�     �� 5�     " ��6   .�5�     ��  � ��$	 Font/#dosis)�6C   �� 5�      � ��	 �#FF830067   �� 5�      �@�Cursor$
	 Hand��63   
 5�     P� 5�      �@J�IsMouseOver . . �5�  "   ��  � ��	 �#F966066?   5�     5�     ��5�     �� 5�     " ��6&   .R�5�     �� $	��110��6!   $��22��6-   $ 10��5�  !   #��z��5�  !   ._�5�     �� $��Center=�6/   $��Center=�5�  /   5�     5�     5�     �� 5�     -   5        $��btnAbout��5     $��About��5�     
���   �$��3,3,3,0q�5      $��10(�5     $��Medium"�5     ��5     �� 5     " ��6   .�5     ��  � ��$	 Font/#dosis)�6C   �� 5      � ��
	 �����67   �� 5	      �@�Cursor$
	 Hand��63   
 5
     P� 5      �@J�IsMouseOver . . �5  "   ��  � ��
	 �����6?   5     5     ��5     �� 5     " ��6&   .R�5     �� $	��110��6!   $��22��6-   $ 10��5  !   #��z��5  !   ._�5     �� $��Center=�6/   $��Center=�5  /   5     5     5     5     5      5!     