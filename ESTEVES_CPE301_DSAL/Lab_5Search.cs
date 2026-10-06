using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTEVES_CPE301_DSAL
{
    public partial class Lab_5Search : Form
    {
        EmployeeConnect empdb_connect = new EmployeeConnect();
        private String picpath;
        private Image pic;
        public string picname;



        public Lab_5Search()
        {


            empdb_connect.emp_connString();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab_2 f2 = new Lab_2();
            f2.Show();

        }

        private void btnsearch6_Click(object sender, EventArgs e)
        {
            DataTable table = (DataTable)dataGridView1.DataSource;
            string target = searchtxtbox.Text.Trim();
            bool found = false;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                string name = table.Rows[i]["first_n"].ToString();

                if (name.Equals(target, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Student found at record " + (i + 1));

                    found = true;
                    break;
                }
            }

            if (!found)
                MessageBox.Show("Student not found.");



        }


        private void Lab_5Search_Load(object sender, EventArgs e)
        {
            empdb_connect.emp_select();
            empdb_connect.emp_cmd();
            empdb_connect.emp_sqladapterSelect();
            empdb_connect.emp_sqldatasetSELECT();

            dataGridView1.DataSource = empdb_connect.emp_sql_dataset.Tables[0];

        }

        private void btnsearch1_Click(object sender, EventArgs e)
        {
            string searchValue = searchtxtbox.Text.Trim();

            bool found = false;

            // Sequential Search
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                // Ignore the empty new row
                if (dataGridView1.Rows[i].IsNewRow)
                    continue;

                string studentName =
                    dataGridView1.Rows[i].Cells["first_n"].Value?.ToString() ?? "";

                if (studentName.Equals(searchValue,
                    StringComparison.OrdinalIgnoreCase))
                {
                    // Select the matching row
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[i].Selected = true;

                    // Move DataGridView to the matching record
                    dataGridView1.CurrentCell =
                        dataGridView1.Rows[i].Cells["first_n"];

                    MessageBox.Show(
                        "Record found at row " + (i + 1),
                        "Sequential Search",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    found = true;
                    break;
                }
            }
        }

        private void saea_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsearch2_Click(object sender, EventArgs e)
        {

            string searchProduct = searchtxtbox.Text.Trim();
            bool found = false;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow)
                    continue;

                string name =
                    dataGridView1.Rows[i].Cells["first_n"].Value?.ToString() ?? "";

                if (name.Equals(searchProduct,
                    StringComparison.OrdinalIgnoreCase))
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[i].Selected = true;

                    string bdate =
                        dataGridView1.Rows[i].Cells["birth"].Value?.ToString() ?? "";

                    MessageBox.Show(
                        "The birthday of " + name + " " +
                        "is at" + " " + bdate);

                    found = true;
                    break;
                }
            }

            if (!found)
                MessageBox.Show("Product not found.");
        }

        private void btnsearch3_Click(object sender, EventArgs e)
        {

            string searchName = searchtxtbox.Text.Trim();
            bool found = false;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow)
                    continue;

                string employeeName =
                    dataGridView1.Rows[i].Cells["first_n"].Value?.ToString() ?? "";

                if (employeeName.Equals(searchName,
                    StringComparison.OrdinalIgnoreCase))
                {
                    string id =
                        dataGridView1.Rows[i].Cells["empid"].Value?.ToString() ?? "";

                    string department =
                        dataGridView1.Rows[i].Cells["dep"].Value?.ToString() ?? "";

                    string position =
                        dataGridView1.Rows[i].Cells["job"].Value?.ToString() ?? "";

                    MessageBox.Show(
                        "Employee Found\n\n" +
                        "ID: " + id +
                        "\nName: " + employeeName +
                        "\nDepartment: " + department +
                        "\nPosition: " + position);

                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[i].Selected = true;

                    found = true;
                    break;
                }
            }

            if (!found)
                MessageBox.Show("Employee not found.");
        }

        private void btnsearch4_Click(object sender, EventArgs e)
        {
            string searchValue = searchtxtbox.Text.Trim();
            bool found = false;

            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                if (dataGridView1.Rows[row].IsNewRow)
                    continue;

                for (int col = 0; col < dataGridView1.Columns.Count; col++)
                {
                    string value =
                        dataGridView1.Rows[row].Cells[col].Value?.ToString() ?? "";

                    if (value.Equals(searchValue,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        dataGridView1.ClearSelection();

                        dataGridView1.Rows[row].Selected = true;
                        dataGridView1.CurrentCell =
                            dataGridView1.Rows[row].Cells[col];

                        MessageBox.Show("Record found at row " + (row + 1));

                        found = true;
                        break;
                    }
                }
            }
        }

        private void btnsearch5_Click(object sender, EventArgs e)
        {
            string searchCourse = searchtxtbox.Text.Trim();
            int count = 0;

            dataGridView1.ClearSelection();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow)
                    continue;

                string course =
                    dataGridView1.Rows[i].Cells["province"].Value?.ToString() ?? "";

                if (course.Equals(searchCourse,
                    StringComparison.OrdinalIgnoreCase))
                {
                    dataGridView1.Rows[i].Selected = true;
                    count++;
                }
            }

            if (count > 0)
            {
                MessageBox.Show(count + " matching record(s) found.");
            }
            else
            {
                MessageBox.Show("No matching records found.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Reload()
        {
            if (empdb_connect.emp_sql_dataset != null)
            {
                empdb_connect.emp_sql_dataset.Clear();
            }
            empdb_connect.emp_sql = "SELECT * FROM CreateEmployee";
            empdb_connect.emp_cmd();
            empdb_connect.emp_sqladapterSelect();
            empdb_connect.emp_sqldatasetSELECT();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = empdb_connect.emp_sql_dataset.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dataGridView1.CurrentRow != null)
                    {
                        dataGridView1.CurrentRow.Selected = true;
                    }
                    var CellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    if (e.ColumnIndex == 0 && CellValue != null)
                    {
                        Lab_2 l = new Lab_2();
                        l.SelectedEmpId = CellValue.ToString();

                        if (l.ShowDialog() == DialogResult.OK)
                        {
                            {
                                Reload();
                            }
                        }
                    }
                }
            }
        }
    }
}









