using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Farmacia.COMMON;

namespace Farmacia.UI
{
    /// <summary>
    /// Interaction logic for EmpleadoRegistro.xaml
    /// </summary>
    public partial class EmpleadoRegistro : Window
    {
        RepositorioEmpleados repositorio;
        bool esNuevo;
        public EmpleadoRegistro()
        {
            InitializeComponent();
            repositorio = new RepositorioEmpleados();
            HabilitarCajas(false);
            HabilitarBotones(true);
            ActualizarTabla();
        }

        private void HabilitarCajas(bool habilitadas)
        {
            txbNombreEmpleado.Clear();
            txbApellidosEmpleado.Clear();
            txbNumeroEmpleado.Clear();
            txbNombreEmpleado.IsEnabled = habilitadas;
            txbApellidosEmpleado.IsEnabled = habilitadas;
            txbNumeroEmpleado.IsEnabled = habilitadas;
        }

        private void HabilitarBotones(bool habilitados)
        {
            btnNuevoEmpleado.IsEnabled = habilitados;
            btnEditarEmpleado.IsEnabled = habilitados;
            btnEliminarEmpleado.IsEnabled = habilitados;
            btnGuardarEmpleado.IsEnabled = !habilitados;
            btnCancelarEmpleado.IsEnabled = !habilitados;
        }

        private void btnNuevoEmpleado_Click(object sender, RoutedEventArgs e)
        {
            HabilitarCajas(true);
            HabilitarBotones(false);
            esNuevo = true;
        }

        private void btnGuardarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txbNombreEmpleado.Text) || string.IsNullOrEmpty(txbApellidosEmpleado.Text) || string.IsNullOrEmpty(txbNumeroEmpleado.Text))
            {
                MessageBox.Show("Faltan datos", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            if (esNuevo)
            {
                Empleado emp = new Empleado()
                {
                    NombreEmpleado = txbNombreEmpleado.Text,
                    ApellidosEmpleado = txbApellidosEmpleado.Text,
                    NumeroEmpleado = txbNumeroEmpleado.Text,
                };
                if (repositorio.AgregarEmpleado(emp))
                {
                    MessageBox.Show("Guardado con Éxito", "Empleado", MessageBoxButton.OK, MessageBoxImage.Information);
                    ActualizarTabla();
                    HabilitarBotones(true);
                    HabilitarCajas(false);
                }
                else
                {
                    MessageBox.Show("Error al guardar", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                Empleado original = dtgEmpleados.SelectedItem as Empleado;
                Empleado emp = new Empleado();
                emp.NombreEmpleado = txbNombreEmpleado.Text;
                emp.ApellidosEmpleado = txbApellidosEmpleado.Text;
                emp.NumeroEmpleado = txbNumeroEmpleado.Text;
                if (repositorio.ModificarEmpleado(original, emp))
                {
                    HabilitarBotones(true);
                    HabilitarCajas(false);
                    ActualizarTabla();
                    MessageBox.Show("Su empleado a sido actualizado", "Empleado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar al empleado, contactarte al administrador", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void ActualizarTabla()
        {
            dtgEmpleados.ItemsSource = null;
            dtgEmpleados.ItemsSource = repositorio.LeerEmpleados();
        }

        private void btnEditarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            if (repositorio.LeerEmpleados().Count == 0)
            {
                MessageBox.Show("No tiene ningun empleado...", "No tiene empleados", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgEmpleados.SelectedItem != null)
                {
                    Empleado emp = dtgEmpleados.SelectedItem as Empleado;
                    HabilitarCajas(true);
                    txbNombreEmpleado.Text = emp.NombreEmpleado;
                    txbApellidosEmpleado.Text = emp.ApellidosEmpleado;
                    txbNumeroEmpleado.Text = emp.NumeroEmpleado;
                    HabilitarBotones(false);
                    esNuevo = false;
                }
                else
                {
                    MessageBox.Show("¿A Quien???", "Empleado", MessageBoxButton.OK, MessageBoxImage.Question);
                }
            }
        }

        private void btnCancelarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            HabilitarCajas(false);
            HabilitarBotones(true);
        }

        private void btnEliminarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            if (repositorio.LeerEmpleados().Count == 0)
            {
                MessageBox.Show("No hay empleados", "Agregue alguno", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgEmpleados.SelectedItem != null)
                {
                    Empleado emp = dtgEmpleados.SelectedItem as Empleado;
                    if (MessageBox.Show("Realmente deseas eliminar a " + emp.NombreEmpleado + "?", "Eliminar????", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        if (repositorio.EliminarEmpleado(emp))
                        {
                            MessageBox.Show("El empleado ha sido removido", "Empleado", MessageBoxButton.OK, MessageBoxImage.Information);
                            ActualizarTabla();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar empleado, contatate al administrador", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("¿Cual???", "Empleado", MessageBoxButton.OK, MessageBoxImage.Question);
                    }
                }
            }
        }

        private void btnRegresarMenu_Click(object sender, RoutedEventArgs e)
        {
            Ventas abrir = new Ventas();
            abrir.Show();
            this.Close();
        }
    }
}
