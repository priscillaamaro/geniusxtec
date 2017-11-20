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
    public partial class addChamado : Form
    {
        public addChamado()
        {
            InitializeComponent();
        }
             
        

        private void formAddChamado_Load(object sender, EventArgs e)
        {

        }
        private void btnLimparNew_Click(object sender, EventArgs e)
        {
            //addCliChamado.Clear();
            descrever.Clear();
            addPrioridade.ResetText();
            //addCliChamado.Focus();
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
            //if (addCliChamado.Text.Equals(""))
            //{
            //    epAddChamado.SetError(addCliChamado, "Nome do clienteo obrigatório");
            //    addCliChamado.Focus();
            //}
            if (addPrioridade.Text.Equals(""))
            {
                epAddChamado.SetError(addPrioridade, "Nome do clienteo obrigatório");
                addPrioridade.Focus();
            }
            if (cbMeioContato.Text.Equals(""))
            {
                epAddChamado.SetError(cbMeioContato, "Nome do clienteo obrigatório");
                cbMeioContato.Focus();
            }
            if (descrever.Text.Equals(""))
            {
                epAddChamado.SetError(descrever, "Nome do clienteo obrigatório");
                descrever.Focus();
            }

        }
    }
}
