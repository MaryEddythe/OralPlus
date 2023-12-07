using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace OralPlus
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if(progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                lbl_percent.Text = progressBar1.Value.ToString() + "%";
            }
           else
            {
                timer1.Stop();
                Branch fm2 = new Branch();
                fm2.Show();
                this.Hide();

            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
            CustomizeProgressBarAppearance();
        }

        private void CustomizeProgressBarAppearance()
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
