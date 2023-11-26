
namespace OralPlus
{
    partial class Branch
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
            this.btn_cebu = new System.Windows.Forms.Button();
            this.btn_ilo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cebu
            // 
            this.btn_cebu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btn_cebu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cebu.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cebu.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cebu.Location = new System.Drawing.Point(679, 470);
            this.btn_cebu.Name = "btn_cebu";
            this.btn_cebu.Size = new System.Drawing.Size(167, 38);
            this.btn_cebu.TabIndex = 10;
            this.btn_cebu.Text = "Cebu City ";
            this.btn_cebu.UseVisualStyleBackColor = false;
            // 
            // btn_ilo
            // 
            this.btn_ilo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(143)))), ((int)(((byte)(213)))));
            this.btn_ilo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ilo.Font = new System.Drawing.Font("Poppins", 8F);
            this.btn_ilo.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ilo.Location = new System.Drawing.Point(180, 470);
            this.btn_ilo.Name = "btn_ilo";
            this.btn_ilo.Size = new System.Drawing.Size(167, 38);
            this.btn_ilo.TabIndex = 9;
            this.btn_ilo.Text = "Iloilo CIty";
            this.btn_ilo.UseVisualStyleBackColor = false;
            this.btn_ilo.Click += new System.EventHandler(this.btn_ilo_Click);
            // 
            // Branch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1022, 620);
            this.Controls.Add(this.btn_cebu);
            this.Controls.Add(this.btn_ilo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Branch";
            this.Text = "Branch";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cebu;
        private System.Windows.Forms.Button btn_ilo;
    }
}