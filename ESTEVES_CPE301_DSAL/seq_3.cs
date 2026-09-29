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
    public partial class seq_3 : Form
    {
        public seq_3()
        {
            InitializeComponent();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string searchName = search_txtbox.Text.Trim();
            bool found = false;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow)
                    continue;

                string employeeName =
                    dataGridView1.Rows[i].Cells["EmployeeName"].Value?.ToString() ?? "";

                if (employeeName.Equals(searchName,
                    StringComparison.OrdinalIgnoreCase))
                {
                    string id =
                        dataGridView1.Rows[i].Cells["EmployeeID"].Value?.ToString() ?? "";

                    string department =
                        dataGridView1.Rows[i].Cells["Department"].Value?.ToString() ?? "";

                    string position =
                        dataGridView1.Rows[i].Cells["Position"].Value?.ToString() ?? "";

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
        

        private void Lab_6_Load(object sender, EventArgs e)
        {
            // Create DataGridView columns
            dataGridView1.Columns.Add("EmployeeID", "EmployeeID");
            dataGridView1.Columns.Add("EmployeeName", "EmployeeName");
            dataGridView1.Columns.Add("Department", "Department");
            dataGridView1.Columns.Add("Position", "Position");

            // Add sample data (made up - not in the PDF)
            dataGridView1.Rows.Add("E001", "Juan Dela Cruz", "IT", "Programmer");
            dataGridView1.Rows.Add("E002", "Maria Santos", "HR", "HR Officer");
            dataGridView1.Rows.Add("E003", "Pedro Reyes", "Finance", "Accountant");
            dataGridView1.Rows.Add("E004", "Ana Garcia", "IT", "Network Admin");
        }
    }
}
