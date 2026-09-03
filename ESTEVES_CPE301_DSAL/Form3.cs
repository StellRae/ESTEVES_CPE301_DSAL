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
        public partial class Form3 : Form
        {
            EmployeeConnect empdb_connect = new EmployeeConnect();
        public void Refresh(object sender, DataGridViewCellEventArgs e, Form2 parent)
        {

            empdb_connect.emp_sql = "SELECT * FROM CreateEmployee";

            empdb_connect.emp_cmd();
            empdb_connect.emp_sqladapterSelect();
            empdb_connect.emp_sqldatasetSELECT();
            dataGridView1.DataSource = empdb_connect.emp_sql_dataset.Tables[0];

        }
            public Form3()
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
                Form2 form2 = new Form2(this, e.ColumnIndex);

               
                form2.Show();
                form2.Activate();
                form2.loadDoata(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
                form2.Function();

                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
