   M S B A M L   `   `   `  ����L  HHttpClientDemo-02, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HttpClientDemo_02HttpClientDemo_02  5   	   "    HttpClientDemo_02.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:HttpClientDemo_02     5   	     � Title$  Using HttpClient��5   	    � WindowStartupLocation$ CenterScreen=�5	   	   $	��450��5
   	   $	��350��6   .��5      � 
����ح� � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��Stretch=�6"   $��Stretch=�6>    �� Orientation$ Vertical=�6\   .+�5      �� -   5        $��lblURL��5      $	��URL��6"   �� 5      -   5        $��txtURL��5      $��http://www.contoso.com��6$   $��25��6B   �� 5      -   5        $��	lbContent��5      $��HTML Source��6%   5      �� 5   
   -   5        $��
txtContent��5      $��1��6    �� TextWrapping$
 Wrap=�61   $ �� HorizontalScrollBarVisibility$
 Auto=�5       �� AcceptsReturn$
 True��67   " �� VerticalScrollBarVisibility$ Visible=�5      �� 5    
   $��2��6   $ 
Horizontal=�6"   $��Center=�6;   $	��Top=�6X   .+�5"      �� -   5         ��Name$ btnViewHTML��5"      $
��25,5q�6*   $��80��68   $��	View HTML��6C   6W   �� 5$      -   5        $ btnClear��5$      $
��25,5q�6'   $��80��65   $��Clear��6@   6P   �� 5&      -   5        $ btnClose��5&      $
��25,5q�6'   $��80��65   $��Close��6@   6P   5'      5(      5*      