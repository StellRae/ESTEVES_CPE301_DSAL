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
    public partial class seq_7 : Form
    {
        DataTable table = new DataTable();

        public seq_7()
        {
            InitializeComponent();
        }

        private void Lab_9_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Course");

            table.Rows.Add("1001", "Juan Cruz", "BSIT");
            table.Rows.Add("1002", "Maria Santos", "BSCS");
            table.Rows.Add("1003", "Pedro Reyes", "BSIS");
            table.Rows.Add("1004", "Ana Garcia", "BSIT");
            table.Rows.Add("1005", "Ali Hanna", "BSCE");
            table.Rows.Add("1006", "Daniel Steve", "BSIE");

            dataGridView1.DataSource = table;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string target = search_txtbox.Text.Trim();
            bool found = false;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                string name = table.Rows[i]["Name"].ToString();

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
    }

}

