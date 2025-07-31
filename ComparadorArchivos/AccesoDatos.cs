using ClosedXML.Excel;
using DocumentFormat.OpenXml.Vml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComparadorArchivos
{
    internal class AccesoDatos
    {
        readonly string rutaArchivo;

        public AccesoDatos(string rutaArchivo)
        {
            this.rutaArchivo = rutaArchivo;
        }
        internal string[] GetHeaders()
        {
            var workbook = new XLWorkbook(rutaArchivo);
            var worksheet = workbook.Worksheets.First();
            return worksheet.Row(1).Cells().Select(c => c.Value.ToString()).ToArray();
        }       
        private SQLiteConnection GetConnection()
        {
            SQLiteConnection conn = new ($"Data Source=Archivos;Version=3;");
            conn.Open();
            return conn;
        }
        private void CrearTabla(SQLiteConnection conn, string tabla, string[] headers)
        {
            string createSql = $"CREATE TABLE IF NOT EXISTS [{tabla}] ({string.Join(", ", headers.Select(h => $"[{h}] TEXT"))});";
            new SQLiteCommand(createSql, conn).ExecuteNonQuery();
        }
        private void InsertarDatos(SQLiteConnection conn, string tabla, string[] headers, Action<int, int>? notificarProgreso)
        {
            var workbook = new XLWorkbook(rutaArchivo);
            var worksheet = workbook.Worksheets.First();
            int rowCount = worksheet.LastRowUsed().RowNumber();
            int total = rowCount - 1;

            for (int i = 2; i <= rowCount; i++)
            {
                var row = worksheet.Row(i).Cells(1, headers.Length);
                var values = row.Select(c => $"'{c.Value.ToString().Replace("'", "''")}'");
                string insertSql = $"INSERT INTO [{tabla}] ({string.Join(", ", headers.Select(h => $"[{h}]"))}) VALUES ({string.Join(", ", values)});";
                new SQLiteCommand(insertSql, conn).ExecuteNonQuery();

                notificarProgreso?.Invoke(i - 1, total); // Porque comienza en fila 2
            }
        }
        internal DataTable ConsultarTabla(string nombreTabla)
        {
            using var conn = GetConnection();
            string consultaSql = $"SELECT * FROM [{nombreTabla}]";

            using var comando = new SQLiteCommand(consultaSql, conn);
            using var adaptador = new SQLiteDataAdapter(comando);

            var tabla = new DataTable();
            adaptador.Fill(tabla);

            conn.Close();

            return tabla;
        }

        internal void ImportarDatos(string tabla, Action<int, int>? notificarProgreso = null)
        {
            var headers = GetHeaders();
            using var conn = GetConnection();
            CrearTabla(conn, tabla, headers);
            InsertarDatos(conn, tabla, headers,notificarProgreso);
            conn.Close();
        }
    }
}
