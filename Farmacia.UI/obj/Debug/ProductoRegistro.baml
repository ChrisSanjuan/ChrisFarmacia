   M S B A M L   `   `   `  ����F  BFarmacia.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Farmacia.UIFarmacia.UI  5   	   "    Farmacia.UI.ProductoRegistro   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Farmacia.UI     5   	     � Title$  ProductoRegistro��5   	   $	��500��6"   $	��430��6/   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��25(�6   $��Center=�6   $��0��6;   .��6H   
Producto6R   � 5   
   $��1��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $	��400��6   6&   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��110��6   .��6$   Nombre6,   �� 5      -   5         ��Name$ txbNombreProducto��5      $	��290��65   6C   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��400��6   6&   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��110��6   .��6$   	Categoria6/   �� 5      -   5        $ txbCategoria��5      $	��290��60   6>   5       �� 5!      $ 
Horizontal=�6   .+�5"      �� $	��400��6   6&   5#      �� 5$      $ 
Horizontal=�6   .+�5%      �� $	��110��6   .��6$   Descripcion61   �� 5&      -   5        $ txbDescripcion��5&      $	��290��62   6@   5'      �� 5(      $ 
Horizontal=�6   .+�5)      �� $	��400��6   6&   5*      �� 5+      $ 
Horizontal=�6   .+�5,      �� $	��110��6   .��6$   Precio de Compra66   �� 5-      -   5        $ txbPrecioCompra��5-      $	��290��63   6A   5.      �� 5/      $ 
Horizontal=�6   .+�50      �� $	��400��6   6&   51      �� 52      $ 
Horizontal=�6   .+�53      �� $	��110��6   .��6$   PrecioVenta61   �� 54      -   5        $ txbPrecioVenta��54      $	��290��62   6@   55      �� 56      $ 
Horizontal=�6   .+�57      �� $	��400��6   6&   58      �� 59      $ 
Horizontal=�6   .+�5:      �� $	��110��6   .��6$   
Cantidad6.   �� 5;      -   5        $ txbCantidad��5;      $	��290��6/   6=   5<      �� 5=      $ 
Horizontal=�6   .+�5>      �� $	��400��6   6&   5?      5@      � 5A   
   $��2��6   .+�5B      �� -   5         ��Name$ btnNuevoProducto��5B       $��80��6   .��6Y   Nuevo6`   �� 5C      -   5        $ btnGuardarProducto��5C       $��80��6   .��6]   	Guardar6f   �� 5D      -	   5        $ btnEditarProducto��5D       $��80��6   .��6[   Editar6c   �� 5E      -
   5        $ btnCancelarProducto��5E       $��80��6   .��6_   
Cancelar6i   �� 5F      -   5        $ btnEliminarProducto��5F       $��80��6   .��6_   
Eliminar6i   �� 5G      -   5        $ btnRegresarMenu��5G       $��80��6   .��6W   
Regresar6a   5H      &   System.Windows.Controls.DataGrid  5I   
   -   5          Name$ dtgProductos��5I         
IsReadOnly . $��3��6;   5J      5K      