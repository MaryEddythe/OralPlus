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
    public partial class AppointmentContact : UserControl
    {
        public AppointmentContact()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
           

        }

     

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {

        }

        private void btn_next_Click_1(object sender, EventArgs e)
        {
            AppointmentDate uc = new AppointmentDate();
            addUserControl(uc);
        }
    }
}
