namespace WindowsFormsApp1
{
    partial class sistemaAberturaChamado
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sistemaAberturaChamado));
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.btnNovoChamado = new System.Windows.Forms.Button();
            this.btnEditardesc = new System.Windows.Forms.Button();
            this.btnSalvarAltr = new System.Windows.Forms.Button();
            this.btncriarUsuario = new System.Windows.Forms.Button();
            this.dataGridChamado = new System.Windows.Forms.DataGridView();
            this.txtDescChamado = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRespons = new System.Windows.Forms.Label();
            this.btnExcluirUsuario = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnrelatorio = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblversao = new System.Windows.Forms.Label();
            this.btnNewCliente = new System.Windows.Forms.Button();
            this.btncontacAdm = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureGenius = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ColunaChamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunastatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaPrioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaReponsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaDataAbertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaLoginCriacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunadataFechamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChamado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGenius)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Navy;
            this.lbl1.Location = new System.Drawing.Point(9, 616);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(43, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Nome:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Navy;
            this.lbl2.Location = new System.Drawing.Point(9, 651);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(47, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Status:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.Navy;
            this.lbl3.Location = new System.Drawing.Point(9, 689);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(84, 13);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Responsável:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(99, 616);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(0, 13);
            this.lblnome.TabIndex = 3;
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.ForeColor = System.Drawing.Color.Navy;
            this.lblDes.Location = new System.Drawing.Point(12, 513);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(137, 13);
            this.lblDes.TabIndex = 4;
            this.lblDes.Text = "Descrição do chamado";
            // 
            // btnNovoChamado
            // 
            this.btnNovoChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoChamado.ForeColor = System.Drawing.Color.Navy;
            this.btnNovoChamado.Location = new System.Drawing.Point(273, 67);
            this.btnNovoChamado.Name = "btnNovoChamado";
            this.btnNovoChamado.Size = new System.Drawing.Size(121, 33);
            this.btnNovoChamado.TabIndex = 5;
            this.btnNovoChamado.Text = "&Novo Chamado";
            this.btnNovoChamado.UseVisualStyleBackColor = true;
            this.btnNovoChamado.Click += new System.EventHandler(this.btnNovoChamado_Click);
            // 
            // btnEditardesc
            // 
            this.btnEditardesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditardesc.ForeColor = System.Drawing.Color.Navy;
            this.btnEditardesc.Location = new System.Drawing.Point(781, 623);
            this.btnEditardesc.Name = "btnEditardesc";
            this.btnEditardesc.Size = new System.Drawing.Size(121, 33);
            this.btnEditardesc.TabIndex = 6;
            this.btnEditardesc.Text = "&Editar Descrição";
            this.btnEditardesc.UseVisualStyleBackColor = true;
            // 
            // btnSalvarAltr
            // 
            this.btnSalvarAltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarAltr.ForeColor = System.Drawing.Color.Navy;
            this.btnSalvarAltr.Location = new System.Drawing.Point(908, 621);
            this.btnSalvarAltr.Name = "btnSalvarAltr";
            this.btnSalvarAltr.Size = new System.Drawing.Size(121, 35);
            this.btnSalvarAltr.TabIndex = 7;
            this.btnSalvarAltr.Text = "Salvar alteração";
            this.btnSalvarAltr.UseVisualStyleBackColor = true;
            this.btnSalvarAltr.Click += new System.EventHandler(this.btnSalvarAltr_Click);
            // 
            // btncriarUsuario
            // 
            this.btncriarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncriarUsuario.ForeColor = System.Drawing.Color.Navy;
            this.btncriarUsuario.Location = new System.Drawing.Point(400, 67);
            this.btncriarUsuario.Name = "btncriarUsuario";
            this.btncriarUsuario.Size = new System.Drawing.Size(121, 33);
            this.btncriarUsuario.TabIndex = 8;
            this.btncriarUsuario.Text = "N&ovo usuário";
            this.btncriarUsuario.UseVisualStyleBackColor = true;
            this.btncriarUsuario.Click += new System.EventHandler(this.btncriarUsuario_Click);
            // 
            // dataGridChamado
            // 
            this.dataGridChamado.AllowUserToAddRows = false;
            this.dataGridChamado.AllowUserToDeleteRows = false;
            this.dataGridChamado.AllowUserToOrderColumns = true;
            this.dataGridChamado.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridChamado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridChamado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaChamado,
            this.ColunaDescricao,
            this.colunaIdCliente,
            this.colunastatus,
            this.ColunaPrioridade,
            this.colunaReponsavel,
            this.colunaDataAbertura,
            this.ColunaLoginCriacao,
            this.ColunadataFechamento});
            this.dataGridChamado.GridColor = System.Drawing.Color.Navy;
            this.dataGridChamado.Location = new System.Drawing.Point(12, 156);
            this.dataGridChamado.Name = "dataGridChamado";
            this.dataGridChamado.ReadOnly = true;
            this.dataGridChamado.Size = new System.Drawing.Size(1144, 345);
            this.dataGridChamado.TabIndex = 9;
            this.dataGridChamado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridChamado_CellContentClick);
            // 
            // txtDescChamado
            // 
            this.txtDescChamado.Location = new System.Drawing.Point(12, 529);
            this.txtDescChamado.Multiline = true;
            this.txtDescChamado.Name = "txtDescChamado";
            this.txtDescChamado.Size = new System.Drawing.Size(1144, 86);
            this.txtDescChamado.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(99, 651);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 12;
            // 
            // lblRespons
            // 
            this.lblRespons.AutoSize = true;
            this.lblRespons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespons.Location = new System.Drawing.Point(99, 689);
            this.lblRespons.Name = "lblRespons";
            this.lblRespons.Size = new System.Drawing.Size(0, 13);
            this.lblRespons.TabIndex = 13;
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirUsuario.ForeColor = System.Drawing.Color.Navy;
            this.btnExcluirUsuario.Location = new System.Drawing.Point(527, 67);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.Size = new System.Drawing.Size(121, 33);
            this.btnExcluirUsuario.TabIndex = 14;
            this.btnExcluirUsuario.Text = "&Excluir Usuários";
            this.btnExcluirUsuario.UseVisualStyleBackColor = true;
            this.btnExcluirUsuario.Click += new System.EventHandler(this.btnExcluirUsuario_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblTitulo.Location = new System.Drawing.Point(358, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(504, 39);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Gerenciamento de Chamados";
            // 
            // btnrelatorio
            // 
            this.btnrelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrelatorio.ForeColor = System.Drawing.Color.Navy;
            this.btnrelatorio.Location = new System.Drawing.Point(654, 67);
            this.btnrelatorio.Name = "btnrelatorio";
            this.btnrelatorio.Size = new System.Drawing.Size(121, 33);
            this.btnrelatorio.TabIndex = 17;
            this.btnrelatorio.Text = "&Relatórios";
            this.btnrelatorio.UseVisualStyleBackColor = true;
            this.btnrelatorio.Click += new System.EventHandler(this.btnrelatorio_Click);
            // 
            // btnManual
            // 
            this.btnManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.ForeColor = System.Drawing.Color.Navy;
            this.btnManual.Location = new System.Drawing.Point(1035, 67);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(121, 33);
            this.btnManual.TabIndex = 18;
            this.btnManual.Text = "&Manual do sistema";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Navy;
            this.btnSair.Location = new System.Drawing.Point(1035, 623);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 33);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblversao
            // 
            this.lblversao.AutoSize = true;
            this.lblversao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblversao.ForeColor = System.Drawing.Color.Navy;
            this.lblversao.Location = new System.Drawing.Point(12, 103);
            this.lblversao.Name = "lblversao";
            this.lblversao.Size = new System.Drawing.Size(104, 13);
            this.lblversao.TabIndex = 21;
            this.lblversao.Text = "Versão 1.0  2017";
            // 
            // btnNewCliente
            // 
            this.btnNewCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCliente.ForeColor = System.Drawing.Color.Navy;
            this.btnNewCliente.Location = new System.Drawing.Point(781, 67);
            this.btnNewCliente.Name = "btnNewCliente";
            this.btnNewCliente.Size = new System.Drawing.Size(121, 33);
            this.btnNewCliente.TabIndex = 22;
            this.btnNewCliente.Text = "&Novo Cliente";
            this.btnNewCliente.UseVisualStyleBackColor = true;
            this.btnNewCliente.Click += new System.EventHandler(this.btnNewCliente_Click);
            // 
            // btncontacAdm
            // 
            this.btncontacAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontacAdm.ForeColor = System.Drawing.Color.Navy;
            this.btncontacAdm.Location = new System.Drawing.Point(908, 67);
            this.btncontacAdm.Name = "btncontacAdm";
            this.btncontacAdm.Size = new System.Drawing.Size(121, 33);
            this.btncontacAdm.TabIndex = 23;
            this.btncontacAdm.Text = "&Contactar ADM";
            this.btncontacAdm.UseVisualStyleBackColor = true;
            this.btncontacAdm.Click += new System.EventHandler(this.btncontacAdm_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(9, 720);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(120, 13);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.geniusxtec.com.br";
            // 
            // pictureGenius
            // 
            this.pictureGenius.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Geniu_imagebaixa1;
            this.pictureGenius.Image = global::WindowsFormsApp1.Properties.Resources.Geniu_imagebaixa;
            this.pictureGenius.Location = new System.Drawing.Point(15, 12);
            this.pictureGenius.Name = "pictureGenius";
            this.pictureGenius.Size = new System.Drawing.Size(226, 88);
            this.pictureGenius.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureGenius.TabIndex = 10;
            this.pictureGenius.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(397, 720);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Contatar o ADM. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(548, 720);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Fale conosco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(216, 720);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Versão 1.0  2017";
            // 
            // ColunaChamado
            // 
            this.ColunaChamado.HeaderText = "Chamado";
            this.ColunaChamado.Name = "ColunaChamado";
            this.ColunaChamado.ReadOnly = true;
            this.ColunaChamado.Width = 80;
            // 
            // ColunaDescricao
            // 
            this.ColunaDescricao.HeaderText = "Descrição";
            this.ColunaDescricao.Name = "ColunaDescricao";
            this.ColunaDescricao.ReadOnly = true;
            this.ColunaDescricao.Width = 200;
            // 
            // colunaIdCliente
            // 
            this.colunaIdCliente.HeaderText = "Cliente";
            this.colunaIdCliente.Name = "colunaIdCliente";
            this.colunaIdCliente.ReadOnly = true;
            this.colunaIdCliente.Width = 150;
            // 
            // colunastatus
            // 
            this.colunastatus.HeaderText = "Status";
            this.colunastatus.Name = "colunastatus";
            this.colunastatus.ReadOnly = true;
            // 
            // ColunaPrioridade
            // 
            this.ColunaPrioridade.HeaderText = "Prioridade";
            this.ColunaPrioridade.Name = "ColunaPrioridade";
            this.ColunaPrioridade.ReadOnly = true;
            // 
            // colunaReponsavel
            // 
            this.colunaReponsavel.HeaderText = "Responsável";
            this.colunaReponsavel.Name = "colunaReponsavel";
            this.colunaReponsavel.ReadOnly = true;
            this.colunaReponsavel.Width = 120;
            // 
            // colunaDataAbertura
            // 
            this.colunaDataAbertura.HeaderText = "Data Abertura";
            this.colunaDataAbertura.Name = "colunaDataAbertura";
            this.colunaDataAbertura.ReadOnly = true;
            // 
            // ColunaLoginCriacao
            // 
            this.ColunaLoginCriacao.HeaderText = "Criado por";
            this.ColunaLoginCriacao.Name = "ColunaLoginCriacao";
            this.ColunaLoginCriacao.ReadOnly = true;
            this.ColunaLoginCriacao.Width = 120;
            // 
            // ColunadataFechamento
            // 
            this.ColunadataFechamento.HeaderText = "Data Fechamento";
            this.ColunadataFechamento.Name = "ColunadataFechamento";
            this.ColunadataFechamento.ReadOnly = true;
            this.ColunadataFechamento.Width = 120;
            // 
            // sistemaAberturaChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1174, 733);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btncontacAdm);
            this.Controls.Add(this.btnNewCliente);
            this.Controls.Add(this.lblversao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnrelatorio);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnExcluirUsuario);
            this.Controls.Add(this.lblRespons);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtDescChamado);
            this.Controls.Add(this.pictureGenius);
            this.Controls.Add(this.dataGridChamado);
            this.Controls.Add(this.btncriarUsuario);
            this.Controls.Add(this.btnSalvarAltr);
            this.Controls.Add(this.btnEditardesc);
            this.Controls.Add(this.btnNovoChamado);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sistemaAberturaChamado";
            this.Text = "Genius X Tec.";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.sistemaAberturaChamado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChamado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGenius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Button btnNovoChamado;
        private System.Windows.Forms.Button btnEditardesc;
        private System.Windows.Forms.Button btnSalvarAltr;
        private System.Windows.Forms.Button btncriarUsuario;
        private System.Windows.Forms.DataGridView dataGridChamado;
        private System.Windows.Forms.PictureBox pictureGenius;
        private System.Windows.Forms.TextBox txtDescChamado;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRespons;
        private System.Windows.Forms.Button btnExcluirUsuario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnrelatorio;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblversao;
        private System.Windows.Forms.Button btnNewCliente;
        private System.Windows.Forms.Button btncontacAdm;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaChamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunastatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaPrioridade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaReponsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaDataAbertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaLoginCriacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunadataFechamento;
    }
}

