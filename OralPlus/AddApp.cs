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
    public partial class AddApp : Form
    {
        public AddApp()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
        }

        private void AddApp_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            string patientId = txt_id.Text;

            string connectionString = "server=localhost;user=root;password=;database=oralplus;";

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "SELECT * FROM patient WHERE patientId = @patientId";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@patientId", patientId);

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


                    MessageBox.Show("Patient ID found.");
                }
                else
                {
                    MessageBox.Show("Patient ID not found.");
                }

                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_makeapp_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=;database=oralplus;";

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "INSERT INTO appointment (patientId, patientFirstName, patientLastName, patientSex, patientDoB, patientAddress, " +
                               "patientEmail, patientContactNumber, appointmentDate, appointmentReason) " +
                               "VALUES (@patientId, @patientFirstName, @patientLastName, @patientSex, @patientDoB, @patientAddress, " +
                               "@patientEmail, @patientContactNumber, @appointmentDate, @appointmentReason)";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@patientId", txt_id.Text);
                cmd.Parameters.AddWithValue("@patientFirstName", txt_lname.Text);
                cmd.Parameters.AddWithValue("@patientLastName", txt_fname.Text);

                string sex = "";
                if (radio_male.Checked)
                    sex = "M";
                else if (radio_female.Checked)
                    sex = "F";
                else if (radio_xx.Checked)
                    sex = "O";
                cmd.Parameters.AddWithValue("@patientSex", sex);

                cmd.Parameters.AddWithValue("@patientDoB", date_dob.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@patientAddress", txt_add.Text);
                cmd.Parameters.AddWithValue("@patientEmail", txt_email.Text);
                cmd.Parameters.AddWithValue("@patientContactNumber", txt_contact.Text);
                cmd.Parameters.AddWithValue("@appointmentDate", calendar.SelectionStart.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@appointmentReason", txt_reason.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Appointment added successfully!");
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
    }
}
