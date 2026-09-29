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
    public partial class seq_5 : Form
    {
        public seq_5()
        {
            InitializeComponent();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string searchValue = search_txtbox.Text.Trim();
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






        private void Lab_7_Load(object sender, EventArgs e)
        {
            // Create DataGridView columns
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Course", "Course");
            dataGridView1.Columns.Add("Year", "Year");

            // Add sample data
            dataGridView1.Rows.Add("1001", "Juan Cruz", "BSIT", "1");
            dataGridView1.Rows.Add("1002", "Maria Santos", "BSCS", "2");
            dataGridView1.Rows.Add("1003", "Carlo Reyes", "BSIT", "3");
        }

        private void search_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
