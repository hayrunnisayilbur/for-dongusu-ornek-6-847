namespace for_dongusu_ornek6_847
{
    partial class Form1
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
            this.lbTek = new System.Windows.Forms.ListBox();
            this.lbCift = new System.Windows.Forms.ListBox();
            this.txtBaslangic = new System.Windows.Forms.TextBox();
            this.txtBitis = new System.Windows.Forms.TextBox();
            this.btnYaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTek
            // 
            this.lbTek.FormattingEnabled = true;
            this.lbTek.Location = new System.Drawing.Point(319, 65);
            this.lbTek.Name = "lbTek";
            this.lbTek.Size = new System.Drawing.Size(135, 212);
            this.lbTek.TabIndex = 0;
            // 
            // lbCift
            // 
            this.lbCift.FormattingEnabled = true;
            this.lbCift.Location = new System.Drawing.Point(475, 65);
            this.lbCift.Name = "lbCift";
            this.lbCift.Size = new System.Drawing.Size(128, 212);
            this.lbCift.TabIndex = 1;
            // 
            // txtBaslangic
            // 
            this.txtBaslangic.Location = new System.Drawing.Point(158, 93);
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.Size = new System.Drawing.Size(135, 20);
            this.txtBaslangic.TabIndex = 2;
            // 
            // txtBitis
            // 
            this.txtBitis.Location = new System.Drawing.Point(158, 147);
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.Size = new System.Drawing.Size(135, 20);
            this.txtBitis.TabIndex = 3;
            // 
            // btnYaz
            // 
            this.btnYaz.Location = new System.Drawing.Point(158, 189);
            this.btnYaz.Name = "btnYaz";
            this.btnYaz.Size = new System.Drawing.Size(135, 42);
            this.btnYaz.TabIndex = 4;
            this.btnYaz.Text = "yaz";
            this.btnYaz.UseVisualStyleBackColor = true;
            this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYaz);
            this.Controls.Add(this.txtBitis);
            this.Controls.Add(this.txtBaslangic);
            this.Controls.Add(this.lbCift);
            this.Controls.Add(this.lbTek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTek;
        private System.Windows.Forms.ListBox lbCift;
        private System.Windows.Forms.TextBox txtBaslangic;
        private System.Windows.Forms.TextBox txtBitis;
        private System.Windows.Forms.Button btnYaz;
    }
}

