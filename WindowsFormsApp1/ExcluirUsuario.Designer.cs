namespace WindowsFormsApp1
{
    partial class ExcluirUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcluirUsuario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridExcluir = new System.Windows.Forms.DataGridView();
            this.btnExcluUser = new System.Windows.Forms.Button();
            this.colunaIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExcluir)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Geniu_imagebaixa100;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 82);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(278, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Excluir Usuário";
            // 
            // dataGridExcluir
            // 
            this.dataGridExcluir.AllowUserToAddRows = false;
            this.dataGridExcluir.AllowUserToDeleteRows = false;
            this.dataGridExcluir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExcluir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaIdCliente,
            this.colunaNome,
            this.ColunaEmail});
            this.dataGridExcluir.Location = new System.Drawing.Point(12, 117);
            this.dataGridExcluir.Name = "dataGridExcluir";
            this.dataGridExcluir.ReadOnly = true;
            this.dataGridExcluir.Size = new System.Drawing.Size(631, 150);
            this.dataGridExcluir.TabIndex = 3;
            // 
            // btnExcluUser
            // 
            this.btnExcluUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluUser.ForeColor = System.Drawing.Color.Navy;
            this.btnExcluUser.Location = new System.Drawing.Point(514, 283);
            this.btnExcluUser.Name = "btnExcluUser";
            this.btnExcluUser.Size = new System.Drawing.Size(115, 23);
            this.btnExcluUser.TabIndex = 4;
            this.btnExcluUser.Text = "Excluir";
            this.btnExcluUser.UseVisualStyleBackColor = true;
            this.btnExcluUser.Click += new System.EventHandler(this.btnExcluUser_Click);
            // 
            // colunaIdCliente
            // 
            this.colunaIdCliente.HeaderText = "Login";
            this.colunaIdCliente.Name = "colunaIdCliente";
            this.colunaIdCliente.ReadOnly = true;
            this.colunaIdCliente.Width = 200;
            // 
            // colunaNome
            // 
            this.colunaNome.HeaderText = "Tipo";
            this.colunaNome.Name = "colunaNome";
            this.colunaNome.ReadOnly = true;
            this.colunaNome.Width = 150;
            // 
            // ColunaEmail
            // 
            this.ColunaEmail.HeaderText = "Nome";
            this.ColunaEmail.Name = "ColunaEmail";
            this.ColunaEmail.ReadOnly = true;
            this.ColunaEmail.Width = 230;
            // 
            // ExcluirUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(655, 318);
            this.Controls.Add(this.btnExcluUser);
            this.Controls.Add(this.dataGridExcluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExcluirUsuario";
            this.Text = "ExcluirUsuario";
            this.Load += new System.EventHandler(this.ExcluirUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExcluir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridExcluir;
        private System.Windows.Forms.Button btnExcluUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaEmail;
    }
}