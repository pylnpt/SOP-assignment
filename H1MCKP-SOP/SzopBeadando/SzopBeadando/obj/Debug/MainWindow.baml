   M S B A M L   `   `   `  ����G  CSzopBeadando, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SzopBeadandoSzopBeadando  5   	   I)clr-namespace:SzopBeadando.MVVM.ViewModelSzopBeadando.MVVM.ViewModel  5   	   7 clr-namespace:SzopBeadando.ThemeSzopBeadando.Theme  5   	       SzopBeadando.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:SzopBeadando     5   	   ?	viewModel)clr-namespace:SzopBeadando.MVVM.ViewModel     5   	   2theme clr-namespace:SzopBeadando.Theme     5   	   $	��600��5   	   $	��920��6     � WindowStyle$
  None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � DataContext 5      /   )SzopBeadando.MVVM.ViewModel.MainViewModel  5   
   .��5      �� -   5        ���#272537 �� CornerRadius$ 10��5      $��2��5      ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       � RowDefinitions 5!      �� 5"      $��75 �6    �� 5#      .+�5&      �� $#��Energy Drink
Database Handler��6   $��Center=�5'      $
��Left=�5(      
�������$��22(�5*      $��20,0,0,0q�5+      �� 5,      $��0��6   $��1��5-       �� Orientation$ 
Horizontal=�5.      .+�5/      ��    VerticalSeparatorStyle#���   50      �� 52      $��Molnár Péter - H1MCKP��53      $��Center=�54      $
��Left=�55      
�������$��15(�57      $��	20,46,0,9q�58      59      �� 5;      -   5        $��2��5;        xButton#��[ 5<      $��50��5>      $��50��6    $��Right=�5?      �� 5B      $��1��6   .+�5C      	� $
��Home��6   $��50��5D      
�������$��14(�5F        MenuButtonTheme#��[ 5G       d� 	IsChecked$
 TrueY�5H      ��5I      �� *HomeviewCommand+	� 5M      $
��List��6   $��50��5N      
�������$��14(�5P      #��[ 5Q      ��5R      �� *ListViewCommand+� 5T      $	��250��6   � 5V      .+�5X      �� -   5        	 ��Name$	 usenameLabel��5X       $��Username��5Y       
�������$��12(�5[       $��24��5\       $��Center=�5]       $��Center=�5^       $��0,0,0,0q�6;   5_      � 5a      .+�5b      �� -   5        
 ��Name$
 UserNameTextBox��5b      ���#353340$	��200��5d      $��30��5e      $��Center=�5f      $
��Left=�5g      
�������$��5q�5i      5k      � 5l      .+�5m      �� -   5        $	 passwordLabel��5m       $��Password��5n       
�������$��12(�5p       $��24��5q       $��Center=�5r       $��Center=�5s       $��0,0,0,0q�5t       5v      � 5w      .+�5x      )   #SzopBeadando.Theme.PasswordBoxTheme  -   5          Name$ password��5x   -   $	��200��5z   %   $
��Left=�5{   %   $��Center=�5|   %   $��30��5}   %   $��5q�5~   %      Password 5y   %   �� *
Password+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�5~   %   5      � 5�      .+�5�      �� -   5         ��Name$ userBtn��5�      $��Login��5�      $��Center=�5�      $��Center=�5�      $	��150��5�      $��30��5�      $��5q�5�        RoundButton#��[ 5�      ��5�      �� *HomeviewCommand+5�      5�      5�      �� 5�      $��1��6   $��1��5�      $��10q�5�      ��5�      �� *CurrentView+5�      5�      5�      