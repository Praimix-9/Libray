   M S B A M L   `   `   `  ����A  =Libray, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LibrayLibray  5          Libray.Enter   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Libray     5        N� Title$  Enter��5	      .��5      � .+�5   
   �� $	��550��6   $	��400��6    
�������$��Center=�6B   $��Center=�6_    �� Padding$ 30q�6z    �� CornerRadius$ 20��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ Orange��63      ShadowDepth$ 0Q�6B   ._�5      �� .+�5      � $��0, 0, 0, 20q�6   .+�5      �� $��Center=�6   
���� ��
�������.��6a   
Вход6g   5      �� 5      Введите логин6+   �� 5      -   5        $��Login_enter��5      �� 5       J� IsHitTestVisible .  $'��! Введите ваш логин��65   $��Center=�6O   $
��Left=�6j   $��	0,-20,0,0q�6�   
���������5      �� 5       �� 
TargetType" ��6    .�5      �� 	 �� Property	 � y�
 �� Value$
 	Collapsed=�6;    �� Triggers 5      �� 5   "    �� Binding 6.   �� *Text+ �� ElementName$ Login_enter�� �� Value  6`   .a�5   &   �� 	 � y�$
 Visible=�6C   5   #   5      5!      �� 5"      $��0, 10, 0, 0q�6   Введите пароль6A   G� 5#      -   5        $��Password_enter��5#      �� 5$      -   5        $��0, 20q�5$   ,   .��6;   
Войти6B   5%      5&      5'      5(      