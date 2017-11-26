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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
            string loginDigitado = txtUsuarioLog.Text;
            string senhaDigitada = txtSenhaLog.Text;

            BuscaDeUsuarios usuarios = new BuscaDeUsuarios();

            Usuario usuarioEncontrado = usuarios.buscar(loginDigitado, senhaDigitada);
            if (usuarioEncontrado != null)
            {
                // Guardando usuario autenticado
                Sessao.usuarioAutenticado = usuarioEncontrado;

                ///Abrindo Principal
                new TelaInicial().Show();

                ///Escondendo Login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Acesso negado. Contate o administrador.", "ERROR", MessageBoxButtons.OK);
;           }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtSenhaLog_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
