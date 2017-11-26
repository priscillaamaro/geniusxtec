namespace WindowsFormsApp1
{
    partial class AddChamadoTela
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddChamadoTela));
            this.label1 = new System.Windows.Forms.Label();
            this.cbPrioridade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.descrever = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalvarnew = new System.Windows.Forms.Button();
            this.btnLimparNew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.responsavelLabel = new System.Windows.Forms.Label();
            this.cbResponsavel = new System.Windows.Forms.ComboBox();
            this.epAddChamado = new System.Windows.Forms.ErrorProvider(this.components);
            this.component11 = new WindowsFormsApp1.Component1(this.components);
            this.cbClientes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAddChamado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(251, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar novo chamado Chamado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbPrioridade
            // 
            this.cbPrioridade.FormattingEnabled = true;
            this.cbPrioridade.Location = new System.Drawing.Point(135, 192);
            this.cbPrioridade.Name = "cbPrioridade";
            this.cbPrioridade.Size = new System.Drawing.Size(165, 21);
            this.cbPrioridade.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(9, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prioridade";
            // 
            // descrever
            // 
            this.descrever.Location = new System.Drawing.Point(340, 141);
            this.descrever.Multiline = true;
            this.descrever.Name = "descrever";
            this.descrever.Size = new System.Drawing.Size(318, 163);
            this.descrever.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(337, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Descrição do chamado";
            // 
            // btnSalvarnew
            // 
            this.btnSalvarnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarnew.ForeColor = System.Drawing.Color.Navy;
            this.btnSalvarnew.Location = new System.Drawing.Point(565, 317);
            this.btnSalvarnew.Name = "btnSalvarnew";
            this.btnSalvarnew.Size = new System.Drawing.Size(93, 23);
            this.btnSalvarnew.TabIndex = 11;
            this.btnSalvarnew.Text = "Salvar chamado";
            this.btnSalvarnew.UseVisualStyleBackColor = true;
            this.btnSalvarnew.Click += new System.EventHandler(this.btnSalvarnew_Click);
            // 
            // btnLimparNew
            // 
            this.btnLimparNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparNew.ForeColor = System.Drawing.Color.Navy;
            this.btnLimparNew.Location = new System.Drawing.Point(454, 317);
            this.btnLimparNew.Name = "btnLimparNew";
            this.btnLimparNew.Size = new System.Drawing.Size(93, 23);
            this.btnLimparNew.TabIndex = 12;
            this.btnLimparNew.Text = "Limpar";
            this.btnLimparNew.UseVisualStyleBackColor = true;
            this.btnLimparNew.Click += new System.EventHandler(this.btnLimparNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Geniu_imagebaixa100;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 83);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // responsavelLabel
            // 
            this.responsavelLabel.AutoSize = true;
            this.responsavelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responsavelLabel.ForeColor = System.Drawing.Color.Navy;
            this.responsavelLabel.Location = new System.Drawing.Point(12, 242);
            this.responsavelLabel.Name = "responsavelLabel";
            this.responsavelLabel.Size = new System.Drawing.Size(80, 13);
            this.responsavelLabel.TabIndex = 17;
            this.responsavelLabel.Text = "Responsável";
            // 
            // cbResponsavel
            // 
            this.cbResponsavel.FormattingEnabled = true;
            this.cbResponsavel.Location = new System.Drawing.Point(135, 234);
            this.cbResponsavel.Name = "cbResponsavel";
            this.cbResponsavel.Size = new System.Drawing.Size(165, 21);
            this.cbResponsavel.TabIndex = 18;
            this.cbResponsavel.SelectedIndexChanged += new System.EventHandler(this.cbMeioContato_SelectedIndexChanged);
            // 
            // epAddChamado
            // 
            this.epAddChamado.ContainerControl = this;
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(135, 144);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(165, 21);
            this.cbClientes.TabIndex = 21;
            // 
            // addChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(670, 349);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.cbResponsavel);
            this.Controls.Add(this.responsavelLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimparNew);
            this.Controls.Add(this.btnSalvarnew);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.descrever);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPrioridade);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addChamado";
            this.Text = "Genius X Tec - Novo Chamado";
            this.Load += new System.EventHandler(this.formAddChamado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAddChamado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPrioridade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descrever;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalvarnew;
        private System.Windows.Forms.Button btnLimparNew;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label responsavelLabel;
        private System.Windows.Forms.ComboBox cbResponsavel;
        private System.Windows.Forms.ErrorProvider epAddChamado;
        private System.Windows.Forms.ComboBox cbClientes;
        private Component1 component11;
    }
}