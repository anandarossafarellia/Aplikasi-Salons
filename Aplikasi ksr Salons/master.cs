using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_ksr_Salons
{
    public partial class master : Form
    {
        public master()
        {
            InitializeComponent();
        }

        private void master1_Click(object sender, EventArgs e)
        {
            identitastk identitas = new identitastk();
            this.Hide();
            identitas.Show();
        }
    }
}
