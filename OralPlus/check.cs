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
            }
            else
            {
               
                MessageBox.Show("Please select a valid device.");
            }
        }

        private void CaptureDevice_NewFrame(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
