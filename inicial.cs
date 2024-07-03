using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tcc_senai
{
    public partial class inicial : Form
    {
        public inicial()
        {
            InitializeComponent();
        }

        private void btncadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            cadastrodesign cadastrodesign = new cadastrodesign();
            cadastrodesign.Show();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }
    }
}
