using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTEVES_CPE301_DSAL
{
    public partial class Lab_7 : Form
    {
        double basic_charge = 0,
             current_charge = 0,
             totalamountdue = 0,
             consumption = 0,
            total_charges_before_tax = 0,
            government_tax = 0,
            environmental_charge = 0,
            maintenance_service_charge = 1.53,
            meter = 23.52;

        private void button1_Click(object sender, EventArgs e)
        {
            //

            billout_txtbox.Text = readdate_txtbox.Text;

            //
            consumption = Convert.ToDouble(cons_txtbox.Text);
            basic_charge = consumption * meter;

            //
            environmental_charge = .20 * basic_charge;
            total_charges_before_tax = basic_charge + environmental_charge + maintenance_service_charge;
            government_tax = total_charges_before_tax * 0.025;
            totalamountdue = total_charges_before_tax + government_tax;
            current_charge = totalamountdue;


            // printer
            basic_txtbox.Text = basic_charge.ToString("N");
            totalbeforetax_txtbox.Text = total_charges_before_tax.ToString("N");
            government_txtbox.Text = government_tax.ToString("N");
            current_txtbox.Text = current_charge.ToString("N");
            envi_txtbox.Text = environmental_charge.ToString("N");
            main_txtbox.Text = maintenance_service_charge.ToString("N");
            totalamount_txtbox.Text = totalamountdue.ToString("N");

            //
            call_print_lab7 print = new call_print_lab7();
            print.Show(); 
            print.executecode();


        }

        public Lab_7()
        {
            InitializeComponent();
        }


        DataTable students = new DataTable();
        private void Lab_7_Load(object sender, EventArgs e)
        {

            /*Create DataGridView columns
            students.Columns.Add("ID", typeof(int));
            students.Columns.Add("Name", typeof(string));


            // Add sample data
            students.Rows.Add("1001", "Juan");
            students.Rows.Add("1002", "Maria");
            students.Rows.Add("1003", "Carlo");

            dataGridView1.DataSource = students;*/
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

   

    }
}
