using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace OralPlus
{
    public partial class check : Form
    {
        public check()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void check_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboDevice.Items.Add(filterInfo.Name);
            cboDevice.SelectedIndex = 0;
        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            if (cboDevice.SelectedIndex >= 0 && cboDevice.SelectedIndex < filterInfoCollection.Count)
            {
                FilterInfo selectedFilter = filterInfoCollection[cboDevice.SelectedIndex];
                captureDevice = new VideoCaptureDevice(selectedFilter.MonikerString);
                captureDevice.NewFrame += CaptureDevice_NewFrame;
                captureDevice.Start();
                timer1.Start();
            }
            else
            {
               
                MessageBox.Show("Please select a valid device.");
            }
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void check_Load_FormClosing(object sender, GiveFeedbackEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((System.Drawing.Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    txt_lname.Text = result.Text;
                    txt_fname.Text = result.Text;
                    txt_add.Text = result.Text;
                    txt_email.Text = result.Text;
                    txt_contact.Text = result.Text;
                    radio_male.Checked = (result.Text == "Male");
                    radio_female.Checked = (result.Text == "Female");
                    radio_female.Checked = (result.Text == "Prefer not to say");
                    date_dob.Value = DateTime.Parse(result.Text);

                    timer1.Stop();

                    if (captureDevice != null && captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }

        private void cboDevice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_mini_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.ShowDialog();
            f2 = null;
            this.Show();
        }
    }
}