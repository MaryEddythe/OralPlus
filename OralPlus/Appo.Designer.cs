
namespace OralPlus
{
    partial class Appo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.appointmentViewForm = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_done = new System.Windows.Forms.Button();
            this.label_patientId = new System.Windows.Forms.Label();
            this.label_appointmentId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentViewForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.appointmentViewForm);
            this.panel1.Location = new System.Drawing.Point(16, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 792);
            this.panel1.TabIndex = 0;
            // 
            // appointmentViewForm
            // 
            this.appointmentViewForm.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.appointmentViewForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentViewForm.Location = new System.Drawing.Point(14, 16);
            this.appointmentViewForm.Name = "appointmentViewForm";
            this.appointmentViewForm.RowHeadersWidth = 51;
            this.appointmentViewForm.RowTemplate.Height = 24;
            this.appointmentViewForm.Size = new System.Drawing.Size(599, 766);
            this.appointmentViewForm.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins ExtraBold", 25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(671, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(519, 74);
            this.label3.TabIndex = 36;
            this.label3.Text = "APPOINTMENT DETAILS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(681, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 114;
            this.label1.Text = "Appointment ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 9F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(681, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 26);
            this.label8.TabIndex = 113;
            this.label8.Text = "Patient ID";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DarkRed;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Poppins SemiBold", 9F);
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.Location = new System.Drawing.Point(917, 643);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(107, 47);
            this.btn_cancel.TabIndex = 116;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click_1);
            // 
            // btn_done
            // 
            this.btn_done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btn_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_done.Font = new System.Drawing.Font("Poppins SemiBold", 9F);
            this.btn_done.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_done.Location = new System.Drawing.Point(785, 643);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(107, 47);
            this.btn_done.TabIndex = 115;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = false;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click_1);
            // 
            // label_patientId
            // 
            this.label_patientId.AutoSize = true;
            this.label_patientId.Font = new System.Drawing.Font("Poppins Medium", 8F);
            this.label_patientId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_patientId.Location = new System.Drawing.Point(683, 327);
            this.label_patientId.Name = "label_patientId";
            this.label_patientId.Size = new System.Drawing.Size(0, 25);
            this.label_patientId.TabIndex = 117;
            // 
            // label_appointmentId
            // 
            this.label_appointmentId.AutoSize = true;
            this.label_appointmentId.Font = new System.Drawing.Font("Poppins Medium", 8F);
            this.label_appointmentId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_appointmentId.Location = new System.Drawing.Point(683, 407);
            this.label_appointmentId.Name = "label_appointmentId";
            this.label_appointmentId.Size = new System.Drawing.Size(0, 25);
            this.label_appointmentId.TabIndex = 118;
            // 
            // Appo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.label_appointmentId);
            this.Controls.Add(this.label_patientId);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Appo";
            this.Size = new System.Drawing.Size(1228, 840);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentViewForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView appointmentViewForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Label label_patientId;
        private System.Windows.Forms.Label label_appointmentId;
    }
}
