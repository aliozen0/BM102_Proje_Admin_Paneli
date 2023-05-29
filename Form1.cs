namespace adminPanel
{
    public partial class formAdmin : Form
    {
        public formAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            siparis1.Show();
            yemek1.Hide();
            yemekSil1.Hide();
            kullanici1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yemek1.Show();
            siparis1.Hide();
            yemekSil1.Hide();
            kullanici1.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            yemek1.Hide();
            siparis1.Hide();
            yemekSil1.Guncelle();
            yemekSil1.GuncelleYemekler();
            yemekSil1.Show();
            kullanici1.Hide();
        }

        private void formAdmin_Load(object sender, EventArgs e)
        {
            yemek1.Hide();
            siparis1.Hide();

            yemekSil1.Hide();
            kullanici1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kullanici1.Show();
            yemek1.Hide();
            siparis1.Hide();

            yemekSil1.Hide();
        }

        private void yemekSil1_Load(object sender, EventArgs e)
        {

        }
    }
}