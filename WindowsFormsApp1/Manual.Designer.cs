namespace WindowsFormsApp1
{
    partial class manualSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manualSistema));
            this.label1 = new System.Windows.Forms.Label();
            this.sairManual = new System.Windows.Forms.Button();
            this.contactADM = new System.Windows.Forms.LinkLabel();
            this.falegenius = new System.Windows.Forms.LinkLabel();
            this.sitegenius = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(453, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manual Genius Service Desk";
            // 
            // sairManual
            // 
            this.sairManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairManual.ForeColor = System.Drawing.Color.Navy;
            this.sairManual.Location = new System.Drawing.Point(907, 657);
            this.sairManual.Name = "sairManual";
            this.sairManual.Size = new System.Drawing.Size(75, 23);
            this.sairManual.TabIndex = 3;
            this.sairManual.Text = "Sair";
            this.sairManual.UseVisualStyleBackColor = true;
            this.sairManual.Click += new System.EventHandler(this.sairManual_Click);
            // 
            // contactADM
            // 
            this.contactADM.AutoSize = true;
            this.contactADM.Location = new System.Drawing.Point(214, 669);
            this.contactADM.Name = "contactADM";
            this.contactADM.Size = new System.Drawing.Size(85, 13);
            this.contactADM.TabIndex = 4;
            this.contactADM.TabStop = true;
            this.contactADM.Text = "Contactar Admin";
            // 
            // falegenius
            // 
            this.falegenius.AutoSize = true;
            this.falegenius.Location = new System.Drawing.Point(415, 669);
            this.falegenius.Name = "falegenius";
            this.falegenius.Size = new System.Drawing.Size(71, 13);
            this.falegenius.TabIndex = 5;
            this.falegenius.TabStop = true;
            this.falegenius.Text = "Fale conosco";
            // 
            // sitegenius
            // 
            this.sitegenius.AutoSize = true;
            this.sitegenius.Location = new System.Drawing.Point(12, 669);
            this.sitegenius.Name = "sitegenius";
            this.sitegenius.Size = new System.Drawing.Size(120, 13);
            this.sitegenius.TabIndex = 6;
            this.sitegenius.TabStop = true;
            this.sitegenius.Text = "www.geniusxtec.com.br";
            this.sitegenius.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sitegenius_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Genius X Tec. Versão 1.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Geniu_imagebaixa1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 125);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 166);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(970, 476);
            this.textBox1.TabIndex = 8;
            // 
            // manualSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(999, 689);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sitegenius);
            this.Controls.Add(this.falegenius);
            this.Controls.Add(this.contactADM);
            this.Controls.Add(this.sairManual);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "manualSistema";
            this.Text = "Manual do sistema";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sairManual;
        private System.Windows.Forms.LinkLabel contactADM;
        private System.Windows.Forms.LinkLabel falegenius;
        private System.Windows.Forms.LinkLabel sitegenius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}