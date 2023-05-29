namespace adminPanel
{
    partial class formAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            siparis1 = new siparis();
            yemek1 = new yemek();
            button4 = new Button();
            yemekSil1 = new yemekSil();
            kullanici1 = new kullanici();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(-6, 142);
            button1.Name = "button1";
            button1.Size = new Size(152, 73);
            button1.TabIndex = 0;
            button1.Text = "Siparişleri Göster";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(-6, 272);
            button2.Name = "button2";
            button2.Size = new Size(152, 62);
            button2.TabIndex = 1;
            button2.Text = "Yemek Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(-6, 509);
            button3.Name = "button3";
            button3.Size = new Size(152, 73);
            button3.TabIndex = 2;
            button3.Text = "Kullanıcıları Göster";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(210, 31);
            label1.TabIndex = 3;
            label1.Text = "Hosgeldin ADMİN";
            // 
            // siparis1
            // 
            siparis1.BackColor = Color.Transparent;
            siparis1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            siparis1.Location = new Point(195, 128);
            siparis1.Margin = new Padding(4, 4, 4, 4);
            siparis1.Name = "siparis1";
            siparis1.Size = new Size(1050, 554);
            siparis1.TabIndex = 4;
            siparis1.Visible = false;
            // 
            // yemek1
            // 
            yemek1.BackColor = Color.Transparent;
            yemek1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            yemek1.Location = new Point(154, 107);
            yemek1.Margin = new Padding(5);
            yemek1.Name = "yemek1";
            yemek1.Size = new Size(862, 539);
            yemek1.TabIndex = 5;
            // 
            // button4
            // 
            button4.Location = new Point(-6, 392);
            button4.Name = "button4";
            button4.Size = new Size(152, 62);
            button4.TabIndex = 1;
            button4.Text = "Yemek Sil";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // yemekSil1
            // 
            yemekSil1.BackColor = Color.Transparent;
            yemekSil1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            yemekSil1.Location = new Point(141, 109);
            yemekSil1.Margin = new Padding(5);
            yemekSil1.Name = "yemekSil1";
            yemekSil1.Size = new Size(921, 537);
            yemekSil1.TabIndex = 6;
            yemekSil1.Load += yemekSil1_Load;
            // 
            // kullanici1
            // 
            kullanici1.BackColor = Color.Transparent;
            kullanici1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            kullanici1.Location = new Point(164, 107);
            kullanici1.Margin = new Padding(5);
            kullanici1.Name = "kullanici1";
            kullanici1.Size = new Size(863, 534);
            kullanici1.TabIndex = 7;
            // 
            // formAdmin
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arkaplan1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1117, 695);
            Controls.Add(kullanici1);
            Controls.Add(yemekSil1);
            Controls.Add(yemek1);
            Controls.Add(siparis1);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "formAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Paneli";
            Load += formAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private siparis siparis1;
        private yemek yemek1;
        private Button button4;
        private yemekSil yemekSil1;
        private kullanici kullanici1;
    }
}