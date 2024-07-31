using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace KGM_Misafirhane
{
    public partial class IptalNedeni : Form
    {
        public IptalNedeni()
        {
            InitializeComponent();
        }

        public static string ConnectionString = Class.vt.ConnectionString;
        public static bool odaSecildiMi = false;

        private void IptalNedeni_Load(object sender, EventArgs e)
        {
            string email = "";

            SqlConnection bg = new SqlConnection(ConnectionString);
            if (rezervasyonlar.onayBekleyen == true || rezervasyonlar.onaylanan == true)
            {
                bg.Open();
                SqlCommand cmd = new SqlCommand("select * from Customers where ReservationId=" + rezervasyonlar.BookingID + "", bg);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    email = (string)(oku["CustomerMail"]);
                }
                bg.Close();
                txtBxMusteriEpostası.Text = email;
            }

            if (Odalar.iptalEt == true)
            {
                txtBxMusteriEpostası.Text = Odalar.iptalEmail;
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection bg = new SqlConnection(ConnectionString);
                string subject = "";
                string fromEmail = "";
                string password = "";
                string SMTPServer = "";
                int port = 0;
                // E-posta bilgilerini doldurun
                bg.Open();
                SqlCommand komut = new SqlCommand("select * from Mail where MailId=1", bg);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    fromEmail = (string)oku["FromMail"];
                    subject = (string)oku["Subject"];
                    password = (string)oku["Password"];
                    SMTPServer = (string)oku["SMTPServer"];
                    port = (int)oku["Port"];
                }
                bg.Close();
                string toEmail = txtBxMusteriEpostası.Text;
                string body = txtBxIptalNedeni.Text;

                // SMTP sunucu ve kimlik bilgilerini ayarlayın
                SmtpClient smtpClient = new SmtpClient(SMTPServer);
                smtpClient.Port = port; // SMTP port numarası
                smtpClient.Credentials = new NetworkCredential(fromEmail, password);
                smtpClient.EnableSsl = true; // SSL kullanılsın mı?

                // E-posta oluştur
                MailMessage mail = new MailMessage(fromEmail, toEmail, subject, body);

                // E-postayı gönder
                smtpClient.Send(mail);

                MessageBox.Show("E-posta başarıyla gönderildi.");

                if (rezervasyonlar.onayBekleyen == true || rezervasyonlar.onaylanan == true)
                {
                    bg.Open();
                    komut = new SqlCommand("update Reservations set Status='İptal Edildi' where ReservationId=@p1", bg);
                    komut.Parameters.AddWithValue("@p1", rezervasyonlar.BookingID);
                    komut.ExecuteNonQuery();
                    bg.Close();
                }

                if (Odalar.iptalEt == true)
                {
                    bg.Open();
                    komut = new SqlCommand("update Reservations set Status='İptal Edildi' where Status='Oturmakta' and RoomFloor=" + Odalar.kat + " and RoomNo=" + Odalar.odaNo + "", bg);
                    komut.ExecuteNonQuery();
                    bg.Close();

                    bg.Open();
                    komut = new SqlCommand("update Rooms set RoomStatus='Boş', ReservationId=null where RoomFloor=" + Odalar.kat + " and RoomNo=" + Odalar.odaNo + "", bg);
                    komut.ExecuteNonQuery();
                    bg.Close();
                }

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("E-posta gönderilirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand komut = new SqlCommand("update Reservations set Status='İptal Edildi' where Status='Oturmakta' and RoomFloor=" + Odalar.kat + " and RoomNo=" + Odalar.odaNo + "", bg);
            komut.ExecuteNonQuery();
            bg.Close();

            bg.Open();
            komut = new SqlCommand("update Rooms set RoomStatus='Boş', ReservationId=null where RoomFloor=" + Odalar.kat + " and RoomNo=" + Odalar.odaNo + "", bg);
            komut.ExecuteNonQuery();
            bg.Close();

            this.Hide();
        }


        private void txtBxMusteriEpostası_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
