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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace KGM_Misafirhane
{
    public partial class YeniRezervasyon : Form
    {
        public YeniRezervasyon()
        {
            InitializeComponent();
        }

        public static string ConnectionString = Class.vt.ConnectionString;

        public static int fiyat = 0;
        public static string tarihGiris = "", tarihCikis = "";


        private void btnOnayla_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);

            string adSoyad = "", telefon = "", mail = "", odaTuru = "", musteriTipi = "";
            int ucret = 0, kat = 0, odaNo = 0, yetiskinSayisi = 0, cocukSayisi = 0;
            DateTime girisTarihi = DateTime.Now, cikisTarihi = DateTime.Now;

            if (txtBxAdSoyad.Text != "" && txtBxTelefon.Text != "" && txtBxUcret.Text != "" && cmbBxKat.Text != "" && cmbBxOdaNo.Text != "" && dateTimeGiris.Text != "" && dateTimeCikis.Text != "" && cmbBxYetiskinSayisi.Text != "" && cmbBxCocukSayisi.Text != "" && cmbBxMusteriTipi.Text != "" && cmbBxOdaTuru.Text != "")
            {
                adSoyad = txtBxAdSoyad.Text;
                telefon = txtBxTelefon.Text;
                mail = txtBxEmail.Text;
                ucret = Convert.ToInt32(txtBxUcret.Text);
                kat = Convert.ToInt32(cmbBxKat.Text);
                odaNo = Convert.ToInt32(cmbBxOdaNo.Text);
                odaTuru = cmbBxOdaTuru.Text;
                girisTarihi = Convert.ToDateTime(dateTimeGiris.Text);
                cikisTarihi = Convert.ToDateTime(dateTimeCikis.Text);
                yetiskinSayisi = Convert.ToInt32(cmbBxYetiskinSayisi.Text);
                cocukSayisi = Convert.ToInt32(cmbBxCocukSayisi.Text);
                musteriTipi = cmbBxMusteriTipi.Text;

                string tarihİlk = girisTarihi.ToString("yyyy/MM/dd");

                string tarihSon = cikisTarihi.ToString("yyyy/MM/dd");

                string bugunTarih = "";
                string saatB = "";
                // Bugünkü tarihi al
                DateTime bugunkuTarih = DateTime.Now;
                // Bugünkü tarihi görüntüle
                bugunTarih = bugunkuTarih.ToString("yyyy/MM/dd");

                // Şu anki saati al
                DateTime suAnkiSaat = DateTime.Now;
                // Şu anki saati görüntüle
                saatB = suAnkiSaat.ToString("HH:mm:ss");

                int rezervasyonAdet = 0;
                bg.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("select count(*) as rezervasyonAdet from Reservations", bg);
                    SqlDataReader oku = cmd.ExecuteReader();
                    while (oku.Read())
                    {
                        rezervasyonAdet = (int)oku["rezervasyonAdet"];
                    }
                }
                catch (Exception) { }
                bg.Close();

                if (rezervasyonAdet == 0)
                    rezervasyonAdet = 1;
                else
                    rezervasyonAdet = rezervasyonAdet + 1;

                bg.Open();
                string kayit = "insert into Customers(CustomerType, CustomerName, CustomerMail, CustomerPhone, ReservationId) values (@p1, @p2, @p3, @p4, @p5)";
                SqlCommand komut = new SqlCommand(kayit, bg);
                komut.Parameters.AddWithValue("@p1", musteriTipi);
                komut.Parameters.AddWithValue("@p2", adSoyad);
                komut.Parameters.AddWithValue("@p3", mail);
                komut.Parameters.AddWithValue("@p4", telefon);
                komut.Parameters.AddWithValue("@p5", rezervasyonAdet);
                komut.ExecuteNonQuery();
                bg.Close();

                bg.Open();
                kayit = "insert into Reservations(CustomerId, RoomFloor, RoomNo, AdultCount, ChildCount, CheckIn, CheckOut, Status, Price, RoomType, ReservationCreationDate, ReservationCreationTime) values ((SELECT TOP 1 CustomerId FROM Customers ORDER BY CustomerId DESC), @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12)";
                komut = new SqlCommand(kayit, bg);
                komut.Parameters.AddWithValue("@p2", kat);
                komut.Parameters.AddWithValue("@p3", odaNo);
                komut.Parameters.AddWithValue("@p4", yetiskinSayisi);
                komut.Parameters.AddWithValue("@p5", cocukSayisi);
                komut.Parameters.AddWithValue("@p6", tarihİlk);
                komut.Parameters.AddWithValue("@p7", tarihSon);
                komut.Parameters.AddWithValue("@p8", "Onay Bekliyor");
                komut.Parameters.AddWithValue("@p9", ucret);
                komut.Parameters.AddWithValue("@p10", odaTuru);
                komut.Parameters.AddWithValue("@p11", bugunTarih);
                komut.Parameters.AddWithValue("@p12", saatB);
                komut.ExecuteNonQuery();
                bg.Close();

                this.Hide();

            }
            else
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!");
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (cmbBxOdaTuru.Text != "" && dateTimeGiris.Text != "" && dateTimeCikis.Text != "" && cmbBxMusteriTipi.Text != "")
            {
                DateTime girisTarihi = Convert.ToDateTime(dateTimeGiris.Text);
                string tarihİlk = girisTarihi.ToString("yyyy/MM/dd");

                DateTime cikisTarihi = Convert.ToDateTime(dateTimeCikis.Text);
                string tarihSon = cikisTarihi.ToString("yyyy/MM/dd");

                // İlk tarih
                DateTime startDate = dateTimeGiris.Value;
                // İkinci tarih
                DateTime endDate = dateTimeCikis.Value;
                // İki tarih arasındaki farkı hesapla
                TimeSpan difference = endDate - startDate;
                int gunFarkı = Convert.ToInt32(difference.TotalDays);

                int gunlukFiyat = 0;
                SqlConnection bg = new SqlConnection(ConnectionString);
                bg.Open();
                SqlCommand cmd = new SqlCommand("select * from RoomType where TypeName='" + cmbBxOdaTuru.Text + "'", bg);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    gunlukFiyat = (int)oku["TypePrice"];
                }
                bg.Close();

                int fiyatFarkı = 0;
                bg.Open();
                cmd = new SqlCommand("select * from CustomerType where CustomerType='" + cmbBxMusteriTipi.Text + "'", bg);
                oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    fiyatFarkı = (int)oku["AdditionalPrice"];
                }
                bg.Close();

                gunlukFiyat += fiyatFarkı;

                int ucret = gunlukFiyat * gunFarkı;

                txtBxUcret.Text = ucret.ToString();

                fiyat = ucret;
            }
            else
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!");
        }


        private void YeniRezervasyon_Load(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from RoomType", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                cmbBxOdaTuru.Items.Add(oku["TypeName"]);
            }
            bg.Close();
            if (KayitliMusteriler.kayitliMusteriler==true)
            {
                string email = "";
                string telefon = "";
                string musteriTipi = "";

                bg.Open();
                cmd = new SqlCommand("select DISTINCT CustomerName, * from Customers where CustomerId=" + KayitliMusteriler.customerId + "", bg);
                oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    email = (string)oku["CustomerMail"];
                    telefon = (string)oku["CustomerPhone"];
                    musteriTipi = (string)oku["CustomerType"];
                }
                bg.Close();

                txtBxAdSoyad.Text = KayitliMusteriler.adSoyad;
                txtBxEmail.Text = KayitliMusteriler.Email;
                txtBxTelefon.Text = KayitliMusteriler.Telefon;
                cmbBxMusteriTipi.Text = KayitliMusteriler.MusteriTipi;
            }
        }
        private void cmbBxOdaTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBxKat.Items.Clear();
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select RoomFloor from Rooms where RoomTypeId in(select RoomTypeId from RoomType where TypeName='" + cmbBxOdaTuru.Text + "') GROUP BY RoomFloor HAVING COUNT(*) > 1;", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                cmbBxKat.Items.Add(oku["RoomFloor"].ToString());
            }
            bg.Close();

        }
        private void cmbBxKat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBxOdaNo.Items.Clear();
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select RoomNo from Rooms where RoomStatus='Boş' and RoomFloor=" + Convert.ToInt32(cmbBxKat.Text) + " and RoomTypeId in(select RoomTypeId from RoomType where TypeName='" + cmbBxOdaTuru.Text + "')", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                cmbBxOdaNo.Items.Add(oku["RoomNo"].ToString());
            }
            bg.Close();

        }


        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void txtBxTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBxTelefon.Text.Length >= 11)
            {
                e.Handled = true;
                if (e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back)
                    e.Handled = false;
            }
            else
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void txtBxUcret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void cmbBxYetiskinSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void cmbBxCocukSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void cmbBxOdaSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void cmbBxKat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void cmbBxOdaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void cmbBxOdaTuru_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void dateTimeGiris_ValueChanged(object sender, EventArgs e)
        {
            tarihGiris = dateTimeGiris.Text;
        }
        private void dateTimeCikis_ValueChanged(object sender, EventArgs e)
        {
            tarihCikis = dateTimeCikis.Text;
        }
    }
}
