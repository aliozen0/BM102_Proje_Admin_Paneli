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

namespace adminPanel
{
    public partial class yemekSil : UserControl
    {
        private SqlConnection baglanti;
        private SqlDataAdapter adapterKategoriler;
        private SqlDataAdapter adapterYemekler;
        private DataTable kategoriDataTable;
        private DataTable yemekDataTable;
        private Dictionary<int, Button> kategoriButonlari;

        public yemekSil()
        {
            InitializeComponent();
        }

        private void yemekSil_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=ACER-58G\SQLEXPRESS;Initial Catalog=ikinci;Integrated Security=True";
            baglanti = new SqlConnection(connectionString);

            adapterKategoriler = new SqlDataAdapter("SELECT kategoriID, kategoriAdi FROM Kategoriler", baglanti);
            adapterYemekler = new SqlDataAdapter("SELECT yemekID, yemekAdi, ucret, kategoriID FROM YemekTablosu", baglanti);
            kategoriDataTable = new DataTable();
            yemekDataTable = new DataTable();
            adapterKategoriler.Fill(kategoriDataTable);
            adapterYemekler.Fill(yemekDataTable);
            kategoriButonlari = new Dictionary<int, Button>();

            Guncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Seçili yemeği silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Yemek seciliYemek = (Yemek)listBox1.SelectedItem;
                    int yemekID = seciliYemek.YemekID;

                    try
                    {
                        baglanti.Open();

                        string sorgu = "DELETE FROM YemekTablosu WHERE yemekID = @yemekID";
                        SqlCommand komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@yemekID", yemekID);
                        komut.ExecuteNonQuery();

                        MessageBox.Show("Yemek başarıyla silindi!");

                        // Yemekleri güncelle
                        GuncelleYemekler();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                    finally
                    {
                        baglanti.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz yemeği seçin.");
            }
        }

        private void KategoriButon_Click(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            int kategoriID = (int)buton.Tag;

            List<Yemek> kategoriyeAitYemekler = yemekDataTable.AsEnumerable()
                .Where(row => row.Field<int>("kategoriID") == kategoriID)
                .Select(row => new Yemek(
                    row.Field<int>("yemekID"),
                    row.Field<string>("yemekAdi"),
                    row.Field<decimal>("ucret"),
                    row.Field<int>("kategoriID")))
                .ToList();

            listBox1.Items.Clear();
            listBox1.Items.AddRange(kategoriyeAitYemekler.ToArray());
        }

        public void Guncelle()
        {
            try
            {
                foreach (DataRow row in kategoriDataTable.Rows)
                {
                    int kategoriID = row.Field<int>("kategoriID");
                    string kategoriAdi = row.Field<string>("kategoriAdi");

                    if (!kategoriButonlari.ContainsKey(kategoriID))
                    {
                        Button buton = new Button();
                        buton.Text = kategoriAdi;
                        buton.Tag = kategoriID;
                        buton.Width = 200;
                        buton.Height = 50;
                        buton.Click += KategoriButon_Click;

                        kategoriButonlari.Add(kategoriID, buton);
                        flowLayoutPanel1.Controls.Add(buton);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategorileri güncelleme sırasında bir hata oluştu: " + ex.Message);
            }
        }

        public void GuncelleYemekler()
        {
            try
            {
                // Yemekleri yeniden çek
                yemekDataTable.Clear();
                adapterYemekler.Fill(yemekDataTable);

                // Seçili kategoriye ait yemekleri yeniden yükle
                if (listBox1.SelectedItem != null)
                {
                    Yemek seciliYemek = (Yemek)listBox1.SelectedItem;
                    int kategoriID = seciliYemek.KategoriID;

                    List<Yemek> kategoriyeAitYemekler = yemekDataTable.AsEnumerable()
                        .Where(row => row.Field<int>("kategoriID") == kategoriID)
                        .Select(row => new Yemek(
                            row.Field<int>("yemekID"),
                            row.Field<string>("yemekAdi"),
                            row.Field<decimal>("ucret"),
                            row.Field<int>("kategoriID")))
                        .ToList();

                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(kategoriyeAitYemekler.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yemekleri güncelleme sırasında bir hata oluştu: " + ex.Message);
            }
        }

        public class Yemek
        {
            public int YemekID { get; set; }
            public string YemekAdi { get; set; }
            public decimal Ucret { get; set; }
            public int KategoriID { get; set; }

            public Yemek(int yemekID, string yemekAdi, decimal ucret, int kategoriID)
            {
                YemekID = yemekID;
                YemekAdi = yemekAdi;
                Ucret = ucret;
                KategoriID = kategoriID;
            }

            public override string ToString()
            {
                return YemekAdi + " - " + Ucret.ToString("C");
            }
        }
    }
}
