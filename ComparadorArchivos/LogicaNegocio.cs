using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparadorArchivos
{
    internal class LogicaNegocio
    {
        readonly string rutaArchivo;
        internal AccesoDatos datos;

        public LogicaNegocio(string rutaArchivo)
        {
            this.rutaArchivo = rutaArchivo;
            datos = new AccesoDatos(rutaArchivo);
        }

        public string ImportarDatos(string nombreTabla)
        {
            string msj = "";
            try
            {
                datos.ImportarDatos(nombreTabla);
                msj = "Archivo importado correctamente";
            }
            catch (Exception)
            {
                msj = "Importa un archivo válido.";
            }
            return msj;
        }

        public DataTable ObtenerDatos(string nombreTabla)
        {
            return datos.ConsultarTabla(nombreTabla);
        }
    }
}
