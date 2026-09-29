namespace ESTEVES_CPE301_DSAL
{
    partial class Lab_3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HEADING = new System.Windows.Forms.TextBox();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.emp_id = new System.Windows.Forms.TextBox();
            this.Createbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1710, 698);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // HEADING
            // 
            this.HEADING.BackColor = System.Drawing.SystemColors.HotTrack;
            this.HEADING.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HEADING.ForeColor = System.Drawing.SystemColors.Window;
            this.HEADING.Location = new System.Drawing.Point(0, -5);
            this.HEADING.Multiline = true;
            this.HEADING.Name = "HEADING";
            this.HEADING.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HEADING.Size = new System.Drawing.Size(1733, 39);
            this.HEADING.TabIndex = 34;
            this.HEADING.Text = "Create Employee";
            this.HEADING.TextChanged += new System.EventHandler(this.HEADING_TextChanged);
            // 
            // Searchbtn
            // 
            this.Searchbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Searchbtn.Location = new System.Drawing.Point(275, 54);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(128, 29);
            this.Searchbtn.TabIndex = 64;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = false;
            this.Searchbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // emp_id
            // 
            this.emp_id.Location = new System.Drawing.Point(12, 59);
            this.emp_id.Name = "emp_id";
            this.emp_id.Size = new System.Drawing.Size(234, 20);
            this.emp_id.TabIndex = 65;
            // 
            // Createbtn
            // 
            this.Createbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Createbtn.Location = new System.Drawing.Point(423, 54);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Size = new System.Drawing.Size(128, 29);
            this.Createbtn.TabIndex = 66;
            this.Createbtn.Text = "Create";
            this.Createbtn.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1734, 816);
            this.Controls.Add(this.Createbtn);
            this.Controls.Add(this.emp_id);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.HEADING);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox HEADING;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox emp_id;
        private System.Windows.Forms.Button Createbtn;
    }
}