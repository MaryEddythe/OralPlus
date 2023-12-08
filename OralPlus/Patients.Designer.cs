
namespace OralPlus
{
    partial class Patients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.patientViewForm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.patientViewForm)).BeginInit();
            this.SuspendLayout();
            // 
            // patientViewForm
            // 
            this.patientViewForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientViewForm.Location = new System.Drawing.Point(25, 28);
            this.patientViewForm.Name = "patientViewForm";
            this.patientViewForm.RowHeadersWidth = 51;
            this.patientViewForm.RowTemplate.Height = 24;
            this.patientViewForm.Size = new System.Drawing.Size(971, 453);
            this.patientViewForm.TabIndex = 0;
            this.patientViewForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientViewForm_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 679);
            this.Controls.Add(this.patientViewForm);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.patientViewForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView patientViewForm;
    }
}