namespace ComparadorArchivos
{
    partial class InformaciónObtenida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            kryptonDataGridView2 = new Krypton.Toolkit.KryptonDataGridView();
            btnExportar = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView2).BeginInit();
            SuspendLayout();
            // 
            // kryptonDataGridView2
            // 
            kryptonDataGridView2.AllowUserToAddRows = false;
            kryptonDataGridView2.AllowUserToDeleteRows = false;
            kryptonDataGridView2.BorderStyle = BorderStyle.None;
            kryptonDataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kryptonDataGridView2.Location = new Point(47, 53);
            kryptonDataGridView2.Name = "kryptonDataGridView2";
            kryptonDataGridView2.ReadOnly = true;
            kryptonDataGridView2.Size = new Size(247, 208);
            kryptonDataGridView2.StateCommon.Background.Color1 = Color.FromArgb(162, 178, 238);
            kryptonDataGridView2.StateCommon.Background.Color2 = Color.FromArgb(162, 178, 238);
            kryptonDataGridView2.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            kryptonDataGridView2.TabIndex = 7;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(349, 119);
            btnExportar.Name = "btnExportar";
            btnExportar.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlackDarkMode;
            btnExportar.Size = new Size(118, 25);
            btnExportar.StateCommon.Back.Color1 = Color.FromArgb(46, 50, 57);
            btnExportar.StateCommon.Back.Color2 = Color.FromArgb(46, 50, 57);
            btnExportar.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            btnExportar.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TileFlipX;
            btnExportar.StateCommon.Border.Color1 = Color.White;
            btnExportar.StateCommon.Border.Color2 = Color.White;
            btnExportar.StateCommon.Border.Rounding = 10F;
            btnExportar.StateCommon.Content.LongText.Color1 = Color.White;
            btnExportar.StateCommon.Content.LongText.Color2 = Color.White;
            btnExportar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnExportar.StateDisabled.Back.Color1 = Color.FromArgb(46, 50, 57);
            btnExportar.StateDisabled.Back.Color2 = Color.FromArgb(46, 50, 57);
            btnExportar.StateDisabled.Border.Color1 = Color.White;
            btnExportar.StateDisabled.Border.Color2 = Color.White;
            btnExportar.StateNormal.Back.Color1 = Color.FromArgb(46, 50, 57);
            btnExportar.StateNormal.Back.Color2 = Color.FromArgb(46, 50, 57);
            btnExportar.StateNormal.Border.Color1 = Color.White;
            btnExportar.StateNormal.Border.Color2 = Color.White;
            btnExportar.StatePressed.Back.Color1 = Color.FromArgb(46, 50, 57);
            btnExportar.StatePressed.Back.Color2 = Color.FromArgb(46, 50, 57);
            btnExportar.StatePressed.Border.Color1 = Color.White;
            btnExportar.StatePressed.Border.Color2 = Color.White;
            btnExportar.StateTracking.Back.Color1 = Color.FromArgb(46, 50, 57);
            btnExportar.StateTracking.Back.Color2 = Color.FromArgb(46, 50, 57);
            btnExportar.StateTracking.Border.Color1 = Color.White;
            btnExportar.StateTracking.Border.Color2 = Color.White;
            btnExportar.TabIndex = 8;
            btnExportar.Values.DropDownArrowColor = Color.Empty;
            btnExportar.Values.Text = "Exportar a Excel";
            btnExportar.Click += btnExportar_Click;
            // 
            // InformaciónObtenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 41, 43);
            ClientSize = new Size(520, 328);
            Controls.Add(btnExportar);
            Controls.Add(kryptonDataGridView2);
            Name = "InformaciónObtenida";
            Text = "InformaciónObtenida";
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView2;
        private Krypton.Toolkit.KryptonButton btnExportar;
    }
}