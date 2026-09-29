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
    public partial class seq_2 : Form
    {
        public seq_2()
        {
            InitializeComponent();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string searchProduct = search_txtbox.Text.Trim();
            bool found = false;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow)
                    continue;

                string product =
                    dataGridView1.Rows[i].Cells["ProductName"].Value?.ToString() ?? "";

                if (product.Equals(searchProduct,
                    StringComparison.OrdinalIgnoreCase))
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[i].Selected = true;

                    string price =
                        dataGridView1.Rows[i].Cells["Price"].Value?.ToString() ?? "";

                    MessageBox.Show(
                        "Product found!\n\n" +
                        "Product: " + product +
                        "\nPrice: ₱" + price);

                    found = true;
                    break;
                }
            }

            if (!found)
                MessageBox.Show("Product not found.");
        }
        

        private void Lab_5_Load(object sender, EventArgs e)
        {
            // Create DataGridView columns
            dataGridView1.Columns.Add("ProductID", "ProductID");
            dataGridView1.Columns.Add("ProductName", "ProductName");
            dataGridView1.Columns.Add("Price", "Price");

            // Add sample data
            dataGridView1.Rows.Add("P001", "Keyboard", "850");
            dataGridView1.Rows.Add("P002", "Mouse", "450");
            dataGridView1.Rows.Add("P003", "Monitor", "7200");
            dataGridView1.Rows.Add("P004", "Printer", "6500");

        }
    }
}
