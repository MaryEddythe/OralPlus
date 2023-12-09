
namespace OralPlus
{
    partial class Appointments
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
            this.appointmentViewForm = new System.Windows.Forms.DataGridView();
            this.btn_done = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label_appointmentId = new System.Windows.Forms.Label();
            this.label_patientId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentViewForm)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentViewForm
            // 
            this.appointmentViewForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentViewForm.Location = new System.Drawing.Point(12, 12);
            this.appointmentViewForm.Name = "appointmentViewForm";
            this.appointmentViewForm.RowHeadersWidth = 51;
            this.appointmentViewForm.RowTemplate.Height = 24;
            this.appointmentViewForm.Size = new System.Drawing.Size(599, 627);
            this.appointmentViewForm.TabIndex = 1;
            // 
            // btn_done
            // 
            this.btn_done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(68)))));
            this.btn_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_done.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_done.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_done.Location = new System.Drawing.Point(638, 535);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(107, 47);
            this.btn_done.TabIndex = 107;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = false;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(68)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.Location = new System.Drawing.Point(638, 588);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(107, 47);
            this.btn_cancel.TabIndex = 108;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label_appointmentId
            // 
            this.label_appointmentId.AutoSize = true;
            this.label_appointmentId.Location = new System.Drawing.Point(677, 146);
            this.label_appointmentId.Name = "label_appointmentId";
            this.label_appointmentId.Size = new System.Drawing.Size(0, 17);
            this.label_appointmentId.TabIndex = 109;
            // 
            // label_patientId
            // 
            this.label_patientId.AutoSize = true;
            this.label_patientId.Location = new System.Drawing.Point(677, 86);
            this.label_patientId.Name = "label_patientId";
            this.label_patientId.Size = new System.Drawing.Size(0, 17);
            this.label_patientId.TabIndex = 110;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(635, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 111;
            this.label8.Text = "Patient ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(635, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 112;
            this.label1.Text = "Appointment ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(617, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 113;
            this.label2.Text = "Appointment Details";
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 647);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_patientId);
            this.Controls.Add(this.label_appointmentId);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.appointmentViewForm);
            this.Name = "Appointments";
            this.Text = "Appointments";
            ((System.ComponentModel.ISupportInitialize)(this.appointmentViewForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView appointmentViewForm;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label_appointmentId;
        private System.Windows.Forms.Label label_patientId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}