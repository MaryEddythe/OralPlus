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
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btn_patient_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPat f2 = new AddPat();
            f2.ShowDialog();
            f2 = null;
            this.Show();
        }

        private void btn_app_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddApp f2 = new AddApp();
            f2.ShowDialog();
            f2 = null;
            this.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
