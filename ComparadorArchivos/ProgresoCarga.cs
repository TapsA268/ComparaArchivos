using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComparadorArchivos
{
    public partial class ProgresoCarga : Form
    {
        LogicaNegocio bll;
        string nombreTabla;
        public ProgresoCarga(LogicaNegocio logica, string nombreTabla)
        {
            InitializeComponent();
            this.bll = logica;
            this.nombreTabla = nombreTabla;
        }
        private async void ProgresoCarga_Load(object sender, EventArgs e)
        {
            kryptonLabel1.Text = "Cargando datos...";
            await Task.Run(() => CargarDatos());

            kryptonLabel1.Text = "¡Carga finalizada!";
            MessageBox.Show(CargarDatos(),"",MessageBoxButtons.OK, MessageBoxIcon.Information);           
            this.Close();
        }
        private string CargarDatos()
        {
            string CargaDatos = "";
            CargaDatos =
            bll.ImportarDatos(nombreTabla, (actual, total) =>
            {
                this.Invoke(() =>
                {
                    kryptonProgressBar1.Maximum = total;
                    kryptonProgressBar1.Value = actual;
                    kryptonProgressBar1.Text = $"{(actual * 100 / total)}%";
                });
            });

            return CargaDatos;
        }
    }
}
