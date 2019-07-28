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
    public partial class Form11 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public Form11()
        {
            InitializeComponent();

        }
        public void DB_Connect()
        {
            String oradb = "Data Source=XE; User ID=system; Password = radhikesh";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        private void Form11_Load(object sender, EventArgs e)
        {
            int j = 0;
            DB_Connect();
            comm = new OracleCommand();
            comm.CommandText = "select palyer_name from player";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "palyer_name");
            dt = ds.Tables["palyer_name"];
            int t = dt.Rows.Count;
            comboBox1.DataSource = dt.DefaultView;
            comboBox1.DisplayMember = "palyer_name";
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            DataRowView drv = (DataRowView) comboBox1.SelectedItem;
            String valueOfItem = drv["palyer_name"].ToString();
            //string s = comboBox1.SelectedItem.ToString();
            MessageBox.Show(valueOfItem);
            comm.CommandText = "select * from player where palyer_name= '" + valueOfItem + "'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tb1_play");
            dt = ds.Tables["Tb1_play"];
            int t = dt.Rows.Count;
            if (t > 0)
            {
                dr = dt.Rows[i];
            }
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Tb1_play";
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
            this.Visible = false;
        }
    }
}
