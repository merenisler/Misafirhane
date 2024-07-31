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

        public static string ConnectionString = Class.vt.ConnectionString;


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

            DateTime tarih1 = Convert.ToDateTime(dateTarih1.Text);
            DateTime tarih2 = Convert.ToDateTime(dateTarih2.Text);

            DateTime ilkTrh = DateTime.Now;
            DateTime sonTrh = DateTime.Now;

            lstViewRezervasyonlar.Items.Clear();
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select C.CustomerName as Ad, C.CustomerMail as Mail, C.CustomerPhone as Telefon, R.AdultCount as Yetiskin, R.ChildCount as Cocuk, R.RoomFloor as Kat, R.RoomNo as OdaNo, R.CheckIn as Giris, R.CheckOut as Cikis, R.Price as Fiyat, R.Status as Durum, R.RoomType as OdaTuru, C.CustomerType as MusteriTipi, R.ReservationId as Id from Reservations R inner join Customers C on R.CustomerId=C.CustomerId where (R.Status='Geçmiş' or R.Status='İptal Edildi') and R.CheckIn<='" + tarih2.ToString("yyyy/MM/dd") + "' and R.CheckIn>='" + tarih1.ToString("yyyy/MM/dd") + "'", bg);
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

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            if (lstViewRezervasyonlar.Items.Count!=0)
            {
                printPreviewYazdir.ShowDialog();
            }
            else
                MessageBox.Show("Tekrar Deneyiniz!");
        }
        private void Yazdir_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);

            DateTime tarih1 = Convert.ToDateTime(dateTarih1.Text);
            string tarihİlk = tarih1.ToString("dd/MM/yyyy");

            DateTime tarih2 = Convert.ToDateTime(dateTarih2.Text);
            string tarihSon = tarih2.ToString("dd/MM/yyyy");

            int adisyonAralik = 0, adisyonAralik2 = 0, aralik = 35, a = 0, b = 0;

            try
            {
                Font font = new Font("Arial", 14);
                SolidBrush firca = new SolidBrush(Color.Black);
                // Pen kalem = new Pen(Color.Black);
                e.Graphics.DrawString($"Tarih={DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}", font, firca, 50, 25);

                Font font2 = new Font("Arial", 15, FontStyle.Bold);
                Font font3 = new Font("Arial", 14);
                Font font4 = new Font("Arial", 16, FontStyle.Bold);
                Font cizgi = new Font("Arial", 12);
                e.Graphics.DrawString("Tarih Aralığı: ", font2, firca, 75, 75);
                e.Graphics.DrawString(tarihİlk + " / " + tarihSon, font3, firca, 210, 76);

                e.Graphics.DrawString("Müşteri Adı: ", font2, firca, 65, 130);
                e.Graphics.DrawString("Kat: ", font2, firca, 228, 130);
                e.Graphics.DrawString("Oda No: ", font2, firca, 300, 130);
                e.Graphics.DrawString("Giriş Tarihi: ", font2, firca, 415, 130);
                e.Graphics.DrawString("Çıkış Tarihi: ", font2, firca, 565, 130);
                e.Graphics.DrawString("Ücret: ", font2, firca, 715, 130);
                e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------", cizgi, firca, 50, 150);

                int gecmisToplam = 0;
                for (int i = 0; i < lstViewRezervasyonlar.Items.Count; i++)
                {
                    if (lstViewRezervasyonlar.Items[i].SubItems[6].Text=="Geçmiş")
                    {
                        if (i == 0)
                        {
                            e.Graphics.DrawString(lstViewRezervasyonlar.Items[i].SubItems[0].Text, font3, firca, 65, 170);
                            e.Graphics.DrawString(lstViewRezervasyonlar.Items[i].SubItems[1].Text, font3, firca, 240, 170);
                            e.Graphics.DrawString(lstViewRezervasyonlar.Items[i].SubItems[2].Text, font3, firca, 325, 170);
                            e.Graphics.DrawString(lstViewRezervasyonlar.Items[i].SubItems[3].Text, font3, firca, 415, 170);
                            e.Graphics.DrawString(lstViewRezervasyonlar.Items[i].SubItems[4].Text, font3, firca, 565, 170);
                            e.Graphics.DrawString(lstViewRezervasyonlar.Items[i].SubItems[5].Text, font3, firca, 715, 170);
                            gecmisToplam = gecmisToplam + Convert.ToInt32(lstViewRezervasyonlar.Items[i].SubItems[5].Text);
                        }
                        else
                        {
                            e.Graphics.DrawString(lstViewRezervasyonlar.Items[i].SubItems[0].Text, font3, firca, 65, (170 + (aralik * a)));
                            e.Graphics.DrawString(lstViewRezervasyonlar.Items[i].SubItems[1].Text, font3, firca, 240, (170 + (aralik * a)));
                            e.Graphics.DrawString(lstViewRezervasyonlar.Items[i].SubItems[2].Text, font3, firca, 325, (170 + (aralik * a)));
                            e.Graphics.DrawString(lstViewRezervasyonlar.Items[i].SubItems[3].Text, font3, firca, 415, (170 + (aralik * a)));
                            e.Graphics.DrawString(lstViewRezervasyonlar.Items[i].SubItems[4].Text, font3, firca, 565, (170 + (aralik * a)));
                            e.Graphics.DrawString(lstViewRezervasyonlar.Items[i].SubItems[5].Text, font3, firca, 715, (170 + (aralik * a)));
                            gecmisToplam = gecmisToplam + Convert.ToInt32(lstViewRezervasyonlar.Items[i].SubItems[5].Text);
                        }
                        a++;
                        adisyonAralik = 170 + (aralik * a);
                    }
                }
                e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------", cizgi, firca, 50, adisyonAralik-6);
                e.Graphics.DrawString("Toplam Ücret: " + gecmisToplam, font3, firca, 630, adisyonAralik+15);

                e.Graphics.DrawString("İptal Edilen Rezervasyonlar ", font4, firca, 70, adisyonAralik+55);

                e.Graphics.DrawString("Müşteri Adı: ", font2, firca, 65, adisyonAralik+90);
                e.Graphics.DrawString("Kat: ", font2, firca, 228, adisyonAralik + 90);
                e.Graphics.DrawString("Oda No: ", font2, firca, 300, adisyonAralik + 90);
                e.Graphics.DrawString("Giriş Tarihi: ", font2, firca, 415, adisyonAralik + 90);
                e.Graphics.DrawString("Çıkış Tarihi: ", font2, firca, 565, adisyonAralik + 90);
                e.Graphics.DrawString("Ücret: ", font2, firca, 715, adisyonAralik + 90);
                e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------", cizgi, firca, 50, adisyonAralik + 110);

                int iptalToplam = 0;
                for (int i = 0; i < lstViewRezervasyonlar.Items.Count; i++)
                {
                    if (lstViewRezervasyonlar.Items[i].SubItems[6].Text == "İptal Edildi")
                    {
                        if (i == 0)
                        {
                            e.Graphics.DrawString(lstViewRezervasyonlar.Items[i].SubItems[0].Text, font3, firca, 65, adisyonAralik + 130);
                            e.Graphics.DrawString(lstViewRezervasyonlar.Items[i].SubItems[1].Text, font3, firca, 240, adisyonAralik + 130);
                            e.Graphics.DrawString(lstViewRezervasyonlar.Items[i].SubItems[2].Text, font3, firca, 325, adisyonAralik + 130);
                            e.Graphics.DrawString(lstViewRezervasyonlar.Items[i].SubItems[3].Text, font3, firca, 415, adisyonAralik + 130);
                            e.Graphics.DrawString(lstViewRezervasyonlar.Items[i].SubItems[4].Text, font3, firca, 565, adisyonAralik + 130);
                            e.Graphics.DrawString(lstViewRezervasyonlar.Items[i].SubItems[5].Text, font3, firca, 715, adisyonAralik + 130);
                            iptalToplam = iptalToplam + Convert.ToInt32(lstViewRezervasyonlar.Items[i].SubItems[5].Text);
                        }
                        else
                        {
                            e.Graphics.DrawString(lstViewRezervasyonlar.Items[i].SubItems[0].Text, font3, firca, 65, ((adisyonAralik + 130) + (aralik * b)));
                            e.Graphics.DrawString(lstViewRezervasyonlar.Items[i].SubItems[1].Text, font3, firca, 240, ((adisyonAralik + 130) + (aralik * b)));
                            e.Graphics.DrawString(lstViewRezervasyonlar.Items[i].SubItems[2].Text, font3, firca, 325, ((adisyonAralik + 130) + (aralik * b)));
                            e.Graphics.DrawString(lstViewRezervasyonlar.Items[i].SubItems[3].Text, font3, firca, 415, ((adisyonAralik + 130) + (aralik * b)));
                            e.Graphics.DrawString(lstViewRezervasyonlar.Items[i].SubItems[4].Text, font3, firca, 565, ((adisyonAralik + 130) + (aralik * b)));
                            e.Graphics.DrawString(lstViewRezervasyonlar.Items[i].SubItems[5].Text, font3, firca, 715, ((adisyonAralik + 130) + (aralik * b)));
                            iptalToplam = iptalToplam + Convert.ToInt32(lstViewRezervasyonlar.Items[i].SubItems[5].Text);
                        }
                        b++;
                        adisyonAralik2 = (adisyonAralik + 130) + (aralik * b);
                    }
                }
                e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------", cizgi, firca, 50, adisyonAralik2 - 6);
                e.Graphics.DrawString("Toplam Ücret: " + iptalToplam, font3, firca, 630, adisyonAralik2 + 15);

            }
            catch (Exception) { }
        }
    }
}
