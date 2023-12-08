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
    public partial class AddApp2 : Form
    {
        public AddApp2()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.ShowDialog();
            f2 = null;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddApp f2 = new AddApp();
            f2.ShowDialog();
            f2 = null;
            this.Show();
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
