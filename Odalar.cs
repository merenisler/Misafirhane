using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace KGM_Misafirhane
{
    public partial class Odalar : Form
    {
        public Odalar()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog = KGMDb; Integrated Security = True";
        public static int kat = 0;
        public static int odaNo = 0;
        public static bool odaSecildiMi = false;

        public static string adSoyad = "";
        public static string email = "";
        public static string telefon = "";
        public static int katG = 0;
        public static int odaNoG = 0;
        public static string yetiskinSayisi = "";
        public static string cocukSayisi = "";
        public static int odaSayisi = 0;
        public static int fiyat = 0;
        public static DateTime GirisTarih = DateTime.Now;
        public static DateTime CikisTarih = DateTime.Now;
        public static string odaTuru = "";
        public static bool iptalEt = false;

        public static string odaDoluMu = "";

        public static string iptalEmail = "";


        private void btnTumOdalar_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            lstViewMusteriBilgileri.Items.Clear();
            lstViewOdalar.Items.Clear();
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from Rooms", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem listele = new ListViewItem();
                listele.Text = (oku["RoomFloor"].ToString());
                listele.SubItems.Add(oku["RoomNo"].ToString());
                listele.SubItems.Add(oku["RoomStatus"].ToString());
                lstViewOdalar.Items.Add(listele);
            }
            bg.Close();
            odaSecildiMi = false;
            odaDoluMu = "Boş";
        }

        private void btnBosOdalar_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            lstViewMusteriBilgileri.Items.Clear();
            lstViewOdalar.Items.Clear();
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from Rooms where RoomStatus='Boş'", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem listele = new ListViewItem();
                listele.Text = (oku["RoomFloor"].ToString());
                listele.SubItems.Add(oku["RoomNo"].ToString());
                listele.SubItems.Add(oku["RoomStatus"].ToString());
                lstViewOdalar.Items.Add(listele);
            }
            bg.Close();
            odaSecildiMi = false;
            odaDoluMu = "Boş";
        }

        private void btnDoluOdalar_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            lstViewOdalar.Items.Clear();
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from Rooms where RoomStatus='Dolu'", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem listele = new ListViewItem();
                listele.Text = (oku["RoomFloor"].ToString());
                listele.SubItems.Add(oku["RoomNo"].ToString());
                listele.SubItems.Add(oku["RoomStatus"].ToString());
                lstViewOdalar.Items.Add(listele);
            }
            bg.Close();
            odaDoluMu = "Dolu";
            odaSecildiMi = true;
        }

        private void lstViewOdalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string items = "";
            if (lstViewOdalar.SelectedItems.Count == 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    items = lstViewOdalar.SelectedItems[0].SubItems[i].Text.ToString();

                    if (i == 0)
                        kat = Convert.ToInt32(items);
                    if (i == 1)
                        odaNo = Convert.ToInt32(items);
                    if (i == 2)
                        odaDoluMu = items;
                }
            }

            if (odaDoluMu == "Dolu")
                odaSecildiMi = true;
            if (odaDoluMu == "Boş")
                odaSecildiMi = false;

            SqlConnection bg = new SqlConnection(ConnectionString);
            lstViewMusteriBilgileri.Items.Clear();
            List<string> columnNames = GetColumnNames("Reservations");
            foreach (string columnName in columnNames)
            {
                if (columnName == "CustomerId")
                    goto Devam;
                if (columnName == "ReservationCreationDate")
                    goto Devam;
                if (columnName == "ReservationCreationTime")
                    goto Devam;

                string musteriBilgileri = "";
                ListViewItem listele = new ListViewItem();
                listele.Text = columnName;
                bg.Open();
                SqlCommand cmd = new SqlCommand("select * from Reservations where ReservationId=(select ReservationId from Rooms where RoomFloor=" + kat + " and RoomNo=" + odaNo + ") and Status='Oturmakta'", bg);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    musteriBilgileri = (string)dr[columnName].ToString();
                }
                bg.Close();
                listele.SubItems.Add(musteriBilgileri.ToString());
                lstViewMusteriBilgileri.Items.Add(listele);
            Devam:
                int a = 0;
            }
            List<string> columnNames2 = GetColumnNames("Customers");
            foreach (string columnName in columnNames2)
            {
                if (columnName == "CustomerId")
                    goto Devam;
                if (columnName == "ReservationId")
                    goto Devam;

                string musteriBilgileri = "";
                ListViewItem listele = new ListViewItem();
                listele.Text = columnName;
                bg.Open();
                SqlCommand cmd = new SqlCommand("select C.CustomerType as CustomerType, C.CustomerName as CustomerName, C.CustomerMail as CustomerMail, C.CustomerPhone as CustomerPhone from Customers C inner join Reservations R on R.CustomerId=C.CustomerId where R.Status='Oturmakta' and R.ReservationId=(select ReservationId from Rooms where RoomFloor=" + kat + " and RoomNo=" + odaNo + ")", bg);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    musteriBilgileri = (string)dr[columnName].ToString();
                }
                bg.Close();
                listele.SubItems.Add(musteriBilgileri.ToString());
                lstViewMusteriBilgileri.Items.Add(listele);
            Devam:
                int a = 0;
            }

            if (odaDoluMu=="Dolu")
            {
                cmbBxOde.Text = odaNo.ToString();
                cmbBxIptaEt.Text = odaNo.ToString();
                cmbBxMusteriBilgileri.Text = odaNo.ToString();
            }

        }

        static List<string> GetColumnNames(string tableName)
        {
            List<string> columnNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = $"SELECT * FROM {tableName} WHERE 1 = 0";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable schemaTable = new DataTable();
                    adapter.FillSchema(schemaTable, SchemaType.Source);

                    foreach (DataColumn column in schemaTable.Columns)
                    {
                        string columnName = column.ColumnName;
                        columnNames.Add(columnName);
                    }
                }
            }
            return columnNames;
        }

        private void btnSureyiUzalt_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);

            if (odaSecildiMi == true)
            {
                if (cmbxSüreyiUzat.Text != "")
                {
                    string süreyiUzalt = cmbxSüreyiUzat.Text;
                    if (süreyiUzalt == "1 Gün")
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("UPDATE Reservations SET CheckOut = DATEADD(DAY, 1, CheckOut) WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    if (süreyiUzalt == "2 Gün")
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("UPDATE Reservations SET CheckOut = DATEADD(DAY, 2, CheckOut) WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    if (süreyiUzalt == "3 Gün")
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("UPDATE Reservations SET CheckOut = DATEADD(DAY, 3, CheckOut) WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    if (süreyiUzalt == "4 Gün")
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("UPDATE Reservations SET CheckOut = DATEADD(DAY, 4, CheckOut) WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    if (süreyiUzalt == "5 Gün")
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("UPDATE Reservations SET CheckOut = DATEADD(DAY, 5, CheckOut) WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    if (süreyiUzalt == "6 Gün")
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("UPDATE Reservations SET CheckOut = DATEADD(DAY, 6, CheckOut) WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    if (süreyiUzalt == "1 Hafta")
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("UPDATE Reservations SET CheckOut = DATEADD(WEEK, 1, CheckOut) WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    if (süreyiUzalt == "2 Hafta")
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("UPDATE Reservations SET CheckOut = DATEADD(WEEK, 2, CheckOut) WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    if (süreyiUzalt == "3 Hafta")
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("UPDATE Reservations SET CheckOut = DATEADD(WEEK, 3, CheckOut) WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    if (süreyiUzalt == "1 Ay")
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("UPDATE Reservations SET CheckOut = DATEADD(MONTH, 1, CheckOut) WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    if (süreyiUzalt == "2 Ay")
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("UPDATE Reservations SET CheckOut = DATEADD(MONTH, 2, CheckOut) WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    if (süreyiUzalt == "3 Ay")
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("UPDATE Reservations SET CheckOut = DATEADD(MONTH, 3, CheckOut) WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }

                    cmbxSüreyiUzat.Text = "";

                    DateTime Checkhin = new DateTime();
                    DateTime CheckOut = new DateTime();
                    string odaTuru = "";
                    string musteriTipi = "";
                    bg.Open();
                    SqlCommand cmd2 = new SqlCommand("select R.CheckIn as CheckIn, R.CheckOut as CheckOut, R.RoomType, C.CustomerType as CustomerType from Reservations R inner join Customers C on R.CustomerId=C.ReservationId where R.Status='Oturmakta' and R.RoomFloor=" + kat + " and R.RoomNo=" + odaNo + "", bg);
                    SqlDataReader oku = cmd2.ExecuteReader();
                    while (oku.Read())
                    {
                        Checkhin = (DateTime)oku["CheckIn"];
                        CheckOut = (DateTime)oku["CheckOut"];
                        odaTuru = (string)oku["RoomType"];
                        musteriTipi = (string)oku["CustomerType"];
                    }
                    bg.Close();

                    int gunlukOdaUcreti = 0;
                    bg.Open();
                    cmd2 = new SqlCommand("select * from RoomType where TypeName='" + odaTuru + "'", bg);
                    oku = cmd2.ExecuteReader();
                    while (oku.Read())
                    {
                        gunlukOdaUcreti = (int)oku["TypePrice"];
                    }
                    bg.Close();

                    int ekFiyat = 0;
                    bg.Open();
                    cmd2 = new SqlCommand("select * from CustomerType where CustomerType='" + musteriTipi + "'", bg);
                    oku = cmd2.ExecuteReader();
                    while (oku.Read())
                    {
                        ekFiyat = (int)oku["AdditionalPrice"];
                    }
                    bg.Close();

                    gunlukOdaUcreti += ekFiyat;

                    int guncelUcret = 0;
                    TimeSpan timeSpan = CheckOut - Checkhin;
                    int daysBetween = (int)timeSpan.TotalDays;
                    guncelUcret = daysBetween * gunlukOdaUcreti;

                    bg.Open();
                    string kayit2 = "update Reservations set Price=" + guncelUcret + " WHERE Status='Oturmakta' and RoomFloor=" + kat + " and RoomNo=" + odaNo + "";
                    SqlCommand komut2 = new SqlCommand(kayit2, bg);
                    komut2.ExecuteNonQuery();
                    bg.Close();

                    lstViewMusteriBilgileri.Items.Clear();
                    List<string> columnNames = GetColumnNames("Reservations");
                    foreach (string columnName in columnNames)
                    {
                        if (columnName == "CustomerId")
                            goto Devam;
                        if (columnName == "ReservationCreationDate")
                            goto Devam;
                        if (columnName == "ReservationCreationTime")
                            goto Devam;


                        string musteriBilgileri = "";
                        ListViewItem listele = new ListViewItem();
                        listele.Text = columnName;
                        bg.Open();
                        SqlCommand cmd = new SqlCommand("select * from Reservations where Status='Oturmakta' and RoomFloor=" + kat + " and RoomNo=" + odaNo + "", bg);
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            musteriBilgileri = (string)dr[columnName].ToString();
                        }
                        bg.Close();
                        listele.SubItems.Add(musteriBilgileri.ToString());
                        lstViewMusteriBilgileri.Items.Add(listele);
                    Devam:
                        int a = 0;
                    }
                    List<string> columnNames2 = GetColumnNames("Customers");
                    foreach (string columnName in columnNames2)
                    {
                        if (columnName == "CustomerId")
                            goto Devam;
                        if (columnName == "ReservationId")
                            goto Devam;

                        string musteriBilgileri = "";
                        ListViewItem listele = new ListViewItem();
                        listele.Text = columnName;
                        bg.Open();
                        SqlCommand cmd = new SqlCommand("select C.CustomerType as CustomerType, C.CustomerName as CustomerName, C.CustomerMail as CustomerMail, C.CustomerPhone as CustomerPhone from Customers C inner join Reservations R on R.CustomerId=C.CustomerId where R.ReservationId=(select ReservationId from Rooms where RoomFloor=" + kat + " and RoomNo=" + odaNo + ")", bg);
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            musteriBilgileri = (string)dr[columnName].ToString();
                        }
                        bg.Close();
                        listele.SubItems.Add(musteriBilgileri.ToString());
                        lstViewMusteriBilgileri.Items.Add(listele);
                    Devam:
                        int a = 0;
                    }
                }
                else
                    MessageBox.Show("Lütfen Süre Seçimi Yapınız!");
            }
            else
                MessageBox.Show("Lütfen Dolu Oda Seçimi Yapınız!");
        }

        private void btnSureyiAzalt_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            if (odaSecildiMi == true)
            {
                if (cmbxSüreyiAzalt.Text != "")
                {
                    string süreyiUzalt = cmbxSüreyiAzalt.Text;
                    if (süreyiUzalt == "1 Gün")
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("UPDATE Reservations SET CheckOut = DATEADD(DAY, -1, CheckOut) WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    if (süreyiUzalt == "2 Gün")
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("UPDATE Reservations SET CheckOut = DATEADD(DAY, -2, CheckOut) WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    if (süreyiUzalt == "3 Gün")
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("UPDATE Reservations SET CheckOut = DATEADD(DAY, -3, CheckOut) WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    if (süreyiUzalt == "4 Gün")
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("UPDATE Reservations SET CheckOut = DATEADD(DAY, -4, CheckOut) WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    if (süreyiUzalt == "5 Gün")
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("UPDATE Reservations SET CheckOut = DATEADD(DAY, -5, CheckOut) WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    if (süreyiUzalt == "6 Gün")
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("UPDATE Reservations SET CheckOut = DATEADD(DAY, -6, CheckOut) WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    if (süreyiUzalt == "1 Hafta")
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("UPDATE Reservations SET CheckOut = DATEADD(WEEK, -1, CheckOut) WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    if (süreyiUzalt == "2 Hafta")
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("UPDATE Reservations SET CheckOut = DATEADD(WEEK, -2, CheckOut) WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    if (süreyiUzalt == "3 Hafta")
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("UPDATE Reservations SET CheckOut = DATEADD(WEEK, -3, CheckOut) WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    if (süreyiUzalt == "1 Ay")
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("UPDATE Reservations SET CheckOut = DATEADD(MONTH, -1, CheckOut) WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    if (süreyiUzalt == "2 Ay")
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("UPDATE Reservations SET CheckOut = DATEADD(MONTH, -1, CheckOut) WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    if (süreyiUzalt == "3 Ay")
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("UPDATE Reservations SET CheckOut = DATEADD(MONTH, -1, CheckOut) WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "", bg);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }

                    cmbxSüreyiAzalt.Text = "";

                    DateTime Checkhin = new DateTime();
                    DateTime CheckOut = new DateTime();
                    string odaTuru = "";
                    string musteriTipi = "";
                    bg.Open();
                    SqlCommand cmd2 = new SqlCommand("select R.CheckIn as CheckIn, R.CheckOut as CheckOut, R.RoomType, C.CustomerType as CustomerType from Reservations R inner join Customers C on R.CustomerId=C.ReservationId where R.Status='Oturmakta' and R.RoomFloor=" + kat + " and R.RoomNo=" + odaNo + "", bg);
                    SqlDataReader oku = cmd2.ExecuteReader();
                    while (oku.Read())
                    {
                        Checkhin = (DateTime)oku["CheckIn"];
                        CheckOut = (DateTime)oku["CheckOut"];
                        odaTuru = (string)oku["RoomType"];
                        musteriTipi = (string)oku["CustomerType"];
                    }
                    bg.Close();

                    int gunlukOdaUcreti = 0;
                    bg.Open();
                    cmd2 = new SqlCommand("select * from RoomType where TypeName='" + odaTuru + "'", bg);
                    oku = cmd2.ExecuteReader();
                    while (oku.Read())
                    {
                        gunlukOdaUcreti = (int)oku["TypePrice"];
                    }
                    bg.Close();

                    int ekFiyat = 0;
                    bg.Open();
                    cmd2 = new SqlCommand("select * from CustomerType where CustomerType='" + musteriTipi + "'", bg);
                    oku = cmd2.ExecuteReader();
                    while (oku.Read())
                    {
                        ekFiyat = (int)oku["AdditionalPrice"];
                    }
                    bg.Close();

                    gunlukOdaUcreti += ekFiyat;

                    TimeSpan timeSpan = CheckOut - Checkhin;
                    int daysBetween = (int)timeSpan.TotalDays;
                    int guncelUcret = daysBetween * gunlukOdaUcreti;

                    bg.Open();
                    string kayit2 = "update Reservations set Price=" + guncelUcret + " WHERE Status='Oturmakta' and RoomFloor = " + kat + " and RoomNo = " + odaNo + "";
                    SqlCommand komut2 = new SqlCommand(kayit2, bg);
                    komut2.ExecuteNonQuery();
                    bg.Close();

                    lstViewMusteriBilgileri.Items.Clear();
                    List<string> columnNames = GetColumnNames("Reservations");
                    foreach (string columnName in columnNames)
                    {
                        if (columnName == "CustomerId")
                            goto Devam;
                        if (columnName == "ReservationCreationDate")
                            goto Devam;
                        if (columnName == "ReservationCreationTime")
                            goto Devam;

                        string musteriBilgileri = "";
                        ListViewItem listele = new ListViewItem();
                        listele.Text = columnName;
                        bg.Open();
                        SqlCommand cmd = new SqlCommand("select * from Reservations where Status='Oturmakta' and RoomFloor=" + kat + " and RoomNo=" + odaNo + "", bg);
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            musteriBilgileri = (string)dr[columnName].ToString();
                        }
                        bg.Close();
                        listele.SubItems.Add(musteriBilgileri.ToString());
                        lstViewMusteriBilgileri.Items.Add(listele);
                    Devam:
                        int a = 0;
                    }
                    List<string> columnNames2 = GetColumnNames("Customers");
                    foreach (string columnName in columnNames2)
                    {
                        if (columnName == "CustomerId")
                            goto Devam;
                        if (columnName == "ReservationId")
                            goto Devam;

                        string musteriBilgileri = "";
                        ListViewItem listele = new ListViewItem();
                        listele.Text = columnName;
                        bg.Open();
                        SqlCommand cmd = new SqlCommand("select C.CustomerType as CustomerType, C.CustomerName as CustomerName, C.CustomerMail as CustomerMail, C.CustomerPhone as CustomerPhone from Customers C inner join Reservations R on R.CustomerId=C.CustomerId where R.ReservationId=(select ReservationId from Rooms where RoomFloor=" + kat + " and RoomNo=" + odaNo + ")", bg);
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            musteriBilgileri = (string)dr[columnName].ToString();
                        }
                        bg.Close();
                        listele.SubItems.Add(musteriBilgileri.ToString());
                        lstViewMusteriBilgileri.Items.Add(listele);
                    Devam:
                        int a = 0;
                    }
                }
                else
                    MessageBox.Show("Lütfen Süre Seçimi Yapınız!");
            }
            else
                MessageBox.Show("Lütfen Dolu Oda Seçimi Yapınız!");
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            string girisTarihi = "";
            string cikisTarihi = "";
            int ucret = 0;
            string email = "";
            string adSoyad = "";
            bg.Open();
            SqlCommand cmd = new SqlCommand("select R.CheckIn as CheckIn, R.CheckOut as CheckOut, R.Price as Price, C.CustomerMail as Mail, C.CustomerName as Name from Reservations R inner join Customers C on R.CustomerId=C.ReservationId where Status='Oturmakta' and RoomFloor=" + kat + " and RoomNo=" + odaNo + "", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                girisTarihi = (string)(oku["CheckIn"]).ToString();
                cikisTarihi = (string)(oku["CheckOut"]).ToString();
                ucret = (int)oku["Price"];
                email = (string)oku["Mail"];
                adSoyad = (string)oku["Name"];
            }
            bg.Close();
            if (odaSecildiMi == true)
            {
                DialogResult dialogResult = MessageBox.Show(odaNo + " Oda Numaralı Müşterinin Ücreti " + ucret + "TLdir Ödemek İstiyor Musunuz?", "Ödeme İşlemi", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (email != "")
                    {
                        if (girisTarihi.Length == 19)
                            girisTarihi = girisTarihi.Remove(10, 9);
                        if (girisTarihi.ToString().Length == 18)
                            girisTarihi = girisTarihi.Remove(9, 9);

                        if (cikisTarihi.Length == 19)
                            cikisTarihi = cikisTarihi.Remove(10, 9);
                        if (cikisTarihi.ToString().Length == 18)
                            cikisTarihi = cikisTarihi.Remove(9, 9);
                        try
                        {
                            string subject = "";
                            string fromEmail = "";
                            string password = "";
                            string SMTPServer = "";
                            int port = 0;
                            // E-posta bilgilerini doldurun
                            bg.Open();
                            cmd = new SqlCommand("select * from Mail where MailId=2", bg);
                            oku = cmd.ExecuteReader();
                            while (oku.Read())
                            {
                                fromEmail = (string)oku["FromMail"];
                                subject = (string)oku["Subject"];
                                password = (string)oku["Password"];
                                SMTPServer = (string)oku["SMTPServer"];
                                port = (int)oku["Port"];
                            }
                            bg.Close();

                            string body = "Sayın " + adSoyad + ", " + girisTarihi + " - " + cikisTarihi + " Tarihleri Arasında Sizleri Misafirhanemizde Misafir Etmekten Mutluluk Duyduk Tekrar Görüşmek Üzere İyi Günler:)";

                            // SMTP sunucu ve kimlik bilgilerini ayarlayın
                            SmtpClient smtpClient = new SmtpClient(SMTPServer);
                            smtpClient.Port = port; // SMTP port numarası
                            smtpClient.Credentials = new NetworkCredential(fromEmail, password);
                            smtpClient.EnableSsl = true; // SSL kullanılsın mı?

                            // E-posta oluştur
                            MailMessage mail = new MailMessage(fromEmail, email, subject, body);

                            // E-postayı gönder
                            smtpClient.Send(mail);

                            MessageBox.Show("E-posta Başarıyla Gönderildi.");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("E-posta Gönderilemedi.");
                        }
                    }

                    bg.Open();
                    SqlCommand komut = new SqlCommand("update Reservations set Status='Geçmiş' where Status='Oturmakta' and RoomFloor=" + kat + " and RoomNo=" + odaNo + "", bg);
                    komut.ExecuteNonQuery();
                    bg.Close();

                    bg.Open();
                    komut = new SqlCommand("update Rooms set RoomStatus='Boş' where RoomFloor=" + kat + " and RoomNo=" + odaNo + "", bg);
                    komut.ExecuteNonQuery();
                    bg.Close();

                    lstViewOdalar.Items.Clear();
                    bg.Open();
                    cmd = new SqlCommand("select * from Rooms where RoomStatus='Dolu'", bg);
                    oku = cmd.ExecuteReader();
                    while (oku.Read())
                    {
                        ListViewItem listele = new ListViewItem();
                        listele.Text = (oku["RoomFloor"].ToString());
                        listele.SubItems.Add(oku["RoomNo"].ToString());
                        listele.SubItems.Add(oku["RoomStatus"].ToString());
                        lstViewOdalar.Items.Add(listele);
                    }
                    bg.Close();
                    lstViewMusteriBilgileri.Items.Clear();
                }
            }
            else
                MessageBox.Show("Lütfen Oda Seçiniz!");
        }

        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            if (odaSecildiMi==true)
            {
                SqlConnection bg = new SqlConnection(ConnectionString);
                int ucret = 0;
                string mail = "";
                bg.Open();
                SqlCommand cmd = new SqlCommand("select R.Price as Price, C.CustomerMail as Mail from Reservations R inner join Customers C on R.CustomerId=C.ReservationId where Status='Oturmakta' and RoomFloor=" + kat + " and RoomNo=" + odaNo + "", bg);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    ucret = (int)oku["Price"];
                    mail = (string)oku["Mail"];
                }
                bg.Close();

                iptalEmail = mail;

                DialogResult dialogResult = MessageBox.Show(odaNo + " Oda Numaralı Müşterinin Ücreti " + ucret + "TLdir İptal Etmek İstiyor Musunuz?", "İptal İşlemi", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //if (mail == "")
                    //{
                    //    bg.Open();
                    //    SqlCommand komut = new SqlCommand("update Reservations set Status='İptal Edildi' where Status='Oturmakta' and RoomFloor=" + kat + " and RoomNo=" + odaNo + "", bg);
                    //    komut.ExecuteNonQuery();
                    //    bg.Close();

                    //    bg.Open();
                    //    komut = new SqlCommand("update Rooms set RoomStatus='Boş', ReservationId=null where RoomFloor=" + kat + " and RoomNo=" + odaNo + "", bg);
                    //    komut.ExecuteNonQuery();
                    //    bg.Close();
                    //}
                        IptalNedeni ıptalNedeni = new IptalNedeni();
                        ıptalNedeni.Show();
                }
            }
            else
                MessageBox.Show("Lütfen Dolu Oda Seçimi Yapınız!!!");
        }

        public void lstViewGuncelle(ListView lstView)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            lstView.Items.Clear();
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from Rooms where RoomStatus='Dolu'", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem listele = new ListViewItem();
                listele.Text = (oku["RoomFloor"].ToString());
                listele.SubItems.Add(oku["RoomNo"].ToString());
                listele.SubItems.Add(oku["RoomStatus"].ToString());
                lstView.Items.Add(listele);
            }
            bg.Close();
        }
        //private void Timer1_Tick(object sender, EventArgs e)
        //{
        //    SqlConnection bg = new SqlConnection(ConnectionString);

        //    if (odaSecildiMi == true)
        //    {
        //        string adSoyad2 = "";
        //        string email2 = "";
        //        string telefon2 = "";
        //        bg.Open();
        //        SqlCommand cmd = new SqlCommand("select * from Customers where ReservationId in(select CustomerId from Reservations where RoomNo=" + odaNo + " and Status='Oturmakta')", bg);
        //        SqlDataReader oku = cmd.ExecuteReader();
        //        while (oku.Read())
        //        {
        //            adSoyad2 = (string)(oku["CustomerName"]);
        //            email2 = (string)(oku["CustomerMail"]);
        //            telefon2 = (string)(oku["CustomerPhone"]);
        //        }
        //        bg.Close();

        //        if (adSoyad != adSoyad2 || email != email2 || telefon != telefon2)
        //        {
        //            lstViewMusteriBilgileri.Items.Clear();
        //            List<string> columnNames = GetColumnNames("Reservations");
        //            foreach (string columnName in columnNames)
        //            {
        //                if (columnName == "CustomerId")
        //                    goto Devam;
        //                if (columnName == "ReservationCreationDate")
        //                    goto Devam;
        //                if (columnName == "ReservationCreationTime")
        //                    goto Devam;


        //                string musteriBilgileri = "";
        //                ListViewItem listele = new ListViewItem();
        //                listele.Text = columnName;
        //                bg.Open();
        //                cmd = new SqlCommand("select * from Reservations where Status='Oturmakta' and RoomFloor=" + kat + " and RoomNo=" + odaNo + "", bg);
        //                SqlDataReader dr = cmd.ExecuteReader();
        //                while (dr.Read())
        //                {
        //                    musteriBilgileri = (string)dr[columnName].ToString();
        //                }
        //                bg.Close();
        //                listele.SubItems.Add(musteriBilgileri.ToString());
        //                lstViewMusteriBilgileri.Items.Add(listele);
        //            Devam:
        //                int a = 0;
        //            }
        //            List<string> columnNames2 = GetColumnNames("Customers");
        //            foreach (string columnName in columnNames2)
        //            {
        //                if (columnName == "CustomerId")
        //                    goto Devam;
        //                if (columnName == "ReservationId")
        //                    goto Devam;

        //                string musteriBilgileri = "";
        //                ListViewItem listele = new ListViewItem();
        //                listele.Text = columnName;
        //                bg.Open();
        //                cmd = new SqlCommand("select C.CustomerType as CustomerType, C.CustomerName as CustomerName, C.CustomerMail as CustomerMail, C.CustomerPhone as CustomerPhone from Customers C inner join Reservations R on C.ReservationId=R.CustomerId", bg);
        //                SqlDataReader dr = cmd.ExecuteReader();
        //                while (dr.Read())
        //                {
        //                    musteriBilgileri = (string)dr[columnName].ToString();
        //                }
        //                bg.Close();
        //                listele.SubItems.Add(musteriBilgileri.ToString());
        //                lstViewMusteriBilgileri.Items.Add(listele);
        //            Devam:
        //                int a = 0;
        //            }
        //        }

        //        lstViewOdalar.FullRowSelect = true;

        //        string odaDoluMu2 = "";
        //        bg.Open();
        //        cmd = new SqlCommand("select * from Rooms where RoomNo=" + odaNo + "", bg);
        //        oku = cmd.ExecuteReader();
        //        while (oku.Read())
        //        {
        //            odaDoluMu2 = (string)(oku["RoomStatus"]);
        //        }
        //        bg.Close();
        //        if (odaDoluMu != odaDoluMu2)
        //        {
        //            lstViewOdalar.Items.Clear();
        //            bg.Open();
        //            cmd = new SqlCommand("select * from Rooms where RoomStatus='Dolu'", bg);
        //            oku = cmd.ExecuteReader();
        //            while (oku.Read())
        //            {
        //                ListViewItem listele = new ListViewItem();
        //                listele.Text = (oku["RoomFloor"].ToString());
        //                listele.SubItems.Add(oku["RoomNo"].ToString());
        //                listele.SubItems.Add(oku["RoomStatus"].ToString());
        //                lstViewOdalar.Items.Add(listele);
        //            }
        //            bg.Close();


        //        }
        //    }
        //}

        private void Odalar_Load_1(object sender, EventArgs e)
        {
            Timer1.Interval = 1000;

            Timer1.Enabled = true;
            Timer1.Start();

            iptalEt = true;

        }
        private void cmbxSüreyiUzat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void cmbxSüreyiAzalt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void cmbBxOde_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void cmbBxIptaEt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void cmbBxMusteriBilgileri_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
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
        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            Raporlar raporlar = new Raporlar();
            raporlar.Show();
            this.Hide();
        }
        private void btnMusteriBilgileri_Click(object sender, EventArgs e)
        {
            if (odaSecildiMi==true)
            {
                MusteriBilgileri musteriBilgileri = new MusteriBilgileri();
                musteriBilgileri.Show();
            }
            else
                MessageBox.Show("Lütfen Dolu Oda Seçimi Yapınız!!!");
        }
        private void btnKayitliMusteriler_Click(object sender, EventArgs e)
        {
            KayitliMusteriler kayitliMusteriler = new KayitliMusteriler();
            kayitliMusteriler.Show();
            this.Hide();
        }
    }
}
