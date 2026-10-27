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
    public partial class Practical_Quiz : Form
    {
        EmployeeConnect empdb_connect = new EmployeeConnect();
        public Practical_Quiz()
        {
            empdb_connect.emp_connString();
            InitializeComponent();
        }
        double basic_rate = 0;
        double basic_hour = 0;
        double over_rate = 0;
        double over_hour = 0;
        double abs_hour = 0;
        double abs_rate = 0;
        double honor = 0;
        double tardy_rate = 0;
        double tardy_hour = 0;

        double basic = 0;
        double over = 0;
        double abs = 0;
        double tardy = 0;


        double gross = 0;
        double deductions = 0;
        double netpay = 0;

        double sss_contrib = 0;
        double phil_contrib = 0;
        double hdmf_contrib = 100;

        int limit_max = 0;
        int limit_min = 0;

        string payperiod;





        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {

                limit_max = Convert.ToInt32(maxtxtbox.Text);

                if (limit_min < limit_max)
                {
                    empdb_connect.emp_sql =
                    "INSERT INTO quizTbl " +
                    "(empcode, comp, dep, cut, empname, payperiod, basicpay, overtime, absences, honor, tardy, gross, totaldeduc, netpay) " +
                    "VALUES ('" + empcodetxtbox.Text + "','" + comptxtbox.Text + "', '" + deptxtbox.Text + "', '" + cutofftxtbox.Text + "', '" + nametxtbox.Text + "', '" + periodtxtbox.Text + "', '" + basictxtbox.Text + "', '" + overtxtbox.Text + "', '" + abstxtbox.Text + "', '" + honortxtbox.Text + "', '" + tardytxtbox.Text + "','" + grosstxtbox.Text + "', '" + deductxtbox.Text + "', '" + nettxtbox.Text + "')";


                empdb_connect.emp_connString();
                empdb_connect.emp_cmd();
                empdb_connect.emp_sqladapterInsert();

                MessageBox.Show("Employee saved successfully!");

                limit_min++;
                currenttxtbox.Text = Convert.ToString(limit_min);
            }


            else
            {
                MessageBox.Show("Input Limit Reached!");
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Practical_Quiz_Load(object sender, EventArgs e)
        {
            honortxtbox.Text = "1000";
            basictxtbox.Enabled = false;
            overtxtbox.Enabled = false;
            abstxtbox.Enabled = false;
            tardytxtbox.Enabled = false;
            grosstxtbox.Enabled = false;
            deductxtbox.Enabled = false;
            nettxtbox.Enabled = false;
         
            hdmftxtbox.Enabled = false;
            honortxtbox.Enabled = false;
            ssstxtbox.Enabled = false;
            philtxtbox.Enabled = false;

            payperiod = periodtxtbox.Text;

          
                empdb_connect.emp_sql = "SELECT * FROM payrollTBL";
                empdb_connect.emp_cmd();
                empdb_connect.emp_sqladapterSelect();
                empdb_connect.emp_sqldatasetSELECT();
                dataGridView1.DataSource = empdb_connect.emp_sql_dataset.Tables[0];
      



        }

        private void compbtn_Click(object sender, EventArgs e)
        {

            try
            {
                limit_max = Convert.ToInt32(maxtxtbox.Text);

            if (limit_min < limit_max)
            {


                basic_rate = Convert.ToDouble(basic_ratetxtbox.Text);
                basic_hour = Convert.ToDouble(basic_hourtxtbox.Text);
                basic = basic_rate * basic_hour;


                over_hour = Convert.ToDouble(overtime.Text);
                over_rate = Convert.ToDouble(basic_ratetxtbox.Text);
                over = over_rate * over_hour;



                abs_hour = Convert.ToDouble(abs_txtbox.Text);
                abs_rate = Convert.ToDouble(basic_ratetxtbox.Text);
                abs = abs_rate * abs_hour;



                honor = Convert.ToDouble(honortxtbox.Text);

                tardy_hour = Convert.ToDouble(tardy_txtbox.Text);
                tardy_rate = Convert.ToDouble(basic_ratetxtbox.Text);
                tardy = tardy_rate * tardy_hour;

                //
                gross = basic + over + honor;

                if (gross > 0 && gross <= 20000)
                {
                    sss_contrib = 125.75;
                }
                else if (gross > 20001 && gross <= 50000)
                {
                    sss_contrib = 2200.50;
                }
                else if (gross > 50001 && gross <= 75000)
                {
                    sss_contrib = 4800;
                }
                else
                {
                    sss_contrib = 5800;
                }

                if (gross > 0 && gross <= 20000)
                {
                    phil_contrib = 125.75;
                }
                else if (gross > 20001 && gross <= 50000)
                {
                    phil_contrib = 2200.50;
                }
                else if (gross > 50001 && gross <= 75000)
                {
                    phil_contrib = 4800;
                }
                else
                {
                    phil_contrib = 5800;
                }

                deductions = abs + tardy + sss_contrib + phil_contrib + hdmf_contrib;

                netpay = gross - deductions;
                //
                deductxtbox.Text = deductions.ToString("C");
                basictxtbox.Text = basic.ToString("C");
                overtxtbox.Text = over.ToString("C");
                abstxtbox.Text = abs.ToString("C");
                tardytxtbox.Text = tardy.ToString("C");
                grosstxtbox.Text = gross.ToString("C");
                nettxtbox.Text = netpay.ToString("C");
                    philtxtbox.Text = phil_contrib.ToString("C");
                    ssstxtbox.Text = sss_contrib.ToString("C");
                    hdmftxtbox.Text = hdmf_contrib.ToString("C");


                limit_min++;
                currenttxtbox.Text = Convert.ToString(limit_min);
            }


            else
            {
                MessageBox.Show("Input Limit Reached!");
            }
            }
            catch 
            {
                MessageBox.Show("Input Error");
            }

}





        

        private void basic_ratetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cutofftxtbox_Leave(object sender, EventArgs e)
        {
                
            string date;
            date = cutofftxtbox.Text;
            periodtxtbox.Text = Convert.ToString(date);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchCourse = payperiodtxtbox.Text.Trim();
            int count = 0;

            dataGridView1.ClearSelection();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow)
                    continue;

                string course =
                    dataGridView1.Rows[i].Cells["payperiod"].Value?.ToString() ?? "";

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
        


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                limit_max = Convert.ToInt32(maxtxtbox.Text);

                if (limit_min < limit_max)
                {
                    empdb_connect.emp_sql =
                    "INSERT INTO payrollTBL " +
                    "(empcode, comp, empname, dep, payperiod, gross, deduc, netpay) " +
                    "VALUES ('" + empcodetxtbox.Text + "','" + comptxtbox.Text + "', '" + nametxtbox.Text + "', '" + deptxtbox.Text + "', '" + periodtxtbox.Text + "', '" + grosstxtbox.Text + "', '" + deductxtbox.Text + "', '" + nettxtbox.Text + "')";


                    empdb_connect.emp_connString();
                    empdb_connect.emp_cmd();
                    empdb_connect.emp_sqladapterInsert();

                    empdb_connect.emp_sql = "SELECT * FROM payrollTBL";
                    empdb_connect.emp_cmd();
                    empdb_connect.emp_sqladapterSelect();
                    empdb_connect.emp_sqldatasetSELECT();
                    dataGridView1.DataSource = empdb_connect.emp_sql_dataset.Tables[0];

                    MessageBox.Show("Employee saved successfully!");

                    limit_min++;
                    currenttxtbox.Text = Convert.ToString(limit_min);
                }


                else
                {
                    MessageBox.Show("Input Limit Reached!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
