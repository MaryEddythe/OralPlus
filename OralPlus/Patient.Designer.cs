
namespace OralPlus
{
    partial class Patient
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.date_dob = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_add = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radio_xx = new System.Windows.Forms.RadioButton();
            this.radio_female = new System.Windows.Forms.RadioButton();
            this.radio_male = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.patientViewForm = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientViewForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.date_dob);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_contact);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_add);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.radio_xx);
            this.panel1.Controls.Add(this.radio_female);
            this.panel1.Controls.Add(this.radio_male);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_fname);
            this.panel1.Controls.Add(this.txt_lname);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.patientViewForm);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 840);
            this.panel1.TabIndex = 0;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(143)))), ((int)(((byte)(213)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Poppins Medium", 7.8F);
            this.btn_delete.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_delete.Location = new System.Drawing.Point(1075, 655);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(107, 39);
            this.btn_delete.TabIndex = 127;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(143)))), ((int)(((byte)(213)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Poppins Medium", 7.8F);
            this.btn_update.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_update.Location = new System.Drawing.Point(959, 655);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(107, 39);
            this.btn_update.TabIndex = 126;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Poppins SemiBold", 9F);
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(716, 303);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(107, 26);
            this.label22.TabIndex = 125;
            this.label22.Text = "Date of Birth";
            // 
            // date_dob
            // 
            this.date_dob.Font = new System.Drawing.Font("Poppins Medium", 8F);
            this.date_dob.Location = new System.Drawing.Point(717, 334);
            this.date_dob.Name = "date_dob";
            this.date_dob.Size = new System.Drawing.Size(463, 27);
            this.date_dob.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(712, 626);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 123;
            this.label1.Text = "Contact Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(715, 539);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 26);
            this.label2.TabIndex = 122;
            this.label2.Text = "Email";
            // 
            // txt_contact
            // 
            this.txt_contact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_contact.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.txt_contact.Location = new System.Drawing.Point(714, 655);
            this.txt_contact.Multiline = true;
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(223, 39);
            this.txt_contact.TabIndex = 121;
            // 
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.txt_email.Location = new System.Drawing.Point(715, 568);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(466, 39);
            this.txt_email.TabIndex = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 9F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(716, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 26);
            this.label3.TabIndex = 119;
            this.label3.Text = "Address";
            // 
            // txt_add
            // 
            this.txt_add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_add.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.txt_add.Location = new System.Drawing.Point(716, 480);
            this.txt_add.Multiline = true;
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(466, 39);
            this.txt_add.TabIndex = 118;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 9F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(713, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 26);
            this.label4.TabIndex = 117;
            this.label4.Text = "Sex";
            // 
            // radio_xx
            // 
            this.radio_xx.AutoSize = true;
            this.radio_xx.Font = new System.Drawing.Font("Poppins Medium", 8F);
            this.radio_xx.ForeColor = System.Drawing.Color.White;
            this.radio_xx.Location = new System.Drawing.Point(1031, 404);
            this.radio_xx.Name = "radio_xx";
            this.radio_xx.Size = new System.Drawing.Size(147, 29);
            this.radio_xx.TabIndex = 116;
            this.radio_xx.TabStop = true;
            this.radio_xx.Text = "Prefer not to say";
            this.radio_xx.UseVisualStyleBackColor = true;
            // 
            // radio_female
            // 
            this.radio_female.AutoSize = true;
            this.radio_female.Font = new System.Drawing.Font("Poppins Medium", 8F);
            this.radio_female.ForeColor = System.Drawing.Color.White;
            this.radio_female.Location = new System.Drawing.Point(876, 404);
            this.radio_female.Name = "radio_female";
            this.radio_female.Size = new System.Drawing.Size(86, 29);
            this.radio_female.TabIndex = 115;
            this.radio_female.TabStop = true;
            this.radio_female.Text = "Female";
            this.radio_female.UseVisualStyleBackColor = true;
            // 
            // radio_male
            // 
            this.radio_male.AutoSize = true;
            this.radio_male.Font = new System.Drawing.Font("Poppins Medium", 8F);
            this.radio_male.ForeColor = System.Drawing.Color.White;
            this.radio_male.Location = new System.Drawing.Point(716, 404);
            this.radio_male.Name = "radio_male";
            this.radio_male.Size = new System.Drawing.Size(67, 29);
            this.radio_male.TabIndex = 114;
            this.radio_male.TabStop = true;
            this.radio_male.Text = "Male";
            this.radio_male.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 9F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(713, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 26);
            this.label8.TabIndex = 113;
            this.label8.Text = "Patient ID";
            // 
            // txt_id
            // 
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.txt_id.Location = new System.Drawing.Point(716, 151);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(223, 39);
            this.txt_id.TabIndex = 112;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 9F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(956, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 26);
            this.label6.TabIndex = 111;
            this.label6.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 9F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(713, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 26);
            this.label7.TabIndex = 110;
            this.label7.Text = "Last Name";
            // 
            // txt_fname
            // 
            this.txt_fname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fname.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.txt_fname.Location = new System.Drawing.Point(959, 243);
            this.txt_fname.Multiline = true;
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(223, 39);
            this.txt_fname.TabIndex = 109;
            // 
            // txt_lname
            // 
            this.txt_lname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lname.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.txt_lname.Location = new System.Drawing.Point(716, 243);
            this.txt_lname.Multiline = true;
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(223, 39);
            this.txt_lname.TabIndex = 108;
            // 
            // txt_search
            // 
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.txt_search.Location = new System.Drawing.Point(325, 39);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(338, 35);
            this.txt_search.TabIndex = 106;
            // 
            // patientViewForm
            // 
            this.patientViewForm.AllowUserToAddRows = false;
            this.patientViewForm.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patientViewForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patientViewForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientViewForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.patientViewForm.GridColor = System.Drawing.SystemColors.ControlLight;
            this.patientViewForm.Location = new System.Drawing.Point(64, 89);
            this.patientViewForm.Name = "patientViewForm";
            this.patientViewForm.RowHeadersWidth = 51;
            this.patientViewForm.RowTemplate.Height = 24;
            this.patientViewForm.Size = new System.Drawing.Size(599, 714);
            this.patientViewForm.TabIndex = 1;
            this.patientViewForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientViewForm_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Last name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "First name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sex";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date of Birth";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Address";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Email";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Phone";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Patient";
            this.Size = new System.Drawing.Size(1225, 840);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientViewForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView patientViewForm;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker date_dob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radio_xx;
        private System.Windows.Forms.RadioButton radio_female;
        private System.Windows.Forms.RadioButton radio_male;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}
