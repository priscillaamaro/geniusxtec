using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TelaInicial : Form
    {
        BuscaDeChamados chamados = new BuscaDeChamados();
        BuscaDeUsuarios buscaDeUsuarios = new BuscaDeUsuarios();
        ManutencaoChamado manutencaoChamado = new ManutencaoChamado();

        public TelaInicial()
        {
            InitializeComponent();

            usuarioAutenticado.Text = Sessao.usuarioAutenticado.nome + "  - " + Sessao.usuarioAutenticado.tipoUsuario.descricao;

            descricaoTb.Enabled = false;
            configuraDataGrid();
            populaDataGrid();

            var usuarios = buscaDeUsuarios.buscarComTipo();
            this.responsavelCb.DataSource = usuarios;
            this.responsavelCb.DisplayMember = "nome";
            this.responsavelCb.ValueMember = "login";

            var status = chamados.buscarStatus();
            this.statusCb.DataSource = status;
            this.statusCb.DisplayMember = "descricao";
            this.statusCb.ValueMember = "id";
        }

        private void dataGridChamado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void configuraDataGrid()
        {
            //populando o dataGrid
            dataGridChamado.AutoGenerateColumns = false;

            dataGridChamado.Columns[0].DataPropertyName = "id";
            dataGridChamado.Columns[1].DataPropertyName = "descricao";
            dataGridChamado.Columns[2].DataPropertyName = "cliente";
            dataGridChamado.Columns[3].DataPropertyName = "status";
            dataGridChamado.Columns[4].DataPropertyName = "prioridade";
            dataGridChamado.Columns[5].DataPropertyName = "usuario_responsavel";
            dataGridChamado.Columns[6].DataPropertyName = "data_criacao";
            dataGridChamado.Columns[7].DataPropertyName = "usuario_criacao";
            dataGridChamado.Columns[8].DataPropertyName = "data_fechamento";
        }

        public void populaDataGrid()
        {
            // Populando os chamados
            var source = new BindingSource();
            source.DataSource = chamados.buscar();
            dataGridChamado.DataSource = source;
        }

        private void btnNovoChamado_Click(object sender, EventArgs e)
        {
            AddChamadoTela telaAddChamado = new AddChamadoTela(this);
            telaAddChamado.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncriarUsuario_Click(object sender, EventArgs e)
        {
            AddUsuarioTela addusuario = new AddUsuarioTela();
            addusuario.Show();

        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            ExcluirUsuarioTela excluirUsuario = new ExcluirUsuarioTela();
            excluirUsuario.Show();
        }

        private void btnrelatorio_Click(object sender, EventArgs e)
        {
            TelaRelatorios relatorios = new TelaRelatorios();
            relatorios.Show();
        }

        private void btnNewCliente_Click(object sender, EventArgs e)
        {
            AddClienteTela novo = new AddClienteTela();
            novo.Show();
        }

        private void btncontacAdm_Click(object sender, EventArgs e)
        {
            formcontatarADM formcontatarADM = new formcontatarADM();
            formcontatarADM.Show();
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            manualSistema manual = new manualSistema();
            manual.Show();
        }

        private void btnSalvarAltr_Click(object sender, EventArgs e)
        {
            descricaoTb.Enabled = false;
            statusCb.Enabled = false;
            responsavelCb.Enabled = false;

            int index = dataGridChamado.CurrentCell.RowIndex;
            Chamado c = (Chamado)dataGridChamado.Rows[index].DataBoundItem;

            c.status = (StatusChamado)statusCb.SelectedItem;
            c.usuario_responsavel = (Usuario)responsavelCb.SelectedItem;
            c.descricao = descricaoTb.Text;

            manutencaoChamado.atualizar(c);

            MessageBox.Show("Alterações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK);

            populaDataGrid();
        }

        private void selecionarChamado(object sender, EventArgs e)
        {
            int index = dataGridChamado.CurrentCell.RowIndex;
            Chamado c = (Chamado)dataGridChamado.Rows[index].DataBoundItem;

            numeroTb.Text = c.id;
            descricaoTb.Text = c.descricao;
            clienteTb.Text = c.cliente.ToString();
            statusCb.Text = c.status.descricao;
            prioridadeTb.Text = c.prioridade.ToString();
            dataCriacaoTb.Text = c.data_criacao;
            responsavelCb.Text = c.usuario_responsavel.nome;
            abertoPorTb.Text = c.usuario_criacao.ToString();
            dataFechamentoTb.Text = c.data_fechamento;
        }

        private void btnEditarChamado_Click(object sender, EventArgs e)
        {
            descricaoTb.Enabled = true;
            statusCb.Enabled = true;
            responsavelCb.Enabled = true;
        }

        private void Inicial_Load(object sender, EventArgs e)
        {

        }
    }
}
