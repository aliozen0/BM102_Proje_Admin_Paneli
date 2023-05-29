using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace adminPanel
{
    public partial class siparis : UserControl
    {
        private string connectionString = @"Data Source=ACER-58G\SQLEXPRESS;Initial Catalog=ikinci;Integrated Security=True";
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public siparis()
        {
            InitializeComponent();
        }

        private void siparis_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter();
            dataTable = new DataTable();

            // Verileri al ve DataGridView'e bağla
            GetData();
            dataGridView.DataSource = dataTable;


            // Sipariş durumlarını ComboBox'a ekle
            comboBoxDurum.Items.AddRange(new string[] { "Sipariş Alındı", "Hazırlanıyor", "Yolda", "Teslim Edildi", "İptal Edildi" });
            dataGridView.DefaultCellStyle.Font = new Font("Segoe UI Semilight", 8f);


        }

        private void GetData()
        {
            try
            {
                connection.Open();

                string query = "SELECT siparisID,tarih, adsoyad, yemekAdi, ucret ,durum,odemeyontemi,adres FROM siparisler";
                dataAdapter.SelectCommand = new SqlCommand(query, connection);

                dataTable.Clear();

                dataAdapter.Fill(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri alınırken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnDurumDegistir_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir sipariş seçin!");
                return;
            }

            DataRow selectedRow = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            string siparisDurumu = comboBoxDurum.SelectedItem.ToString();

            try
            {
                string updateQuery = "UPDATE siparisler SET durum = @durum WHERE siparisID = @siparisID";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@durum", siparisDurumu);
                    command.Parameters.AddWithValue("@siparisID", selectedRow["siparisID"]);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sipariş durumu güncellendi.");
                        GetData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sipariş durumu güncellenirken bir hata oluştu: " + ex.Message);
            }
        }



    }
}
