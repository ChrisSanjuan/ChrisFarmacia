   M S B A M L   `   `   `  ����F  BFarmacia.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Farmacia.UIFarmacia.UI  5   	   "    Farmacia.UI.EmpleadoRegistro   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Farmacia.UI     5   	     � Title$  EmpleadoRegistro��5   	   $	��400��6"   $	��450��6/   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��25(�6   $��Center=�6   $��0��6;   .��6H   
Empleado6R   � 5   
   $��1��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $	��400��6   6&   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��130��6   .��6$   Nombre6,   �� 5      -   5         ��Name$ txbNombreEmpleado��5      $	��300��65   6C   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��400��6   6&   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��130��6   .��6$   	Apellidos6/   �� 5      -   5        $ txbApellidosEmpleado��5      $	��300��68   6F   5       �� 5!      $ 
Horizontal=�6   .+�5"      �� $	��400��6   6&   5#      �� 5$      $ 
Horizontal=�6   .+�5%      �� $	��130��6   .��6$   Numero de Empleado68   �� 5&      -   5        $ txbNumeroEmpleado��5&      $	��300��65   6C   5'      �� 5(      $ 
Horizontal=�6   .+�5)      �� $	��400��6   6&   5*      5+      � 5,   
   $��2��6   .+�5-      �� -   5         ��Name$ btnNuevoEmpleado��5-       $��80��6   .��6Y   Nuevo6`   �� 5.      -   5        $ btnGuardarEmpleado��5.       $��80��6   .��6]   	Guardar6f   �� 5/      -   5        $ btnEditarEmpleado��5/       $��80��6   .��6[   Editar6c   �� 50      -   5        $ btnCancelarEmpleado��50       $��80��6   .��6_   
Cancelar6i   �� 51      -   5        $ btnEliminarEmpleado��51       $��80��6   .��6_   
Eliminar6i   �� 52      -	   5        $ btnRegresarMenu��52       $��80��6   .��6W   
Regresar6a   53      &   System.Windows.Controls.DataGrid  54   
   -
   5          Name$ dtgEmpleados��54         
IsReadOnly . $��3��6;   55      56      