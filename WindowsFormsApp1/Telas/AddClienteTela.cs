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

    public partial class AddClienteTela : Form
    {
        BuscaDeUsuarios buscaUsuario = new BuscaDeUsuarios();
        ManutencaoDeCliente manutencao = new ManutencaoDeCliente();

        public AddClienteTela()
        {
            InitializeComponent();            

            var usuarios = buscaUsuario.buscarComTipo();
            this.comboUsuario.DataSource = usuarios;
            this.comboUsuario.DisplayMember = "nome";
            this.comboUsuario.ValueMember = "login";

            comboUsuario.Text = "";
        }
        
        private void btnNewCli_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals(""))
            {
                epNovoCliente.SetError(txtNome, "Nome do cliente obrigatório");
                txtNome.Focus();
            }
            if (txtTelefone.Text.Equals(""))
            {
                epNovoCliente.SetError(txtTelefone, "Telefone do cliente obrigatório");
                txtTelefone.Focus();
            }
            if (txtEndereco.Text.Equals(""))
            {
                epNovoCliente.SetError(txtEndereco, "Endereço do cliente obrigatório");
                txtEndereco.Focus();
            }
            if (comboUF.Text.Equals(""))
            {
                epNovoCliente.SetError(comboUF, "UF do cliente obrigatório");
                comboUF.Focus();
            }
            if (comboUsuario.Text.Equals(""))
            {
                epNovoCliente.SetError(comboUsuario, "Usuário do cliente obrigatório");
                comboUsuario.Focus();
            }

            Cliente novoCliente = new Cliente();

            novoCliente.endereco = txtEndereco.Text;
            novoCliente.nome = txtNome.Text;
            novoCliente.telefone = txtTelefone.Text;
            novoCliente.uf = comboUF.Text;
            novoCliente.usuario = (Usuario)comboUsuario.SelectedItem;
            manutencao.salvar(novoCliente);

            limparCamposNewCli_Click(null, null);

            MessageBox.Show("Cliente salvo com sucesso!", "Cliente", MessageBoxButtons.OK);
        }

        private void limparCamposNewCli_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtTelefone.Clear();
            txtEndereco.Clear();
            comboUF.Text = "";
            comboUsuario.Text = "";
        }

        private void addCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
