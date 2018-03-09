using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.COMMON
{
    public class RepositorioClientes
    {
        ManejadorDeArchivos archivoClientes;
        List<Cliente> Clientes;
        public RepositorioClientes()
        {
            archivoClientes = new ManejadorDeArchivos("Clientes.txt");
            Clientes = new List<Cliente>();
        }

        public bool AgregarCliente (Cliente cliente)
        {
            Clientes.Add(cliente);
            bool resultado = ActualizarArchivo();
            Clientes = LeerClientes();
            return resultado;
        }

        public bool EliminarCliente(Cliente cliente)
        {
            Cliente temporal = new Cliente();
            foreach (var item in Clientes)
            {
                if (item.Telefono == cliente.Telefono)
                {
                    temporal = item;
                }
            }
            Clientes.Remove(temporal);
            bool resultado = ActualizarArchivo();
            Clientes = LeerClientes();
            return resultado;
        }

        public bool ModificarCliente(Cliente original, Cliente modificado)
        {
            Cliente temporal = new Cliente();
            foreach (var item in Clientes)
            {
                if (original.Telefono == item.Telefono)
                {
                    temporal = item;
                }
            }
            temporal.NombreCliente = modificado.NombreCliente;
            temporal.ApellidosCliente = modificado.ApellidosCliente;
            temporal.Direccion = modificado.Direccion;
            temporal.RFC = modificado.RFC;
            temporal.Telefono = modificado.Telefono;
            temporal.Correo = modificado.Correo;
            bool resultado = ActualizarArchivo();
            Clientes = LeerClientes();
            return resultado;
        }

        private bool ActualizarArchivo()
        {
            string datos = "";
            foreach (Cliente item in Clientes)
            {
                datos += string.Format("{0}|{1}|{2}|{3}|{4}|{5}\n", item.NombreCliente, item.ApellidosCliente, item.Direccion, item.RFC, item.Telefono, item.Correo);
            }
            return archivoClientes.Guardar(datos);
        }
        public List<Cliente> LeerClientes()
        {
            string datos = archivoClientes.Leer();
            if (datos != null)
            {
                List<Cliente> clientes = new List<Cliente>();
                string[] lineas = datos.Split('\n');
                for (int i = 0; i < lineas.Length-1; i++)
                {
                    string[] campos = lineas[i].Split('|');
                    Cliente c = new Cliente()
                    {
                        NombreCliente = campos[0],
                        ApellidosCliente = campos[1],
                        Direccion = campos[2],
                        RFC = campos[3],
                        Telefono = campos[4],
                        Correo = campos[5],
                    };
                    clientes.Add(c);
                }
                Clientes = clientes;
                return clientes;
            }
            else
            {
                return null;
            }
        }
    }
}
