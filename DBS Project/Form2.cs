using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace DBS_Project
{
    public partial class Form2 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void DB_Connect()
        {
            String oradb = "Data Source=XE; User ID=system; Password = radhikesh";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.Show();
            this.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form10 frm = new Form10();
            frm.Show();
            this.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form11 frm = new Form11();
            frm.Show();
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form12 frm = new Form12();
            frm.Show();
            this.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form13 frm = new Form13();
            frm.Show();
            this.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Visible = false;
        }
    }
}
