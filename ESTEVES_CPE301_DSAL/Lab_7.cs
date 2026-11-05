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
        EmployeeConnect empdb_connect = new EmployeeConnect();
        double basic_charge = 0,
             current_charge = 0,
             totalamountdue = 0,
             consumption = 0,
            total_charges_before_tax = 0,
            government_tax = 0,
            environmental_charge = 0,
            maintenance_service_charge = 1.53,
            meter = 23.52;

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1st table
            empdb_connect.emp_sql =
                    "INSERT INTO customerInfoTbl " +
                    "(cotractno, SOA, months, named, addressed, tinn, class, area) " +
                    "VALUES ('" + tboxa.Text + "','" + soatxtbox.Text + "', '" + monthtxtbox.Text + "', '" + tboxb.Text + "', '" + tboxc.Text + "', '" + tboxd.Text + "', '" + tboxe.Text + "', '" + tboxf.Text + "')";


            empdb_connect.emp_connString();
            empdb_connect.emp_cmd();
            empdb_connect.emp_sqladapterInsert();

            //2nd table
            empdb_connect.emp_sql =
                    "INSERT INTO meterTbl " +
                    "(meterno, mru, seq,  readdate, presentread, previousread, consump, cotractno) " +
                    "VALUES ('" + tboxg.Text + "','" + tboxh.Text + "', '" + tboxi.Text + "', '" + readdate_txtbox.Text + "', '" + textBox9.Text + "', '" + textBox8.Text + "', '" + cons_txtbox.Text + "', '" + tboxa.Text + "')";


            empdb_connect.emp_connString();
            empdb_connect.emp_cmd();
            empdb_connect.emp_sqladapterInsert();

            //3rd table
            empdb_connect.emp_sql =
                    "INSERT INTO paymentTbl " +
                    "(billperiodinput, billperiodoutput, currentcharge, basiccharge, environmental, maintenance, totalcurrent, govtax, totalamountdue, paymentdue, contractno) " +
                    "VALUES ('" + textBox19.Text + "','" + billout_txtbox.Text + "', '" + current_txtbox.Text + "', '" + basic_txtbox.Text + "', '" + envi_txtbox.Text + "', '" + main_txtbox.Text + "', '" + totalbeforetax_txtbox.Text + "', '" + government_txtbox.Text + "', '" + totalamount_txtbox.Text + "', '" + paymentdue_txtbox.Text + "', '" + tboxa.Text + "')";


            empdb_connect.emp_connString();
            empdb_connect.emp_cmd();
            empdb_connect.emp_sqladapterInsert();

            //
            empdb_connect.emp_sql = "SELECT c.SOA, c.named, c.addressed, m.meterno, m.readdate, m.consump, p.billperiodinput, p.billperiodoutput, p.totalamountdue, p.paymentdue FROM customerInfoTbl c INNER JOIN meterTbl m ON c.cotractno = m.cotractno INNER JOIN paymentTbl p ON c.cotractno = p.contractno;";
            empdb_connect.emp_cmd();
            empdb_connect.emp_sqladapterSelect();
            empdb_connect.emp_sqldatasetSELECT();
            dataGridView1.DataSource = empdb_connect.emp_sql_dataset.Tables[0];



        }

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
            call_print_lab7 print = new call_print_lab7(tboxa.Text, tboxb.Text, tboxc.Text, tboxd.Text, tboxe.Text, tboxf.Text, tboxg.Text, tboxh.Text, tboxi.Text, readdate_txtbox.Text, textBox9.Text, textBox8.Text, cons_txtbox.Text, textBox19.Text, billout_txtbox.Text, current_txtbox.Text, basic_txtbox.Text, envi_txtbox.Text, main_txtbox.Text, totalbeforetax_txtbox.Text, government_txtbox.Text, totalamount_txtbox.Text, paymentdue_txtbox.Text, soatxtbox.Text, monthtxtbox.Text );
            print.Show(); 
           



        }

        public Lab_7()
        {
            empdb_connect.emp_connString();
            InitializeComponent();
        }


        DataTable students = new DataTable();
        private void Lab_7_Load(object sender, EventArgs e)
        {
           empdb_connect.emp_sql = "SELECT * FROM customerInfoTbl c INNER JOIN meterTbl m ON c.cotractno = m.cotractno INNER JOIN paymentTbl p ON c.cotractno = p.contractno;";
            empdb_connect.emp_cmd();
            empdb_connect.emp_sqladapterSelect();
            empdb_connect.emp_sqldatasetSELECT();
            dataGridView1.DataSource = empdb_connect.emp_sql_dataset.Tables[0];
          
           

        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

   

    }
}
