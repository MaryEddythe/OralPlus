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
using System;
using MySql.Data.MySqlClient;

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
                    string patientIdFromQR = result.Text;

                    string connectionString = "server=localhost;user=root;password=;database=oralplus;";

                    MySqlConnection connection = new MySqlConnection(connectionString);

                    timer1.Stop();

                    try
                    {
                        connection.Open();

                        string query = "SELECT * FROM patient WHERE patientId = @patientId";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@patientId", patientIdFromQR);

                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txt_id.Text = reader["patientId"].ToString();
                            txt_lname.Text = reader["patientFirstName"].ToString();
                            txt_fname.Text = reader["patientLastName"].ToString();

                            string sex = reader["patientSex"].ToString();
                            if (sex == "M")
                                radio_male.Checked = true;
                            else if (sex == "F")
                                radio_female.Checked = true;
                            else if (sex == "O")
                                radio_xx.Checked = true;

                            DateTime dob;
                            if (DateTime.TryParse(reader["patientDoB"].ToString(), out dob))
                                date_dob.Value = dob;

                            txt_add.Text = reader["patientAddress"].ToString();
                            txt_email.Text = reader["patientEmail"].ToString();
                            txt_contact.Text = reader["patientContactNumber"].ToString();
                        }

                        reader.Close();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }

                    if (captureDevice != null && captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }

        private void cboDevice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Patient Checked-In");
        }
    }
}