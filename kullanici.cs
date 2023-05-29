using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace adminPanel
{
    public partial class kullanici : UserControl
    {
        private SqlConnection baglanti;
        private SqlDataAdapter adapter;
        private DataTable dataTable;

        public kullanici()
        {
            InitializeComponent();
        }

        private void kullanici_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=ACER-58G\SQLEXPRESS;Initial Catalog=ikinci;Integrated Security=True";
            baglanti = new SqlConnection(connectionString);

            adapter = new SqlDataAdapter("SELECT ad, soyad, mail, telNo FROM kullanicilar", baglanti);
            dataTable = new DataTable();
            adapter.Fill(dataTable);

            Goster();
        }

        private void Goster()
        {
            listBox1.Items.Clear();

            // Başlık satırını oluştur
            string baslik = string.Format("{0,-20}{1,-20}{2,-30}{3,-15}", "Ad", "Soyad", "Mail", "Tel No");
            listBox1.Items.Add(baslik);

            foreach (DataRow row in dataTable.Rows)
            {
                string ad = row.Field<string>("ad");
                string soyad = row.Field<string>("soyad");
                string mail = row.Field<string>("mail");
                string telNo = row.Field<string>("telNo");

                string item = string.Format("{0,-20}{1,-20}{2,-30}{3,-15}", ad, soyad, mail, telNo);
                listBox1.Items.Add(item);
            }
        }
    }
}
