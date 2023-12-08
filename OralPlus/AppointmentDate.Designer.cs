
namespace OralPlus
{
    partial class AppointmentDate
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
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_app = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(68)))));
            this.label5.Location = new System.Drawing.Point(222, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(378, 48);
            this.label5.TabIndex = 39;
            this.label5.Text = "appointment information";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(68)))));
            this.label11.Location = new System.Drawing.Point(248, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(221, 26);
            this.label11.TabIndex = 49;
            this.label11.Text = "Schedule for appointement";
            // 
            // calendar
            // 
            this.calendar.Font = new System.Drawing.Font("Poppins", 15F);
            this.calendar.Location = new System.Drawing.Point(253, 295);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 48;
            // 
            // txt_reason
            // 
            this.txt_reason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_reason.Font = new System.Drawing.Font("Poppins SemiBold", 9F);
            this.txt_reason.Location = new System.Drawing.Point(162, 569);
            this.txt_reason.Multiline = true;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(466, 179);
            this.txt_reason.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(68)))));
            this.label12.Location = new System.Drawing.Point(248, 540);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(208, 26);
            this.label12.TabIndex = 50;
            this.label12.Text = "Reason for appointement";
            // 
            // btn_app
            // 
            this.btn_app.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(68)))));
            this.btn_app.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_app.Font = new System.Drawing.Font("Poppins", 8F);
            this.btn_app.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_app.Location = new System.Drawing.Point(536, 782);
            this.btn_app.Name = "btn_app";
            this.btn_app.Size = new System.Drawing.Size(218, 38);
            this.btn_app.TabIndex = 53;
            this.btn_app.Text = "+ Make appointment";
            this.btn_app.UseVisualStyleBackColor = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkGray;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Poppins", 8F);
            this.btn_back.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_back.Location = new System.Drawing.Point(387, 782);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(128, 38);
            this.btn_back.TabIndex = 54;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // AppointmentDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_app);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.label5);
            this.Name = "AppointmentDate";
            this.Size = new System.Drawing.Size(823, 843);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_app;
        private System.Windows.Forms.Button btn_back;
    }
}
