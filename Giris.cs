using System;
using System.Collections;
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

        public static string ConnectionString = Class.vt.ConnectionString;

        private void GirisKontrol(string kullaniciAdi, string sifre)
        {
            string Saat = DateTime.Now.ToLongTimeString();
            DateTime bugunkuTarih = DateTime.Now;

            string personel = "";

            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from UserLogin where UserName=@p1 and UserPassword=@p2", bg);
            cmd.Parameters.AddWithValue("@p1", kullaniciAdi);
            cmd.Parameters.AddWithValue("@p2", sifre);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            bg.Close();
            bool sifreKontrol = false;
            if (dt.Rows.Count > 0)
            {
                sifreKontrol = true;
                personel = kullaniciAdi;
            }
            else
                sifreKontrol = false;

            int userId = 0;

            bg.Open();
            SqlCommand cmd2 = new SqlCommand("select * from UserLogin where UserName='" + kullaniciAdi + "'", bg);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                userId = (int)dr2["UserId"];
            }
            bg.Close();

            if (sifreKontrol == true)
            {
                try
                {
                    bg.Open();
                    string kayit = "update UserLogin set LastLoginDate=@p1, LastLoginTime=@p2 where UserId=" + userId + "";
                    SqlCommand komut = new SqlCommand(kayit, bg);
                    komut.Parameters.AddWithValue("@p1", bugunkuTarih.ToString("yyyy/MM/dd"));
                    komut.Parameters.AddWithValue("@p2", Saat);
                    komut.ExecuteNonQuery();
                    bg.Close();
                }
                catch (Exception hata)
                { MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message); }

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

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            GirisKontrol(txtBxKullaniciAdi.Text, txtBxSifre.Text);
        }

        private void txtBxSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                GirisKontrol(txtBxKullaniciAdi.Text, txtBxSifre.Text);
            }
        }

        private void txtBxKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                GirisKontrol(txtBxKullaniciAdi.Text, txtBxSifre.Text);
            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            string tarih = "";
            DateTime bugunkuTarih = DateTime.Now;
            tarih = bugunkuTarih.ToString("dd/MM/yyyy");

            SqlConnection bg = new SqlConnection(ConnectionString);
            int toplamOda = 0;
            bg.Open();
            SqlCommand cmd = new SqlCommand("select count(RoomId) as toplamOda from Rooms", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                toplamOda = (int)dr["toplamOda"];
            }
            bg.Close();

            ArrayList suresiDolanOdalar = new ArrayList();

            for (int i = 1; i <= toplamOda; i++)
            {
                bg.Open();
                cmd = new SqlCommand("select * from Rooms where RoomStatus='Dolu' and RoomId=" + i + "", bg);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DateTime musteriCikisTarihi;
                    musteriCikisTarihi = (DateTime)dr["CheckOut"];
                    if (tarih == musteriCikisTarihi.ToString("dd/MM/yyyy"))
                    {
                        suresiDolanOdalar.Add(i);
                    }
                }
                bg.Close();
            }

            foreach (var item in suresiDolanOdalar)
            {
                bg.Open();
                string kayit = "update Rooms set RoomStatus='Boş', ReservationId=0 where RoomId=" + item + "";
                SqlCommand komut = new SqlCommand(kayit, bg);
                komut.ExecuteNonQuery();
                bg.Close();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Hide();
        }
    }
}
