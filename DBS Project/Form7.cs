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
    public partial class Form7 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        int j = 0;
        int k = 0;
        public Form7()
        {
            InitializeComponent();
        }
        public void DB_Connect()
        {
            String oradb = "Data Source=XE; User ID=system; Password = radhikesh";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            comm.CommandText = "select * from bowling_stats left outer join player on bowling_stats.id=player.id AND bowling_stats.jersey_no=player.jersey_no where player.id='SRI LANKA'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_bowling_stats");
            dt = ds.Tables["Tbl_bowling_stats"];
            int t = dt.Rows.Count;
            dr = dt.Rows[j];
            textBox1.Text = dr["id"].ToString();
            textBox2.Text = dr["jersey_no"].ToString();
            textBox3.Text = dr["balls"].ToString();
            textBox4.Text = dr["maidens"].ToString();
            textBox5.Text = dr["wickets"].ToString();
            textBox6.Text = dr["economy"].ToString();
            textBox7.Text = dr["palyer_name"].ToString();
            j++;
            if (j >= dt.Rows.Count)
                j = 0;
            dr = dt.Rows[j];
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            comm.CommandText = "select * from bowling_stats left outer join player on bowling_stats.id=player.id AND bowling_stats.jersey_no=player.jersey_no where player.id='INDIA'" ;
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tb1_bowling_stats");
            dt = ds.Tables["Tb1_bowling_stats"];
            int t = dt.Rows.Count;
            dr = dt.Rows[i];
            textBox1.Text = dr["id"].ToString();
            textBox2.Text = dr["jersey_no"].ToString();
            textBox3.Text = dr["balls"].ToString();
            textBox4.Text = dr["maidens"].ToString();
            textBox5.Text = dr["wickets"].ToString();
            textBox6.Text = dr["economy"].ToString();
            textBox7.Text = dr["palyer_name"].ToString();
            i++;
            if (i >= dt.Rows.Count)
                i = 0;
            dr = dt.Rows[i];
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            comm.CommandText = "select * from bowling_stats left outer join player on bowling_stats.id=player.id AND bowling_stats.jersey_no=player.jersey_no where player.id='BANGLADESH'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_bowling_stats");
            dt = ds.Tables["Tbl_bowling_stats"];
            int t = dt.Rows.Count;
            dr = dt.Rows[k];
            textBox1.Text = dr["id"].ToString();
            textBox2.Text = dr["jersey_no"].ToString();
            textBox3.Text = dr["balls"].ToString();
            textBox4.Text = dr["maidens"].ToString();
            textBox5.Text = dr["wickets"].ToString();
            textBox6.Text = dr["economy"].ToString();
            textBox7.Text = dr["palyer_name"].ToString();
            k++;
            if (k >= dt.Rows.Count)
                k = 0;
            dr = dt.Rows[k];
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
            this.Visible = false;
        }
    }
}
