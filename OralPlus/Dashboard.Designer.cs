
namespace OralPlus
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.btn_Patient = new System.Windows.Forms.Button();
            this.btn_Appointment = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.pnl_nav = new System.Windows.Forms.Panel();
            this.btn_Check = new System.Windows.Forms.Button();
            this.btn_message = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(68)))));
            this.panelContainer.Location = new System.Drawing.Point(302, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1228, 840);
            this.panelContainer.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 221);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(63, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(100, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "OralPlus";
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_Dashboard.FlatAppearance.BorderSize = 0;
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("btn_Dashboard.Image")));
            this.btn_Dashboard.Location = new System.Drawing.Point(12, 321);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(284, 44);
            this.btn_Dashboard.TabIndex = 1;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            this.btn_Dashboard.Leave += new System.EventHandler(this.btn_Dashboard_Leave);
            // 
            // btn_Patient
            // 
            this.btn_Patient.BackColor = System.Drawing.Color.Transparent;
            this.btn_Patient.FlatAppearance.BorderSize = 0;
            this.btn_Patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Patient.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Patient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Patient.Image = ((System.Drawing.Image)(resources.GetObject("btn_Patient.Image")));
            this.btn_Patient.Location = new System.Drawing.Point(12, 371);
            this.btn_Patient.Name = "btn_Patient";
            this.btn_Patient.Size = new System.Drawing.Size(284, 44);
            this.btn_Patient.TabIndex = 2;
            this.btn_Patient.Text = "Patient";
            this.btn_Patient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Patient.UseVisualStyleBackColor = false;
            this.btn_Patient.Click += new System.EventHandler(this.btn_Patient_Click);
            this.btn_Patient.Leave += new System.EventHandler(this.btn_Patient_Leave);
            // 
            // btn_Appointment
            // 
            this.btn_Appointment.BackColor = System.Drawing.Color.Transparent;
            this.btn_Appointment.FlatAppearance.BorderSize = 0;
            this.btn_Appointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Appointment.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Appointment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Appointment.Image = ((System.Drawing.Image)(resources.GetObject("btn_Appointment.Image")));
            this.btn_Appointment.Location = new System.Drawing.Point(12, 520);
            this.btn_Appointment.Name = "btn_Appointment";
            this.btn_Appointment.Size = new System.Drawing.Size(284, 44);
            this.btn_Appointment.TabIndex = 3;
            this.btn_Appointment.Text = "Appointment";
            this.btn_Appointment.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Appointment.UseVisualStyleBackColor = false;
            this.btn_Appointment.Click += new System.EventHandler(this.btn_Appointment_Click);
            this.btn_Appointment.Leave += new System.EventHandler(this.btn_Appointment_Leave);
            // 
            // btn_Settings
            // 
            this.btn_Settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Settings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Settings.Image = ((System.Drawing.Image)(resources.GetObject("btn_Settings.Image")));
            this.btn_Settings.Location = new System.Drawing.Point(12, 570);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(284, 44);
            this.btn_Settings.TabIndex = 4;
            this.btn_Settings.Text = "Settings";
            this.btn_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Settings.UseVisualStyleBackColor = false;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            this.btn_Settings.Leave += new System.EventHandler(this.btn_Settings_Leave);
            // 
            // pnl_nav
            // 
            this.pnl_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(49)))));
            this.pnl_nav.Location = new System.Drawing.Point(3, 371);
            this.pnl_nav.Name = "pnl_nav";
            this.pnl_nav.Size = new System.Drawing.Size(3, 200);
            this.pnl_nav.TabIndex = 1;
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.Transparent;
            this.btn_Check.FlatAppearance.BorderSize = 0;
            this.btn_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Check.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Check.Image = ((System.Drawing.Image)(resources.GetObject("btn_Check.Image")));
            this.btn_Check.Location = new System.Drawing.Point(12, 420);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(284, 44);
            this.btn_Check.TabIndex = 5;
            this.btn_Check.Text = "Check in";
            this.btn_Check.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_message
            // 
            this.btn_message.BackColor = System.Drawing.Color.Transparent;
            this.btn_message.FlatAppearance.BorderSize = 0;
            this.btn_message.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_message.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_message.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_message.Image = ((System.Drawing.Image)(resources.GetObject("btn_message.Image")));
            this.btn_message.Location = new System.Drawing.Point(12, 470);
            this.btn_message.Name = "btn_message";
            this.btn_message.Size = new System.Drawing.Size(284, 44);
            this.btn_message.TabIndex = 6;
            this.btn_message.Text = "Message";
            this.btn_message.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_message.UseVisualStyleBackColor = false;
            this.btn_message.Click += new System.EventHandler(this.btn_message_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btn_message);
            this.panel1.Controls.Add(this.btn_Check);
            this.panel1.Controls.Add(this.pnl_nav);
            this.panel1.Controls.Add(this.btn_Settings);
            this.panel1.Controls.Add(this.btn_Appointment);
            this.panel1.Controls.Add(this.btn_Patient);
            this.panel1.Controls.Add(this.btn_Dashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 840);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1531, 840);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Button btn_Patient;
        private System.Windows.Forms.Button btn_Appointment;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Panel pnl_nav;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Button btn_message;
        private System.Windows.Forms.Panel panel1;
    }
}

