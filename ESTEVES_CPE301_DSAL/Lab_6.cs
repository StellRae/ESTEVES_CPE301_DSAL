using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace ESTEVES_CPE301_DSAL
{
    public partial class Lab_6 : Form
    {
        public Lab_6()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
        DataTable students = new DataTable();
        private void Lab_6_Load(object sender, EventArgs e)
        {
          
             
            // Create DataGridView columns
            students.Columns.Add("ID", typeof(int));
            students.Columns.Add("Name", typeof(string));
           

            // Add sample data
            students.Rows.Add("1001", "Juan");
            students.Rows.Add("1002", "Maria");
            students.Rows.Add("1003", "Carlo");

            dataGridView1.DataSource = students;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {

            RunSearch(SequentialSearch);
         
        }
        private int SentinelSearch(DataTable table, string key)
        {
            var names = table.AsEnumerable().Select(r => r["Name"].ToString()).ToList();

            int originalCount = names.Count();
            names.Add(key);
            int i = 0;  
            while (!string.Equals(names[i], key, StringComparison.OrdinalIgnoreCase)) 
            { i++; 
            }
            return i < originalCount ? i : -1;

        }
        private int SequentialSearch(DataTable table, string key)
        {
          for (int i = 0; i < table.Rows.Count; i++)
            {
                string name = table.Rows[i]["Name"].ToString();
                if (string.Equals(name, key, StringComparison.OrdinalIgnoreCase))
                    return i;
            }
                 return -1; // not found
        }
        


      

        private void RunSearch(Func<DataTable, string, int> search)
        {
            var table = (DataTable)dataGridView1.DataSource;
            int index = search(table, search_txtbox.Text.Trim());
            dataGridView1.ClearSelection();
            if (index >= 0)
            {
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = index;

            }
            MessageBox.Show(index < 0 ? "Not Found" : "Found !!");

        }

        private void btnsentinelsearch_Click(object sender, EventArgs e)
        {
            RunSearch(SentinelSearch);
        }
    }
}

