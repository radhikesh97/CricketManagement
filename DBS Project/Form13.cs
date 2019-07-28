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
    public partial class Form13 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public Form13()
        {
            InitializeComponent();
        }
        public void DB_Connect()
        {
            String oradb = "Data Source=XE; User ID=system; Password = radhikesh";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            int j = 0;
            DB_Connect();
            comm = new OracleCommand();
            comm.CommandText = "select batting_stats.id,batting_stats.jersey_no,palyer_name as player_name,runs,six,four,sr,avg from batting_stats left outer join player on batting_stats.id = player.id and batting_stats.jersey_no = player.jersey_no where avg > (select avg(avg) from batting_stats) ";
            comm.CommandType = CommandType.Text;
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tb1_x");
            dt = ds.Tables["Tb1_x"];
            int t = dt.Rows.Count;
            if (t > 0)
            {
                dr = dt.Rows[i];
            }
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Tb1_x";
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
