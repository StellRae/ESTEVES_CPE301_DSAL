    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    namespace ESTEVES_CPE301_DSAL
    {
        public partial class Form3 : Form
        {
            EmployeeConnect empdb_connect = new EmployeeConnect();

            public Form3()
            {
                empdb_connect.emp_connString();
                InitializeComponent();
            }

            private void Form3_Load(object sender, EventArgs e)
            {
               

            }

            private void button1_Click(object sender, EventArgs e)
            {
   
            
                empdb_connect.emp_sql = "SELECT * FROM CreateEmployee WHERE EmployeeID = '" + emp_id.Text + "'";

                empdb_connect.emp_cmd();
                empdb_connect.emp_sqladapterSelect();
                empdb_connect.emp_sqldatasetSELECT();
                dataGridView1.DataSource = empdb_connect.emp_sql_dataset.Tables[0];
            }

            private void HEADING_TextChanged(object sender, EventArgs e)
            {

            }
        }
    }
