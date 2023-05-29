namespace adminPanel
{
    partial class yemekSil
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
            listBox1 = new ListBox();
            btnSil = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 31;
            listBox1.Location = new Point(36, 181);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(532, 345);
            listBox1.TabIndex = 0;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(647, 206);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(210, 67);
            btnSil.TabIndex = 1;
            btnSil.Text = "Seçili Yemeği Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(18, 22);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(839, 131);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // yemekSil
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnSil);
            Controls.Add(listBox1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "yemekSil";
            Size = new Size(883, 549);
            Load += yemekSil_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btnSil;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
