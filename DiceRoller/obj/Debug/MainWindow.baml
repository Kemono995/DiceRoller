   M S B A M L   `   `   `  ����E  ADiceRoller, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DiceRoller
DiceRoller  5   	       DiceRoller.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:DiceRoller     5   	     � Title$  Dice Roller��5   	   $��261.548��6   $��248.35��6.    � WindowStartupLocation$ CenterScreen=�6=    � 
ResizeMode$ NoResize=�6b   .��5	      � $��0,0,0,1q�6   .+�5
   
   �� $��Result:��6   $
��Left=�6"   $��
14,155,0,0q�6=   $	��Top=�6Q   �� 5   
   $
��Left=�6   {�.  $��23��6?   $��110,158,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $	��Top=�6�   $	��120��6�   ��6t   ��  �� Path$ Result�6�   �� 5   
   $
��Roll��6   $
��Left=�6    $��157,200,0,0q�6;   $	��Top=�6P   $��75��6h   ��6s   �� $ ExecuteCommand�	� 5   
   -   5        $��Total��5       	� 	GroupName$ RollingMode��6&    d� 	IsChecked$
 TrueY�6>   $
��Left=�6O   $��	15,12,0,0q�6j   $	��Top=�6}   6�   	� 5   
   -   5        $��Average��5      $ RollingMode��6(   $
��Left=�6@   $��
110,15,0,0q�6[   $	��Top=�6o   6�   �� 5   
   $��Dice:��6   $
��Left=�6    $��	14,34,0,0q�6;   $	��Top=�6N   �� 5   
   $
��Left=�6   $��23��6-   $��
112,37,0,0q�69   $
 Wrap=�6M   $	��Top=�6�   $��42��6�   ��6a   �� $ 
DiceNumber�6�   �� 5   
   $��d��6   $
��Left=�6   $��
154,37,0,0q�67   $	��Top=�6K    J� RenderTransformOrigin$ 3.919,-0.233&�6c   $��21��6�   �� 5   
   $
��Left=�6   $��23��6-   $��
180,37,0,0q�69   $
 Wrap=�6M   $	��Top=�6�   $��40��6�   ��6a   �� $ DiceSize�6�   	� 5   
   -   5        $��Regular��5      $ AdvantageMode��6(   $
 TrueY�6B   $
��Left=�6S   $��	14,71,0,0q�6n   $	��Top=�6�   6�   	� 5   
   -   5        $��	Advantage��5      $ AdvantageMode��6*   $
��Left=�6D   $��	14,96,0,0q�6_   $	��Top=�6r   6�   	� 5   
   -   5        $��Dissadvantage��5      $ AdvantageMode��6.   $
��Left=�6H   $��
112,96,0,0q�6c   $	��Top=�6w   $ 0.502,-2.168&�6�   6�   �� 5   
   $��Reroll bellow:��6   $
��Left=�6)   $��
14,116,0,0q�6D   $	��Top=�6X   �� 5   
   $
��Left=�6   $��23��6-   $��112,119,0,0q�69   $
 Wrap=�6N   $	��Top=�6�   $	��120��6�   ��6b   �� $ RerollLimit�6�   5      5      