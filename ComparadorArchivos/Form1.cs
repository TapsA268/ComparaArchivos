using DocumentFormat.OpenXml.Bibliography;

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
                Filter= "Archivo CSV (*.csv)|*.csv|Archivo de Excel |*.xls;*.xlsx"
            };
            if (file.ShowDialog() == DialogResult.OK)
            {
                
                string filePath = file.FileName;
                bll = new LogicaNegocio(filePath);
                bll.ImportarDatos(filePath);
                MessageBox.Show("Archivo seleccionado: " + filePath);
            }
        }

        private void btnImportar2_Click(object sender, EventArgs e)
        {

        }

        private void btnComparar_Click(object sender, EventArgs e)
        {

        }
    }
}
