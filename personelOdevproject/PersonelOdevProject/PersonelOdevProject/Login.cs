using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelOdevProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-TEUK5RQ\SQLEXPRESS;Initial Catalog=PersonelDB;Integrated Security=True");
        private void Login_Load(object sender, EventArgs e)
        {
            StreamReader oku; //yol bilgisini akıştan okuyacak. yani dosyayı okuyacak

           // oku = File.OpenText(@"C:\Users\Dell\Desktop\Ödev\PersonelOdevProject\PersonelOdevProject\CurrentUser\MaasPersonel\Personel.txt");

            string yazi;

          //  if ((yazi = oku.ReadLine()) != null)

            {
            //    txtKullaniciAdi.Text = yazi.ToString();
            }

          //  oku.Close();//okumayı kapat
        }
        int denemeSayisi = 3;
        int Id;
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand($"select * from Kullanici where KullaniciAdi='{txtKullaniciAdi.Text}' and Sifre='{txtSifre.Text}'", connect);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Id = int.Parse(dr[0].ToString());
                if (denemeSayisi == 0)
                {
                    connect.Close();
                    connect.Open();
                    SqlCommand cmd2 = new SqlCommand($"delete from Kullanici where Id={Id}", connect);
                    cmd2.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Şifreyi 3 Kere Yanlış girdiğiniz için Hesabınız Silindi !");
                    Application.Exit();
                }
                else
                {
                    connect.Close();
                    Anasayfa frm = new Anasayfa();
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                connect.Close();
                if (denemeSayisi == 0)
                {
                    connect.Open();
                    SqlCommand cmd2 = new SqlCommand($"delete from Kullanici where KullaniciAdi='{txtKullaniciAdi.Text}'", connect);
                    cmd2.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Hesabınız Silindi program kapatılıyor");
                    Application.Exit();
                }
                denemeSayisi--;
                MessageBox.Show("Şifre Yanlış , Kalan Deneme Hakkı => " + denemeSayisi);

            }
        }
    }
}
