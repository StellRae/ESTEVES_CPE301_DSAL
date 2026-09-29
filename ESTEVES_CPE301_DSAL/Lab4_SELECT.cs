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
    public partial class Lab4_SELECT : Form
    {
        public Lab4_SELECT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    seq_1 a = new seq_1();
                    a.ShowDialog();
                    break;

                case 1:
                    seq_2 b = new seq_2();
                    b.ShowDialog();
                    break;

                case 2:
                    seq_3 c = new seq_3();
                    c.ShowDialog();
                    break;

                case 3:
                    seq_5 d = new seq_5();
                    d.ShowDialog();
                    break;

                case 4:
                    seq_6 da= new seq_6();
                    da.ShowDialog();
                    break;

                case 5:
                    seq_7 f = new seq_7();
                    f.ShowDialog();
                    break;




            }
        }

        private void Lab4_SELECT_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Seq_1");
            comboBox1.Items.Add("Seq_2");
            comboBox1.Items.Add("Seq_3");
            comboBox1.Items.Add("Seq_5");
            comboBox1.Items.Add("Seq_6");
            comboBox1.Items.Add("Seq_7");

        }
    }
}
