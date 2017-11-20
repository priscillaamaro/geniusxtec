namespace WindowsFormsApp1
{
    partial class addUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTipoUser = new System.Windows.Forms.ComboBox();
            this.dataGridViewNewUser = new System.Windows.Forms.DataGridView();
            this.ColunaLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailUser = new System.Windows.Forms.TextBox();
            this.salvarNewUser = new System.Windows.Forms.Button();
            this.limparNewUser = new System.Windows.Forms.Button();
            this.btnSairNewUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSenhaAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtconfirmSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.epAddUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAddUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(227, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar novo usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo usuário";
            // 
            // comboTipoUser
            // 
            this.comboTipoUser.FormattingEnabled = true;
            this.comboTipoUser.Location = new System.Drawing.Point(150, 150);
            this.comboTipoUser.Name = "comboTipoUser";
            this.comboTipoUser.Size = new System.Drawing.Size(369, 21);
            this.comboTipoUser.TabIndex = 2;
            // 
            // dataGridViewNewUser
            // 
            this.dataGridViewNewUser.AllowUserToAddRows = false;
            this.dataGridViewNewUser.AllowUserToDeleteRows = false;
            this.dataGridViewNewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaLogin,
            this.ColunaTipo,
            this.ColunaNome});
            this.dataGridViewNewUser.Location = new System.Drawing.Point(-1, 319);
            this.dataGridViewNewUser.Name = "dataGridViewNewUser";
            this.dataGridViewNewUser.ReadOnly = true;
            this.dataGridViewNewUser.Size = new System.Drawing.Size(534, 150);
            this.dataGridViewNewUser.TabIndex = 3;
            this.dataGridViewNewUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNewUser_CellContentClick);
            // 
            // ColunaLogin
            // 
            this.ColunaLogin.HeaderText = "Login";
            this.ColunaLogin.Name = "ColunaLogin";
            this.ColunaLogin.ReadOnly = true;
            this.ColunaLogin.Width = 150;
            // 
            // ColunaTipo
            // 
            this.ColunaTipo.HeaderText = "Tipo";
            this.ColunaTipo.Name = "ColunaTipo";
            this.ColunaTipo.ReadOnly = true;
            this.ColunaTipo.Width = 140;
            // 
            // ColunaNome
            // 
            this.ColunaNome.HeaderText = "Nome";
            this.ColunaNome.Name = "ColunaNome";
            this.ColunaNome.ReadOnly = true;
            this.ColunaNome.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome Usuário";
            // 
            // txtNomeUser
            // 
            this.txtNomeUser.Location = new System.Drawing.Point(150, 113);
            this.txtNomeUser.Name = "txtNomeUser";
            this.txtNomeUser.Size = new System.Drawing.Size(369, 20);
            this.txtNomeUser.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(12, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // txtEmailUser
            // 
            this.txtEmailUser.Location = new System.Drawing.Point(150, 192);
            this.txtEmailUser.Name = "txtEmailUser";
            this.txtEmailUser.Size = new System.Drawing.Size(369, 20);
            this.txtEmailUser.TabIndex = 7;
            // 
            // salvarNewUser
            // 
            this.salvarNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarNewUser.ForeColor = System.Drawing.Color.Navy;
            this.salvarNewUser.Location = new System.Drawing.Point(276, 475);
            this.salvarNewUser.Name = "salvarNewUser";
            this.salvarNewUser.Size = new System.Drawing.Size(75, 23);
            this.salvarNewUser.TabIndex = 8;
            this.salvarNewUser.Text = "Salvar";
            this.salvarNewUser.UseVisualStyleBackColor = true;
            this.salvarNewUser.Click += new System.EventHandler(this.salvarNewUser_Click);
            // 
            // limparNewUser
            // 
            this.limparNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparNewUser.ForeColor = System.Drawing.Color.Navy;
            this.limparNewUser.Location = new System.Drawing.Point(368, 475);
            this.limparNewUser.Name = "limparNewUser";
            this.limparNewUser.Size = new System.Drawing.Size(75, 23);
            this.limparNewUser.TabIndex = 9;
            this.limparNewUser.Text = "Limpar";
            this.limparNewUser.UseVisualStyleBackColor = true;
            this.limparNewUser.Click += new System.EventHandler(this.limparNewUser_Click);
            // 
            // btnSairNewUser
            // 
            this.btnSairNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairNewUser.ForeColor = System.Drawing.Color.Navy;
            this.btnSairNewUser.Location = new System.Drawing.Point(458, 475);
            this.btnSairNewUser.Name = "btnSairNewUser";
            this.btnSairNewUser.Size = new System.Drawing.Size(75, 23);
            this.btnSairNewUser.TabIndex = 10;
            this.btnSairNewUser.Text = "Sair";
            this.btnSairNewUser.UseVisualStyleBackColor = true;
            this.btnSairNewUser.Click += new System.EventHandler(this.btnSairNewUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Geniu_imagebaixa100;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 70);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtSenhaAdd
            // 
            this.txtSenhaAdd.Location = new System.Drawing.Point(150, 232);
            this.txtSenhaAdd.Name = "txtSenhaAdd";
            this.txtSenhaAdd.PasswordChar = '*';
            this.txtSenhaAdd.Size = new System.Drawing.Size(369, 20);
            this.txtSenhaAdd.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(12, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Senha";
            // 
            // txtconfirmSenha
            // 
            this.txtconfirmSenha.Location = new System.Drawing.Point(150, 272);
            this.txtconfirmSenha.Name = "txtconfirmSenha";
            this.txtconfirmSenha.PasswordChar = '*';
            this.txtconfirmSenha.Size = new System.Drawing.Size(369, 20);
            this.txtconfirmSenha.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(12, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Confirmar senha";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 505);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(12, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Versão 1.0";
            // 
            // epAddUsuario
            // 
            this.epAddUsuario.ContainerControl = this;
            // 
            // addUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(545, 523);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtconfirmSenha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSenhaAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSairNewUser);
            this.Controls.Add(this.limparNewUser);
            this.Controls.Add(this.salvarNewUser);
            this.Controls.Add(this.txtEmailUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewNewUser);
            this.Controls.Add(this.comboTipoUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addUsuario";
            this.Text = "addUsuario";
            this.Load += new System.EventHandler(this.addUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAddUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTipoUser;
        private System.Windows.Forms.DataGridView dataGridViewNewUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailUser;
        private System.Windows.Forms.Button salvarNewUser;
        private System.Windows.Forms.Button limparNewUser;
        private System.Windows.Forms.Button btnSairNewUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSenhaAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtconfirmSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider epAddUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaNome;
    }
}