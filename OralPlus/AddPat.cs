using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using ZXing.QrCode.Internal;

namespace OralPlus
{
    public partial class AddPat : Form
    {
        public AddPat()
        {
            InitializeComponent();
        }

        private void btn_code_Click(object sender, EventArgs e)
        {
            BarcodeWriter barcodeWriter = new BarcodeWriter();

            EncodingOptions encodingOptions = new QrCodeEncodingOptions
            {
                Width = 300,
                Height = 300,
                Margin = 0
            };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);

            barcodeWriter.Options = encodingOptions;
            barcodeWriter.Format = BarcodeFormat.QR_CODE;

            string patientInfo = $"{txt_id.Text}, ";

            Bitmap bitmap = barcodeWriter.Write(patientInfo);

            QR.Image = bitmap;
        }

        private void btn_patient_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (QR.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG Image|*.png";
                saveFileDialog.Title = "Save QR Code Image";
                saveFileDialog.FileName = "Patient Card";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                       QR.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
                        MessageBox.Show("QR Code image downloaded successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error downloading QR Code image: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please generate a QR code first.");
            }
        }

        private void btn_jpg_Click(object sender, EventArgs e)
        {
            if (QR.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JPEG Image|*.jpg"; 
                saveFileDialog.Title = "Save QR Code Image";
                saveFileDialog.FileName = "Patient Card";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        QR.Image.Save(saveFileDialog.FileName, ImageFormat.Jpeg); 
                        MessageBox.Show("QR Code image downloaded successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error downloading QR Code image: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please generate a QR code first.");
            }
        }

        private void AddPat_Load(object sender, EventArgs e)
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
  
