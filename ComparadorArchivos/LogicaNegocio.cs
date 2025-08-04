using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparadorArchivos
{
    public class LogicaNegocio
    {
        readonly string rutaArchivo;
        internal AccesoDatos datos;

        internal LogicaNegocio(string rutaArchivo)
        {
            this.rutaArchivo = rutaArchivo;
            datos = new AccesoDatos(rutaArchivo);
        }

        internal string ImportarDatos(string nombreTabla, Action<int, int>? notificarProgreso = null)
        {
            string msj = "";
            try
            {
                datos.ImportarDatos(nombreTabla,notificarProgreso);
                msj = "Archivo importado correctamente";
            }
            catch (Exception)
            {
                msj = "Importa un archivo válido.";
            }
            return msj;
        }

        internal DataTable ObtenerDatos(string nombreTabla)
        {
            return datos.ConsultarTabla(nombreTabla);
        }

        internal DataTable CruzarInformacion(string nombreTabla1, string columnaTabla1, string nombreTabla2, string columnaTabla2)
        {
            return datos.Cruzar_Informacion(nombreTabla1,columnaTabla1,nombreTabla2,columnaTabla2);
        }

        internal string[] ObtenerCampos()
        {
            return datos.GetHeaders();
        }

        internal string Exportar(DataTable tabla, string rutaArchivo)
        {
            return datos.ExportarDatos(tabla, rutaArchivo);
        }

        internal string EliminarTablas(string tabla1,string tabla2)
        {
            return datos.EliminarTablas(tabla1, tabla2);
        }
    }
}
