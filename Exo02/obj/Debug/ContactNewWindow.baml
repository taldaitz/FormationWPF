   M S B A M L   `   `   `  ����@  <Exo02, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Exo02Exo02  5   	       Exo02.ContactNewWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Exo02     5   	     � Title$  ContactNewWindow��5   	   $	��450��6"   $	��370��6/    � 
ResizeMode$ NoResize=�6;   .��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��0��6    .��6-   	Prénom :68   �� 5   
   -   5        $��tbPrenom��5   /   $��1��6   $��0��6"   $��	0,20,0,10q�6?   6T   �� 5   
   $��0��6   $��1��6    .��6-   Nom :65   �� 5   
   -   5        $��tbNom��5   /   $��1��6   $��1��6"   $��0,0,0,10q�6<   6P   �� 5    
   $��0��6   $��2��6    .��6-   Date Naissance :6@   (  "System.Windows.Controls.DatePicker  5!   
   -   5        $��dpDateNaissance��5!   2   $��1��6   $��2��6%   $��0,0,0,10q�6I   6]   �� 5#   
   $��0��6   $��3��6    .��6-   
Rôles :67   �� 5$   
   -   5        $��lbRole��5$   /   $��1��6   $��3��6"    �� SelectionMode$ Multiple=�6=   $��0,0,0,10q�6V   .@�5%      �� .��6   Admin6!   �� 5&      .��6   Développeur6'   �� 5'      .��6   Utilisateur6'   �� 5(      .��6   
Rédacteur6%   �� 5)      .��6   	Testeur6#   5*      �� 5,   
   $��0��6   $��4��6    .��6-   	Actif ?66   �� 5-   
   -   5        $��cbActif��5-   0   $��1��6   $��4��6#   6A   �� 5/   
   $��0��6   $��5��6    .��6-   	Email :66   �� 50   
   -   5        $��tbEmail��50   /   $��1��6   $��5��6"   $��0,0,0,10q�6>   6R   �� 52   
   -   5        $��0��52      $��6��6!   $��2��6.   .��6W   Créer Contact6f   54      55      