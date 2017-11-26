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
    public partial class AddUsuarioTela : Form
    {
        BuscaDeUsuarios usuarios = new BuscaDeUsuarios();

        public AddUsuarioTela()
        {
            InitializeComponent();

            configuraDataGrid();

            populaCombo();

            populaDataGrid();
        }

        private void populaDataGrid()
        {
            // Populando os usuarios
            var source = new BindingSource();
            source.DataSource = usuarios.buscarComTipo();
            dataGridViewNewUser.DataSource = source;
        }

        private void configuraDataGrid() {

            //populando o dataGrid
            dataGridViewNewUser.AutoGenerateColumns = false;

            dataGridViewNewUser.Columns[0].DataPropertyName = "login";
            dataGridViewNewUser.Columns[1].DataPropertyName = "descricaoTipoUsuario";
            dataGridViewNewUser.Columns[2].DataPropertyName = "nome";
        }

        private void populaCombo() {
            // Populando os tipos de usuários
            var tipos = usuarios.buscarTipos();
            this.comboTipoUser.DataSource = tipos;
            this.comboTipoUser.DisplayMember = "descricao";
            this.comboTipoUser.ValueMember = "id";
        }

        private void salvarNewUser_Click(object sender, EventArgs e)
        {
            if (txtNomeUser.Text.Equals(""))
            {
                epAddUsuario.SetError(txtNomeUser, "Nome de usuário obrigatório");
                txtNomeUser.Focus();
            }
            if (comboTipoUser.Text.Equals(""))
            {
                epAddUsuario.SetError(comboTipoUser, "Tipo de usuário obrigatório");
                comboTipoUser.Focus();
            }
            if (txtEmailUser.Text.Equals(""))
            {
                epAddUsuario.SetError(txtEmailUser, "E-mail de usuário obrigatório");
                txtEmailUser.Focus();
            }
            if (txtSenhaAdd.Text.Equals(""))
            {
                epAddUsuario.SetError(txtSenhaAdd, "Senha de usuário obrigatório");
                txtSenhaAdd.Focus();
            }
            if (txtconfirmSenha.Text.Equals(""))
            {
                epAddUsuario.SetError(txtconfirmSenha, "Confirmação de senha de usuário obrigatório");
                txtconfirmSenha.Focus();
            }
            /*
            string nome, contato;
            nome = txtNomeUser.Text;
            contato = txtEmailUser.Text;
            dataGridViewNewUser.Rows.Insert(0,txtNomeUser.Text);
            dataGridViewNewUser.Rows.Insert(0, txtEmailUser.Text);
            */

            Usuario novoUsuario = new Usuario();
            novoUsuario.login = txtEmailUser.Text;
            novoUsuario.senha = txtSenhaAdd.Text;
            TipoUsuario tipo = new TipoUsuario();
            tipo = (TipoUsuario) comboTipoUser.SelectedItem;
            novoUsuario.tipoUsuario = (TipoUsuario) comboTipoUser.SelectedItem;
            novoUsuario.nome = txtNomeUser.Text;

            ManutencaoDeUsuarios manutencao = new ManutencaoDeUsuarios();
            manutencao.salvar(novoUsuario);

            // Recarregar lista de usuarios
            populaDataGrid();

            txtNomeUser.Clear();
            txtEmailUser.Clear();
            txtNomeUser.Focus();
            comboTipoUser.ResetText();
            txtSenhaAdd.Clear();
            txtconfirmSenha.Clear();
        }


        private void btnSairNewUser_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void limparNewUser_Click(object sender, EventArgs e)
        {
           

        }

        private void addUsuario_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewNewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
