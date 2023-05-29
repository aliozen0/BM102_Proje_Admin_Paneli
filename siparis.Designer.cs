namespace adminPanel
{
    partial class siparis
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
            comboBoxDurum = new ComboBox();
            label1 = new Label();
            btnDurumDegistir = new Button();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // comboBoxDurum
            // 
            comboBoxDurum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxDurum.FormattingEnabled = true;
            comboBoxDurum.Location = new Point(176, 325);
            comboBoxDurum.Margin = new Padding(2);
            comboBoxDurum.Name = "comboBoxDurum";
            comboBoxDurum.Size = new Size(176, 36);
            comboBoxDurum.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 328);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 28);
            label1.TabIndex = 2;
            label1.Text = "Durum Değiştir";
            // 
            // btnDurumDegistir
            // 
            btnDurumDegistir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDurumDegistir.Location = new Point(412, 320);
            btnDurumDegistir.Margin = new Padding(2);
            btnDurumDegistir.Name = "btnDurumDegistir";
            btnDurumDegistir.Size = new Size(109, 40);
            btnDurumDegistir.TabIndex = 3;
            btnDurumDegistir.Text = "Değiştir";
            btnDurumDegistir.UseVisualStyleBackColor = true;
            btnDurumDegistir.Click += btnDurumDegistir_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.BackgroundColor = SystemColors.Control;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(3, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(522, 288);
            dataGridView.TabIndex = 4;
            // 
            // siparis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(dataGridView);
            Controls.Add(btnDurumDegistir);
            Controls.Add(label1);
            Controls.Add(comboBoxDurum);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "siparis";
            Size = new Size(613, 477);
            Load += siparis_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxDurum;
        private Label label1;
        private Button btnDurumDegistir;
        private DataGridView dataGridView;
    }
}
