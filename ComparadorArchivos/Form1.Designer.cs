namespace ComparadorArchivos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnImportar1 = new Krypton.Toolkit.KryptonButton();
            kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            kryptonDataGridView2 = new Krypton.Toolkit.KryptonDataGridView();
            btnImportar2 = new Krypton.Toolkit.KryptonButton();
            btnComparar = new Krypton.Toolkit.KryptonButton();
            archivoLabel1 = new Krypton.Toolkit.KryptonLabel();
            archivoLabel2 = new Krypton.Toolkit.KryptonLabel();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            tablaLabel1 = new Krypton.Toolkit.KryptonLabel();
            tablaLabel2 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btnImportar1
            // 
            btnImportar1.Location = new Point(72, 140);
            btnImportar1.Name = "btnImportar1";
            btnImportar1.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlackDarkMode;
            btnImportar1.Size = new Size(118, 25);
            btnImportar1.StateCommon.Back.Color1 = Color.FromArgb(46, 50, 57);
            btnImportar1.StateCommon.Back.Color2 = Color.FromArgb(46, 50, 57);
            btnImportar1.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            btnImportar1.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TileFlipX;
            btnImportar1.StateCommon.Border.Color1 = Color.White;
            btnImportar1.StateCommon.Border.Color2 = Color.White;
            btnImportar1.StateCommon.Border.Rounding = 10F;
            btnImportar1.StateCommon.Content.LongText.Color1 = Color.White;
            btnImportar1.StateCommon.Content.LongText.Color2 = Color.White;
            btnImportar1.StateCommon.Content.ShortText.Color1 = Color.White;
            btnImportar1.StateDisabled.Back.Color1 = Color.FromArgb(46, 50, 57);
            btnImportar1.StateDisabled.Back.Color2 = Color.FromArgb(46, 50, 57);
            btnImportar1.StateDisabled.Border.Color1 = Color.White;
            btnImportar1.StateDisabled.Border.Color2 = Color.White;
            btnImportar1.StateNormal.Back.Color1 = Color.FromArgb(46, 50, 57);
            btnImportar1.StateNormal.Back.Color2 = Color.FromArgb(46, 50, 57);
            btnImportar1.StateNormal.Border.Color1 = Color.White;
            btnImportar1.StateNormal.Border.Color2 = Color.White;
            btnImportar1.StatePressed.Back.Color1 = Color.FromArgb(46, 50, 57);
            btnImportar1.StatePressed.Back.Color2 = Color.FromArgb(46, 50, 57);
            btnImportar1.StatePressed.Border.Color1 = Color.White;
            btnImportar1.StatePressed.Border.Color2 = Color.White;
            btnImportar1.StateTracking.Back.Color1 = Color.FromArgb(46, 50, 57);
            btnImportar1.StateTracking.Back.Color2 = Color.FromArgb(46, 50, 57);
            btnImportar1.StateTracking.Border.Color1 = Color.White;
            btnImportar1.StateTracking.Border.Color2 = Color.White;
            btnImportar1.TabIndex = 1;
            btnImportar1.Values.DropDownArrowColor = Color.Empty;
            btnImportar1.Values.Text = "Importar Archivo 1";
            btnImportar1.Click += kryptonButton1_Click;
            // 
            // kryptonDataGridView1
            // 
            kryptonDataGridView1.AllowUserToAddRows = false;
            kryptonDataGridView1.AllowUserToDeleteRows = false;
            kryptonDataGridView1.BorderStyle = BorderStyle.None;
            kryptonDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kryptonDataGridView1.Location = new Point(72, 230);
            kryptonDataGridView1.Name = "kryptonDataGridView1";
            kryptonDataGridView1.ReadOnly = true;
            kryptonDataGridView1.Size = new Size(287, 352);
            kryptonDataGridView1.StateCommon.Background.Color1 = Color.FromArgb(162, 178, 238);
            kryptonDataGridView1.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            kryptonDataGridView1.TabIndex = 5;
            // 
            // kryptonDataGridView2
            // 
            kryptonDataGridView2.AllowUserToAddRows = false;
            kryptonDataGridView2.AllowUserToDeleteRows = false;
            kryptonDataGridView2.BorderStyle = BorderStyle.None;
            kryptonDataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kryptonDataGridView2.Location = new Point(474, 230);
            kryptonDataGridView2.Name = "kryptonDataGridView2";
            kryptonDataGridView2.ReadOnly = true;
            kryptonDataGridView2.Size = new Size(287, 352);
            kryptonDataGridView2.StateCommon.Background.Color1 = Color.FromArgb(162, 178, 238);
            kryptonDataGridView2.StateCommon.Background.Color2 = Color.FromArgb(162, 178, 238);
            kryptonDataGridView2.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            kryptonDataGridView2.TabIndex = 6;
            // 
            // btnImportar2
            // 
            btnImportar2.Location = new Point(474, 140);
            btnImportar2.Name = "btnImportar2";
            btnImportar2.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlackDarkMode;
            btnImportar2.Size = new Size(118, 25);
            btnImportar2.StateCommon.Back.Color1 = Color.FromArgb(46, 50, 57);
            btnImportar2.StateCommon.Back.Color2 = Color.FromArgb(46, 50, 57);
            btnImportar2.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            btnImportar2.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TileFlipX;
            btnImportar2.StateCommon.Border.Color1 = Color.White;
            btnImportar2.StateCommon.Border.Color2 = Color.White;
            btnImportar2.StateCommon.Border.Rounding = 10F;
            btnImportar2.StateCommon.Content.LongText.Color1 = Color.White;
            btnImportar2.StateCommon.Content.LongText.Color2 = Color.White;
            btnImportar2.StateCommon.Content.ShortText.Color1 = Color.White;
            btnImportar2.StateDisabled.Back.Color1 = Color.FromArgb(46, 50, 57);
            btnImportar2.StateDisabled.Back.Color2 = Color.FromArgb(46, 50, 57);
            btnImportar2.StateDisabled.Border.Color1 = Color.White;
            btnImportar2.StateDisabled.Border.Color2 = Color.White;
            btnImportar2.StateNormal.Back.Color1 = Color.FromArgb(46, 50, 57);
            btnImportar2.StateNormal.Back.Color2 = Color.FromArgb(46, 50, 57);
            btnImportar2.StateNormal.Border.Color1 = Color.White;
            btnImportar2.StateNormal.Border.Color2 = Color.White;
            btnImportar2.StatePressed.Back.Color1 = Color.FromArgb(46, 50, 57);
            btnImportar2.StatePressed.Back.Color2 = Color.FromArgb(46, 50, 57);
            btnImportar2.StatePressed.Border.Color1 = Color.White;
            btnImportar2.StatePressed.Border.Color2 = Color.White;
            btnImportar2.StateTracking.Back.Color1 = Color.FromArgb(46, 50, 57);
            btnImportar2.StateTracking.Back.Color2 = Color.FromArgb(46, 50, 57);
            btnImportar2.StateTracking.Border.Color1 = Color.White;
            btnImportar2.StateTracking.Border.Color2 = Color.White;
            btnImportar2.TabIndex = 7;
            btnImportar2.Values.DropDownArrowColor = Color.Empty;
            btnImportar2.Values.Text = "Importar Archivo 2";
            btnImportar2.Click += btnImportar2_Click;
            // 
            // btnComparar
            // 
            btnComparar.Location = new Point(350, 613);
            btnComparar.Name = "btnComparar";
            btnComparar.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlackDarkMode;
            btnComparar.Size = new Size(118, 25);
            btnComparar.StateCommon.Back.Color1 = Color.FromArgb(46, 50, 57);
            btnComparar.StateCommon.Back.Color2 = Color.FromArgb(46, 50, 57);
            btnComparar.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            btnComparar.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TileFlipX;
            btnComparar.StateCommon.Border.Color1 = Color.White;
            btnComparar.StateCommon.Border.Color2 = Color.White;
            btnComparar.StateCommon.Border.Rounding = 10F;
            btnComparar.StateCommon.Content.LongText.Color1 = Color.White;
            btnComparar.StateCommon.Content.LongText.Color2 = Color.White;
            btnComparar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnComparar.StateDisabled.Back.Color1 = Color.FromArgb(46, 50, 57);
            btnComparar.StateDisabled.Back.Color2 = Color.FromArgb(46, 50, 57);
            btnComparar.StateDisabled.Border.Color1 = Color.White;
            btnComparar.StateDisabled.Border.Color2 = Color.White;
            btnComparar.StateNormal.Back.Color1 = Color.FromArgb(46, 50, 57);
            btnComparar.StateNormal.Back.Color2 = Color.FromArgb(46, 50, 57);
            btnComparar.StateNormal.Border.Color1 = Color.White;
            btnComparar.StateNormal.Border.Color2 = Color.White;
            btnComparar.StatePressed.Back.Color1 = Color.FromArgb(46, 50, 57);
            btnComparar.StatePressed.Back.Color2 = Color.FromArgb(46, 50, 57);
            btnComparar.StatePressed.Border.Color1 = Color.White;
            btnComparar.StatePressed.Border.Color2 = Color.White;
            btnComparar.StateTracking.Back.Color1 = Color.FromArgb(46, 50, 57);
            btnComparar.StateTracking.Back.Color2 = Color.FromArgb(46, 50, 57);
            btnComparar.StateTracking.Border.Color1 = Color.White;
            btnComparar.StateTracking.Border.Color2 = Color.White;
            btnComparar.TabIndex = 8;
            btnComparar.Values.DropDownArrowColor = Color.Empty;
            btnComparar.Values.Text = "Comparar Archivos";
            btnComparar.Click += btnComparar_Click;
            // 
            // archivoLabel1
            // 
            archivoLabel1.Location = new Point(155, 181);
            archivoLabel1.Name = "archivoLabel1";
            archivoLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365Black;
            archivoLabel1.Size = new Size(6, 2);
            archivoLabel1.TabIndex = 9;
            archivoLabel1.Values.Text = "";
            // 
            // archivoLabel2
            // 
            archivoLabel2.Location = new Point(588, 181);
            archivoLabel2.Name = "archivoLabel2";
            archivoLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365Black;
            archivoLabel2.Size = new Size(6, 2);
            archivoLabel2.TabIndex = 10;
            archivoLabel2.Values.Text = "";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(217, 142);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 23);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(619, 140);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(142, 23);
            comboBox2.TabIndex = 12;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // tablaLabel1
            // 
            tablaLabel1.Location = new Point(72, 111);
            tablaLabel1.Name = "tablaLabel1";
            tablaLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365Black;
            tablaLabel1.Size = new Size(6, 2);
            tablaLabel1.TabIndex = 13;
            tablaLabel1.Values.Text = "";
            // 
            // tablaLabel2
            // 
            tablaLabel2.Location = new Point(474, 111);
            tablaLabel2.Name = "tablaLabel2";
            tablaLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365Black;
            tablaLabel2.Size = new Size(6, 2);
            tablaLabel2.TabIndex = 14;
            tablaLabel2.Values.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 41, 43);
            ClientSize = new Size(829, 714);
            Controls.Add(tablaLabel2);
            Controls.Add(tablaLabel1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(archivoLabel2);
            Controls.Add(archivoLabel1);
            Controls.Add(btnComparar);
            Controls.Add(btnImportar2);
            Controls.Add(kryptonDataGridView2);
            Controls.Add(kryptonDataGridView1);
            Controls.Add(btnImportar1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Krypton.Toolkit.KryptonButton btnImportar1;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView2;
        private Krypton.Toolkit.KryptonButton btnImportar2;
        private Krypton.Toolkit.KryptonButton btnComparar;
        private Krypton.Toolkit.KryptonLabel archivoLabel1;
        private Krypton.Toolkit.KryptonLabel archivoLabel2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Krypton.Toolkit.KryptonLabel tablaLabel1;
        private Krypton.Toolkit.KryptonLabel tablaLabel2;
    }
}
