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
    public partial class sample : Form
    {
        public sample()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            putvalue("n");
        }

        public void putvalue(int i) {
            textBox1.Text = "i'm a int overloaded function";
        }

        public void putvalue(string s)
        {
            textBox1.Text = "i'm a string overloaded function";
        }
    }
}
