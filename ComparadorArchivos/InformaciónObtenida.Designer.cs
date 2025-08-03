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
            // InformaciónObtenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 41, 43);
            ClientSize = new Size(520, 328);
            Controls.Add(kryptonDataGridView2);
            Name = "InformaciónObtenida";
            Text = "InformaciónObtenida";
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView2;
    }
}