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
    public partial class Form3 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        public Form3()
        {
            InitializeComponent();
        }

        public void DB_Connect()
        {
            String oradb = "Data Source=XE; User ID=system; Password = radhikesh";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int flag = 0;
            DB_Connect();
            OracleCommand comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "select * from log";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_log");
            dt = ds.Tables["Tbl_log"];
            int t = dt.Rows.Count;
            for (i = 0; i < t; i++)
            {
                dr = dt.Rows[i];
                if (textBox1.Text== dr["username"].ToString() && textBox2.Text == dr["password"].ToString())
                {
                    flag = 1;
                    MessageBox.Show("Success");
                    Form4 frm = new Form4();
                    frm.Show();
                    this.Visible = false;
                }
            }
            if (flag == 0)
            {
                MessageBox.Show("Failure");
            }
            conn.Close();
        }
    }
}
