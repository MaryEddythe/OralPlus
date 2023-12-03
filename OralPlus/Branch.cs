using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OralPlus
{
    public partial class Branch : Form
    {
        public Branch()
        {
            InitializeComponent();
        }

        private void btn_ilo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f2 = new Login();
            f2.ShowDialog();
            f2 = null;
            this.Show();
        }

        private void btn_cebu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login2 f2 = new Login2 ();
            f2.ShowDialog();
            f2 = null;
            this.Show();
        }
    }
}
