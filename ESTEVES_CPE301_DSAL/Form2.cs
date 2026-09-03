using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        public string picname;
      
            

        Form3 parent = null;
        int index;
        
        public Form2(Form3 _parent, int _index)
        {
            empdb_connect.emp_connString();
            InitializeComponent();

            parent = _parent;
            index = _index;
        }

        public Form2()
        {
            empdb_connect.emp_connString();
            InitializeComponent();
        }

        public void loadDoata(int i) {
            empdb_connect.emp_sql = "SELECT * FROM CreateEmployee WHERE empid = '" + i + "'";

            empdb_connect.emp_cmd();
            empdb_connect.emp_sqladapterSelect();
            empdb_connect.emp_sqldatasetSELECT();
            dataGridView1.DataSource = empdb_connect.emp_sql_dataset.Tables[0];
        }

        private void Update_Click(object sender, EventArgs e)
        {
            parent.Refresh();
            empdb_connect.emp_sql = "UPDATE CreateEmployee SET salu='" + salu_combo.Text + "', first_n='" + first_txtbox.Text + "', middle='" + middle_txtbox.Text + "', surname='" + surname_txtbox.Text + "', suffix='" + suffix_txtbox.Text + "', house='" + house_txtbox.Text + "', barangay='" + barangay_txtbox.Text + "', city='" + city_txtbox.Text + "', province='" + province_txtbox.Text + "', zip='" + zip_txtbox.Text + "', birth='" + birth_txtbox.Text + "', nation='" + nation_txtbox.Text + "', email='" + email_txtbox.Text + "', tele='" + tele_txtbox.Text + "', job='" + job_combo.Text + "', dep='" + dep_combo.Text + "', Stat='" + stat_combo.Text + "', picpath='" + picpath_txtbox.Text + "' WHERE empid='" + empid_txtbox.Text + "'";

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
                    "(empid, salu, first_n, middle, surname, suffix, house, barangay, city, province, zip, birth, nation, email, tele, job, dep, stat, picpath) " +
                    "VALUES ('" + empid_txtbox.Text + "','" + salu_combo.Text + "', '" + first_txtbox.Text + "', '" + middle_txtbox.Text + "', '" + surname_txtbox.Text + "', '" + suffix_txtbox.Text + "', '" + house_txtbox.Text + "', '" + barangay_txtbox.Text + "', '" + city_txtbox.Text + "', '" + province_txtbox.Text + "', '" + zip_txtbox.Text + "','" + birth_txtbox.Text + "', '" + nation_txtbox.Text + "', '" + email_txtbox.Text + "', '" + tele_txtbox.Text + "', '" + job_combo.Text + "', '" + dep_combo.Text + "', '" + stat_combo.Text + "', '" + picpath_txtbox.Text + "')";


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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Function()
        {
            DataRow row = empdb_connect.emp_sql_dataset.Tables[0].Rows[0];

            empid_txtbox.Text = row["empid"].ToString();
            salu_combo.Text = row["salu"].ToString();
            first_txtbox.Text = row["first_n"].ToString();
            middle_txtbox.Text = row["middle"].ToString();
            surname_txtbox.Text = row["surname"].ToString();
            suffix_txtbox.Text = row["suffix"].ToString();
            house_txtbox.Text = row["house"].ToString();
            barangay_txtbox.Text = row["barangay"].ToString();
            city_txtbox.Text = row["city"].ToString();
            province_txtbox.Text = row["province"].ToString();
            zip_txtbox.Text = row["zip"].ToString();
            birth_txtbox.Text = row["birth"].ToString();
            nation_txtbox.Text = row["nation"].ToString();
            email_txtbox.Text = row["email"].ToString();
            tele_txtbox.Text = row["tele"].ToString();
            job_combo.Text = row["job"].ToString();
            dep_combo.Text = row["dep"].ToString();
            stat_combo.Text = row["stat"].ToString();
            picpath_txtbox.Text = row["picpath"].ToString();
            picname = picpath_txtbox.Text;

           
            pictureBox1.Image = Image.FromFile(picname);



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
            dataGridView1.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            pictureBox1.Text = picpath; 
            picpath_txtbox.Text = picpath;
        }

        private void picpath_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            empdb_connect.emp_sql = "DELETE FROM EmployeeCreate WHERE empid = " + empid_txtbox.Text + "";
            empdb_connect.emp_cmd();
            empdb_connect.emp_sqladapterUpdate();


        }

        private void infobtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            form3.Activate();

        }

        private void HEADING_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
