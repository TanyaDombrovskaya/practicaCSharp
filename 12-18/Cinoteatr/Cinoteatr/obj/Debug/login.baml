   M S B A M L   `   `   `  ����D  @Cinoteatr, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Cinoteatr	Cinoteatr  5   	       Cinoteatr.login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Cinoteatr     5   	   -   5          �Name$  	LoginForm��5   	    � Title$ login��5   	   $	��221��6   $	��490��6$    � 	Resources 5
         ButtonTemplate �� 
TargetType ��Name �� CornerRadius �� Padding �� Triggers P� Property	 P� Value
 �� 
TargetName �� Property �� Value��%�  &	        �� 5   
   " ��61   .R�5      �� $ border��6   
����ح�$ 5��6<   $ 5q�6M   ._�5      �� $��Center=�6#   $��Center=�6@   5       5      P� 5       �@J�IsMouseOver	 . . �5      �� $
 border��6    � ��
 ����6G   5      P� 5       � ��	 . . �5      �� $
 border��6    � ��
 ��·�6G   5      5      5      .��5      � $��10,10,10,-6q�6   .+�5   
   �� $(��"Электронная почта:��6   $
��Left=�6-   $	��Top=�6H   �� 5   
   -   5         ��Name$ emailTextBox��5      $	��200��6(   $	��Top=�64   $��0,25,0,0q�6L   �� 5   
   $��Пароль:��6   $
��Left=�6"   $	��Top=�6=   $��0,60,0,0q�6U   G� 5   
   -   5         G�Name$ passwordBox��5      $	��200��6+   $	��Top=�67   $��0,85,0,0q�6O   �� 5!   
   -   5         ��Name$ loginButton��5!      #��[  6&   $��
Войти��6Q   $	��100��6a   $	��Top=�6m   $��	0,120,0,0q�6�   6�   5"      5#      