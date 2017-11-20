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
    public partial class manualSistema : Form
    {
        public manualSistema()
        {
            InitializeComponent();
        }

        private void sairManual_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sitegenius_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
