using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace KGM_Misafirhane
{
    public partial class rezervasyonlar : Form
    {
        public rezervasyonlar()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog = KGMDb; Integrated Security = True";
        public static bool onayBekleyen = false;
        public static bool onaylanan = false;
        public static bool gecmis = false;
        public static bool rezervasyonSecildiMi = false;

        public static string adSoyad = "";
        public static string email = "";
        public static string telefon = "";
        public static int kat = 0;
        public static int odaNo = 0;
        public static string yetiskinSayisi = "";
        public static string cocukSayisi = "";
        public static int odaSayisi = 0;
        public static int fiyat = 0;
        public static string girisTarihi = "";
        public static string cikisTarihi = "";
        public static string odaTuru = "";
        public static string durum = "";
        public static string musteriTipi = "";

        public static int BookingID = 0;


        private void Rezervasyonlar_Load(object sender, EventArgs e)
        {
            Timer1.Interval = 1000;
            Timer1.Enabled = true;
            Timer1.Start();

            lstViewRezervasyonlar.Items.Clear();
            DateTime ilkTrh = DateTime.Now;
            DateTime sonTrh = DateTime.Now;

            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select C.CustomerName as Ad, C.CustomerMail as Mail, C.CustomerPhone as Telefon, R.AdultCount as Yetiskin, R.ChildCount as Cocuk, R.RoomFloor as Kat, R.RoomNo as OdaNo, R.CheckIn as Giris, R.CheckOut as Cikis, R.Price as Fiyat, R.Status as Durum, R.ReservationId as Id from Reservations R inner join Customers C on R.CustomerId=C.CustomerId where R.Status='Onay Bekliyor' or R.Status='Beklemede'", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem listele = new ListViewItem();
                listele.Text = (oku["Ad"].ToString());
                listele.SubItems.Add(oku["Mail"].ToString());
                listele.SubItems.Add(oku["Telefon"].ToString());
                listele.SubItems.Add(oku["Yetiskin"].ToString());
                listele.SubItems.Add(oku["Cocuk"].ToString());
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
                listele.SubItems.Add(oku["Id"].ToString());
                lstViewRezervasyonlar.Items.Add(listele);
            }
            bg.Close();
            onayBekleyen = true;
            onaylanan = false;
            gecmis = false;
        }

        private void btnOnayBekleyen_Click(object sender, EventArgs e)
        {
            btnOnayBekleyen.BackColor = Color.DarkOrange;
            btnOnayBekleyen.FlatAppearance.BorderSize = 1;
            btnOnaylanan.BackColor = Color.DarkSeaGreen;
            btnOnaylanan.FlatAppearance.BorderSize = 0;
            btnGecmis.BackColor = Color.DarkSeaGreen;
            btnGecmis.FlatAppearance.BorderSize = 0;
            lstViewRezervasyonlar.Items.Clear();
            DateTime ilkTrh = DateTime.Now;
            DateTime sonTrh = DateTime.Now;

            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select C.CustomerName as Ad, C.CustomerMail as Mail, C.CustomerPhone as Telefon, R.AdultCount as Yetiskin, R.ChildCount as Cocuk, R.RoomFloor as Kat, R.RoomNo as OdaNo, R.CheckIn as Giris, R.CheckOut as Cikis, R.Price as Fiyat, R.Status as Durum, R.ReservationId as Id from Reservations R inner join Customers C on R.CustomerId=C.CustomerId where R.Status='Onay Bekliyor' or R.Status='Beklemede'", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem listele = new ListViewItem();
                listele.Text = (oku["Ad"].ToString());
                listele.SubItems.Add(oku["Mail"].ToString());
                listele.SubItems.Add(oku["Telefon"].ToString());
                listele.SubItems.Add(oku["Yetiskin"].ToString());
                listele.SubItems.Add(oku["Cocuk"].ToString());
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
                listele.SubItems.Add(oku["Id"].ToString());
                lstViewRezervasyonlar.Items.Add(listele);
            }
            bg.Close();

            onayBekleyen = true;
            onaylanan = false;
            gecmis = false;
        }

        private void btnOnaylanan_Click(object sender, EventArgs e)
        {
            btnOnaylanan.BackColor = Color.DarkOrange;
            btnOnaylanan.FlatAppearance.BorderSize = 1;
            btnOnayBekleyen.BackColor = Color.DarkSeaGreen;
            btnOnayBekleyen.FlatAppearance.BorderSize = 0;
            btnGecmis.BackColor = Color.DarkSeaGreen;
            btnGecmis.FlatAppearance.BorderSize = 0;
            lstViewRezervasyonlar.Items.Clear();
            DateTime ilkTrh = DateTime.Now;
            DateTime sonTrh = DateTime.Now;

            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select C.CustomerName as Ad, C.CustomerMail as Mail, C.CustomerPhone as Telefon, R.AdultCount as Yetiskin, R.ChildCount as Cocuk, R.RoomFloor as Kat, R.RoomNo as OdaNo, R.CheckIn as Giris, R.CheckOut as Cikis, R.Price as Fiyat, R.Status as Durum, R.ReservationId as Id from Reservations R inner join Customers C on R.CustomerId=C.CustomerId where R.Status='Onaylanan' or R.Status='Oturmakta'", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem listele = new ListViewItem();
                listele.Text = (oku["Ad"].ToString());
                listele.SubItems.Add(oku["Mail"].ToString());
                listele.SubItems.Add(oku["Telefon"].ToString());
                listele.SubItems.Add(oku["Yetiskin"].ToString());
                listele.SubItems.Add(oku["Cocuk"].ToString());
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
                listele.SubItems.Add(oku["Id"].ToString());
                lstViewRezervasyonlar.Items.Add(listele);
            }
            bg.Close();
            onayBekleyen = false;
            onaylanan = true;
            gecmis = false;
        }

        private void btnGecmis_Click(object sender, EventArgs e)
        {
            btnGecmis.BackColor = Color.DarkOrange;
            btnGecmis.FlatAppearance.BorderSize = 1;
            btnOnaylanan.BackColor = Color.DarkSeaGreen;
            btnOnaylanan.FlatAppearance.BorderSize = 0;
            btnOnayBekleyen.BackColor = Color.DarkSeaGreen;
            btnOnayBekleyen.FlatAppearance.BorderSize = 0;
            lstViewRezervasyonlar.Items.Clear();
            DateTime ilkTrh = DateTime.Now;
            DateTime sonTrh = DateTime.Now;

            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select C.CustomerName as Ad, C.CustomerMail as Mail, C.CustomerPhone as Telefon, R.AdultCount as Yetiskin, R.ChildCount as Cocuk, R.RoomFloor as Kat, R.RoomNo as OdaNo, R.CheckIn as Giris, R.CheckOut as Cikis, R.Price as Fiyat, R.Status as Durum, R.ReservationId as Id from Reservations R inner join Customers C on R.CustomerId=C.CustomerId where R.Status='Geçmiş' or R.Status='İptal Edildi'", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem listele = new ListViewItem();
                listele.Text = (oku["Ad"].ToString());
                listele.SubItems.Add(oku["Mail"].ToString());
                listele.SubItems.Add(oku["Telefon"].ToString());
                listele.SubItems.Add(oku["Yetiskin"].ToString());
                listele.SubItems.Add(oku["Cocuk"].ToString());
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
                listele.SubItems.Add(oku["Id"].ToString());
                lstViewRezervasyonlar.Items.Add(listele);
            }
            bg.Close();
            onayBekleyen = false;
            onaylanan = false;
            gecmis = true;
        }

        private void lstViewRezervasyonlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gecmis == false)
            {
                rezervasyonSecildiMi = true;

                string items = "";
                if (lstViewRezervasyonlar.SelectedItems.Count == 1)
                {
                    for (int i = 0; i <= 11; i++)
                    {
                        items = lstViewRezervasyonlar.SelectedItems[0].SubItems[i].Text.ToString();

                        if (i == 0)
                            adSoyad = items;
                        if (i == 1)
                            email = items;
                        if (i == 2)
                            telefon = items;
                        if (i == 3)
                            yetiskinSayisi = items;
                        if (i == 4)
                            cocukSayisi = items;
                        if (i == 5)
                            kat = Convert.ToInt32(items);
                        if (i == 6)
                            odaNo = Convert.ToInt32(items);
                        if (i == 7)
                            girisTarihi = items;
                        if (i == 8)
                            cikisTarihi = items;
                        if (i == 9)
                            fiyat = Convert.ToInt32(items);
                        if (i == 10)
                            durum = items;
                        if (i == 11)
                            BookingID = Convert.ToInt32(items);
                    }
                }
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            if (onayBekleyen == true)
            {
                if (rezervasyonSecildiMi == true)
                {
                    string doluMu = "";
                    bg.Open();
                    SqlCommand cmd = new SqlCommand("select * from Rooms where RoomFloor=" + kat + " and RoomNo=" + odaNo + "", bg);
                    SqlDataReader oku = cmd.ExecuteReader();
                    while (oku.Read())
                    {
                        doluMu = (string)oku["RoomStatus"];
                    }
                    bg.Close();

                    if (doluMu == "Dolu")
                    {
                        if (girisTarihi.Length == 19)
                            girisTarihi = girisTarihi.Remove(10, 9);
                        if (girisTarihi.ToString().Length == 18)
                            girisTarihi = girisTarihi.Remove(9, 9);

                        if (cikisTarihi.Length == 19)
                            cikisTarihi = cikisTarihi.Remove(10, 9);
                        if (cikisTarihi.ToString().Length == 18)
                            cikisTarihi = cikisTarihi.Remove(9, 9);
                        char ayrac = '.';
                        string[] Tarih1 = girisTarihi.Split(ayrac);
                        string yıl = Tarih1[2];
                        string ay = Tarih1[1];
                        string gun = Tarih1[0];
                        string tarihİlk = yıl + "-" + ay + "-" + gun;

                        char ayrac2 = '.';
                        string[] Tarih2 = cikisTarihi.Split(ayrac2);
                        string yıl2 = Tarih2[2];
                        string ay2 = Tarih2[1];
                        string gun2 = Tarih2[0];
                        string tarihSon = yıl2 + "-" + ay2 + "-" + gun2;

                        int rezervasyonVarMı = 0;
                        bg.Open();
                        SqlCommand komut = new SqlCommand("select count(*) as rezervasyonVarMı from Rooms where RoomFloor=@p1 and RoomNo=@p2 and CheckOut<@p3 and RoomStatus='Dolu'", bg);
                        komut.Parameters.AddWithValue("@p1", kat);
                        komut.Parameters.AddWithValue("@p2", odaNo);
                        komut.Parameters.AddWithValue("@p3", tarihİlk);
                        oku = komut.ExecuteReader();
                        while (oku.Read())
                        {
                            rezervasyonVarMı = (int)oku["rezervasyonVarMı"];
                        }
                        bg.Close();

                        if (rezervasyonVarMı == 1)
                        {
                            DialogResult dialogResult = MessageBox.Show("Onaylamak İstediğinize Emin Misiniz?", "Uyarı!", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                bg.Open();
                                komut = new SqlCommand("update Reservations set Status='Onaylanan' where ReservationId=@p1", bg);
                                komut.Parameters.AddWithValue("@p1", BookingID);
                                komut.ExecuteNonQuery();
                                bg.Close();
                            }
                        }
                        else
                            MessageBox.Show("Oda Dolu!");
                    }
                    else if (doluMu == "Boş")
                    {
                        if (girisTarihi.Length == 19)
                            girisTarihi = girisTarihi.Remove(10, 9);
                        if (girisTarihi.ToString().Length == 18)
                            girisTarihi = girisTarihi.Remove(9, 9);

                        if (cikisTarihi.Length == 19)
                            cikisTarihi = cikisTarihi.Remove(10, 9);
                        if (cikisTarihi.ToString().Length == 18)
                            cikisTarihi = cikisTarihi.Remove(9, 9);
                        char ayrac = '.';
                        string[] Tarih1 = girisTarihi.Split(ayrac);
                        string yıl = Tarih1[2];
                        string ay = Tarih1[1];
                        string gun = Tarih1[0];
                        string tarihİlk = yıl + "-" + ay + "-" + gun;

                        char ayrac2 = '.';
                        string[] Tarih2 = cikisTarihi.Split(ayrac2);
                        string yıl2 = Tarih2[2];
                        string ay2 = Tarih2[1];
                        string gun2 = Tarih2[0];
                        string tarihSon = yıl2 + "-" + ay2 + "-" + gun2;

                        DialogResult dialogResult = MessageBox.Show("Onaylamak İstediğinize Emin Misiniz?", "Uyarı!", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            bg.Open();
                            SqlCommand komut = new SqlCommand("update Reservations set Status='Onaylanan' where ReservationId=@p1", bg);
                            komut.Parameters.AddWithValue("@p1", BookingID);
                            komut.ExecuteNonQuery();
                            bg.Close();


                            DateTime bugununTarihi = DateTime.Now;
                            string tarihMetni = bugununTarihi.ToShortDateString();

                            if (girisTarihi == tarihMetni)
                            {
                                bg.Open();
                                komut = new SqlCommand("update Rooms set CheckIn=@p1, CheckOut=@p2, RoomStatus=@p3, ReservationId=@p6 where RoomFloor=@p4 and RoomNo=@p5", bg);
                                komut.Parameters.AddWithValue("@p1", tarihİlk);
                                komut.Parameters.AddWithValue("@p2", tarihSon);
                                komut.Parameters.AddWithValue("@p3", "Dolu");
                                komut.Parameters.AddWithValue("@p4", kat);
                                komut.Parameters.AddWithValue("@p5", odaNo);
                                komut.Parameters.AddWithValue("@p6", BookingID);
                                komut.ExecuteNonQuery();
                                bg.Close();

                                bg.Open();
                                komut = new SqlCommand("update Reservations set Status='Oturmakta' where ReservationId=@p1", bg);
                                komut.Parameters.AddWithValue("@p1", BookingID);
                                komut.ExecuteNonQuery();
                                bg.Close();
                            }

                        }
                    }
                }
                else
                    MessageBox.Show("Lütfen Herhangi Bir Rezervasyonu Seçiniz!");
            }
            else
                MessageBox.Show("Onay Bekleyen Sayfası Hariç Onaylama İşlemi Yapamazsınız!");
        }

        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);

            if (onayBekleyen == true)
            {
                if (rezervasyonSecildiMi == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Onaylamak İstediğinize Emin Misiniz?", "Uyarı!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (email != "")
                        {
                            IptalNedeni ıptalNedeni = new IptalNedeni();
                            ıptalNedeni.Show();
                        }
                        else
                        {
                            bg.Open();
                            SqlCommand komut = new SqlCommand("update Reservations set Status='İptal Edildi' where ReservationId=@p1", bg);
                            komut.Parameters.AddWithValue("@p1", BookingID);
                            komut.ExecuteNonQuery();
                            bg.Close();
                        }
                    }
                }
                else
                    MessageBox.Show("Lütfen Herhangi Bir Rezervasyonu Seçiniz!");
            }
            if (onaylanan == true)
            {
                if (rezervasyonSecildiMi == true)
                {
                    if (durum == "Oturmakta")
                        MessageBox.Show("İptal Etmek İstediğiniz Rezervasyonun Oturma Süresi Başladığı İçin Bu Sayfadan İptal Edemezsiniz");
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Onaylamak İstediğinize Emin Misiniz?", "Uyarı!", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (email != "")
                            {
                                IptalNedeni ıptalNedeni = new IptalNedeni();
                                ıptalNedeni.Show();
                            }
                            else
                            {
                                bg.Open();
                                SqlCommand komut = new SqlCommand("update Reservations set Status='İptal Edildi' where ReservationId=@p1", bg);
                                komut.Parameters.AddWithValue("@p1", BookingID);
                                komut.ExecuteNonQuery();
                                bg.Close();
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Lütfen Herhangi Bir Rezervasyonu Seçiniz!");
            }
        }

        private void btnBeklet_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            if (onayBekleyen == true)
            {
                if (rezervasyonSecildiMi == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Bekletmek İstediğinize Emin Misiniz?", "Uyarı!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("update Reservations set Status='Beklemede' where ReservationId=" + BookingID + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                }
                else
                    MessageBox.Show("Lütfen Herhangi Bir Rezervasyonu Seçiniz!");
            }
            else
                MessageBox.Show("Onay Bekleyen Sayfası Hariç Bekletme İşlemi Yapamazsınız!");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            int rezervasyonAdet1 = 0;
            int rezervasyonAdet2 = 0;
            int rezervasyonAdet3 = 0;
            bg.Open();
            SqlCommand cmd = new SqlCommand("select Count(ReservationId) as rezervasyonAdet from Reservations where Status='Onay Bekliyor'", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                rezervasyonAdet1 = (int)oku["rezervasyonAdet"];
            }
            bg.Close();
            bg.Open();
            cmd = new SqlCommand("select Count(ReservationId) as rezervasyonAdet from Reservations where Status='Onaylanan' or Status='Oturmakta'", bg);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                rezervasyonAdet2 = (int)oku["rezervasyonAdet"];
            }
            bg.Close();
            bg.Open();
            cmd = new SqlCommand("select Count(ReservationId) as rezervasyonAdet from Reservations where Status='Geçmiş' or Status='İptal Edildi'", bg);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                rezervasyonAdet3 = (int)oku["rezervasyonAdet"];
            }
            bg.Close();
            if (onayBekleyen == true)
            {
                if (rezervasyonAdet1 != lstViewRezervasyonlar.Items.Count)
                {
                    lstViewRezervasyonlar.Items.Clear();
                    DateTime ilkTrh = DateTime.Now;
                    DateTime sonTrh = DateTime.Now;

                    bg.Open();
                    cmd = new SqlCommand("select C.CustomerName as Ad, C.CustomerMail as Mail, C.CustomerPhone as Telefon, R.AdultCount as Yetiskin, R.ChildCount as Cocuk, R.RoomFloor as Kat, R.RoomNo as OdaNo, R.CheckIn as Giris, R.CheckOut as Cikis, R.Price as Fiyat, R.Status as Durum, R.ReservationId as Id from Reservations R inner join Customers C on R.CustomerId=C.CustomerId where R.Status='Onay Bekliyor' or R.Status='Beklemede'", bg);
                    oku = cmd.ExecuteReader();
                    while (oku.Read())
                    {
                        ListViewItem listele = new ListViewItem();
                        listele.Text = (oku["Ad"].ToString());
                        listele.SubItems.Add(oku["Mail"].ToString());
                        listele.SubItems.Add(oku["Telefon"].ToString());
                        listele.SubItems.Add(oku["Yetiskin"].ToString());
                        listele.SubItems.Add(oku["Cocuk"].ToString());
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
                        listele.SubItems.Add(oku["Id"].ToString());
                        lstViewRezervasyonlar.Items.Add(listele);
                    }
                    bg.Close();
                }
            }
            if (onaylanan == true)
            {
                if (rezervasyonAdet2 != lstViewRezervasyonlar.Items.Count)
                {
                    lstViewRezervasyonlar.Items.Clear();
                    DateTime ilkTrh = DateTime.Now;
                    DateTime sonTrh = DateTime.Now;

                    bg.Open();
                    cmd = new SqlCommand("select C.CustomerName as Ad, C.CustomerMail as Mail, C.CustomerPhone as Telefon, R.AdultCount as Yetiskin, R.ChildCount as Cocuk, R.RoomFloor as Kat, R.RoomNo as OdaNo, R.CheckIn as Giris, R.CheckOut as Cikis, R.Price as Fiyat, R.Status as Durum, R.ReservationId as Id from Reservations R inner join Customers C on R.CustomerId=C.CustomerId where R.Status='Onaylanan' or R.Status='Oturmakta'", bg);
                    oku = cmd.ExecuteReader();
                    while (oku.Read())
                    {
                        ListViewItem listele = new ListViewItem();
                        listele.Text = (oku["Ad"].ToString());
                        listele.SubItems.Add(oku["Mail"].ToString());
                        listele.SubItems.Add(oku["Telefon"].ToString());
                        listele.SubItems.Add(oku["Yetiskin"].ToString());
                        listele.SubItems.Add(oku["Cocuk"].ToString());
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
                        listele.SubItems.Add(oku["Id"].ToString());
                        lstViewRezervasyonlar.Items.Add(listele);
                    }
                    bg.Close();
                }
            }
            if (gecmis == true)
            {
                if (rezervasyonAdet3 != lstViewRezervasyonlar.Items.Count)
                {
                    lstViewRezervasyonlar.Items.Clear();
                    DateTime ilkTrh = DateTime.Now;
                    DateTime sonTrh = DateTime.Now;

                    bg.Open();
                    cmd = new SqlCommand("select C.CustomerName as Ad, C.CustomerMail as Mail, C.CustomerPhone as Telefon, R.AdultCount as Yetiskin, R.ChildCount as Cocuk, R.RoomFloor as Kat, R.RoomNo as OdaNo, R.CheckIn as Giris, R.CheckOut as Cikis, R.Price as Fiyat, R.Status as Durum, R.ReservationId as Id from Reservations R inner join Customers C on R.CustomerId=C.CustomerId where R.Status='Geçmiş' or R.Status='İptal Edildi'", bg);
                    oku = cmd.ExecuteReader();
                    while (oku.Read())
                    {
                        ListViewItem listele = new ListViewItem();
                        listele.Text = (oku["Ad"].ToString());
                        listele.SubItems.Add(oku["Mail"].ToString());
                        listele.SubItems.Add(oku["Telefon"].ToString());
                        listele.SubItems.Add(oku["Yetiskin"].ToString());
                        listele.SubItems.Add(oku["Cocuk"].ToString());
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
                        listele.SubItems.Add(oku["Id"].ToString());
                        lstViewRezervasyonlar.Items.Add(listele);
                    }
                    bg.Close();
                }
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Hide();
        }
        private void btnOdalar_Click(object sender, EventArgs e)
        {
            Odalar odalar = new Odalar();
            odalar.Show();
            this.Hide();
        }
        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            Raporlar raporlar = new Raporlar();
            raporlar.Show();
            this.Hide();
        }
        private void btnYeniRezervasyon_Click(object sender, EventArgs e)
        {
            YeniRezervasyon yeniRezervasyon = new YeniRezervasyon();
            yeniRezervasyon.Show();
        }
        private void btnKayitliMusteriler_Click(object sender, EventArgs e)
        {
            KayitliMusteriler kayitliMusteriler = new KayitliMusteriler();
            kayitliMusteriler.Show();
            this.Hide();
        }
    }
}
