using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.COMMON
{
    public class RepositorioProductos
    {
        ManejadorDeArchivos archivoProductos;
        List<Producto> Productos;
        public RepositorioProductos()
        {
            archivoProductos = new ManejadorDeArchivos("Productos.txt");
            Productos = new List<Producto>();
        }

        public bool AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
            bool resultado = ActualizarArchivo();
            Productos = LeerProductos();
            return resultado;
        }

        public bool EliminarProducto(Producto producto)
        {
            Producto temporal = new Producto();
            foreach (var item in Productos)
            {
                if (item.NombreProducto == producto.NombreProducto)
                {
                    temporal = item;
                }
            }
            Productos.Remove(temporal);
            bool resultado = ActualizarArchivo();
            Productos = LeerProductos();
            return resultado;
        }

        public bool ModificarProducto(Producto original, Producto modificado)
        {
            Producto temporal = new Producto();
            foreach (var item in Productos)
            {
                if (original.NombreProducto == item.NombreProducto)
                {
                    temporal = item;
                }
            }
            temporal.NombreProducto = modificado.NombreProducto;
            temporal.Categoria = modificado.Categoria;
            temporal.Descripcion = modificado.Descripcion;
            temporal.PrecioCompra = modificado.PrecioCompra;
            temporal.PrecioVenta = modificado.PrecioVenta;
            temporal.Cantidad = modificado.Cantidad;
            bool resultado = ActualizarArchivo();
            Productos = LeerProductos();
            return resultado;
        }

        private bool ActualizarArchivo()
        {
            string datos = "";
            foreach (Producto item in Productos)
            {
                datos += string.Format("{0}|{1}|{2}|{3}|{4}|{5}\n", item.NombreProducto, item.Categoria, item.Descripcion, item.PrecioCompra, item.PrecioVenta, item.Cantidad);
            }
            return archivoProductos.Guardar(datos);
        }

        public List<Producto> LeerProductos()
        {
            string datos = archivoProductos.Leer();
            if (datos != null)
            {
                List<Producto> productos = new List<Producto>();
                string[] lineas = datos.Split('\n');
                for (int i = 0; i < lineas.Length - 1; i++)
                {
                    string[] campos = lineas[i].Split('|');
                    Producto pr = new Producto()
                    {
                        NombreProducto = campos[0],
                        Categoria = campos[1],
                        Descripcion = campos[2],
                        PrecioCompra = campos[3],
                        PrecioVenta = campos[4],
                        Cantidad = campos[5],
                    };
                    productos.Add(pr);
                }
                Productos = productos;
                return productos;
            }
            else
            {
                return null;
            }
        }
    }
}
