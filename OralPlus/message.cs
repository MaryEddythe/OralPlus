using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Collections.Specialized;
using System.IO;
using System.Drawing.Drawing2D;

namespace OralPlus
{
    public partial class message : UserControl
    {
		NetworkCredential login;
		SmtpClient client;
		MailMessage msg;
        public message()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
			String result;
			string apiKey = "NjY3MTZmN2EzOTM2NmY3Njc1NDk0OTRhNmU3Nzc2NGU=";
			string numbers = txt_contact.Text;

			string send = "OralPlus+ Dental Clinic";
			string name = txt_name.Text;
			string message = txt_message.Text;

			String url = "https://api.txtlocal.com/send/?apikey=" + apiKey + "&numbers=" + numbers + "&message=" + message + "&sender=" + sender;
			StreamWriter myWriter = null;
			HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);

			objRequest.Method = "POST";
			objRequest.ContentLength = Encoding.UTF8.GetByteCount(url);
			objRequest.ContentType = "application/x-www-form-urlencoded";
			try
			{
				myWriter = new StreamWriter(objRequest.GetRequestStream());
				myWriter.Write(url);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				myWriter.Close();
			}

			HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
			using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
			{
				result = sr.ReadToEnd();
				sr.Close();
			}
			MessageBox.Show("Appointment reminder sent successfully!");
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{
			
		}

        private void txt_contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
