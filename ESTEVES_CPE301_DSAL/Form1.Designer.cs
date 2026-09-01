namespace ESTEVES_CPE301_DSAL
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
            this.HEADING = new System.Windows.Forms.TextBox();
            this.empid_txtbox = new System.Windows.Forms.TextBox();
            this.first_txtbox = new System.Windows.Forms.TextBox();
            this.middle_txtbox = new System.Windows.Forms.TextBox();
            this.surname_txtbox = new System.Windows.Forms.TextBox();
            this.suffix_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.salu_combo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.house_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.barangay_txtbox = new System.Windows.Forms.TextBox();
            this.city_txtbox = new System.Windows.Forms.TextBox();
            this.province_txtbox = new System.Windows.Forms.TextBox();
            this.zip_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.birth_txtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nation_txtbox = new System.Windows.Forms.TextBox();
            this.email_txtbox = new System.Windows.Forms.TextBox();
            this.job_combo = new System.Windows.Forms.ComboBox();
            this.dep_combo = new System.Windows.Forms.ComboBox();
            this.stat_combo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tele_txtbox = new System.Windows.Forms.TextBox();
            this.picpath_txtbox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HEADING
            // 
            this.HEADING.BackColor = System.Drawing.SystemColors.HotTrack;
            this.HEADING.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HEADING.ForeColor = System.Drawing.SystemColors.Window;
            this.HEADING.Location = new System.Drawing.Point(-2, -1);
            this.HEADING.Multiline = true;
            this.HEADING.Name = "HEADING";
            this.HEADING.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HEADING.Size = new System.Drawing.Size(968, 39);
            this.HEADING.TabIndex = 0;
            this.HEADING.Text = "Create Employee";
            this.HEADING.TextChanged += new System.EventHandler(this.HEADING_TextChanged);
            // 
            // empid_txtbox
            // 
            this.empid_txtbox.Location = new System.Drawing.Point(86, 56);
            this.empid_txtbox.Name = "empid_txtbox";
            this.empid_txtbox.Size = new System.Drawing.Size(189, 20);
            this.empid_txtbox.TabIndex = 1;
            this.empid_txtbox.TextChanged += new System.EventHandler(this.empid_txtbox_TextChanged);
            // 
            // first_txtbox
            // 
            this.first_txtbox.Location = new System.Drawing.Point(124, 102);
            this.first_txtbox.Name = "first_txtbox";
            this.first_txtbox.Size = new System.Drawing.Size(204, 20);
            this.first_txtbox.TabIndex = 2;
            this.first_txtbox.Text = "Firstname";
            this.first_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.first_txtbox.TextChanged += new System.EventHandler(this.first_txtbox_TextChanged);
            // 
            // middle_txtbox
            // 
            this.middle_txtbox.Location = new System.Drawing.Point(334, 102);
            this.middle_txtbox.Name = "middle_txtbox";
            this.middle_txtbox.Size = new System.Drawing.Size(170, 20);
            this.middle_txtbox.TabIndex = 3;
            this.middle_txtbox.Text = "Middlename";
            this.middle_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.middle_txtbox.TextChanged += new System.EventHandler(this.middle_txtbox_TextChanged);
            // 
            // surname_txtbox
            // 
            this.surname_txtbox.Location = new System.Drawing.Point(510, 102);
            this.surname_txtbox.Name = "surname_txtbox";
            this.surname_txtbox.Size = new System.Drawing.Size(153, 20);
            this.surname_txtbox.TabIndex = 4;
            this.surname_txtbox.Text = "Surname";
            this.surname_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.surname_txtbox.TextChanged += new System.EventHandler(this.surname_txtbox_TextChanged);
            // 
            // suffix_txtbox
            // 
            this.suffix_txtbox.Location = new System.Drawing.Point(669, 102);
            this.suffix_txtbox.Name = "suffix_txtbox";
            this.suffix_txtbox.Size = new System.Drawing.Size(69, 20);
            this.suffix_txtbox.TabIndex = 5;
            this.suffix_txtbox.Text = "Suffix";
            this.suffix_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.suffix_txtbox.TextChanged += new System.EventHandler(this.suffix_txtbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee Id";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Employee Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Salutation";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // salu_combo
            // 
            this.salu_combo.FormattingEnabled = true;
            this.salu_combo.Location = new System.Drawing.Point(373, 55);
            this.salu_combo.Name = "salu_combo";
            this.salu_combo.Size = new System.Drawing.Size(365, 21);
            this.salu_combo.TabIndex = 9;
            this.salu_combo.SelectedIndexChanged += new System.EventHandler(this.salu_combo_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(755, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 164);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // house_txtbox
            // 
            this.house_txtbox.Location = new System.Drawing.Point(124, 137);
            this.house_txtbox.Name = "house_txtbox";
            this.house_txtbox.Size = new System.Drawing.Size(614, 20);
            this.house_txtbox.TabIndex = 11;
            this.house_txtbox.Text = "House No./Street/Subdivision";
            this.house_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.house_txtbox.TextChanged += new System.EventHandler(this.house_txtbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // barangay_txtbox
            // 
            this.barangay_txtbox.Location = new System.Drawing.Point(124, 172);
            this.barangay_txtbox.Name = "barangay_txtbox";
            this.barangay_txtbox.Size = new System.Drawing.Size(167, 20);
            this.barangay_txtbox.TabIndex = 13;
            this.barangay_txtbox.Text = "Barangay";
            this.barangay_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.barangay_txtbox.TextChanged += new System.EventHandler(this.barangay_txtbox_TextChanged);
            // 
            // city_txtbox
            // 
            this.city_txtbox.Location = new System.Drawing.Point(297, 172);
            this.city_txtbox.Name = "city_txtbox";
            this.city_txtbox.Size = new System.Drawing.Size(167, 20);
            this.city_txtbox.TabIndex = 14;
            this.city_txtbox.Text = "City/Municipality";
            this.city_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.city_txtbox.TextChanged += new System.EventHandler(this.city_txtbox_TextChanged);
            // 
            // province_txtbox
            // 
            this.province_txtbox.Location = new System.Drawing.Point(470, 172);
            this.province_txtbox.Name = "province_txtbox";
            this.province_txtbox.Size = new System.Drawing.Size(167, 20);
            this.province_txtbox.TabIndex = 15;
            this.province_txtbox.Text = "Province/Region";
            this.province_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.province_txtbox.TextChanged += new System.EventHandler(this.province_txtbox_TextChanged);
            // 
            // zip_txtbox
            // 
            this.zip_txtbox.Location = new System.Drawing.Point(643, 172);
            this.zip_txtbox.Name = "zip_txtbox";
            this.zip_txtbox.Size = new System.Drawing.Size(95, 20);
            this.zip_txtbox.TabIndex = 16;
            this.zip_txtbox.Text = "Zip";
            this.zip_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.zip_txtbox.TextChanged += new System.EventHandler(this.zip_txtbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Birthday";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // birth_txtbox
            // 
            this.birth_txtbox.Location = new System.Drawing.Point(124, 207);
            this.birth_txtbox.Name = "birth_txtbox";
            this.birth_txtbox.Size = new System.Drawing.Size(614, 20);
            this.birth_txtbox.TabIndex = 18;
            this.birth_txtbox.Text = "mm/dd/yy";
            this.birth_txtbox.TextChanged += new System.EventHandler(this.birth_txtbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nationality";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Contact Info";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Job Title";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Department";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Status";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // nation_txtbox
            // 
            this.nation_txtbox.Location = new System.Drawing.Point(124, 243);
            this.nation_txtbox.Name = "nation_txtbox";
            this.nation_txtbox.Size = new System.Drawing.Size(614, 20);
            this.nation_txtbox.TabIndex = 24;
            this.nation_txtbox.TextChanged += new System.EventHandler(this.nation_txtbox_TextChanged);
            // 
            // email_txtbox
            // 
            this.email_txtbox.Location = new System.Drawing.Point(124, 277);
            this.email_txtbox.Name = "email_txtbox";
            this.email_txtbox.Size = new System.Drawing.Size(301, 20);
            this.email_txtbox.TabIndex = 25;
            this.email_txtbox.Text = "Email Address";
            this.email_txtbox.TextChanged += new System.EventHandler(this.email_txtbox_TextChanged);
            // 
            // job_combo
            // 
            this.job_combo.FormattingEnabled = true;
            this.job_combo.Location = new System.Drawing.Point(124, 316);
            this.job_combo.Name = "job_combo";
            this.job_combo.Size = new System.Drawing.Size(614, 21);
            this.job_combo.TabIndex = 27;
            this.job_combo.SelectedIndexChanged += new System.EventHandler(this.job_combo_SelectedIndexChanged);
            // 
            // dep_combo
            // 
            this.dep_combo.FormattingEnabled = true;
            this.dep_combo.Location = new System.Drawing.Point(124, 360);
            this.dep_combo.Name = "dep_combo";
            this.dep_combo.Size = new System.Drawing.Size(614, 21);
            this.dep_combo.TabIndex = 28;
            this.dep_combo.SelectedIndexChanged += new System.EventHandler(this.dep_combo_SelectedIndexChanged);
            // 
            // stat_combo
            // 
            this.stat_combo.FormattingEnabled = true;
            this.stat_combo.Location = new System.Drawing.Point(124, 399);
            this.stat_combo.Name = "stat_combo";
            this.stat_combo.Size = new System.Drawing.Size(614, 21);
            this.stat_combo.TabIndex = 29;
            this.stat_combo.SelectedIndexChanged += new System.EventHandler(this.stat_combo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(788, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 39);
            this.button1.TabIndex = 30;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(788, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 39);
            this.button2.TabIndex = 31;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tele_txtbox
            // 
            this.tele_txtbox.Location = new System.Drawing.Point(431, 277);
            this.tele_txtbox.Name = "tele_txtbox";
            this.tele_txtbox.Size = new System.Drawing.Size(307, 20);
            this.tele_txtbox.TabIndex = 26;
            this.tele_txtbox.Text = "Telephone/Mobile No.";
            this.tele_txtbox.TextChanged += new System.EventHandler(this.tele_txtbox_TextChanged);
            // 
            // picpath_txtbox
            // 
            this.picpath_txtbox.Location = new System.Drawing.Point(755, 365);
            this.picpath_txtbox.Name = "picpath_txtbox";
            this.picpath_txtbox.Size = new System.Drawing.Size(199, 20);
            this.picpath_txtbox.TabIndex = 32;
            this.picpath_txtbox.TextChanged += new System.EventHandler(this.picpath_txtbox_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(966, 443);
            this.Controls.Add(this.picpath_txtbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stat_combo);
            this.Controls.Add(this.dep_combo);
            this.Controls.Add(this.job_combo);
            this.Controls.Add(this.tele_txtbox);
            this.Controls.Add(this.email_txtbox);
            this.Controls.Add(this.nation_txtbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.birth_txtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.zip_txtbox);
            this.Controls.Add(this.province_txtbox);
            this.Controls.Add(this.city_txtbox);
            this.Controls.Add(this.barangay_txtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.house_txtbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.salu_combo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.suffix_txtbox);
            this.Controls.Add(this.surname_txtbox);
            this.Controls.Add(this.middle_txtbox);
            this.Controls.Add(this.first_txtbox);
            this.Controls.Add(this.empid_txtbox);
            this.Controls.Add(this.HEADING);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox HEADING;
        private System.Windows.Forms.TextBox empid_txtbox;
        private System.Windows.Forms.TextBox first_txtbox;
        private System.Windows.Forms.TextBox middle_txtbox;
        private System.Windows.Forms.TextBox surname_txtbox;
        private System.Windows.Forms.TextBox suffix_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox salu_combo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox house_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox barangay_txtbox;
        private System.Windows.Forms.TextBox city_txtbox;
        private System.Windows.Forms.TextBox province_txtbox;
        private System.Windows.Forms.TextBox zip_txtbox;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox birth_txtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nation_txtbox;
        private System.Windows.Forms.TextBox email_txtbox;
        private System.Windows.Forms.ComboBox job_combo;
        private System.Windows.Forms.ComboBox dep_combo;
        private System.Windows.Forms.ComboBox stat_combo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tele_txtbox;
        private System.Windows.Forms.TextBox picpath_txtbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}