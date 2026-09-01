using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ESTEVES_CPE301_DSAL
{
    public partial class Form2 : Form
    {
        EmployeeConnect empdb_connect = new EmployeeConnect();
        private String picpath;
        private Image pic;
        public Form2()
        {
            empdb_connect.emp_connString();
            InitializeComponent();
        }

        private void Update_Click(object sender, EventArgs e)
        {
                          
            empdb_connect.emp_sql = "UPDATE CreateEmployee SET Salutation='" + salu_combo.Text + "', FirstName='" + first_txtbox.Text + "', MiddleName='" + middle_txtbox.Text + "', Surname='" + surname_txtbox.Text + "', Suffix='" + suffix_txtbox.Text + "', HouseNo='" + house_txtbox.Text + "', Birthday='" + birth_txtbox.Text + "', Nationality='" + nation_txtbox.Text + "', EmailAddress='" + email_txtbox.Text + "', Telephone='" + tele_txtbox.Text + "', JobTitle='" + job_combo.Text + "', Department='" + dep_combo.Text + "', Stat='" + stat_combo.Text + "', Picture='" + picpath_txtbox.Text + "' WHERE EmployeeID='" + empid_txtbox.Text + "'";
            
            empdb_connect.emp_connString();
            empdb_connect.emp_cmd();
            empdb_connect.emp_sqladapterUpdate();



            MessageBox.Show("Updated Successfully!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                empdb_connect.emp_sql =
                    "INSERT INTO CreateEmployee " +
                    "(EmployeeID, Salutation, FirstName, MiddleName, Surname, Suffix, HouseNo, Birthday, Nationality, EmailAddress, Telephone, JobTitle, Department, Stat, Picture) " +
                    "VALUES ('" + empid_txtbox.Text + "','" + salu_combo.Text + "', '" + first_txtbox.Text + "', '" + middle_txtbox.Text + "', '" + surname_txtbox.Text + "', '" + suffix_txtbox.Text + "', '" + house_txtbox.Text + "', '" + birth_txtbox.Text + "', '" + nation_txtbox.Text + "', '" + email_txtbox.Text + "', '" + tele_txtbox.Text + "', '" + job_combo.Text + "', '" + dep_combo.Text + "', '" + stat_combo.Text + "', '" + dep_combo.Text + "')";

                empdb_connect.emp_cmd();
                empdb_connect.emp_sqladapterInsert();

                MessageBox.Show("Employee saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            pictureBox1.Text = picpath;
        }

        private void picpath_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
