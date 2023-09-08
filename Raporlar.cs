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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog = KGMDb; Integrated Security = True";


        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Hide();
        }

        private void btnRezervasyonlar_Click(object sender, EventArgs e)
        {
            rezervasyonlar rezervasyonlar = new rezervasyonlar();
            rezervasyonlar.Show();
            this.Hide();
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            Odalar odalar = new Odalar();
            odalar.Show();
            this.Hide();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            string tarih1 = dateTarih1.Text.ToString();
            char ayrac = '.';
            string[] Tarih1 = tarih1.Split(ayrac);
            string yıl = Tarih1[2];
            string ay = Tarih1[1];
            string gun = Tarih1[0];
            string tarihİlk = yıl + "-" + ay + "-" + gun;

            string tarih2 = dateTarih2.Text.ToString();
            string[] Tarih2 = tarih2.Split(ayrac);
            string yıl2 = Tarih2[2];
            string ay2 = Tarih2[1];
            string gun2 = Tarih2[0];
            string tarihSon = yıl2 + "-" + ay2 + "-" + gun2;

            DateTime ilkTrh = DateTime.Now;
            DateTime sonTrh = DateTime.Now;

            lstViewRezervasyonlar.Items.Clear();
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select C.CustomerName as Ad, C.CustomerMail as Mail, C.CustomerPhone as Telefon, R.AdultCount as Yetiskin, R.ChildCount as Cocuk, R.RoomFloor as Kat, R.RoomNo as OdaNo, R.CheckIn as Giris, R.CheckOut as Cikis, R.Price as Fiyat, R.Status as Durum, R.RoomType as OdaTuru, C.CustomerType as MusteriTipi, R.ReservationId as Id from Reservations R inner join Customers C on R.CustomerId=C.CustomerId where (R.Status='Geçmiş' or R.Status='İptal Edildi') and R.CheckIn>='" + tarihİlk + "' and R.CheckOut<='" + tarihSon + "'", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem listele = new ListViewItem();
                listele.Text = (oku["Ad"].ToString());
                listele.SubItems.Add(oku["Kat"].ToString());
                listele.SubItems.Add(oku["OdaNo"].ToString());
                ilkTrh = (DateTime)oku["Giris"];
                sonTrh = (DateTime)oku["Cikis"];
                if (ilkTrh.ToString().Length == 19)
                    listele.SubItems.Add(oku["Giris"].ToString().Remove(10, 9));
                if (ilkTrh.ToString().Length == 18)
                    listele.SubItems.Add(oku["Giris"].ToString().Remove(9, 9));
                if (sonTrh.ToString().Length == 19)
                    listele.SubItems.Add(oku["Cikis"].ToString().Remove(10, 9));
                if (sonTrh.ToString().Length == 18)
                    listele.SubItems.Add(oku["Cikis"].ToString().Remove(9, 9));
                listele.SubItems.Add(oku["Fiyat"].ToString());
                listele.SubItems.Add(oku["Durum"].ToString());
                //listele.SubItems.Add(oku["OdaTuru"].ToString());
                //listele.SubItems.Add(oku["MusteriTipi"].ToString());
                listele.SubItems.Add(oku["Id"].ToString());
                lstViewRezervasyonlar.Items.Add(listele);
            }
            bg.Close();
        }

        private void btnKayitliMusteriler_Click(object sender, EventArgs e)
        {
            KayitliMusteriler kayitliMusteriler = new KayitliMusteriler();
            kayitliMusteriler.Show();
            this.Hide();
        }
    }
}
