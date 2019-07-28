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
    public partial class Form12 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public Form12()
        {
            InitializeComponent();
        }
        public void DB_Connect()
        {
            String oradb = "Data Source=XE; User ID=system; Password = radhikesh";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        private void Form12_Load(object sender, EventArgs e)
        {
            int j = 0;
            DB_Connect();
            comm = new OracleCommand();
            comm.CommandText = "select match.match_date,team1_id,team2_id,stadium_name,team1_score,team2_score,winner from match left outer join summary on match.match_date=summary.match_date";
            comm.CommandType = CommandType.Text;
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tb1_xxx");
            dt = ds.Tables["Tb1_xxx"];
            int t = dt.Rows.Count;
            if (t > 0)
            {
                dr = dt.Rows[i];
            }
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Tb1_xxx";
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
            this.Visible = false;
        }
    }
}
