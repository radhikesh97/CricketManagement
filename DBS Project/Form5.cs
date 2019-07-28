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
    public partial class Form5 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public Form5()
        {
            InitializeComponent();
            comboBox1.Items.Add("INDIA");
            comboBox1.Items.Add("SRI LANKA");
            comboBox1.Items.Add("BANGLADESH");
        }
        public void DB_Connect()
        {
            String oradb = "Data Source=XE; User ID=system; Password = radhikesh";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            comm.CommandText = "select * from player where ID = '"+comboBox1.SelectedItem.ToString()+"'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tb1_player");
            dt = ds.Tables["Tb1_player"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            if (t > 0)
            {
                dr = dt.Rows[i];
            }
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Tb1_player";
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
            this.Visible = false;
        }
    }
}
