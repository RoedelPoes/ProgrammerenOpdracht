   M S B A M L   `   `   `  ����N  JWpfAppGridspelletje, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WpfAppGridspelletjeWpfAppGridspelletje  5   	   $    WpfAppGridspelletje.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WpfAppGridspelletje     5   	   -   5          �Name$  
mainWindow��5   	    � Title$ 
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      � 
�������.+�5   
   �� $
��Left=�6   $	��Top=�60   $��	25,50,0,0q�6H   $	��100��6[   .+�5      �� -   5         ��Name$ btnStartGame��5      $��Start the game��6C   $��25��6\   $��0,0,0,5q�6h   �� 5      -   5         ��Name$ tbTimer��5      $	��0,5q�6)   $��25��66    �� TextAlignment$ Center=�6B   
�������6Y   5      �� 5   
   -   5         ��Name$ options��5      $
��Left=�6&   $��Center=�6A   $��25,0,0,0q�6\   $	��100��6n   .+�5      �� -   5        $ tbSpeed��5      $��Speed Level: 6��6)   $ Center=�6?   $��25��6V   $	��0,5q�6b   
�������6o   �� 5      -   5        $ 	btnFaster��5      $��Faster��6=   $��25��6N   $	��0,5q�6Z   �� 5      -   5        $ 	btnSlower��5      $��Slower��6=   $��25��6N   $	��0,5q�6Z   �� 5      -   5        $ btnParty��5      $��
Party Mode��6;   $��25��6P   $	��0,5q�6\   
���  ��6i   �� 5      -	   5         ��Name$ cmbImage��5      .@�5      �� $
��Woud��6   �� 5      $��Dikzakje��6   �� 5      $	��Rat��6   5      5      � 5   
   -
   5         �Name$ gameGrid��5      $��150,50,50,50q�6!   
����ح�.+�5      �� -   5        $ btnCatch��5      {�.  $��50��5      $��50��6!   $
��Left=�6,   $	��Top=�6G   .��5      �� -   5         ��Name$ btnImage��5      5       5!      5"      5#      