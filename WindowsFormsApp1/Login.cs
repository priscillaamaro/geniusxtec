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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
            string loginDigitado = txtUsuarioLog.Text;
            string senhaDigitada = txtSenhaLog.Text;

            BuscaDeUsuarios usuarios = new BuscaDeUsuarios();

            if (usuarios.buscar(loginDigitado, senhaDigitada))
            {
                ///Abrindo Principal
                new sistemaAberturaChamado().Show();
                
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
