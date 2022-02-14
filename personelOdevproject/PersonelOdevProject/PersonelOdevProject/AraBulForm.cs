using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelOdevProject
{
    public partial class AraBulForm : Form
    {
        public AraBulForm()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-TEUK5RQ\SQLEXPRESS;Initial Catalog=PersonelDB;Integrated Security=True");

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            connect.Open();
            SqlDataAdapter da = new SqlDataAdapter($"select * from Personel where {cmbKriter.Text} LIKE '%{txtArama.Text}%'", connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void AraBulForm_Load(object sender, EventArgs e)
        {
            PersonelGetir();
        }
        void PersonelGetir()
        {
            connect.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Personel ", connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text=dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtTC.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSicil.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            connect.Open();
            SqlCommand cmd = new SqlCommand($"update Personel set Ad='{txtAd.Text}',Soyad='{txtSoyad.Text}',TC='{txtTC.Text}',SicilNo='{txtSicil.Text}' where Id={int.Parse(txtId.Text)}",connect);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Güncelleme İşlemi tamamlandı");
            connect.Close();
            PersonelGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand($"delete from Personel where Id={int.Parse(txtId.Text)}",connect);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi tamamlandı");
            connect.Close();
            PersonelGetir();
        }
    }
}
