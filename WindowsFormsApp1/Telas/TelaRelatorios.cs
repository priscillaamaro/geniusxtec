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
    public partial class TelaRelatorios : Form
    {
        BuscaDeUsuarios buscaDeUsuarios = new BuscaDeUsuarios();
        BuscaDeClientes buscaDeClientes = new BuscaDeClientes();
        BuscaDeChamados buscaDeChamados = new BuscaDeChamados();

        public TelaRelatorios()
        {
            InitializeComponent();

            popularUsuarios();
            popularClientes();
            popularChamados();
        }

        private void popularUsuarios()
        {
            List<Usuario> usuarios = buscaDeUsuarios.buscar();
            totalUsuariosVl.Text = usuarios.Count.ToString();
            foreach (Usuario usuario in usuarios)
            {
                switch (Int32.Parse(usuario.tipoUsuario.id))
                {
                    case 1:
                        int cl = Int32.Parse(clientesVl.Text) + 1;
                        clientesVl.Text = cl.ToString();
                        break;
                    case 2:
                        int at = Int32.Parse(atendentesVl.Text) + 1;
                        atendentesVl.Text = at.ToString();
                        break;
                    case 3:
                        int dv = Int32.Parse(desenvolvedoresVl.Text) + 1;
                        desenvolvedoresVl.Text = dv.ToString();
                        break;
                }
                if (Boolean.Parse(usuario.status))
                {
                    int at = Int32.Parse(ativosUsuariosVl.Text) + 1;
                    ativosUsuariosVl.Text = at.ToString();
                }
                else
                {
                    int itv = Int32.Parse(inativosUsuariosVl.Text) + 1;
                    inativosUsuariosVl.Text = itv.ToString();
                }
            }
        }

        private void popularClientes()
        {
            List<Cliente> clientes = buscaDeClientes.buscarTodos();
            totalClientesVl.Text = clientes.Count.ToString();
            foreach (Cliente cliente in clientes)
            {
                if (Boolean.Parse(cliente.status))
                {
                    int at = Int32.Parse(ativosClientesVl.Text) + 1;
                    ativosClientesVl.Text = at.ToString();
                }
                else
                {
                    int itv = Int32.Parse(inativosClientesVl.Text) + 1;
                    inativosClientesVl.Text = itv.ToString();
                }
            }
        }

        private void popularChamados()
        {
            List<Chamado> chamados = buscaDeChamados.buscar();
            totalChamadosVl.Text = chamados.Count.ToString();
            foreach (Chamado chamado in chamados)
            {
                switch (Int32.Parse(chamado.status.id))
                {
                    case 1:
                        int ab = Int32.Parse(abertosVl.Text) + 1;
                        abertosVl.Text = ab.ToString();
                        break;
                    case 2:
                        int an = Int32.Parse(emAnaliseVl.Text) + 1;
                        emAnaliseVl.Text = an.ToString();
                        break;
                    case 3:
                        int en = Int32.Parse(encaminhadoVl.Text) + 1;
                        encaminhadoVl.Text = en.ToString();
                        break;
                    case 4:
                        int co = Int32.Parse(emCorrecaoVl.Text) + 1;
                        emCorrecaoVl.Text = co.ToString();
                        break;
                    case 5:
                        int va = Int32.Parse(emValidacaoVl.Text) + 1;
                        emValidacaoVl.Text = va.ToString();
                        break;
                    case 6:
                        int re = Int32.Parse(reabertoVl.Text) + 1;
                        reabertoVl.Text = re.ToString();
                        break;
                    case 7:
                        int fe = Int32.Parse(fechadoVl.Text) + 1;
                        fechadoVl.Text = fe.ToString();
                        break;
                }
            }
        }
    }
}
