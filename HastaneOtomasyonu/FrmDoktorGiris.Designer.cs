namespace HastaneOtomasyonu
{
    partial class FrmDoktorGiris
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
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(103, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doktor Giriş Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 134);
            this.label2.TabIndex = 2;
            this.label2.Text = "TC Kimlik No:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(262, 135);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(143, 34);
            this.mskTC.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 134);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(262, 201);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(143, 34);
            this.TxtSifre.TabIndex = 6;
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Location = new System.Drawing.Point(252, 264);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(184, 99);
            this.BtnGirisYap.TabIndex = 7;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = true;
            // 
            // FrmDoktorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 129F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(676, 411);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria Math", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 24, 5, 24);
            this.Name = "FrmDoktorGiris";
            this.Text = "FrmDoktorGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Button BtnGirisYap;
    }
}