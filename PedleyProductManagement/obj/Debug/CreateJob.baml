   M S B A M L   `   `   `  ����R  NPedleyProductManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:PedleyProductManagementPedleyProductManagement  5   	   '    !PedleyProductManagement.CreateJob   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:PedleyProductManagement     5   	     � Title$  	CreateJob��5   	   $	��300��6   $	��300��6(   .��5	      �  � RowDefinitions 5
   
   �� 5      $��10 �6   �� 5      $��20 �6   �� 5      $��20 �6   �� 5      $��20 �6   �� 5      $��20 �6   �� 5      $��20 �6   �� 5      $��20 �6   �� 5      $��20 �6   �� 5      $��20 �6    � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��1��6$   $��Job Name��61   6C   �� 5   
   -   5        $��JobNameTextBox��5      $��2��6(   $��1��68   6G   �� 5   
   $��1��6   $��2��6$   $��Client Name��61   6F   �� 5    
   $��2��6   $��2��6"   61   �� 5"   
   $��1��6   $��3��6$   $��Date Created��61   6G   �� 5#   
   -   5        $��CurrentDateTextBox��5#      $��2��6,   $��3��6<   6K   �� 5%   
   $��1��6   $��4��6$   $��Check-Out By��61   6G   �� 5&   
   $��2��6   $��4��6"   61   �� 5(   
   $��1��6   $��5��6$   $��Check-In By��61   6F   �� 5)   
   $��2��6   $��5��6"   61   �� 5+   
   -   5        $��3��5+      $��6��6!   .��6F   Create6N   �� 5-   
   -   5        $��ErrorMsgTextBlock��5-      
���  ��$��2��6>   $��7��6N   $��2��6[   6q   50      51      