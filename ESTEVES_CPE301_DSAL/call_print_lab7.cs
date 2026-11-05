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
    public partial class call_print_lab7 : Form
    {
        string Contract;
        string names;
        string services;
        string tins;
        string rates;
        string businesses;
        string meters;
        string mrus;

        string seqs;
        string dates;
        string presents;
        string previouss;
        string consumps;
        string basics;
        string currents;
        string inputs;

        string outputs;
        string environmentals;
        string mscs;
        string totalcurrents;
        string governmenttaxs;
        string totalamounts;
        string paymentdues;
        string soas;
        string months;




        public call_print_lab7(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k, string l, string m, string n, string o, string p, string q, string r, string s, string t, string u, string v, string w, string x, string y)
        {
            InitializeComponent();
            Contract = a;
            names = b;
            services = c;
            tins = d;
            rates = e;
            businesses = f;
            meters = g;
            mrus = h;
            seqs = i;
            dates = j;
            presents = k;
            previouss = l;
            consumps = m;

            inputs = n;
            outputs = o;
            basics = p;
            currents = q;
            environmentals = r;
            mscs = s;
            totalcurrents = t;
            governmenttaxs = u;
            totalamounts = v;
            paymentdues = w;
            soas = x;
            months = y;

        }

        private void call_print_lab7_Load(object sender, EventArgs e)
        {
            contract.Text = Contract;
            name.Text = names;
            service.Text = services;
            tin.Text = tins;
            rate.Text = rates;
            business.Text = businesses;
            meter.Text = meters;
            mru.Text = mrus;
            seq.Text = seqs;
            date.Text = dates;
            present.Text = presents;
            previous.Text = previouss;
            consump.Text = consumps;
            basic.Text = basics;
            current.Text = currents;
            input.Text = inputs;
            output.Text = outputs;
            environmental.Text = environmentals;
            msc.Text = mscs;
            totalcurrent.Text = totalcurrents;
            governmenttax.Text = governmenttaxs;
            totalamount.Text = totalamounts;
            paymentdue.Text = paymentdues;
            soa_txtbox.Text = soas;
            month_txtbox.Text = months;

        }
    }
}
