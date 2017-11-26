namespace WindowsFormsApp1
{
    partial class TelaInicial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.usuarioAutenticado = new System.Windows.Forms.Label();
            this.btncontacAdm = new System.Windows.Forms.Button();
            this.btnNewCliente = new System.Windows.Forms.Button();
            this.lblversao = new System.Windows.Forms.Label();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnrelatorio = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnExcluirUsuario = new System.Windows.Forms.Button();
            this.pictureGenius = new System.Windows.Forms.PictureBox();
            this.dataGridChamado = new System.Windows.Forms.DataGridView();
            this.ColunaChamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunastatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaPrioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaReponsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaDataAbertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaLoginCriacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunadataFechamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncriarUsuario = new System.Windows.Forms.Button();
            this.btnNovoChamado = new System.Windows.Forms.Button();
            this.prioridadeTb = new System.Windows.Forms.TextBox();
            this.statusCb = new System.Windows.Forms.ComboBox();
            this.responsavelCb = new System.Windows.Forms.ComboBox();
            this.abertoPorTb = new System.Windows.Forms.TextBox();
            this.dataCriacaoTb = new System.Windows.Forms.TextBox();
            this.clienteTb = new System.Windows.Forms.TextBox();
            this.dataFechamentoTb = new System.Windows.Forms.TextBox();
            this.numeroTb = new System.Windows.Forms.TextBox();
            this.abertoPorLabel = new System.Windows.Forms.Label();
            this.dataFechamentoLabel = new System.Windows.Forms.Label();
            this.prioridadeLabel = new System.Windows.Forms.Label();
            this.dataCriacaoLabel = new System.Windows.Forms.Label();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnSair = new System.Windows.Forms.Button();
            this.descricaoTb = new System.Windows.Forms.TextBox();
            this.btnSalvarAltr = new System.Windows.Forms.Button();
            this.btnEditarChamado = new System.Windows.Forms.Button();
            this.lblDes = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.clienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGenius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChamado)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioAutenticado
            // 
            this.usuarioAutenticado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.usuarioAutenticado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioAutenticado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usuarioAutenticado.Location = new System.Drawing.Point(886, 12);
            this.usuarioAutenticado.Name = "usuarioAutenticado";
            this.usuarioAutenticado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.usuarioAutenticado.Size = new System.Drawing.Size(270, 15);
            this.usuarioAutenticado.TabIndex = 55;
            this.usuarioAutenticado.Text = "Usuario - Tipos";
            this.usuarioAutenticado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btncontacAdm
            // 
            this.btncontacAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontacAdm.ForeColor = System.Drawing.Color.Navy;
            this.btncontacAdm.Location = new System.Drawing.Point(905, 67);
            this.btncontacAdm.Name = "btncontacAdm";
            this.btncontacAdm.Size = new System.Drawing.Size(121, 33);
            this.btncontacAdm.TabIndex = 54;
            this.btncontacAdm.Text = "&Contactar ADM";
            this.btncontacAdm.UseVisualStyleBackColor = true;
            this.btncontacAdm.Click += new System.EventHandler(this.btncontacAdm_Click);
            // 
            // btnNewCliente
            // 
            this.btnNewCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCliente.ForeColor = System.Drawing.Color.Navy;
            this.btnNewCliente.Location = new System.Drawing.Point(778, 67);
            this.btnNewCliente.Name = "btnNewCliente";
            this.btnNewCliente.Size = new System.Drawing.Size(121, 33);
            this.btnNewCliente.TabIndex = 53;
            this.btnNewCliente.Text = "&Novo Cliente";
            this.btnNewCliente.UseVisualStyleBackColor = true;
            this.btnNewCliente.Click += new System.EventHandler(this.btnNewCliente_Click);
            // 
            // lblversao
            // 
            this.lblversao.AutoSize = true;
            this.lblversao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblversao.ForeColor = System.Drawing.Color.Navy;
            this.lblversao.Location = new System.Drawing.Point(9, 103);
            this.lblversao.Name = "lblversao";
            this.lblversao.Size = new System.Drawing.Size(104, 13);
            this.lblversao.TabIndex = 52;
            this.lblversao.Text = "Versão 1.0  2017";
            // 
            // btnManual
            // 
            this.btnManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.ForeColor = System.Drawing.Color.Navy;
            this.btnManual.Location = new System.Drawing.Point(1032, 67);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(121, 33);
            this.btnManual.TabIndex = 51;
            this.btnManual.Text = "&Manual do sistema";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnrelatorio
            // 
            this.btnrelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrelatorio.ForeColor = System.Drawing.Color.Navy;
            this.btnrelatorio.Location = new System.Drawing.Point(651, 67);
            this.btnrelatorio.Name = "btnrelatorio";
            this.btnrelatorio.Size = new System.Drawing.Size(121, 33);
            this.btnrelatorio.TabIndex = 50;
            this.btnrelatorio.Text = "&Relatórios";
            this.btnrelatorio.UseVisualStyleBackColor = true;
            this.btnrelatorio.Click += new System.EventHandler(this.btnrelatorio_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblTitulo.Location = new System.Drawing.Point(355, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(504, 39);
            this.lblTitulo.TabIndex = 49;
            this.lblTitulo.Text = "Gerenciamento de Chamados";
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirUsuario.ForeColor = System.Drawing.Color.Navy;
            this.btnExcluirUsuario.Location = new System.Drawing.Point(524, 67);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.Size = new System.Drawing.Size(121, 33);
            this.btnExcluirUsuario.TabIndex = 48;
            this.btnExcluirUsuario.Text = "&Excluir Usuários";
            this.btnExcluirUsuario.UseVisualStyleBackColor = true;
            this.btnExcluirUsuario.Click += new System.EventHandler(this.btnExcluirUsuario_Click);
            // 
            // pictureGenius
            // 
            this.pictureGenius.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Geniu_imagebaixa1;
            this.pictureGenius.Image = global::WindowsFormsApp1.Properties.Resources.Geniu_imagebaixa;
            this.pictureGenius.Location = new System.Drawing.Point(12, 12);
            this.pictureGenius.Name = "pictureGenius";
            this.pictureGenius.Size = new System.Drawing.Size(226, 88);
            this.pictureGenius.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureGenius.TabIndex = 47;
            this.pictureGenius.TabStop = false;
            // 
            // dataGridChamado
            // 
            this.dataGridChamado.AllowUserToAddRows = false;
            this.dataGridChamado.AllowUserToDeleteRows = false;
            this.dataGridChamado.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridChamado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridChamado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridChamado.GridColor = System.Drawing.Color.Navy;
            this.dataGridChamado.Location = new System.Drawing.Point(9, 129);
            this.dataGridChamado.Name = "dataGridChamado";
            this.dataGridChamado.ReadOnly = true;
            this.dataGridChamado.Size = new System.Drawing.Size(1144, 199);
            this.dataGridChamado.TabIndex = 46;
            this.dataGridChamado.SelectionChanged += new System.EventHandler(this.selecionarChamado);
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
            // btncriarUsuario
            // 
            this.btncriarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncriarUsuario.ForeColor = System.Drawing.Color.Navy;
            this.btncriarUsuario.Location = new System.Drawing.Point(397, 67);
            this.btncriarUsuario.Name = "btncriarUsuario";
            this.btncriarUsuario.Size = new System.Drawing.Size(121, 33);
            this.btncriarUsuario.TabIndex = 45;
            this.btncriarUsuario.Text = "N&ovo usuário";
            this.btncriarUsuario.UseVisualStyleBackColor = true;
            this.btncriarUsuario.Click += new System.EventHandler(this.btncriarUsuario_Click);
            // 
            // btnNovoChamado
            // 
            this.btnNovoChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoChamado.ForeColor = System.Drawing.Color.Navy;
            this.btnNovoChamado.Location = new System.Drawing.Point(270, 67);
            this.btnNovoChamado.Name = "btnNovoChamado";
            this.btnNovoChamado.Size = new System.Drawing.Size(121, 33);
            this.btnNovoChamado.TabIndex = 44;
            this.btnNovoChamado.Text = "&Novo Chamado";
            this.btnNovoChamado.UseVisualStyleBackColor = true;
            this.btnNovoChamado.Click += new System.EventHandler(this.btnNovoChamado_Click);
            // 
            // prioridadeTb
            // 
            this.prioridadeTb.Location = new System.Drawing.Point(677, 458);
            this.prioridadeTb.Name = "prioridadeTb";
            this.prioridadeTb.ReadOnly = true;
            this.prioridadeTb.Size = new System.Drawing.Size(185, 20);
            this.prioridadeTb.TabIndex = 80;
            // 
            // statusCb
            // 
            this.statusCb.Enabled = false;
            this.statusCb.FormattingEnabled = true;
            this.statusCb.Location = new System.Drawing.Point(72, 524);
            this.statusCb.Name = "statusCb";
            this.statusCb.Size = new System.Drawing.Size(185, 21);
            this.statusCb.TabIndex = 79;
            // 
            // responsavelCb
            // 
            this.responsavelCb.Enabled = false;
            this.responsavelCb.FormattingEnabled = true;
            this.responsavelCb.Location = new System.Drawing.Point(399, 492);
            this.responsavelCb.Name = "responsavelCb";
            this.responsavelCb.Size = new System.Drawing.Size(185, 21);
            this.responsavelCb.TabIndex = 78;
            // 
            // abertoPorTb
            // 
            this.abertoPorTb.Location = new System.Drawing.Point(677, 492);
            this.abertoPorTb.Name = "abertoPorTb";
            this.abertoPorTb.ReadOnly = true;
            this.abertoPorTb.Size = new System.Drawing.Size(185, 20);
            this.abertoPorTb.TabIndex = 77;
            // 
            // dataCriacaoTb
            // 
            this.dataCriacaoTb.Location = new System.Drawing.Point(399, 458);
            this.dataCriacaoTb.Name = "dataCriacaoTb";
            this.dataCriacaoTb.ReadOnly = true;
            this.dataCriacaoTb.Size = new System.Drawing.Size(185, 20);
            this.dataCriacaoTb.TabIndex = 76;
            // 
            // clienteTb
            // 
            this.clienteTb.Location = new System.Drawing.Point(72, 492);
            this.clienteTb.Name = "clienteTb";
            this.clienteTb.ReadOnly = true;
            this.clienteTb.Size = new System.Drawing.Size(185, 20);
            this.clienteTb.TabIndex = 75;
            // 
            // dataFechamentoTb
            // 
            this.dataFechamentoTb.Location = new System.Drawing.Point(399, 524);
            this.dataFechamentoTb.Name = "dataFechamentoTb";
            this.dataFechamentoTb.ReadOnly = true;
            this.dataFechamentoTb.Size = new System.Drawing.Size(185, 20);
            this.dataFechamentoTb.TabIndex = 74;
            // 
            // numeroTb
            // 
            this.numeroTb.Location = new System.Drawing.Point(72, 458);
            this.numeroTb.Name = "numeroTb";
            this.numeroTb.ReadOnly = true;
            this.numeroTb.Size = new System.Drawing.Size(185, 20);
            this.numeroTb.TabIndex = 73;
            // 
            // abertoPorLabel
            // 
            this.abertoPorLabel.AutoSize = true;
            this.abertoPorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abertoPorLabel.ForeColor = System.Drawing.Color.Navy;
            this.abertoPorLabel.Location = new System.Drawing.Point(600, 495);
            this.abertoPorLabel.Name = "abertoPorLabel";
            this.abertoPorLabel.Size = new System.Drawing.Size(70, 13);
            this.abertoPorLabel.TabIndex = 72;
            this.abertoPorLabel.Text = "Aberto por:";
            // 
            // dataFechamentoLabel
            // 
            this.dataFechamentoLabel.AutoSize = true;
            this.dataFechamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataFechamentoLabel.ForeColor = System.Drawing.Color.Navy;
            this.dataFechamentoLabel.Location = new System.Drawing.Point(267, 527);
            this.dataFechamentoLabel.Name = "dataFechamentoLabel";
            this.dataFechamentoLabel.Size = new System.Drawing.Size(126, 13);
            this.dataFechamentoLabel.TabIndex = 71;
            this.dataFechamentoLabel.Text = "Data de fechamento:";
            // 
            // prioridadeLabel
            // 
            this.prioridadeLabel.AutoSize = true;
            this.prioridadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prioridadeLabel.ForeColor = System.Drawing.Color.Navy;
            this.prioridadeLabel.Location = new System.Drawing.Point(600, 461);
            this.prioridadeLabel.Name = "prioridadeLabel";
            this.prioridadeLabel.Size = new System.Drawing.Size(68, 13);
            this.prioridadeLabel.TabIndex = 70;
            this.prioridadeLabel.Text = "Prioridade:";
            // 
            // dataCriacaoLabel
            // 
            this.dataCriacaoLabel.AutoSize = true;
            this.dataCriacaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataCriacaoLabel.ForeColor = System.Drawing.Color.Navy;
            this.dataCriacaoLabel.Location = new System.Drawing.Point(291, 461);
            this.dataCriacaoLabel.Name = "dataCriacaoLabel";
            this.dataCriacaoLabel.Size = new System.Drawing.Size(102, 13);
            this.dataCriacaoLabel.TabIndex = 69;
            this.dataCriacaoLabel.Text = "Data de criação:";
            // 
            // numeroLabel
            // 
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroLabel.ForeColor = System.Drawing.Color.Navy;
            this.numeroLabel.Location = new System.Drawing.Point(12, 461);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(54, 13);
            this.numeroLabel.TabIndex = 68;
            this.numeroLabel.Text = "Número:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(216, 572);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Versão 1.0  2017";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(548, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Fale conosco";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(397, 572);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Contatar o ADM. ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(9, 572);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(120, 13);
            this.linkLabel1.TabIndex = 64;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.geniusxtec.com.br";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Silver;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Navy;
            this.btnSair.Location = new System.Drawing.Point(1035, 541);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 33);
            this.btnSair.TabIndex = 63;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // descricaoTb
            // 
            this.descricaoTb.Enabled = false;
            this.descricaoTb.Location = new System.Drawing.Point(12, 360);
            this.descricaoTb.Multiline = true;
            this.descricaoTb.Name = "descricaoTb";
            this.descricaoTb.Size = new System.Drawing.Size(1144, 86);
            this.descricaoTb.TabIndex = 62;
            // 
            // btnSalvarAltr
            // 
            this.btnSalvarAltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarAltr.ForeColor = System.Drawing.Color.Navy;
            this.btnSalvarAltr.Location = new System.Drawing.Point(1035, 459);
            this.btnSalvarAltr.Name = "btnSalvarAltr";
            this.btnSalvarAltr.Size = new System.Drawing.Size(121, 35);
            this.btnSalvarAltr.TabIndex = 61;
            this.btnSalvarAltr.Text = "Salvar alteração";
            this.btnSalvarAltr.UseVisualStyleBackColor = true;
            this.btnSalvarAltr.Click += new System.EventHandler(this.btnSalvarAltr_Click);
            // 
            // btnEditarChamado
            // 
            this.btnEditarChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarChamado.ForeColor = System.Drawing.Color.Navy;
            this.btnEditarChamado.Location = new System.Drawing.Point(908, 461);
            this.btnEditarChamado.Name = "btnEditarChamado";
            this.btnEditarChamado.Size = new System.Drawing.Size(121, 33);
            this.btnEditarChamado.TabIndex = 60;
            this.btnEditarChamado.Text = "&Editar Chamado";
            this.btnEditarChamado.UseVisualStyleBackColor = true;
            this.btnEditarChamado.Click += new System.EventHandler(this.btnEditarChamado_Click);
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.ForeColor = System.Drawing.Color.Navy;
            this.lblDes.Location = new System.Drawing.Point(12, 344);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(137, 13);
            this.lblDes.TabIndex = 59;
            this.lblDes.Text = "Descrição do chamado";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.Navy;
            this.lbl3.Location = new System.Drawing.Point(309, 495);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(84, 13);
            this.lbl3.TabIndex = 58;
            this.lbl3.Text = "Responsável:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Navy;
            this.lbl2.Location = new System.Drawing.Point(12, 527);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(47, 13);
            this.lbl2.TabIndex = 57;
            this.lbl2.Text = "Status:";
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteLabel.ForeColor = System.Drawing.Color.Navy;
            this.clienteLabel.Location = new System.Drawing.Point(12, 495);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(50, 13);
            this.clienteLabel.TabIndex = 56;
            this.clienteLabel.Text = "Cliente:";
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1165, 587);
            this.Controls.Add(this.prioridadeTb);
            this.Controls.Add(this.statusCb);
            this.Controls.Add(this.responsavelCb);
            this.Controls.Add(this.abertoPorTb);
            this.Controls.Add(this.dataCriacaoTb);
            this.Controls.Add(this.clienteTb);
            this.Controls.Add(this.dataFechamentoTb);
            this.Controls.Add(this.numeroTb);
            this.Controls.Add(this.abertoPorLabel);
            this.Controls.Add(this.dataFechamentoLabel);
            this.Controls.Add(this.prioridadeLabel);
            this.Controls.Add(this.dataCriacaoLabel);
            this.Controls.Add(this.numeroLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.descricaoTb);
            this.Controls.Add(this.btnSalvarAltr);
            this.Controls.Add(this.btnEditarChamado);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.clienteLabel);
            this.Controls.Add(this.usuarioAutenticado);
            this.Controls.Add(this.btncontacAdm);
            this.Controls.Add(this.btnNewCliente);
            this.Controls.Add(this.lblversao);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnrelatorio);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnExcluirUsuario);
            this.Controls.Add(this.pictureGenius);
            this.Controls.Add(this.dataGridChamado);
            this.Controls.Add(this.btncriarUsuario);
            this.Controls.Add(this.btnNovoChamado);
            this.Name = "Inicial";
            this.Text = "Genius X Tec - Gerenciamento de Chamados";
            this.Load += new System.EventHandler(this.Inicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureGenius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChamado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridChamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaChamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunastatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaPrioridade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaReponsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaDataAbertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaLoginCriacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunadataFechamento;
        private System.Windows.Forms.Label usuarioAutenticado;
        private System.Windows.Forms.Button btncontacAdm;
        private System.Windows.Forms.Button btnNewCliente;
        private System.Windows.Forms.Label lblversao;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnrelatorio;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnExcluirUsuario;
        private System.Windows.Forms.PictureBox pictureGenius;
        private System.Windows.Forms.Button btncriarUsuario;
        private System.Windows.Forms.Button btnNovoChamado;
        private System.Windows.Forms.TextBox prioridadeTb;
        private System.Windows.Forms.ComboBox statusCb;
        private System.Windows.Forms.ComboBox responsavelCb;
        private System.Windows.Forms.TextBox abertoPorTb;
        private System.Windows.Forms.TextBox dataCriacaoTb;
        private System.Windows.Forms.TextBox clienteTb;
        private System.Windows.Forms.TextBox dataFechamentoTb;
        private System.Windows.Forms.TextBox numeroTb;
        private System.Windows.Forms.Label abertoPorLabel;
        private System.Windows.Forms.Label dataFechamentoLabel;
        private System.Windows.Forms.Label prioridadeLabel;
        private System.Windows.Forms.Label dataCriacaoLabel;
        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox descricaoTb;
        private System.Windows.Forms.Button btnSalvarAltr;
        private System.Windows.Forms.Button btnEditarChamado;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label clienteLabel;
    }
}