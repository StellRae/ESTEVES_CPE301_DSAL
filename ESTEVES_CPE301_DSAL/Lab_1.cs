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
    public partial class Lab_1 : Form
    {
        EmployeeConnect empdb_connect = new EmployeeConnect();
        private String picpath;
        private Image pic;
        public Lab_1()
        {
            empdb_connect.emp_connString();
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
                    "(empid, salu, first_n, middle, surname, suffix, house, barangay, city, province, zip, birth, nation, email, tele, job, dep, stat, picpath) " +
                    "VALUES ('" + empid_txtbox.Text + "','" + salu_combo.Text + "', '" + first_txtbox.Text + "', '" + middle_txtbox.Text + "', '" + surname_txtbox.Text + "', '" + suffix_txtbox.Text + "', '" + house_txtbox.Text + "', '" + barangay_txtbox.Text + "', '" + city_txtbox.Text + "', '" + province_txtbox.Text + "', '" + zip_txtbox.Text + "','" + birth_txtbox.Text + "', '" + nation_txtbox.Text + "', '" + email_txtbox.Text + "', '" + tele_txtbox.Text + "', '" + job_combo.Text + "', '" + dep_combo.Text + "', '" + stat_combo.Text + "', '"  + picpath_txtbox.Text + "')";


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

        private void stat_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dep_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void job_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tele_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nation_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void birth_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void zip_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void province_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void city_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void barangay_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void house_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void suffix_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void surname_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void middle_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void first_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void empid_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HEADING_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
