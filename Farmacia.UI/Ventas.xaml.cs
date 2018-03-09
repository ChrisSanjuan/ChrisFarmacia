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

namespace Farmacia.UI
{
    /// <summary>
    /// Interaction logic for Ventas.xaml
    /// </summary>
    public partial class Ventas : Window
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void btnRegistrarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            EmpleadoRegistro abrir = new EmpleadoRegistro();
            abrir.Show();
            this.Close();
        }

        private void btnRegistrarCliente_Click(object sender, RoutedEventArgs e)
        {
            ClienteRegistro abrir = new ClienteRegistro();
            abrir.Show();
            this.Close();
        }

        private void btnRegistrarProducto_Click(object sender, RoutedEventArgs e)
        {
            ProductoRegistro abrir = new ProductoRegistro();
            abrir.Show();
            this.Close();
        }
    }
}
