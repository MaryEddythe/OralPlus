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
    public partial class Appo : UserControl
    {
        public Appo()
        {
            InitializeComponent();
            DisplayAppointments();

            appointmentViewForm.CellClick += appointmentViewForm_CellClick;
        }
        private void DisplayAppointments()
        {
            string connectionString = "server=localhost;user=root;password=;database=oralplus;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "SELECT * FROM appointment";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);

                appointmentViewForm.DataSource = dt;
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


        private void appointmentViewForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = appointmentViewForm.Rows[e.RowIndex];

                label_appointmentId.Text = row.Cells["appointmentId"].Value.ToString();
                label_patientId.Text = row.Cells["patientId"].Value.ToString();
            }
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            string appointmentId = label_appointmentId.Text;
            string patientId = label_patientId.Text;

            if (!string.IsNullOrEmpty(appointmentId))
            {
                string connectionString = "server=localhost;user=root;password=;database=oralplus;";
                MySqlConnection connection = new MySqlConnection(connectionString);

                try
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO patientsToday (patientsTodayDate, patientId, appointmentId) " +
                                         "VALUES (NOW(), @patientId, @appointmentId)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                    insertCmd.Parameters.AddWithValue("@patientId", patientId);
                    insertCmd.Parameters.AddWithValue("@appointmentId", appointmentId);

                    int rowsInserted = insertCmd.ExecuteNonQuery();

                    if (rowsInserted > 0)
                    {
                        MessageBox.Show("Appointment marked as done.");
                        DisplayAppointments();
                    }
                    else
                    {
                        MessageBox.Show("Failed to mark as done.");
                    }
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
            else
            {
                MessageBox.Show("Please select an appointment.");
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            string appointmentId = label_appointmentId.Text;

            if (!string.IsNullOrEmpty(appointmentId))
            {
                string connectionString = "server=localhost;user=root;password=;database=oralplus;";
                MySqlConnection connection = new MySqlConnection(connectionString);

                try
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM appointment WHERE appointmentId = @appointmentId";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection);
                    deleteCmd.Parameters.AddWithValue("@appointmentId", appointmentId);

                    int rowsDeleted = deleteCmd.ExecuteNonQuery();

                    if (rowsDeleted > 0)
                    {
                        MessageBox.Show("Appointment cancelled. Entry deleted from appointment table.");
                        DisplayAppointments();
                    }
                    else
                    {
                        MessageBox.Show("Failed to cancel the appointment.");
                    }
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
            else
            {
                MessageBox.Show("Please select an appointment.");
            }
        }

        private void appointmentViewForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
