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
using KGM_Misafirhane.Class;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace KGM_Misafirhane
{
    public partial class MailGönder : Form
    {
        public MailGönder()
        {
            InitializeComponent();
        }

        public static string ConnectionString = Class.vt.ConnectionString;


        private void MailGönder_Load(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from Customers where CustomerMail!=''", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                lstBxKayitliMusteriler.Items.Add((oku["CustomerName"].ToString()));
            }
            bg.Close();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            string email = "";
            string ad = "";
            for (int i = 0; i < lstBxKayitliMusteriler.CheckedItems.Count; i++)
            {
                ad = lstBxKayitliMusteriler.CheckedItems[i].ToString();

                bg.Open();
                SqlCommand cmd = new SqlCommand("select * from Customers where CustomerName='" + ad + "'", bg);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    email = (string)oku["CustomerMail"];
                }
                bg.Close();

                try
                {
                    string subject = "", fromEmail = "", password = "", SMTPServer = "";
                    int port = 0;
                    // E-posta bilgilerini doldurun
                    bg.Open();
                    cmd = new SqlCommand("select * from Mail where MailId=3", bg);
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

                    string body = txtBxMailMetni.Text;

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
        }

        private void btnTumunuSec_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstBxKayitliMusteriler.Items.Count; i++)
            {
                lstBxKayitliMusteriler.SetItemChecked(i, true);
            }
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSecimleriKaldir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstBxKayitliMusteriler.Items.Count; i++)
            {
                lstBxKayitliMusteriler.SetItemChecked(i, false);
            }
        }
    }
}
