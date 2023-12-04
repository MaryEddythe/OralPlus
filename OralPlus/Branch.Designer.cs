
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Branch));
            this.btn_cebu = new System.Windows.Forms.Button();
            this.btn_ilo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cebu
            // 
            this.btn_cebu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(145)))), ((int)(((byte)(33)))));
            this.btn_cebu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cebu.Font = new System.Drawing.Font("Poppins SemiBold", 12F);
            this.btn_cebu.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cebu.Location = new System.Drawing.Point(744, 480);
            this.btn_cebu.Name = "btn_cebu";
            this.btn_cebu.Size = new System.Drawing.Size(420, 48);
            this.btn_cebu.TabIndex = 10;
            this.btn_cebu.Text = "Cebu City ";
            this.btn_cebu.UseVisualStyleBackColor = false;
            this.btn_cebu.Click += new System.EventHandler(this.btn_cebu_Click);
            // 
            // btn_ilo
            // 
            this.btn_ilo.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_ilo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ilo.Font = new System.Drawing.Font("Poppins SemiBold", 12F);
            this.btn_ilo.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ilo.Location = new System.Drawing.Point(85, 482);
            this.btn_ilo.Name = "btn_ilo";
            this.btn_ilo.Size = new System.Drawing.Size(420, 48);
            this.btn_ilo.TabIndex = 9;
            this.btn_ilo.Text = "Iloilo CIty";
            this.btn_ilo.UseVisualStyleBackColor = false;
            this.btn_ilo.Click += new System.EventHandler(this.btn_ilo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1279, 708);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Branch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1276, 708);
            this.Controls.Add(this.btn_cebu);
            this.Controls.Add(this.btn_ilo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Branch";
            this.Text = "Branch";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cebu;
        private System.Windows.Forms.Button btn_ilo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}