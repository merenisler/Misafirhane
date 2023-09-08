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

namespace KGM_Misafirhane
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog=KGMDb;Integrated Security=True";
        public static string personel;
        public static int staffId = 0;

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Hide();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string Saat = DateTime.Now.ToLongTimeString();
            string Tarih = DateTime.Now.ToShortDateString();
            char ayrac = '.';
            string[] Tarih1 = Tarih.Split(ayrac);
            string yıl = Tarih1[2];
            string ay = Tarih1[1];
            string gun = Tarih1[0];
            string tarihİlk = yıl + "-" + ay + "-" + gun;

            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from UserLogin where UserName=@p1 and UserPassword=@p2", bg);
            cmd.Parameters.AddWithValue("@p1", txtBxKullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@p2", txtBxSifre.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            bg.Close();
            bool sifreKontrol = false;
            if (dt.Rows.Count > 0)
            {
                sifreKontrol = true;
                personel = txtBxKullaniciAdi.Text;
            }
            else
                sifreKontrol = false;

            bg.Open();
            SqlCommand cmd2 = new SqlCommand("select * from UserLogin where UserName='" + txtBxKullaniciAdi.Text + "'", bg);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                staffId = (int)dr2["UserId"];
            }
            bg.Close();
            if (sifreKontrol == true)
            {
                try
                {
                    bg.Open();
                    string kayit = "update StaffLogin set LastLoginDate=@p1, LastLoginTime=@p2 where UserId=" + staffId + "";
                    SqlCommand komut = new SqlCommand(kayit, bg);
                    komut.Parameters.AddWithValue("@p1", tarihİlk);
                    komut.Parameters.AddWithValue("@p2", Saat);
                    komut.ExecuteNonQuery();
                    bg.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
                rezervasyonlar rezervasyonlar = new rezervasyonlar();
                rezervasyonlar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!");
                txtBxKullaniciAdi.Text = "";
                txtBxSifre.Text = "";
            }
        }

        private void txtBxSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string Saat = DateTime.Now.ToLongTimeString();
                string Tarih = DateTime.Now.ToShortDateString();
                char ayrac = '.';
                string[] Tarih1 = Tarih.Split(ayrac);
                string yıl = Tarih1[2];
                string ay = Tarih1[1];
                string gun = Tarih1[0];
                string tarihİlk = yıl + "-" + ay + "-" + gun;

                SqlConnection bg = new SqlConnection(ConnectionString);
                bg.Open();
                SqlCommand cmd = new SqlCommand("select * from UserLogin where UserName=@p1 and UserPassword=@p2", bg);
                cmd.Parameters.AddWithValue("@p1", txtBxKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@p2", txtBxSifre.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                bg.Close();
                bool sifreKontrol = false;
                if (dt.Rows.Count > 0)
                {
                    sifreKontrol = true;
                    personel = txtBxKullaniciAdi.Text;
                }
                else
                    sifreKontrol = false;

                bg.Open();
                SqlCommand cmd2 = new SqlCommand("select * from UserLogin where UserName='" + txtBxKullaniciAdi.Text + "'", bg);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    staffId = (int)dr2["UserId"];
                }
                bg.Close();
                if (sifreKontrol == true)
                {
                    try
                    {
                        bg.Open();
                        string kayit = "update UserLogin set LastLoginDate=@p1, LastLoginTime=@p2 where UserId=" + staffId + "";
                        SqlCommand komut = new SqlCommand(kayit, bg);
                        komut.Parameters.AddWithValue("@p1", tarihİlk);
                        komut.Parameters.AddWithValue("@p2", Saat);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                    }
                    rezervasyonlar rezervasyonlar = new rezervasyonlar();
                    rezervasyonlar.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!");
                    txtBxKullaniciAdi.Text = "";
                    txtBxSifre.Text = "";
                }
            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            //string tarih = "";
            //string saat = "";
            // Bugünkü tarihi al
            //DateTime bugunkuTarih = DateTime.Now;
            // Bugünkü tarihi görüntüle
            //tarih = bugunkuTarih.ToString("dd/MM/yyyy");

            // Şu anki saati al
            //DateTime suAnkiSaat = DateTime.Now;
            // Şu anki saati görüntüle
            //saat = suAnkiSaat.ToString("HH:mm:ss");
            //MessageBox.Show(tarih + " ve " + saat);

        }
    }
}
