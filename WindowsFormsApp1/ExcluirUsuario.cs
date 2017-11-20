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
    public partial class ExcluirUsuario : Form
    {
        BuscaDeUsuarios usuarios = new BuscaDeUsuarios();
        ManutencaoDeUsuarios manutencao = new ManutencaoDeUsuarios();

        public ExcluirUsuario()

        {
            InitializeComponent();

            configuraDataGrid();

            populaDataGrid();                 
        }

        private void populaDataGrid()
        {
            // Populando os usuarios
            var source = new BindingSource();
            source.DataSource = usuarios.buscarComTipo();
            dataGridExcluir.DataSource = source;
        }

        private void configuraDataGrid()
        {
            //populando o dataGrid
            dataGridExcluir.AutoGenerateColumns = false;

            dataGridExcluir.Columns[0].DataPropertyName = "login";
            dataGridExcluir.Columns[1].DataPropertyName = "descricaoTipoUsuario";
            dataGridExcluir.Columns[2].DataPropertyName = "nome";
        }

        private void ExcluirUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluUser_Click(object sender, EventArgs e)
        {
            string loginSelecionado =  dataGridExcluir.CurrentRow.Cells[0].Value.ToString();
            manutencao.excluir(loginSelecionado);
            populaDataGrid();
        }
    }
}
