using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Servicos;

namespace WindowsFormsApp1
{
    public partial class AddChamadoTela : Form
    {
        BuscaDeChamados chamados = new BuscaDeChamados();
        BuscaDeClientes buscaDeClientes = new BuscaDeClientes();
        BuscaDeUsuarios buscaDeUsuarios = new BuscaDeUsuarios();
        ManutencaoChamado manutencaoChamado = new ManutencaoChamado();

        TelaInicial inicial;

        public AddChamadoTela(TelaInicial inicial)
        {
            InitializeComponent();

            this.inicial = inicial;

            var clientes = buscaDeClientes.buscar();
            this.cbClientes.DataSource = clientes;
            this.cbClientes.DisplayMember = "nome";
            this.cbClientes.ValueMember = "id";

            var usuarios = buscaDeUsuarios.buscarComTipo();
            this.cbResponsavel.DataSource = usuarios;
            this.cbResponsavel.DisplayMember = "nome";
            this.cbResponsavel.ValueMember = "login";

            var prioridades = chamados.buscarPrioridades();
            this.cbPrioridade.DataSource = prioridades;
            this.cbPrioridade.DisplayMember = "descricao";
            this.cbPrioridade.ValueMember = "id";
        }
             
        

        private void formAddChamado_Load(object sender, EventArgs e)
        {

        }
        private void btnLimparNew_Click(object sender, EventArgs e)
        {
            cbClientes.ResetText();
            descrever.Clear();
            cbPrioridade.ResetText();
            cbResponsavel.ResetText();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarnew_Click(object sender, EventArgs e)
        {
            if (cbClientes.Text.Equals(""))
            {
                epAddChamado.SetError(cbClientes, "Cliente obrigatório");
                cbClientes.Focus();
            }
            if (cbPrioridade.Text.Equals(""))
            {
                epAddChamado.SetError(cbPrioridade, "Prioridade obrigatória");
                cbPrioridade.Focus();
            }
            if (cbResponsavel.Text.Equals(""))
            {
                epAddChamado.SetError(cbResponsavel, "Responsável obrigatório");
                cbResponsavel.Focus();
            }
            if (descrever.Text.Equals(""))
            {
                epAddChamado.SetError(descrever, "Descrição obrigatória");
                descrever.Focus();
            }

            Chamado novoChamado = new Chamado();
            novoChamado.cliente = (Cliente)cbClientes.SelectedItem;
            novoChamado.usuario_responsavel = (Usuario) cbResponsavel.SelectedItem;
            novoChamado.prioridade = (PrioridadeChamado) cbPrioridade.SelectedItem;
            novoChamado.descricao = descrever.Text;

            novoChamado.usuario_criacao = Sessao.usuarioAutenticado;

            manutencaoChamado.salvar(novoChamado);

            btnLimparNew_Click(null, null);

            inicial.populaDataGrid();
        }

        private void cbMeioContato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
