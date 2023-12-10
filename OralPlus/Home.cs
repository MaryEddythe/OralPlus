using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            UpdateAppointmentCountLabel();
            UpdatePatientCountLabel();
            UpdatePatientsTodayCountLabel();
            UpdateTodaysAppointments();
        }

        private void UpdateAppointmentCountLabel()
        {
            string connectionString = "server=localhost;user=root;password=;database=oralplus;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string countQuery = "SELECT COUNT(*) FROM appointment";
                MySqlCommand countCmd = new MySqlCommand(countQuery, connection);

                int rowCount = Convert.ToInt32(countCmd.ExecuteScalar());

                label_appointmentCount.Text = rowCount.ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void UpdatePatientCountLabel()
        {
            string connectionString = "server=localhost;user=root;password=;database=oralplus;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string countQuery = "SELECT COUNT(*) FROM patient";
                MySqlCommand countCmd = new MySqlCommand(countQuery, connection);

                int rowCount = Convert.ToInt32(countCmd.ExecuteScalar());

                label_patientCount.Text = rowCount.ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void UpdatePatientsTodayCountLabel()
        {
            string connectionString = "server=localhost;user=root;password=;database=oralplus;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string countQuery = "SELECT COUNT(*) FROM patientsToday";
                MySqlCommand countCmd = new MySqlCommand(countQuery, connection);

                int rowCount = Convert.ToInt32(countCmd.ExecuteScalar());

                label_patientsTodayCount.Text = rowCount.ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
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

        private void appointmentsTodayViewForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateTodaysAppointments()
        {
            string connectionString = "server=localhost;user=root;password=;database=oralplus;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                string query = "SELECT patientId, patientLastName, appointmentReason FROM appointment WHERE appointmentDate = @currentDate";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@currentDate", currentDate);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                appointmentsTodayViewForm.Columns.Clear();

                appointmentsTodayViewForm.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
