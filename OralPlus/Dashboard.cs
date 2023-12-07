using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace OralPlus
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            pnl_nav.Height = btn_Dashboard.Height;
            pnl_nav.Top = btn_Dashboard.Top;
            pnl_nav.Left = btn_Dashboard.Left;
            btn_Dashboard.BackColor = Color.FromArgb(46, 51, 73);

            Home uc = new Home();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {

            Home uc = new Home();
            addUserControl(uc);


            pnl_nav.Height = btn_Dashboard.Height;
            pnl_nav.Top = btn_Dashboard.Top;
            pnl_nav.Left = btn_Dashboard.Left;
            btn_Dashboard.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void btn_Patient_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_Patient.Height;
            pnl_nav.Top = btn_Patient.Top;
            pnl_nav.Left = btn_Patient.Left;
            btn_Patient.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_Appointment_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_Appointment.Height;
            pnl_nav.Top = btn_Appointment.Top;
            pnl_nav.Left = btn_Appointment.Left;
            btn_Appointment.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_Settings.Height;
            pnl_nav.Top = btn_Settings.Top;
            pnl_nav.Left = btn_Settings.Left;
            btn_Settings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_Dashboard_Leave(object sender, EventArgs e)
        {
            btn_Dashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_Patient_Leave(object sender, EventArgs e)
        {
            btn_Patient.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_Appointment_Leave(object sender, EventArgs e)
        {
            btn_Appointment.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_Settings_Leave(object sender, EventArgs e)
        {
            btn_Settings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_Check.Height;
            pnl_nav.Top = btn_Check.Top;
            pnl_nav.Left = btn_Check.Left;
            btn_Check.BackColor = Color.FromArgb(46, 51, 73);

            this.Hide();
            check f2 = new check();
            f2.ShowDialog();
            f2 = null;
            this.Show();
        }

        private void btn_message_Click(object sender, EventArgs e)
        {

            message uc = new message();
            addUserControl(uc);

            pnl_nav.Height = btn_message.Height;
            pnl_nav.Top = btn_message.Top;
            pnl_nav.Left = btn_message.Left;
            btn_message.BackColor = Color.FromArgb(46, 51, 73);


            
        }

        private void home1_Load(object sender, EventArgs e)
        {

        }
    }
}
