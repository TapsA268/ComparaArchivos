using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComparadorArchivos
{
    public partial class InformaciónObtenida : Form
    {
        LogicaNegocio bll;
        string nombreTabla1;
        string nombreColumna1;
        string nombreTabla2;
        string nombreColumna2;
        DataTable datos;

        public InformaciónObtenida(LogicaNegocio logica, string nombreTabla1, string nombreColumna1, string nombreTabla2, string nombreColumna2)
        {
            InitializeComponent();
            this.bll = logica;
            this.nombreTabla1 = nombreTabla1;
            this.nombreColumna1 = nombreColumna1;
            this.nombreTabla2 = nombreTabla2;
            this.nombreColumna2 = nombreColumna2;
            MostrarInfo();
        }

        public void MostrarInfo()
        {
            datos = bll.CruzarInformacion(nombreTabla1, nombreColumna1, nombreTabla2, nombreColumna2);
            kryptonDataGridView2.DataSource = datos;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarArchivo = new SaveFileDialog
            {
                Title = "Guarda el archivo",
                DefaultExt=".xlsx",
                OverwritePrompt=true,
                AddExtension=true,
                Filter = "Archivo de Excel |*.xls;*.xlsx;*xlsxb"
            };
            
            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(bll.Exportar(datos, guardarArchivo.FileName),"", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
