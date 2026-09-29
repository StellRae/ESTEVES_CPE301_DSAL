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
    public partial class seq_6 : Form
    {
        public seq_6()
        {
            InitializeComponent();
        }

        private void Lab_8_Load(object sender, EventArgs e)
        {
            // Create DataGridView columns
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Course", "Course");

            // Add sample data
            dataGridView1.Rows.Add("1001", "Juan Cruz", "BSIT");
            dataGridView1.Rows.Add("1002", "Maria Santos", "BSCS");
            dataGridView1.Rows.Add("1003", "Carlo Reyes", "BSIT");
            dataGridView1.Rows.Add("1004", "Ana Garcia", "BSIS");
            dataGridView1.Rows.Add("1005", "Mark Lopez", "BSIT");
            dataGridView1.Rows.Add("1006", "Ron Garcia", "BSCpE");
            dataGridView1.Rows.Add("1007", "Ken Ernest", "BSCE");
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string searchCourse = search_txtbox.Text.Trim();
            int count = 0;

            dataGridView1.ClearSelection();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow)
                    continue;

                string course =
                    dataGridView1.Rows[i].Cells["Course"].Value?.ToString() ?? "";

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
    }
}
