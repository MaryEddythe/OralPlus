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
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
            DisplayPatients();
        }

        private void patientViewForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplayPatients()
        {
            string connectionString = "server=your_server;user=your_username;password=your_password;database=your_database;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "SELECT * FROM patient";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);

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
    }
}
