   M S B A M L   `   `   `  ����F  BFarmacia.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Farmacia.UIFarmacia.UI  5   	       Farmacia.UI.Ventas   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Farmacia.UI     5   	     � Title$  Ventas��5   	   $	��500��6   $	��700��6%   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��0��6%   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $	��130��6   .��6$   Nombre del Empleado69   �� 5      -   5         ��Name$ cmbEmpleado��5   '   $	��215��6   6>   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��130��6   .��6$   Nombre del Cliente68   �� 5      -   5        $ 
cmbCliente��5   '   $	��215��6   6=   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��130��6   .��6$   	Categoria6/   �� 5       -   5        $ cmbCategoria��5    '   $	��215��6   6?   5!      �� 5"      $ 
Horizontal=�6   .+�5#      �� $	��130��6   .��6$   	Productos6/   �� 5$      -   5        $ cmbProducto��5$   '   $	��215��6   6>   5%      5&      �� 5(   
   $��1��6   $��1��6%   .+�5)      �� $ 
Horizontal=�6   .+�5*      �� $	��350��6   6&   5+      5,      � 5.   
   $��1��6   $��2��6$   .+�5/      �� -   5         ��Name$ btnAgregarProducto��5/   !   $	��100��6   .��6=   Agregar Producto6O   50      �� 52   
   $��0��6   $��0��6%   .+�53      �� $ 
Horizontal=�6   .+�54      �� -   5        $ btnRegistrarEmpleado��54      $	��150��67   $��25��6C   .��6r   Registrar Empleado6�   55      �� 56      $ 
Horizontal=�6   .+�57      �� -   5        $ btnRegistrarCliente��57      $	��150��66   $��25��6B   .��6p   Registrar Cliente6�   58      �� 59      $ 
Horizontal=�6   .+�5:      �� -   5        $ btnRegistrarProducto��5:      $	��150��67   $��25��6C   .��6r   Registrar Producto6�   5;      5<      &   System.Windows.Controls.DataGrid  5>   
   -	   5          Name$ dtgProductos��5>         
IsReadOnly . $��1��6;   $��3��6K   � 5@   
   $��2��6   .+�5A      �� -
   5        $ btnNuevaVenta��5A       $��65��6   .��67   Nuevo6>   �� 5B      -   5        $ btnGuardarVenta��5B       $��65��6   .��69   	Guardar6B   �� 5C      -   5        $ btnEditarVenta��5C       $��65��6   .��68   Editar6@   �� 5D      -   5        $ btnCancelarVenta��5D       $��65��6   .��6:   
Cancelar6D   �� 5E      -   5        $ btnEliminarVenta��5E       $��65��6   .��6:   
Eliminar6D   5F      5G      5H      