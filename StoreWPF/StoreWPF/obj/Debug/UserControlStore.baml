   M S B A M L   `   `   `  ����C  ?StoreWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:StoreWPFStoreWPF  5          StoreWPF.UserControlStore   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:StoreWPF     5      $	��736��5      $	��309��6+   
�������.��5      �   � ColumnDefinitions  5	   
   �� 5
      $
��135* �6   �� 5      $
��233* �6   .+�5   
   �� -   5         ��Name$ imageProduct��5      $��0��6&   � 5   
   $��1��6    � RowDefinitions 5      �� 5      $
��256* �6    �� 5      $	��53* �6    .+�5      �� -   5         ��Name$ productName��5   )   $��Название: ��6   $��20(�6>   $	��Top=�6L   $
��Left=�6d   �� 5      -   5        $ productDescription��5   )   $��Описание: ��6   $��20(�6E   $��Center=�6S   $
��Left=�6n   �� 5      -   5        $ productPrice��5   %   $��
Цена: ��6   $��20(�6;   $��Bottom=�6I   $
��Left=�6d   � 5      $��1��6     5      �� 5      $	��70* �6'   �� 5      $	��70* �6'   .+�5      �� -   5         ��Name$ 	buttonBuy��5   )   $��1��6   $y�Visible=�6<   $��Купить��6Q   $��Center=�6b   $��Center=�6}   $	��130��6�   6�   �� 5      -   5        $ buttonDelete��5   )   $��0��6   $��Удалить��6?   $��Center=�6Q   $y�Visible=�6l   $��Center=�6�   $	��120��6�   6�   �� 5      -   5        $ buttonPlusProduct��5   )   $��1��6   $y�Hidden=�6D   $��+��6X   $
��Left=�6d   $��Center=�6   $��40��6�   $��	141,0,0,0q�6�   6�   �� 5      -   5        $ buttonMinusProduct��5   )   $��1��6   $y�Hidden=�6E   $��-��6Y   $
��Left=�6e   $��Center=�6�   $��40��6�   $��51,0,0,0q�6�   �� 5      -	   5        $ amountAddProduct��5   (   $��1��6   $��1��6B   $y�Hidden=�6N   $��Center=�6b   $��Center=�6   $��38��6�   $��32��6�   5       5!      5"      5#      