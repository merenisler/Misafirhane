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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KGM_Misafirhane
{
    public partial class KayitliMusteriler : Form
    {
        public KayitliMusteriler()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog = KGMDb; Integrated Security = True";
        public static string adSoyad = "";
        public static int customerId = 0;
        public static bool kayitliMusteriler = false;

        private void KayitliMusteriler_Load(object sender, EventArgs e)
        {
            kayitliMusteriler = true;
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select DISTINCT CustomerName, CustomerId from Customers;", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem listele = new ListViewItem();
                listele.Text = (string)oku["CustomerName"];
                listele.SubItems.Add(((int)oku["CustomerId"]).ToString());
                lstViewAd.Items.Add(listele);
            }
            bg.Close();

            bg.Open();
            cmd = new SqlCommand("select CustomerType from CustomerType;", bg);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                cmbBxMusteriTipi.Items.Add((string)oku["CustomerType"]);
            }
            bg.Close();
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

        private void lstViewOdalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string items = "";
            if (lstViewAd.SelectedItems.Count == 1)
            {
                for (int i = 0; i <= 1; i++)
                {
                    items = lstViewAd.SelectedItems[0].SubItems[i].Text.ToString();
                    if (i == 0)
                        adSoyad = items;
                    if (i == 1)
                        customerId = Convert.ToInt32(items);
                }
            }

            SqlConnection bg = new SqlConnection(ConnectionString);
            string email = "";
            string telefon = "";
            string musteriTipi = "";
            bg.Open();
            SqlCommand cmd = new SqlCommand("select DISTINCT CustomerName, * from Customers where CustomerId=" + customerId + "", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                email = (string)oku["CustomerMail"];
                telefon = (string)oku["CustomerPhone"];
                musteriTipi = (string)oku["CustomerType"];
            }
            bg.Close();

            txtBxAdSoyad.Text = adSoyad;
            txtBxEmail.Text = email;
            txtBxTelefon.Text = telefon;
            cmbBxMusteriTipi.Text = musteriTipi;


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
                cmd = new SqlCommand("select * from Reservations where CustomerId=(select ReservationId from Customers where CustomerId=" + customerId + ")", bg);
                oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    musteriBilgileri = (string)oku[columnName].ToString();
                }
                bg.Close();
                listele.SubItems.Add(musteriBilgileri.ToString());
                lstViewMusteriBilgileri.Items.Add(listele);
            Devam:
                int a = 0;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand komut = new SqlCommand("UPDATE Customers SET CustomerType='" + cmbBxMusteriTipi.Text + "', CustomerName='" + txtBxAdSoyad.Text + "', CustomerMail='" + txtBxEmail.Text + "', CustomerPhone='" + txtBxTelefon.Text + "' WHERE CustomerId=" + customerId + "", bg);
            komut.ExecuteNonQuery();
            bg.Close();

        }

        private void btnYeniRezervasyon_Click(object sender, EventArgs e)
        {
            YeniRezervasyon yeniRezervasyon = new YeniRezervasyon();
            yeniRezervasyon.Show();
            kayitliMusteriler = true;
        }

        private void btnRezervasyonlar_Click(object sender, EventArgs e)
        {
            rezervasyonlar rezervasyonlar = new rezervasyonlar();
            rezervasyonlar.Show();
            this.Hide();
            kayitliMusteriler = false;
        }
        private void btnOdalar_Click(object sender, EventArgs e)
        {
            Odalar odalar = new Odalar();
            odalar.Show();
            this.Hide();
            kayitliMusteriler = false;
        }
        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            Raporlar raporlar = new Raporlar();
            raporlar.Show();
            this.Hide();
            kayitliMusteriler = false;
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            kayitliMusteriler = false;
            this.Hide();
            Application.Exit();
        }
        private void btnMailGonder_Click(object sender, EventArgs e)
        {
            MailGönder mailGönder = new MailGönder();
            mailGönder.Show();
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
    }
}
