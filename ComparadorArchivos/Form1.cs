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
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
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
                ProgresoCarga progreso = new ProgresoCarga(bll, filePath);
                progreso.Show();
                kryptonDataGridView1.DataSource = bll.ObtenerDatos(filePath);
                tablaLabel1.Text = filePath;
            }
            LlenarComboBox(comboBox1);
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
                ProgresoCarga progreso = new ProgresoCarga(bll, filePath);
                progreso.Show();
                kryptonDataGridView2.DataSource = bll.ObtenerDatos(filePath);
                tablaLabel2.Text = filePath;
            }
            LlenarComboBox(comboBox2);
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            InformaciónObtenida info = new InformaciónObtenida(bll, tablaLabel1.Text, archivoLabel1.Text, tablaLabel2.Text, archivoLabel2.Text);
            info.Show();
        }

        private void LlenarComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            var campos = bll.ObtenerCampos();

            foreach (var campo in campos)
            {
                comboBox.Items.Add(campo);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seleccionado = comboBox1.Text;
            archivoLabel1.Text = seleccionado;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seleccionado = comboBox2.Text;
            archivoLabel2.Text = seleccionado;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show(bll.EliminarTablas(tablaLabel1.Text, tablaLabel2.Text));
        }
    }
}
