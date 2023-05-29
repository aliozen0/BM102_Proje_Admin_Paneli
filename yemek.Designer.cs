namespace adminPanel
{
    partial class yemek
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBoxOnay = new CheckBox();
            cmbKategori = new ComboBox();
            txtYemekAdi = new TextBox();
            numericUpDownUcret = new NumericUpDown();
            btnKaydet = new Button();
            pictureBox = new PictureBox();
            btnFotoEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUcret).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 45);
            label1.Name = "label1";
            label1.Size = new Size(199, 31);
            label1.TabIndex = 0;
            label1.Text = "Kategori Seçiniz :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 157);
            label2.Name = "label2";
            label2.Size = new Size(216, 31);
            label2.TabIndex = 0;
            label2.Text = "Yemek Adı Giriniz :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 278);
            label3.Name = "label3";
            label3.Size = new Size(161, 31);
            label3.TabIndex = 0;
            label3.Text = "Ücret Giriniz :";
            // 
            // checkBoxOnay
            // 
            checkBoxOnay.AutoSize = true;
            checkBoxOnay.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxOnay.Location = new Point(32, 386);
            checkBoxOnay.Name = "checkBoxOnay";
            checkBoxOnay.Size = new Size(343, 29);
            checkBoxOnay.TabIndex = 1;
            checkBoxOnay.Text = "Bilgilerin Doğruluğunu Onaylıyorum";
            checkBoxOnay.UseVisualStyleBackColor = true;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(249, 42);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(317, 39);
            cmbKategori.TabIndex = 2;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // txtYemekAdi
            // 
            txtYemekAdi.Location = new Point(249, 154);
            txtYemekAdi.Name = "txtYemekAdi";
            txtYemekAdi.Size = new Size(317, 38);
            txtYemekAdi.TabIndex = 3;
            // 
            // numericUpDownUcret
            // 
            numericUpDownUcret.Location = new Point(249, 276);
            numericUpDownUcret.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownUcret.Name = "numericUpDownUcret";
            numericUpDownUcret.Size = new Size(317, 38);
            numericUpDownUcret.TabIndex = 4;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(508, 433);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(189, 60);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "YEMEK EKLE";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(638, 42);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(157, 175);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 6;
            pictureBox.TabStop = false;
            // 
            // btnFotoEkle
            // 
            btnFotoEkle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnFotoEkle.Location = new Point(638, 223);
            btnFotoEkle.Name = "btnFotoEkle";
            btnFotoEkle.Size = new Size(157, 40);
            btnFotoEkle.TabIndex = 7;
            btnFotoEkle.Text = "Fotoğraf Ekle";
            btnFotoEkle.UseVisualStyleBackColor = true;
            btnFotoEkle.Click += btnFotoEkle_Click;
            // 
            // yemek
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnFotoEkle);
            Controls.Add(pictureBox);
            Controls.Add(btnKaydet);
            Controls.Add(numericUpDownUcret);
            Controls.Add(txtYemekAdi);
            Controls.Add(cmbKategori);
            Controls.Add(checkBoxOnay);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "yemek";
            Size = new Size(853, 539);
            Load += yemek_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownUcret).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBoxOnay;
        private ComboBox cmbKategori;
        private TextBox txtYemekAdi;
        private NumericUpDown numericUpDownUcret;
        private Button btnKaydet;
        private PictureBox pictureBox;
        private Button btnFotoEkle;
    }
}
