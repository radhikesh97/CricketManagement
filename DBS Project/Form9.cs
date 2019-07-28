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
    public partial class Form9 : Form
    {
        OracleConnection conn;
        OracleCommand comm,comm2;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public Form9()
        {
            InitializeComponent();
            DB_Connect();
            comm2 = new OracleCommand();
            comm2.CommandText = "exec details";
            comm2.CommandType = CommandType.Text; 
            comm = new OracleCommand();
            comm.CommandText = "select * from topper";
            //comm.CommandText = "select from batting_stats order by runs desc";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tb1_topper");
            dt = ds.Tables["Tb1_topper"];
            
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            if (t > 0)
            {
                dr = dt.Rows[i];
            }
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Tb1_topper";
            

            conn.Close();
        }
        public void DB_Connect()
        {
            String oradb = "Data Source=XE; User ID=system; Password = radhikesh";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
            this.Visible = false;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
        
        }
    }
}
