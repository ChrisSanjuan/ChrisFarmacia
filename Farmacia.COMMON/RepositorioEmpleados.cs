using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.COMMON
{
    public class RepositorioEmpleados
    {
        ManejadorDeArchivos archivoEmpleados;
        List<Empleado> Empleados;
        public RepositorioEmpleados()
        {
            archivoEmpleados = new ManejadorDeArchivos("Empleados.txt");
            Empleados = new List<Empleado>();
        }

        public bool AgregarEmpleado(Empleado empleado)
        {
            Empleados.Add(empleado);
            bool resultado = ActualizarArchivo();
            Empleados = LeerEmpleados();
            return resultado;
        }

        public bool EliminarEmpleado(Empleado empleado)
        {
            Empleado temporal = new Empleado();
            foreach (var item in Empleados)
            {
                if (item.NombreEmpleado == empleado.NombreEmpleado)
                {
                    temporal = item;
                }
            }
            Empleados.Remove(temporal);
            bool resultado = ActualizarArchivo();
            Empleados = LeerEmpleados();
            return resultado;
        }

        public bool ModificarEmpleado(Empleado original, Empleado modificado)
        {
            Empleado temporal = new Empleado();
            foreach (var item in Empleados)
            {
                if (original.NombreEmpleado == item.NombreEmpleado)
                {
                    temporal = item;
                }
            }
            temporal.NombreEmpleado = modificado.NombreEmpleado;
            temporal.ApellidosEmpleado = modificado.ApellidosEmpleado;
            temporal.NumeroEmpleado = modificado.NumeroEmpleado;
            bool resultado = ActualizarArchivo();
            Empleados = LeerEmpleados();
            return resultado;
        }

        private bool ActualizarArchivo()
        {
            string datos = "";
            foreach (Empleado item in Empleados)
            {
                datos += string.Format("{0}|{1}|{2}\n", item.NombreEmpleado, item.ApellidosEmpleado, item.NumeroEmpleado);
            }
            return archivoEmpleados.Guardar(datos);
        }

        public List<Empleado> LeerEmpleados()
        {
            string datos = archivoEmpleados.Leer();
            if (datos != null)
            {
                List<Empleado> empleados = new List<Empleado>();
                string[] lineas = datos.Split('\n');
                for (int i = 0; i < lineas.Length - 1; i++)
                {
                    string[] campos = lineas[i].Split('|');
                    Empleado emp = new Empleado()
                    {
                        NombreEmpleado = campos[0],
                        ApellidosEmpleado = campos[1],
                        NumeroEmpleado = campos[2],
                    };
                    empleados.Add(emp);
                }
                Empleados = empleados;
                return empleados;
            }
            else
            {
                return null;
            }
        }
    }
}
