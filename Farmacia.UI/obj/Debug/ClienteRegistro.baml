   M S B A M L   `   `   `  ����F  BFarmacia.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Farmacia.UIFarmacia.UI  5   	   !    Farmacia.UI.ClienteRegistro   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Farmacia.UI     5   	     � Title$  ClienteRegistro��5   	   $	��500��6!   $	��430��6.   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��25(�6   $��Center=�6   $��0��6;   .��6H   	Cliente6Q   � 5   
   $��1��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $	��400��6   6&   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��100��6   .��6$   Nombre6,   �� 5      -   5         ��Name$ txbNombreCliente��5      $	��300��64   6B   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��400��6   6&   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��100��6   .��6$   	Apellidos6/   �� 5      -   5        $ txbApellidosCliente��5      $	��300��67   6E   5       �� 5!      $ 
Horizontal=�6   .+�5"      �� $	��400��6   6&   5#      �� 5$      $ 
Horizontal=�6   .+�5%      �� $	��100��6   .��6$   	Direccion6/   �� 5&      -   5        $ txbDireccion��5&      $	��300��60   6>   5'      �� 5(      $ 
Horizontal=�6   .+�5)      �� $	��400��6   6&   5*      �� 5+      $ 
Horizontal=�6   .+�5,      �� $	��100��6   .��6$   RFC6)   �� 5-      -   5        $ txbRFC��5-      $	��300��6*   68   5.      �� 5/      $ 
Horizontal=�6   .+�50      �� $	��400��6   6&   51      �� 52      $ 
Horizontal=�6   .+�53      �� $	��100��6   .��6$   
Telefono6.   �� 54      -   5        $ txbTelefono��54      $	��300��6/   6=   55      �� 56      $ 
Horizontal=�6   .+�57      �� $	��400��6   6&   58      �� 59      $ 
Horizontal=�6   .+�5:      �� $	��100��6   .��6$   Correo6,   �� 5;      -   5        $ 	txbCorreo��5;      $	��300��6-   6;   5<      �� 5=      $ 
Horizontal=�6   .+�5>      �� $	��400��6   6&   5?      5@      � 5A   
   $��2��6   .+�5B      �� -   5         ��Name$ btnNuevoCliente��5B       $��80��6   .��6W   Nuevo6^   �� 5C      -   5        $ btnGuardarCliente��5C       $��80��6   .��6[   	Guardar6d   �� 5D      -	   5        $ btnEditarCliente��5D       $��80��6   .��6Y   Editar6a   �� 5E      -
   5        $ btnCancelarCliente��5E       $��80��6   .��6]   
Cancelar6g   �� 5F      -   5        $ btnEliminarCliente��5F       $��80��6   .��6]   
Eliminar6g   �� 5G      -   5        $ btnRegresarMenu��5G       $��80��6   .��6W   
Regresar6a   5H      &   System.Windows.Controls.DataGrid  5I   
   -   5          Name$ dtgClientes��5I         
IsReadOnly . $��3��6:   5J      5K      