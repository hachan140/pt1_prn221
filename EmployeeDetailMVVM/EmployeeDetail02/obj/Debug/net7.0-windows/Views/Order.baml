   M S B A M L   `   `   `  ����K  GEmployeeDetail02, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:EmployeeDetail02.ViewsEmployeeDetail02.Views  5   	   "    EmployeeDetail02.Views.Order   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:EmployeeDetail02.Views     5   	     � Title$  Order��5   	   $	��450��6   $	��800��6$   .��5	      � .+�5
   
   �� 
����ح� �� Orientation$ Vertical=�6,   $
��Left=�5      $	��400��68   .+�5      �� -   5        $��lbTitle��5      
���  ��$��DemiBold"�64   $��20(�6J   $��Order��6X   �� 5      -   5        $��	lbOrderID��5      $��OrderID��6%   �� 5      -   5        $��
txtOrderID��5      $��Stretch=�6(   $��25��5      ��5      ��  �� Path$ OrderId� �� Mode$ OneWay=� � DataContext 5      ��  �� ElementName$ lvCars��$ SelectedItem��� 5      -   5        $��lbDate��5      $
��Date��6"   �� 5      -   5        $��txtDate��5      $��Stretch=�6%   $��25��5      ��5      �� $
 Date�$ OneWay=� �� StringFormat$ {0:dd/MM/yyyy}�� 5      �� $ lvCars��$ SelectedItem��� 5      -   5        $��lbCustomerID��5      $��
CustomerID��6(   �� 5      -   5        $��txtCustomerID��5      $��Stretch=�6+   $��25��5      ��5      �� $ 
CustomerId�$ OneWay=� 5      �� $ lvCars��$ SelectedItem��� 5       -   5        $��lbTotalPayment��5       $��TotalPayment��6*   �� 5!      -	   5        $��txtTotalPayment��5!      $��Stretch=�6-   $��25��5"      ��5#      �� $ TotalPayment�$ {0:N3}��$ OneWay=� 5%      �� $ lvCars��$ SelectedItem�5'      �� 5(   
   -
   5        $��OrderDetail��5(      $
��Left=�6D   $��
37,281,0,0q�6_   $	��Top=�6s    J� RenderTransformOrigin$ 0.429,-0.499&�6�   $��24��6�   $��81��6�   �� 5)   
   -   5        $��txtFindOrder��5)      $
��Left=�6&   $��
583,62,0,0q�6A    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��120��6�   �� 5*   
   -   5        $��	FindOrder��5*      $
��Left=�6%   $��
583,98,0,0q�6@   $	��Top=�6T   6l   �� 5+   
   $��
Discount: ��6   $
��Left=�6%   $��583,162,0,0q�6@   $	��Top=�6U   �� 5,   
   -   5        $��txtDiscount��5,      $
��Left=�6%   $��651,166,0,0q�6@   $
 Wrap=�6U   $	��Top=�6i   $	��120��6�   5-      5.      