   M S B A M L   `   `   `  ����H  DReceptProjekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ReceptProjekt.ViewsReceptProjekt.Views  5      9!clr-namespace:ReceptProjekt.ViewsReceptProjekt.Views  5      C&clr-namespace:ReceptProjekt.ViewModelsReceptProjekt.ViewModels  5	      $    ReceptProjekt.Views.MainWindow   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:ReceptProjekt.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      2view!clr-namespace:ReceptProjekt.Views     5      <	viewmodel&clr-namespace:ReceptProjekt.ViewModels     5	        � Title$  
MainWindow��5
      $	��800��5      $	��450��5       � 	Resources 5       �� DataType/   )ReceptProjekt.ViewModels.BelepesViewModel!   ReceptProjekt.Views.Belepes.   (ReceptProjekt.ViewModels.ReceptViewModel$   ReceptProjekt.Views.ReceptView,   &ReceptProjekt.ViewModels.CikkViewModel"   ReceptProjekt.Views.CikkView/   )ReceptProjekt.ViewModels.SzemelyViewModel%   ReceptProjekt.Views.SzemelyView��%,  (��       5      *, +)(�� 2     5      *, +)(�� d     5      *, +)(�� �     5      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $��* �6   �� 5       $��30 �6    � ColumnDefinitions 5"   
   �� 5#      $	��250 �6   �� 5$      $��* �6   .+�5&   
   #	   ReceptProjekt.Views.LeftPanel	  $��2��6   $��0��6+   
   ReceptProjekt.Views.Menu
  5'   
   $��0��6   $��2��6"   �� 5(   
   $��1��5)      $��1��5*      ��5+      �� *ChildViewModel+�� 5,   
   $��2��5-      $��2��5.      $��30��5/      
���"�"�.@�51      ��  �� Orientation$ 
Horizontal=�6   .+�53      �� $��10,0,0,0q�6   $6��0Az oldalt szerkesztették:  Komiszár János és��6.   �� 54      $��30,0,0,0q�6   $��Vida-Szücs Gellért��6.   56      57      58      5:      