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
    public partial class ProductoRegistro : Window
    {
        RepositorioProductos repositorio;
        bool esNuevo;
        public ProductoRegistro()
        {
            InitializeComponent();
            repositorio = new RepositorioProductos();
            HabilitarCajas(false);
            HabilitarBotones(true);
            ActualizarTabla();
        }

        private void HabilitarCajas(bool habilitadas)
        {
            txbNombreProducto.Clear();
            txbCategoria.Clear();
            txbDescripcion.Clear();
            txbPrecioCompra.Clear();
            txbPrecioVenta.Clear();
            txbCantidad.Clear();
            txbNombreProducto.IsEnabled = habilitadas;
            txbCategoria.IsEnabled = habilitadas;
            txbDescripcion.IsEnabled = habilitadas;
            txbPrecioCompra.IsEnabled = habilitadas;
            txbPrecioVenta.IsEnabled = habilitadas;
            txbCantidad.IsEnabled = habilitadas;
        }

        private void HabilitarBotones(bool habilitados)
        {
            btnNuevoProducto.IsEnabled = habilitados;
            btnEditarProducto.IsEnabled = habilitados;
            btnEliminarProducto.IsEnabled = habilitados;
            btnGuardarProducto.IsEnabled = !habilitados;
            btnCancelarProducto.IsEnabled = !habilitados;
        }

        private void btnNuevoProducto_Click(object sender, RoutedEventArgs e)
        {
            HabilitarCajas(true);
            HabilitarBotones(false);
            esNuevo = true;
        }

        private void btnGuardarProducto_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txbNombreProducto.Text) || string.IsNullOrEmpty(txbNombreProducto.Text) || string.IsNullOrEmpty(txbCategoria.Text))
            {
                MessageBox.Show("Faltan datos", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            if (esNuevo)
            {
                Producto pr = new Producto()
                {
                    NombreProducto = txbNombreProducto.Text,
                    Categoria = txbCategoria.Text,
                    Descripcion = txbDescripcion.Text,
                    PrecioCompra = txbPrecioCompra.Text,
                    PrecioVenta = txbPrecioVenta.Text,
                    Cantidad = txbCantidad.Text,
                };
                if (repositorio.AgregarProducto(pr))
                {
                    MessageBox.Show("Guardado con Éxito", "Producto", MessageBoxButton.OK, MessageBoxImage.Information);
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
                Producto original = dtgProductos.SelectedItem as Producto;
                Producto p = new Producto();
                p.NombreProducto = txbNombreProducto.Text;
                p.Categoria = txbCategoria.Text;
                p.Descripcion = txbDescripcion.Text;
                p.PrecioCompra = txbPrecioCompra.Text;
                p.PrecioVenta = txbPrecioVenta.Text;
                p.Cantidad = txbCantidad.Text;
                if (repositorio.ModificarProducto(original, p))
                {
                    HabilitarBotones(true);
                    HabilitarCajas(false);
                    ActualizarTabla();
                    MessageBox.Show("Su producto a sido actualizado", "Producto", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar producto, contactarte al administrador", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void ActualizarTabla()
        {
            dtgProductos.ItemsSource = null;
            dtgProductos.ItemsSource = repositorio.LeerProductos();
        }

        private void btnEditarProducto_Click(object sender, RoutedEventArgs e)
        {
            if (repositorio.LeerProductos().Count == 0)
            {
                MessageBox.Show("No tiene ningun producto...", "No tiene productos", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgProductos.SelectedItem != null)
                {
                    Producto pr = dtgProductos.SelectedItem as Producto;
                    HabilitarCajas(true);
                    txbNombreProducto.Text = pr.NombreProducto;
                    txbCategoria.Text = pr.Categoria;
                    txbDescripcion.Text = pr.Descripcion;
                    txbPrecioCompra.Text = pr.PrecioCompra;
                    txbPrecioVenta.Text = pr.PrecioVenta;
                    txbCantidad.Text = pr.Cantidad;
                    HabilitarBotones(false);
                    esNuevo = false;
                }
                else
                {
                    MessageBox.Show("¿Cual???", "Producto", MessageBoxButton.OK, MessageBoxImage.Question);
                }
            }
        }

        private void btnCancelarProducto_Click(object sender, RoutedEventArgs e)
        {
            HabilitarCajas(false);
            HabilitarBotones(true);
        }

        private void btnEliminarProducto_Click(object sender, RoutedEventArgs e)
        {
            if (repositorio.LeerProductos().Count == 0)
            {
                MessageBox.Show("No hay Productos", "Agregue alguno", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgProductos.SelectedItem != null)
                {
                    Producto pr = dtgProductos.SelectedItem as Producto;
                    if (MessageBox.Show("Realmente deseas eliminar a " + pr.NombreProducto + "?", "Eliminar????", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        if (repositorio.EliminarProducto(pr))
                        {
                            MessageBox.Show("El producto ha sido removido", "Producto", MessageBoxButton.OK, MessageBoxImage.Information);
                            ActualizarTabla();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar producto, contatate al administrador", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("¿Cual???", "Producto", MessageBoxButton.OK, MessageBoxImage.Question);
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
