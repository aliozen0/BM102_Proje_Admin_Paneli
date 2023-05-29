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
    public partial class yemek : UserControl
    {
        private SqlConnection baglanti;
        private SqlCommand komut;
        private byte[] fotoData;

        public yemek()
        {
            InitializeComponent();
            numericUpDownUcret.DecimalPlaces = 2;
        }

        private void yemek_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=ACER-58G\SQLEXPRESS;Initial Catalog=ikinci;Integrated Security=True";
            baglanti = new SqlConnection(connectionString);
            komut = new SqlCommand();
            komut.Connection = baglanti;

            KategorileriYukle();
        }

        private void KategorileriYukle()
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT kategoriID, kategoriAdi FROM Kategoriler";
                komut.CommandText = sorgu;

                SqlDataReader okuyucu = komut.ExecuteReader();
                while (okuyucu.Read())
                {
                    int kategoriID = (int)okuyucu["kategoriID"];
                    string kategoriAdi = (string)okuyucu["kategoriAdi"];
                    cmbKategori.Items.Add(new Kategori(kategoriID, kategoriAdi));
                }

                okuyucu.Close();
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
        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void btnFotoEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Fotoğraf Seç";
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png|Tüm Dosyalar|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = openFileDialog.FileName;
                Image foto = Image.FromFile(dosyaYolu);
                pictureBox.Image = foto;

                fotoData = ConvertImageToByteArray(foto);
            }
            else
            {
                MessageBox.Show("Fotoğraf seçilmedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] ConvertImageToByteArray(Image image)
        {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!checkBoxOnay.Checked)
            {
                MessageBox.Show("İşlemi gerçekleştirebilmek için onay kutusunu işaretleyin.", "Onay Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (fotoData == null)
            {
                MessageBox.Show("Lütfen bir fotoğraf seçin!");
                return;
            }

            Kategori seciliKategori = (Kategori)cmbKategori.SelectedItem;
            string yemekAdi = txtYemekAdi.Text;
            decimal ucret = numericUpDownUcret.Value;

            if (seciliKategori == null)
            {
                MessageBox.Show("Lütfen bir kategori seçin!");
                return;
            }

            if (string.IsNullOrWhiteSpace(yemekAdi))
            {
                MessageBox.Show("Lütfen bir yemek adı girin!");
                return;
            }

            if (ucret == 0)
            {
                MessageBox.Show("Lütfen ücret girin!");
                return;
            }

            try
            {
                baglanti.Open();

                string sorgu = "INSERT INTO YemekTablosu (kategoriID, kategoriAdi, yemekAdi, ucret, foto) " +
                               "VALUES (@kategoriID, @kategoriAdi, @yemekAdi, @ucret, @foto)";
                komut.CommandText = sorgu;
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@kategoriID", seciliKategori.KategoriID);
                komut.Parameters.AddWithValue("@kategoriAdi", seciliKategori.KategoriAdi);
                komut.Parameters.AddWithValue("@yemekAdi", yemekAdi);
                komut.Parameters.AddWithValue("@ucret", ucret);
                komut.Parameters.AddWithValue("@foto", fotoData);


                komut.ExecuteNonQuery();

                MessageBox.Show("Yemek başarıyla kaydedildi!");

                // Formu sıfırla
                cmbKategori.SelectedIndex = -1;
                txtYemekAdi.Clear();
                numericUpDownUcret.Value = 0;
                checkBoxOnay.Checked = false;
                fotoData = null;
                pictureBox.Image = null;
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

        public class Kategori
        {
            public int KategoriID { get; set; }
            public string KategoriAdi { get; set; }

            public Kategori(int kategoriID, string kategoriAdi)
            {
                KategoriID = kategoriID;
                KategoriAdi = kategoriAdi;
            }

            public override string ToString()
            {
                return KategoriAdi;
            }
        }


    }
}

