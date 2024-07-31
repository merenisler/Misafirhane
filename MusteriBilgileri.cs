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
    public partial class MusteriBilgileri : Form
    {
        public MusteriBilgileri()
        {
            InitializeComponent();
        }

        public static string ConnectionString = Class.vt.ConnectionString;
        public static string GadSoyad = "";
        public static string Gmail = "";
        public static string GtelefonNo = "";
        public static int Gkat = 0;
        public static int GodaNo = 0;

        private void MusteriBilgileri_Load(object sender, EventArgs e)
        {
            string adSoyad = "";
            string mail = "";
            string telefonNo = "";
            string odaTuru = "";

            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select C.CustomerName as Name, C.CustomerMail as Mail, C.CustomerPhone as Phone, R.RoomType as RoomType from Customers C inner join Reservations R on C.ReservationId=R.CustomerId where R.Status='Oturmakta' and R.RoomFloor=" + Odalar.kat + " and R.RoomNo=" + Odalar.odaNo + "", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                adSoyad = (string)oku["Name"];
                mail = (string)oku["Mail"];
                telefonNo = (string)oku["Phone"];
                odaTuru = (string)oku["RoomType"];
            }
            bg.Close();

            txtBxSoyad.Text = adSoyad;
            txtBxEmail.Text = mail;
            txtBxTelefon.Text = telefonNo;
            cmbBxOdaTuru.Text = odaTuru;
            cmbBxKat.Text = Odalar.kat.ToString();
            cmbBxOdaNo.Text = Odalar.odaNo.ToString();

            bg.Open();
            cmd = new SqlCommand("select TypeName from RoomType", bg);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                cmbBxOdaTuru.Items.Add((string)oku["TypeName"]);
            }
            bg.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int kat2 = Convert.ToInt32(cmbBxKat.Text);
            int odaNo2 = Convert.ToInt32(cmbBxOdaNo.Text);
            SqlConnection bg = new SqlConnection(ConnectionString);
            if (Odalar.kat != kat2 || Odalar.odaNo != odaNo2)
            {
                bg.Open();
                SqlCommand komut = new SqlCommand("UPDATE Reservations SET RoomFloor=" + kat2 + ", RoomNo=" + odaNo2 + " WHERE RoomFloor=" + Odalar.kat + " and RoomNo=" + Odalar.odaNo + " and Status='Oturmakta'", bg);
                komut.ExecuteNonQuery();
                bg.Close();

                bg.Open();
                komut = new SqlCommand("UPDATE Rooms SET RoomStatus='Boş', ReservationId=null WHERE RoomFloor=" + Odalar.kat + " and RoomNo=" + Odalar.odaNo + "", bg);
                komut.ExecuteNonQuery();
                bg.Close();

                bg.Open();
                komut = new SqlCommand("UPDATE Rooms SET RoomStatus='Dolu', ReservationId=(select ReservationId from Reservations where RoomFloor=" + kat2 + " and RoomNo=" + odaNo2 + " and Status='Oturmakta') WHERE RoomFloor=" + kat2 + " and RoomNo=" + odaNo2 + "", bg);
                komut.ExecuteNonQuery();
                bg.Close();

                bg.Open();
                komut = new SqlCommand("UPDATE Customers SET CustomerName='" + txtBxSoyad.Text + "', CustomerMail='" + txtBxEmail.Text + "', CustomerPhone='" + txtBxTelefon.Text + "' WHERE ReservationId in(select ReservationId from Reservations where RoomFloor=" + kat2 + " and RoomNo=" + odaNo2 + " and Status='Oturmakta')", bg);
                komut.ExecuteNonQuery();
                bg.Close();
            }
            else
            {
                bg.Open();
                SqlCommand komut2 = new SqlCommand("UPDATE Customers SET CustomerName='" + txtBxSoyad.Text + "', CustomerMail='" + txtBxEmail.Text + "', CustomerPhone='" + txtBxTelefon.Text + "' WHERE ReservationId in(select ReservationId from Reservations where RoomFloor=" + kat2 + " and RoomNo=" + odaNo2 + " and Status='Oturmakta')", bg);
                komut2.ExecuteNonQuery();
                bg.Close();
            }

            GadSoyad = txtBxSoyad.Text;
            Gmail = txtBxEmail.Text;
            GtelefonNo = txtBxTelefon.Text;

            this.Hide();
        }

        private void cmbBxKat_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            cmbBxOdaNo.Items.Clear();
            bg.Open();
            SqlCommand cmd = new SqlCommand("select R.RoomNo as RoomNo from Rooms R inner join RoomType T on R.RoomTypeId=T.RoomTypeId where R.RoomFloor=" + Convert.ToInt32(cmbBxKat.Text) + " and R.RoomStatus='Boş' and T.TypeName='" + cmbBxOdaTuru.Text + "'", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                cmbBxOdaNo.Items.Add((int)oku["RoomNo"]);
            }
            bg.Close();
        }
        private void cmbBxOdaTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            cmbBxKat.Items.Clear();
            bg.Open();
            SqlCommand cmd = new SqlCommand("select R.RoomFloor, count(R.RoomFloor) from Rooms R inner join RoomType T on R.RoomTypeId=T.RoomTypeId where T.TypeName='" + cmbBxOdaTuru.Text + "' Group By R.RoomFloor HAVING COUNT(R.RoomFloor) > 1", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                cmbBxKat.Items.Add((int)oku["RoomFloor"]);
            }
            bg.Close();
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
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
