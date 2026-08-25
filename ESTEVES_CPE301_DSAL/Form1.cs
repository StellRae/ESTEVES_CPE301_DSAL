using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ESTEVES_CPE301_DSAL
{
    public partial class Form1 : Form
    {
        EmployeeConnect empdb_connect = new EmployeeConnect();
        private String picpath;
        private Image pic;
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                empdb_connect.emp_sql =
                    "INSERT INTO CreateEmployee " +
                    "(Salutation, FirstName, MiddleName, Surname, Suffix, HouseNo, Birthday, Nationality, EmailAddress, Telephone, JobTitle, Department, Status, Picture) " +
                    "VALUES ('" + salu_combo.Text + "', '" + first_txtbox.Text + "', '" + middle_txtbox.Text + "', '" + surname_txtbox.Text + "', '" + suffix_txtbox.Text + "', '" + house_txtbox.Text + "', '" + birth_txtbox.Text + "', '" + nation_txtbox.Text + "', '" + email_txtbox.Text + "', '" + tele_txtbox.Text + "', '" + job_combo.Text + "', '" + dep_combo.Text + "', '" + stat_combo.Text + "', '" + dep_combo.Text + "')";


                empdb_connect.emp_connString();
                empdb_connect.emp_cmd();
                empdb_connect.emp_sqladapterInsert();

                MessageBox.Show("Employee saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }   
        }

        private void picpath_txtbox_TextChanged(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            pictureBox1.Text = picpath;
        }

        private void salu_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            salu_combo.Items.Add("Mr.");
            salu_combo.Items.Add("Ms.");
            job_combo.Items.Add("Teacher");
            job_combo.Items.Add("Accountant");
            dep_combo.Items.Add("Engineering");
            dep_combo.Items.Add("Nursing");
            stat_combo.Items.Add("Married");
            stat_combo.Items.Add("Single");
            picpath_txtbox.Visible = false;

        }
    }
}
