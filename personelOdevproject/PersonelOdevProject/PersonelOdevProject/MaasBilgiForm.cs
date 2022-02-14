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
    public partial class MaasBilgiForm : Form
    {
        public MaasBilgiForm()
        {
            InitializeComponent();
        }
        public int personelSayisi;
        List<PersonelBilgi> personelBilgiList = new List<PersonelBilgi>();
        private void MaasBilgiForm_Load(object sender, EventArgs e)
        {
            PersonelLabelGuncelle();
        }
        void PersonelLabelGuncelle()
        {
            lblPersonelSayisi.Text = personelSayisi.ToString();
        }
        PersonelBilgi p = new PersonelBilgi();

        private void button1_Click(object sender, EventArgs e)
        {
            p = p.Hesapla(decimal.Parse(txtBrutUcret.Text));
            p.Ad = txtPersonelAd.Text;
            p.Soyad = txtPersonelSoyad.Text;
            p.SicilNo = txtSicilNo.Text;
            p.TC = txtTC.Text;
            p.BrutUcret = decimal.Parse(txtBrutUcret.Text);
            personelBilgiList.Add(p);
            if (personelSayisi != 1)
            {
                MessageBox.Show("Bir Sonraki Personelin Bilgilerini Girin");
            }
            else
            {
                MessageBox.Show("Personel Ekleme İşlemi tamamlandı,Hesaplama Yapınız .");
            }
            personelSayisi--;
            PersonelLabelGuncelle();

            if (personelSayisi == 0)
            {
                button1.Enabled = false;
            }



        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = personelBilgiList;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-TEUK5RQ\SQLEXPRESS;Initial Catalog=PersonelDB;Integrated Security=True");

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            foreach (var personel in personelBilgiList)
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand($"insert into Personel (Ad,Soyad,TC,SicilNo,BrutUcret,SSKPrimiIsciPayi,IssizlikSigortasiIsciPayi,GelirVergisiMatrah,GelirVergisiMiktar,DamgaVergisiMiktari,Kesinti,NetUcret) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", connect);
                cmd.Parameters.AddWithValue("@p1", personel.Ad);
                cmd.Parameters.AddWithValue("@p2", personel.Soyad);
                cmd.Parameters.AddWithValue("@p3", personel.TC);
                cmd.Parameters.AddWithValue("@p4", personel.SicilNo);
                cmd.Parameters.AddWithValue("@p5", personel.BrutUcret);
                cmd.Parameters.AddWithValue("@p6", personel.SSKPrimiIsciPayi);
                cmd.Parameters.AddWithValue("@p7", personel.IssizlikSigortasiIsciPayi);
                cmd.Parameters.AddWithValue("@p8", personel.GelirVergisiMatrah);
                cmd.Parameters.AddWithValue("@p9", personel.GelirVergisiMiktar);
                cmd.Parameters.AddWithValue("@p10", personel.DamgaVergisiMiktari);
                cmd.Parameters.AddWithValue("@p11", personel.Kesinti);
                cmd.Parameters.AddWithValue("@p12", personel.NetUcret);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Kullanıcı/lar veritabanına kaydedildi");

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

         
        }
    }
}
