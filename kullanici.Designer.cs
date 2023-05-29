namespace adminPanel
{
    partial class kullanici
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
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 31;
            listBox1.Location = new Point(3, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(845, 407);
            listBox1.TabIndex = 0;
            // 
            // kullanici
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(listBox1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "kullanici";
            Size = new Size(857, 522);
            Load += kullanici_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
    }
}
