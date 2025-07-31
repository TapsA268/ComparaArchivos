using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Data.SQLite;
using System.Data;

namespace ComparadorArchivos
{
    internal class AccesoDatos
    {
        readonly string rutaArchivo;

        public AccesoDatos(string rutaArchivo)
        {
            this.rutaArchivo = rutaArchivo;
        }
        private string[] GetHeaders()
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
        private void InsertarDatos(SQLiteConnection conn, string tabla, string[] headers)
        {
            var workbook = new XLWorkbook(rutaArchivo);
            var worksheet = workbook.Worksheets.First();
            int rowCount = worksheet.LastRowUsed().RowNumber();

            for (int i = 2; i <= rowCount; i++)
            {
                var row = worksheet.Row(i).Cells(1, headers.Length);
                var values = row.Select(c => $"'{c.Value.ToString().Replace("'", "''")}'");
                string insertSql = $"INSERT INTO [{tabla}] ({string.Join(", ", headers.Select(h => $"[{h}]"))}) VALUES ({string.Join(", ", values)});";
                new SQLiteCommand(insertSql, conn).ExecuteNonQuery();
            }
        }
        public DataTable ConsultarTabla(string nombreTabla)
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

        public void ImportarDatos(string tabla)
        {
            var headers = GetHeaders();
            using var conn = GetConnection();
            CrearTabla(conn, tabla, headers);
            InsertarDatos(conn, tabla, headers);
            conn.Close();
        }
    }
}
