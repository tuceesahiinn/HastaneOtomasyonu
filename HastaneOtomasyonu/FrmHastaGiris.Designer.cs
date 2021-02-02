namespace HastaneOtomasyonu
{
    partial class FrmHastaGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.LnkUyeOl = new System.Windows.Forms.LinkLabel();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(217, 82);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(100, 35);
            this.mskTC.TabIndex = 3;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(217, 131);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(100, 35);
            this.TxtSifre.TabIndex = 4;
            // 
            // LnkUyeOl
            // 
            this.LnkUyeOl.AutoSize = true;
            this.LnkUyeOl.Location = new System.Drawing.Point(335, 131);
            this.LnkUyeOl.Name = "LnkUyeOl";
            this.LnkUyeOl.Size = new System.Drawing.Size(82, 28);
            this.LnkUyeOl.TabIndex = 5;
            this.LnkUyeOl.TabStop = true;
            this.LnkUyeOl.Text = "Üye Ol";
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Location = new System.Drawing.Point(158, 199);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(159, 39);
            this.BtnGirisYap.TabIndex = 6;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = true;
            // 
            // FrmHastaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(543, 311);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.LnkUyeOl);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmHastaGiris";
            this.Text = "FrmHastaGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.LinkLabel LnkUyeOl;
        private System.Windows.Forms.Button BtnGirisYap;
    }
}