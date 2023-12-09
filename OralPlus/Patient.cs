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
    public partial class Patient : UserControl
    {

        public static Form1 instance;
        MySqlConnection conn;
        int i = 0;
        MySqlDataReader dr; 

        public Patient()
        {
            InitializeComponent();
            DisplayPatients();

            txt_search.TextChanged += txt_search_TextChanged;
            patientViewForm.CellClick += patientViewForm_CellClick;
            btn_delete.Click += btn_delete_Click;


        }

        private void patientViewForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void DisplayPatients()
        {
            string connectionString = "server=localhost;user=root;password=;database=oralplus;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "SELECT * FROM patient";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);

                patientViewForm.AutoGenerateColumns = true;
                patientViewForm.DataSource = dt;
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
        private void PatientViewForm_Load(object sender, EventArgs e)
        {
            SearchPatients(string.Empty);
        }

        private void SearchPatients(string searchText)
        {
            if (patientViewForm.DataSource is System.Data.DataTable dt)
            {
                if (!string.IsNullOrEmpty(searchText))
                {
                    dt.DefaultView.RowFilter = string.Format("patientFirstName LIKE '%{0}%' OR patientLastName LIKE '%{0}%' OR patientId LIKE '%{0}%'", searchText);
                }
                else
                {
                    dt.DefaultView.RowFilter = string.Empty;
                }
            }
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            SearchPatients(txt_search.Text);
        }

        private void patientViewForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = patientViewForm.Rows[e.RowIndex];

                txt_id.Text = row.Cells["patientId"].Value.ToString();
                txt_lname.Text = row.Cells["patientFirstName"].Value.ToString();
                txt_fname.Text = row.Cells["patientLastName"].Value.ToString();

                string sex = row.Cells["patientSex"].Value.ToString();
                if (sex == "M")
                    radio_male.Checked = true;
                else if (sex == "F")
                    radio_female.Checked = true;
                else if (sex == "O")
                    radio_xx.Checked = true;

                DateTime dob;
                if (DateTime.TryParse(row.Cells["patientDoB"].Value.ToString(), out dob))
                    date_dob.Value = dob;

                txt_add.Text = row.Cells["patientAddress"].Value.ToString();
                txt_email.Text = row.Cells["patientEmail"].Value.ToString();
                txt_contact.Text = row.Cells["patientContactNumber"].Value.ToString();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=;database=oralplus;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "UPDATE patient SET patientFirstName = @patientFirstName, patientLastName = @patientLastName, " +
                               "patientSex = @patientSex, patientDoB = @patientDoB, patientAddress = @patientAddress, " +
                               "patientEmail = @patientEmail, patientContactNumber = @patientContactNumber " +
                               "WHERE patientId = @patientId";

                MySqlCommand cmd = new MySqlCommand(query, connection);

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
                cmd.Parameters.AddWithValue("@patientId", txt_id.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Patient record updated successfully!");
                    DisplayPatients();
                }
                else
                {
                    MessageBox.Show("No records were updated.");
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=;database=oralplus;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "DELETE FROM patient WHERE patientId = @patientId";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@patientId", txt_id.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Patient record deleted successfully!");
                    DisplayPatients();
                    ClearFormFields();
                }
                else
                {
                    MessageBox.Show("No records were deleted.");
                }
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

        private void ClearFormFields()
        {
            txt_id.Text = string.Empty;
            txt_lname.Text = string.Empty;
            txt_fname.Text = string.Empty;
            radio_male.Checked = false;
            radio_female.Checked = false;
            radio_xx.Checked = false;
            date_dob.Value = DateTime.Now;
            txt_add.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_contact.Text = string.Empty;
        }
    }
}