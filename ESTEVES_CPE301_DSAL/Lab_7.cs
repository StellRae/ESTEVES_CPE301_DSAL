    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Net.Http.Headers;
    using System.Security.Cryptography;
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

        private void button5_Click(object sender, EventArgs e)
        {
            object source = dataGridView1.DataSource;

            if (source == null)
            {
                MessageBox.Show("No records found.");
                return;
            }

            BindingSource bs = source as BindingSource;

            if (bs == null)
            {
                bs = new BindingSource();
                bs.DataSource = source;
                dataGridView1.DataSource = bs;
            }

            IList records = bs.List;

            if (records.Count == 0 ||
                records.IsReadOnly ||
                records.IsFixedSize)
            {
                MessageBox.Show("DataSource cannot be sorted directly.");
                return;
            }

            string column;

            switch (sortby.Text)
            {
                case "Statement of Account":
                    column = "SOA";
                    break;

                case "Account Name":
                    column = "named";
                    break;

                case "Service Address":
                    column = "addressed";
                    break;

                case "Meter No.":
                    column = "meterno";
                    break;

                case "Read Date":
                    column = "readdate";
                    break;

                case "Consumption":
                    column = "consump";
                    break;

                case "Bill Period Input":
                    column = "billperiodinput";
                    break;

                case "Bill Period Output":
                    column = "billperiodoutput";
                    break;

                case "Total Amount Due":
                    column = "totalamountdue";
                    break;

                default:
                    MessageBox.Show("Please select a valid sort field.");
                    return;
            }

            PropertyDescriptor property =
                TypeDescriptor.GetProperties(records[0])
                .Find(column, true);

            if (property == null)
            {
                MessageBox.Show("Sorting field not found.");
                return;
            }

            bool isDescending = string.Equals(
                sortorder.Text,
                "Descending",
                StringComparison.OrdinalIgnoreCase);

            Comparison<object> compare = (a, b) =>
            {
                object x = property.GetValue(a);
                object y = property.GetValue(b);

                bool xNull = x == null || x == DBNull.Value;
                bool yNull = y == null || y == DBNull.Value;

                if (xNull && yNull)
                    return 0;

                if (xNull)
                    return isDescending ? 1 : -1;

                if (yNull)
                    return isDescending ? -1 : 1;

                int result = Comparer.DefaultInvariant.Compare(x, y);
                return isDescending ? -result : result;
            };

            List<object> items = new List<object>(records.Count);
            foreach (object item in records)
            {
                items.Add(item);
            }

            switch (sortalgo.Text)
            {
                case "Bubble Sort":
                    BubbleSort(items, compare);
                    break;

                case "Selection Sort":
                    SelectionSort(items, compare);
                    break;

                case "Insertion Sort":
                    InsertionSort(items, compare);
                    break;

                case "Merge Sort":
                    MergeSort(items, 0,
                        items.Count - 1, compare);
                    break;

                case "Quick Sort":
                    QuickSort(items, 0,
                        items.Count - 1, compare);
                    break;

                default:
                    MessageBox.Show("Please select a valid sort algorithm.");
                    return;
            }

            if (bs.DataSource is DataTable dt)
            {
                DataTable sortedTable = dt.Clone();
                foreach (object item in items)
                {
                    if (item is DataRowView drv)
                        sortedTable.ImportRow(drv.Row);
                    else if (item is DataRow dr)
                        sortedTable.ImportRow(dr);
                }
                bs.DataSource = sortedTable;
                bs.ResetBindings(false);
            }
            else
            {
                bool previous = bs.RaiseListChangedEvents;
                bs.RaiseListChangedEvents = false;

                try
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        records[i] = items[i];
                    }
                }
                finally
                {
                    bs.RaiseListChangedEvents = previous;

                    if (previous)
                        bs.ResetBindings(false);
                }
            }
        }

        private void BubbleSort(
        IList records,
        Comparison<object> compare)
            {
                int n = records.Count;

                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (compare(records[j], records[j + 1]) > 0)
                        {
                            object temp = records[j];
                            records[j] = records[j + 1];
                            records[j + 1] = temp;
                        }
                    }
                }
            }

            private void SelectionSort(
        IList records,
        Comparison<object> compare)
            {
                int n = records.Count;

                for (int i = 0; i < n - 1; i++)
                {
                    int min = i;

                    for (int j = i + 1; j < n; j++)
                    {
                        if (compare(records[j], records[min]) < 0)
                        {
                            min = j;
                        }
                    }

                    object temp = records[i];
                    records[i] = records[min];
                    records[min] = temp;
                }
            }

            private void InsertionSort( 
                IList records,
                Comparison<object> compare)
            {
                for (int i = 1; i < records.Count; i++)
                {
                    object key = records[i];

                    int j = i - 1;

                    while (j >= 0 &&
                        compare(records[j], key) > 0)
                    {
                        records[j + 1] = records[j];
                        j--;
                    }

                    records[j + 1] = key;
                }
            }

            private void MergeSort(
                IList records,
                int left,
                int right,
                Comparison<object> compare)
            {
                if (left >= right)
                    return;

                int mid = left + (right - left) / 2;

                MergeSort(records, left, mid, compare);
                MergeSort(records, mid + 1, right, compare);

                object[] temp = new object[right - left + 1];

                int i = left;
                int j = mid + 1;
                int k = 0;

                while (i <= mid && j <= right)
                {
                    if (compare(records[i], records[j]) <= 0)
                        temp[k++] = records[i++];
                    else
                        temp[k++] = records[j++];
                }

                while (i <= mid)
                    temp[k++] = records[i++];

                while (j <= right)
                    temp[k++] = records[j++];

                for (int x = 0; x < temp.Length; x++)
                {
                    records[left + x] = temp[x];
                }
            }

            private void QuickSort(
                IList records,
                int low,
                int high,
                Comparison<object> compare)
            {
                if (low >= high)
                    return;

                int pivotIndex = Partition(
                    records, low, high, compare);

                QuickSort(records, low, pivotIndex - 1, compare);
                QuickSort(records, pivotIndex + 1, high, compare);
            }

            private void button3_Click(object sender, EventArgs e)
            {

            }

            private int Partition(
                IList records,
                int low,
                int high,
                Comparison<object> compare)
            {
                object pivot = records[high];

                int i = low - 1;

                for (int j = low; j < high; j++)
                {
                    if (compare(records[j], pivot) <= 0)
                    {
                        i++;
                        object temp = records[i];
                        records[i] = records[j];
                        records[j] = temp;
                    }
                }

                object swap = records[i + 1];
                records[i + 1] = records[high];
                records[high] = swap;

                return i + 1;
            }



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
                //
                sortalgo.Items.Add("Bubble Sort");
                sortalgo.Items.Add("Selection Sort");
                sortalgo.Items.Add("Insertion Sort");
                sortalgo.Items.Add("Merge Sort");
                sortalgo.Items.Add("Quick Sort");

                sortorder.Items.Add("Ascending");
                sortorder.Items.Add("Descending");

                sortby.Items.Add("Statement of Account");
                sortby.Items.Add("Account Name");
                sortby.Items.Add("Service Address");
                sortby.Items.Add("Meter No.");
                sortby.Items.Add("Read Date");
                sortby.Items.Add("Consumption");
                sortby.Items.Add("Bill Period Input");
                sortby.Items.Add("Bill Period Output");
                sortby.Items.Add("Total Amount Due");




                //
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
