using DocumentFormat.OpenXml.Bibliography;
using Krypton.Toolkit;

namespace ComparadorArchivos
{
    public partial class Form1 : Form
    {
        LogicaNegocio bll;
        public Form1()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog 
            { 
                Title="Selecciona un archivo de Excel",
                Filter= "Archivo de Excel |*.xls;*.xlsx;*xlsxb"
            };
            if (file.ShowDialog() == DialogResult.OK)
            {                
                string filePath = file.FileName;
                bll = new LogicaNegocio(filePath);               
                ProgresoCarga progreso = new ProgresoCarga(bll,filePath);
                progreso.Show();

                LlenarComboBox(kryptonThemeComboBox1);
                
                kryptonDataGridView1.DataSource = bll.ObtenerDatos(filePath);                
            }
        }

        private void btnImportar2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog
            {
                Title = "Selecciona un archivo de Excel",
                Filter = "Archivo de Excel |*.xls;*.xlsx;*xlsxb"
            };
            if (file.ShowDialog() == DialogResult.OK)
            {
                string filePath = file.FileName;
                bll = new LogicaNegocio(filePath);
                ProgresoCarga progreso = new ProgresoCarga(bll,filePath);
                progreso.Show();

                LlenarComboBox(kryptonThemeComboBox2);

                kryptonDataGridView2.DataSource = bll.ObtenerDatos(filePath);
            }
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {

        }

        private void LlenarComboBox(KryptonThemeComboBox comboBox)
        {
            var headers = bll.ObtenerCampos();
            comboBox.Items.Clear();

            foreach (var header in headers)
            {
                comboBox.Items.Add(header);
            }

        }
    }
}
