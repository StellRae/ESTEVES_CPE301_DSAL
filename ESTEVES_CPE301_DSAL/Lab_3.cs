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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

    namespace ESTEVES_CPE301_DSAL
    {
        public partial class Lab_3 : Form
        {
            EmployeeConnect empdb_connect = new EmployeeConnect();
        public void Refresh(object sender, DataGridViewCellEventArgs e, Lab_2 parent)
        {

            empdb_connect.emp_sql = "SELECT * FROM CreateEmployee";

            empdb_connect.emp_cmd();
            empdb_connect.emp_sqladapterSelect();
            empdb_connect.emp_sqldatasetSELECT();
            dataGridView1.DataSource = empdb_connect.emp_sql_dataset.Tables[0];

        }
            public Lab_3()
            {
                empdb_connect.emp_connString();
                InitializeComponent();
            }
       
            private void Form3_Load(object sender, EventArgs e)
            {

            empdb_connect.emp_sql = "SELECT * FROM CreateEmployee";

            empdb_connect.emp_cmd();
            empdb_connect.emp_sqladapterSelect();
            empdb_connect.emp_sqldatasetSELECT();
            dataGridView1.DataSource = empdb_connect.emp_sql_dataset.Tables[0];
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Lab_2 form2 = new Lab_2(this, e.ColumnIndex);

                form2.loadDoata(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
                form2.Function();   
                form2.Show();
         


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
