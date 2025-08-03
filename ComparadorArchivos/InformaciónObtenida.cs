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
        
        public InformaciónObtenida(LogicaNegocio logica, string nombreTabla1, string nombreColumna1, string nombreTabla2, string nombreColumna2)
        {
            InitializeComponent();
            this.bll = logica;
            this.nombreTabla1 = nombreTabla1;
            this.nombreColumna1 = nombreColumna1;
            this.nombreTabla2 = nombreTabla2;
            this.nombreColumna2 = nombreColumna2;
        }

        public void MostrarInfo()
        {
            kryptonDataGridView2.DataSource = bll.CruzarInformacion(nombreTabla1, nombreColumna1, nombreTabla2, nombreColumna2);
        }
    }
}
