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
    public partial class AddAppointment : Form
    {
        List<Panel> listPanel = new List<Panel>();
        public AddAppointment()
        {
            InitializeComponent();
            AppointmentContact uc = new AppointmentContact();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.ShowDialog();
            f2 = null;
            this.Show();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            AppointmentDate uc = new AppointmentDate();
            addUserControl(uc);
        }
    }
}
