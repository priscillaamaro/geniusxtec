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
    public partial class sistemaAberturaChamado : Form
    {
        BuscaDeChamados chamados = new BuscaDeChamados();

        public sistemaAberturaChamado()
        {
            InitializeComponent();

            configuraDataGrid();
            populaDataGrid();
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
            dataGridChamado.Columns[6].DataPropertyName = "data_abertura";
            dataGridChamado.Columns[7].DataPropertyName = "usuario_criacao";
            dataGridChamado.Columns[8].DataPropertyName = "data_fechamento";
        }

        private void populaDataGrid()
        {
            // Populando os chamados
            var source = new BindingSource();
            source.DataSource = chamados.buscar();
            dataGridChamado.DataSource = source;
        }

        private void sistemaAberturaChamado_Load(object sender, EventArgs e)
        {

        }

        private void dataGridChamado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNovoChamado_Click(object sender, EventArgs e)
        {
            addChamado telaAddChamado = new addChamado();
            telaAddChamado.Show();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncriarUsuario_Click(object sender, EventArgs e)
        {
            addUsuario addusuario = new addUsuario();
            addusuario.Show();

        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            ExcluirUsuario excluirUsuario = new ExcluirUsuario();
            excluirUsuario.Show();
        }

        private void btnrelatorio_Click(object sender, EventArgs e)
        {
            relatorios relatorios = new relatorios();
            relatorios.Show();
        }

        private void btnNewCliente_Click(object sender, EventArgs e)
        {
            addCliente novo = new addCliente();
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

        }
    }
}
