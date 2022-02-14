using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelOdevProject
{
    public partial class BilgiForm : Form
    {
        public BilgiForm()
        {
            InitializeComponent(); 
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-TEUK5RQ\SQLEXPRESS;Initial Catalog=PersonelDB;Integrated Security=True");

        private void BilgiForm_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("select * from Personel",connect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listView1.Items.Add(dr[0].ToString());
                listView1.Items.Add(dr[1].ToString());
                listView1.Items.Add(dr[2].ToString());
                listView1.Items.Add(dr[3].ToString());
                listView1.Items.Add(dr[4].ToString());
                listView1.Items.Add("\n");
                listView1.Items.Add("\n");
                listView1.Items.Add("\n");
                listView1.Items.Add("\n");
                listView1.Items.Add("\n");
                listView1.Items.Add("\n");
                listView1.Items.Add("\n");
                listView1.Items.Add("\n");
                listView1.Items.Add("\n");
                listView1.Items.Add("\n");
                listView1.Items.Add("\n");
                listView1.Items.Add("\n");
                listView1.Items.Add("\n");
                Thread.Sleep(100);
            }
           
            connect.Close();
        }
    }
}
