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
    /// Interaction logic for ProductoRegistro.xaml
    /// </summary>
    public partial class ClienteRegistro : Window
    {
        RepositorioClientes repositorio;
        bool esNuevo;
        public ClienteRegistro()
        {
            InitializeComponent();
            repositorio = new RepositorioClientes();
            HabilitarCajas(false);
            HabilitarBotones(true);
            ActualizarTabla();
        }

        private void HabilitarCajas(bool habilitadas)
        {
            txbNombreCliente.Clear();
            txbApellidosCliente.Clear();
            txbDireccion.Clear();
            txbRFC.Clear();
            txbTelefono.Clear();
            txbCorreo.Clear();
            txbNombreCliente.IsEnabled = habilitadas;
            txbApellidosCliente.IsEnabled = habilitadas;
            txbDireccion.IsEnabled = habilitadas;
            txbRFC.IsEnabled = habilitadas;
            txbTelefono.IsEnabled = habilitadas;
            txbCorreo.IsEnabled = habilitadas;
        }

        private void HabilitarBotones(bool habilitados)
        {
            btnNuevoCliente.IsEnabled = habilitados;
            btnEditarCliente.IsEnabled = habilitados;
            btnEliminarCliente.IsEnabled = habilitados;
            btnGuardarCliente.IsEnabled = !habilitados;
            btnCancelarCliente.IsEnabled = !habilitados;
        }

        private void btnNuevoCliente_Click(object sender, RoutedEventArgs e)
        {
            HabilitarCajas(true);
            HabilitarBotones(false);
            esNuevo = true;
        }

        private void btnGuardarCliente_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txbNombreCliente.Text) || string.IsNullOrEmpty(txbApellidosCliente.Text) || string.IsNullOrEmpty(txbTelefono.Text))
            {
                MessageBox.Show("Faltan datos", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            if (esNuevo)
            {
                Cliente c = new Cliente()
                {
                    NombreCliente = txbNombreCliente.Text,
                    ApellidosCliente = txbApellidosCliente.Text,
                    Direccion = txbDireccion.Text,
                    RFC = txbRFC.Text,
                    Telefono = txbTelefono.Text,
                    Correo = txbCorreo.Text,
                };
                if(repositorio.AgregarCliente(c))
                {
                    MessageBox.Show("Guardado con Éxito", "Cliente", MessageBoxButton.OK, MessageBoxImage.Information);
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
                Cliente original = dtgClientes.SelectedItem as Cliente;
                Cliente c = new Cliente();
                c.NombreCliente = txbNombreCliente.Text;
                c.ApellidosCliente = txbApellidosCliente.Text;
                c.Direccion = txbDireccion.Text;
                c.RFC = txbRFC.Text;
                c.Telefono = txbTelefono.Text;
                c.Correo = txbCorreo.Text;
                if (repositorio.ModificarCliente(original, c))
                {
                    HabilitarBotones(true);
                    HabilitarCajas(false);
                    ActualizarTabla();
                    MessageBox.Show("Su cliente a sido actualizado", "Cliente", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar al cliente, contactarte al administrador", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void ActualizarTabla()
        {
            dtgClientes.ItemsSource = null;
            dtgClientes.ItemsSource = repositorio.LeerClientes();
        }

        private void btnEditarCliente_Click(object sender, RoutedEventArgs e)
        {
            if (repositorio.LeerClientes().Count == 0)
            {
                MessageBox.Show("No tiene ningun cliente...", "No tiene clientes", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgClientes.SelectedItem != null)
                {
                    Cliente c = dtgClientes.SelectedItem as Cliente;
                    HabilitarCajas(true);
                    txbNombreCliente.Text = c.NombreCliente;
                    txbApellidosCliente.Text = c.ApellidosCliente;
                    txbDireccion.Text = c.Direccion;
                    txbRFC.Text = c.RFC;
                    txbTelefono.Text = c.Telefono;
                    txbCorreo.Text = c.Correo;
                    HabilitarBotones(false);
                    esNuevo = false;
                }
                else
                {
                    MessageBox.Show("¿A Quien???", "Cliente", MessageBoxButton.OK, MessageBoxImage.Question);
                }
            }
        }

        private void btnCancelarCliente_Click(object sender, RoutedEventArgs e)
        {
            HabilitarCajas(false);
            HabilitarBotones(true);
        }

        private void btnEliminarCliente_Click(object sender, RoutedEventArgs e)
        {
            if (repositorio.LeerClientes().Count == 0)
            {
                MessageBox.Show("No hay clientes", "Agregue alguno", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgClientes.SelectedItem != null)
                {
                    Cliente c = dtgClientes.SelectedItem as Cliente;
                    if (MessageBox.Show("Realmente deseas eliminar a " + c.NombreCliente + "?", "Eliminar????", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        if (repositorio.EliminarCliente(c))
                        {
                            MessageBox.Show("El cliente ha sido removido", "Cliente", MessageBoxButton.OK, MessageBoxImage.Information);
                            ActualizarTabla();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar cliente, contatate al administrador", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("¿Cual???", "Cliente", MessageBoxButton.OK, MessageBoxImage.Question);
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
