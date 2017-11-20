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
    public partial class formcontatarADM : Form
    {
        public formcontatarADM()
        {
            InitializeComponent();
        }

        private void formcontatarADM_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            epADM.SetError(comboADM, "Nome de ADM obrigatório");
            comboADM.Focus();
        }
    }
}
