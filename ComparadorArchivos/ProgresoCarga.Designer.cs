﻿namespace ComparadorArchivos
{
    partial class ProgresoCarga
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
            kryptonProgressBar1 = new Krypton.Toolkit.KryptonProgressBar();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            SuspendLayout();
            // 
            // kryptonProgressBar1
            // 
            kryptonProgressBar1.Location = new Point(127, 60);
            kryptonProgressBar1.Name = "kryptonProgressBar1";
            kryptonProgressBar1.Size = new Size(183, 26);
            kryptonProgressBar1.StateCommon.Back.Color1 = Color.FromArgb(21, 128, 61);
            kryptonProgressBar1.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            kryptonProgressBar1.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            kryptonProgressBar1.TabIndex = 0;
            kryptonProgressBar1.Values.Text = "";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(205, 92);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlackDarkMode;
            kryptonLabel1.Size = new Size(6, 2);
            kryptonLabel1.StateCommon.LongText.Color1 = Color.White;
            kryptonLabel1.StateCommon.LongText.Color2 = Color.White;
            kryptonLabel1.TabIndex = 1;
            kryptonLabel1.Values.Text = "";
            // 
            // ProgresoCarga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 41, 43);
            ClientSize = new Size(428, 150);
            Controls.Add(kryptonLabel1);
            Controls.Add(kryptonProgressBar1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLight;
            Name = "ProgresoCarga";
            Text = "ProgresoCarga";
            Load += ProgresoCarga_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonProgressBar kryptonProgressBar1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}