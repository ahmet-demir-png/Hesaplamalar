namespace Hesaplamalar
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.tabControl_Menu = new System.Windows.Forms.TabControl();
            this.tabPage_Hesap_Makinesi = new System.Windows.Forms.TabPage();
            this.panel_toplama = new System.Windows.Forms.Panel();
            this.button_topla_sonuc = new System.Windows.Forms.Button();
            this.button_CE_sil = new System.Windows.Forms.Button();
            this.label_Sonuc = new System.Windows.Forms.Label();
            this.radioButton_tekislem = new System.Windows.Forms.RadioButton();
            this.radioButton_surekiislem = new System.Windows.Forms.RadioButton();
            this.label_sembol = new System.Windows.Forms.Label();
            this.maskedTextBox_Sayi2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Sayi1 = new System.Windows.Forms.MaskedTextBox();
            this.panel_dahaoncekiislemler = new System.Windows.Forms.Panel();
            this.button_temizle = new System.Windows.Forms.Button();
            this.listBox_dahaoncekiislemler = new System.Windows.Forms.ListBox();
            this.listBox_Listececmisi = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Liste_gecmisi = new System.Windows.Forms.Button();
            this.button_Daha_onceki_islemler = new System.Windows.Forms.Button();
            this.button_Carpma = new System.Windows.Forms.Button();
            this.button2_Bolme = new System.Windows.Forms.Button();
            this.button_Cikarma = new System.Windows.Forms.Button();
            this.button_Toplama = new System.Windows.Forms.Button();
            this.tabPage_Yol_Hız_Zaman = new System.Windows.Forms.TabPage();
            this.tabControl_Menu.SuspendLayout();
            this.tabPage_Hesap_Makinesi.SuspendLayout();
            this.panel_toplama.SuspendLayout();
            this.panel_dahaoncekiislemler.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Menu
            // 
            this.tabControl_Menu.Controls.Add(this.tabPage_Hesap_Makinesi);
            this.tabControl_Menu.Controls.Add(this.tabPage_Yol_Hız_Zaman);
            this.tabControl_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl_Menu.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Menu.Name = "tabControl_Menu";
            this.tabControl_Menu.SelectedIndex = 0;
            this.tabControl_Menu.Size = new System.Drawing.Size(1363, 567);
            this.tabControl_Menu.TabIndex = 0;
            // 
            // tabPage_Hesap_Makinesi
            // 
            this.tabPage_Hesap_Makinesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabPage_Hesap_Makinesi.Controls.Add(this.panel_toplama);
            this.tabPage_Hesap_Makinesi.Controls.Add(this.panel_dahaoncekiislemler);
            this.tabPage_Hesap_Makinesi.Controls.Add(this.listBox_Listececmisi);
            this.tabPage_Hesap_Makinesi.Controls.Add(this.panel1);
            this.tabPage_Hesap_Makinesi.ForeColor = System.Drawing.Color.White;
            this.tabPage_Hesap_Makinesi.Location = new System.Drawing.Point(4, 30);
            this.tabPage_Hesap_Makinesi.Name = "tabPage_Hesap_Makinesi";
            this.tabPage_Hesap_Makinesi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Hesap_Makinesi.Size = new System.Drawing.Size(1355, 533);
            this.tabPage_Hesap_Makinesi.TabIndex = 0;
            this.tabPage_Hesap_Makinesi.Text = "4 İşlem";
            // 
            // panel_toplama
            // 
            this.panel_toplama.Controls.Add(this.button_topla_sonuc);
            this.panel_toplama.Controls.Add(this.button_CE_sil);
            this.panel_toplama.Controls.Add(this.label_Sonuc);
            this.panel_toplama.Controls.Add(this.radioButton_tekislem);
            this.panel_toplama.Controls.Add(this.radioButton_surekiislem);
            this.panel_toplama.Controls.Add(this.label_sembol);
            this.panel_toplama.Controls.Add(this.maskedTextBox_Sayi2);
            this.panel_toplama.Controls.Add(this.maskedTextBox_Sayi1);
            this.panel_toplama.Location = new System.Drawing.Point(448, 252);
            this.panel_toplama.Name = "panel_toplama";
            this.panel_toplama.Size = new System.Drawing.Size(505, 154);
            this.panel_toplama.TabIndex = 2;
            // 
            // button_topla_sonuc
            // 
            this.button_topla_sonuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_topla_sonuc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_topla_sonuc.ForeColor = System.Drawing.Color.White;
            this.button_topla_sonuc.Location = new System.Drawing.Point(455, 45);
            this.button_topla_sonuc.Name = "button_topla_sonuc";
            this.button_topla_sonuc.Size = new System.Drawing.Size(50, 50);
            this.button_topla_sonuc.TabIndex = 7;
            this.button_topla_sonuc.Text = "=";
            this.button_topla_sonuc.UseVisualStyleBackColor = true;
            this.button_topla_sonuc.Click += new System.EventHandler(this.button_topla_sonuc_Click);
            // 
            // button_CE_sil
            // 
            this.button_CE_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CE_sil.ForeColor = System.Drawing.Color.IndianRed;
            this.button_CE_sil.Location = new System.Drawing.Point(455, 101);
            this.button_CE_sil.Name = "button_CE_sil";
            this.button_CE_sil.Size = new System.Drawing.Size(50, 50);
            this.button_CE_sil.TabIndex = 6;
            this.button_CE_sil.Text = " CE ";
            this.button_CE_sil.UseVisualStyleBackColor = true;
            this.button_CE_sil.Click += new System.EventHandler(this.button_CE_sil_Click);
            // 
            // label_Sonuc
            // 
            this.label_Sonuc.AutoSize = true;
            this.label_Sonuc.Location = new System.Drawing.Point(3, 42);
            this.label_Sonuc.Name = "label_Sonuc";
            this.label_Sonuc.Size = new System.Drawing.Size(61, 21);
            this.label_Sonuc.TabIndex = 5;
            this.label_Sonuc.Text = "Sonuç:";
            // 
            // radioButton_tekislem
            // 
            this.radioButton_tekislem.AutoSize = true;
            this.radioButton_tekislem.Location = new System.Drawing.Point(148, 119);
            this.radioButton_tekislem.Name = "radioButton_tekislem";
            this.radioButton_tekislem.Size = new System.Drawing.Size(99, 25);
            this.radioButton_tekislem.TabIndex = 4;
            this.radioButton_tekislem.TabStop = true;
            this.radioButton_tekislem.Text = "Tek işlem";
            this.radioButton_tekislem.UseVisualStyleBackColor = true;
            // 
            // radioButton_surekiislem
            // 
            this.radioButton_surekiislem.AutoSize = true;
            this.radioButton_surekiislem.Location = new System.Drawing.Point(13, 119);
            this.radioButton_surekiislem.Name = "radioButton_surekiislem";
            this.radioButton_surekiislem.Size = new System.Drawing.Size(126, 25);
            this.radioButton_surekiislem.TabIndex = 3;
            this.radioButton_surekiislem.TabStop = true;
            this.radioButton_surekiislem.Text = "Sürekli işlem";
            this.radioButton_surekiislem.UseVisualStyleBackColor = true;
            // 
            // label_sembol
            // 
            this.label_sembol.AutoSize = true;
            this.label_sembol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_sembol.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_sembol.Location = new System.Drawing.Point(237, 0);
            this.label_sembol.Name = "label_sembol";
            this.label_sembol.Size = new System.Drawing.Size(31, 32);
            this.label_sembol.TabIndex = 2;
            this.label_sembol.Text = "+";
            this.label_sembol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBox_Sayi2
            // 
            this.maskedTextBox_Sayi2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.maskedTextBox_Sayi2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox_Sayi2.Dock = System.Windows.Forms.DockStyle.Right;
            this.maskedTextBox_Sayi2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox_Sayi2.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox_Sayi2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.maskedTextBox_Sayi2.Location = new System.Drawing.Point(268, 0);
            this.maskedTextBox_Sayi2.Name = "maskedTextBox_Sayi2";
            this.maskedTextBox_Sayi2.PromptChar = ' ';
            this.maskedTextBox_Sayi2.Size = new System.Drawing.Size(237, 39);
            this.maskedTextBox_Sayi2.TabIndex = 1;
            this.maskedTextBox_Sayi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maskedTextBox_Sayi2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox_Sayi2_KeyDown);
            this.maskedTextBox_Sayi2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox_Sayi2_KeyPress);
            // 
            // maskedTextBox_Sayi1
            // 
            this.maskedTextBox_Sayi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.maskedTextBox_Sayi1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox_Sayi1.Dock = System.Windows.Forms.DockStyle.Left;
            this.maskedTextBox_Sayi1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox_Sayi1.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox_Sayi1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.maskedTextBox_Sayi1.Location = new System.Drawing.Point(0, 0);
            this.maskedTextBox_Sayi1.Name = "maskedTextBox_Sayi1";
            this.maskedTextBox_Sayi1.PromptChar = ' ';
            this.maskedTextBox_Sayi1.Size = new System.Drawing.Size(237, 39);
            this.maskedTextBox_Sayi1.TabIndex = 0;
            this.maskedTextBox_Sayi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maskedTextBox_Sayi1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox_Sayi1_KeyPress);
            // 
            // panel_dahaoncekiislemler
            // 
            this.panel_dahaoncekiislemler.Controls.Add(this.button_temizle);
            this.panel_dahaoncekiislemler.Controls.Add(this.listBox_dahaoncekiislemler);
            this.panel_dahaoncekiislemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_dahaoncekiislemler.Location = new System.Drawing.Point(3, 527);
            this.panel_dahaoncekiislemler.Name = "panel_dahaoncekiislemler";
            this.panel_dahaoncekiislemler.Size = new System.Drawing.Size(1349, 3);
            this.panel_dahaoncekiislemler.TabIndex = 4;
            // 
            // button_temizle
            // 
            this.button_temizle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_temizle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_temizle.Location = new System.Drawing.Point(0, -50);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(1349, 53);
            this.button_temizle.TabIndex = 4;
            this.button_temizle.Text = "İşlemleri Temizle";
            this.button_temizle.UseVisualStyleBackColor = true;
            this.button_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // listBox_dahaoncekiislemler
            // 
            this.listBox_dahaoncekiislemler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.listBox_dahaoncekiislemler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_dahaoncekiislemler.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox_dahaoncekiislemler.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox_dahaoncekiislemler.ForeColor = System.Drawing.Color.White;
            this.listBox_dahaoncekiislemler.FormattingEnabled = true;
            this.listBox_dahaoncekiislemler.ItemHeight = 37;
            this.listBox_dahaoncekiislemler.Location = new System.Drawing.Point(0, 0);
            this.listBox_dahaoncekiislemler.Name = "listBox_dahaoncekiislemler";
            this.listBox_dahaoncekiislemler.Size = new System.Drawing.Size(1349, 444);
            this.listBox_dahaoncekiislemler.TabIndex = 3;
            // 
            // listBox_Listececmisi
            // 
            this.listBox_Listececmisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.listBox_Listececmisi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Listececmisi.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox_Listececmisi.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox_Listececmisi.ForeColor = System.Drawing.Color.White;
            this.listBox_Listececmisi.FormattingEnabled = true;
            this.listBox_Listececmisi.ItemHeight = 37;
            this.listBox_Listececmisi.Location = new System.Drawing.Point(3, 83);
            this.listBox_Listececmisi.Name = "listBox_Listececmisi";
            this.listBox_Listececmisi.Size = new System.Drawing.Size(1349, 444);
            this.listBox_Listececmisi.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Liste_gecmisi);
            this.panel1.Controls.Add(this.button_Daha_onceki_islemler);
            this.panel1.Controls.Add(this.button_Carpma);
            this.panel1.Controls.Add(this.button2_Bolme);
            this.panel1.Controls.Add(this.button_Cikarma);
            this.panel1.Controls.Add(this.button_Toplama);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1349, 80);
            this.panel1.TabIndex = 1;
            // 
            // button_Liste_gecmisi
            // 
            this.button_Liste_gecmisi.BackColor = System.Drawing.Color.Black;
            this.button_Liste_gecmisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Liste_gecmisi.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Liste_gecmisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Liste_gecmisi.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Liste_gecmisi.ForeColor = System.Drawing.Color.LightGray;
            this.button_Liste_gecmisi.Location = new System.Drawing.Point(1142, 0);
            this.button_Liste_gecmisi.Name = "button_Liste_gecmisi";
            this.button_Liste_gecmisi.Size = new System.Drawing.Size(207, 80);
            this.button_Liste_gecmisi.TabIndex = 5;
            this.button_Liste_gecmisi.Text = "Liste Geçmişi";
            this.button_Liste_gecmisi.UseVisualStyleBackColor = false;
            this.button_Liste_gecmisi.Click += new System.EventHandler(this.button_Liste_gecmisi_Click);
            // 
            // button_Daha_onceki_islemler
            // 
            this.button_Daha_onceki_islemler.BackColor = System.Drawing.Color.Black;
            this.button_Daha_onceki_islemler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Daha_onceki_islemler.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Daha_onceki_islemler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Daha_onceki_islemler.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Daha_onceki_islemler.ForeColor = System.Drawing.Color.LightGray;
            this.button_Daha_onceki_islemler.Location = new System.Drawing.Point(800, 0);
            this.button_Daha_onceki_islemler.Name = "button_Daha_onceki_islemler";
            this.button_Daha_onceki_islemler.Size = new System.Drawing.Size(342, 80);
            this.button_Daha_onceki_islemler.TabIndex = 4;
            this.button_Daha_onceki_islemler.Text = "Daha Önceki İşlemler";
            this.button_Daha_onceki_islemler.UseVisualStyleBackColor = false;
            this.button_Daha_onceki_islemler.Click += new System.EventHandler(this.button_Daha_onceki_islemler_Click);
            // 
            // button_Carpma
            // 
            this.button_Carpma.BackColor = System.Drawing.Color.Black;
            this.button_Carpma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Carpma.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Carpma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Carpma.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Carpma.ForeColor = System.Drawing.Color.LightGray;
            this.button_Carpma.Location = new System.Drawing.Point(600, 0);
            this.button_Carpma.Name = "button_Carpma";
            this.button_Carpma.Size = new System.Drawing.Size(200, 80);
            this.button_Carpma.TabIndex = 3;
            this.button_Carpma.Text = "Çarpma[x]";
            this.button_Carpma.UseVisualStyleBackColor = false;
            this.button_Carpma.Click += new System.EventHandler(this.button_Carpma_Click);
            // 
            // button2_Bolme
            // 
            this.button2_Bolme.BackColor = System.Drawing.Color.Black;
            this.button2_Bolme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2_Bolme.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2_Bolme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_Bolme.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2_Bolme.ForeColor = System.Drawing.Color.LightGray;
            this.button2_Bolme.Location = new System.Drawing.Point(400, 0);
            this.button2_Bolme.Name = "button2_Bolme";
            this.button2_Bolme.Size = new System.Drawing.Size(200, 80);
            this.button2_Bolme.TabIndex = 2;
            this.button2_Bolme.Text = "Bölme[÷]";
            this.button2_Bolme.UseVisualStyleBackColor = false;
            this.button2_Bolme.Click += new System.EventHandler(this.button2_Bolme_Click);
            // 
            // button_Cikarma
            // 
            this.button_Cikarma.BackColor = System.Drawing.Color.Black;
            this.button_Cikarma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Cikarma.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Cikarma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cikarma.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Cikarma.ForeColor = System.Drawing.Color.LightGray;
            this.button_Cikarma.Location = new System.Drawing.Point(200, 0);
            this.button_Cikarma.Name = "button_Cikarma";
            this.button_Cikarma.Size = new System.Drawing.Size(200, 80);
            this.button_Cikarma.TabIndex = 1;
            this.button_Cikarma.Text = "Çıkarma[-]";
            this.button_Cikarma.UseVisualStyleBackColor = false;
            this.button_Cikarma.Click += new System.EventHandler(this.button_Cikarma_Click);
            // 
            // button_Toplama
            // 
            this.button_Toplama.BackColor = System.Drawing.Color.Black;
            this.button_Toplama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Toplama.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Toplama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Toplama.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Toplama.ForeColor = System.Drawing.Color.LightGray;
            this.button_Toplama.Location = new System.Drawing.Point(0, 0);
            this.button_Toplama.Name = "button_Toplama";
            this.button_Toplama.Size = new System.Drawing.Size(200, 80);
            this.button_Toplama.TabIndex = 0;
            this.button_Toplama.Text = "Toplama[+]";
            this.button_Toplama.UseVisualStyleBackColor = false;
            this.button_Toplama.Click += new System.EventHandler(this.button_Toplama_Click);
            // 
            // tabPage_Yol_Hız_Zaman
            // 
            this.tabPage_Yol_Hız_Zaman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabPage_Yol_Hız_Zaman.ForeColor = System.Drawing.Color.White;
            this.tabPage_Yol_Hız_Zaman.Location = new System.Drawing.Point(4, 30);
            this.tabPage_Yol_Hız_Zaman.Name = "tabPage_Yol_Hız_Zaman";
            this.tabPage_Yol_Hız_Zaman.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Yol_Hız_Zaman.Size = new System.Drawing.Size(1355, 533);
            this.tabPage_Yol_Hız_Zaman.TabIndex = 1;
            this.tabPage_Yol_Hız_Zaman.Text = "Farkı İşlemler";
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1363, 567);
            this.Controls.Add(this.tabControl_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "anasayfa";
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.tabControl_Menu.ResumeLayout(false);
            this.tabPage_Hesap_Makinesi.ResumeLayout(false);
            this.panel_toplama.ResumeLayout(false);
            this.panel_toplama.PerformLayout();
            this.panel_dahaoncekiislemler.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl_Menu;
        private TabPage tabPage_Hesap_Makinesi;
        private TabPage tabPage_Yol_Hız_Zaman;
        private Button button_Toplama;
        private Panel panel1;
        private Button button_Carpma;
        private Button button2_Bolme;
        private Button button_Cikarma;
        private Button button_Liste_gecmisi;
        private Button button_Daha_onceki_islemler;
        private Panel panel_toplama;
        private Label label_sembol;
        private RadioButton radioButton_tekislem;
        private RadioButton radioButton_surekiislem;
        private Label label_Sonuc;
        private ListBox listBox_dahaoncekiislemler;
        public MaskedTextBox maskedTextBox_Sayi1;
        public MaskedTextBox maskedTextBox_Sayi2;
        private Panel panel_dahaoncekiislemler;
        private Button button_temizle;
        private ListBox listBox_Listececmisi;
        private Button button_CE_sil;
        private Button button_topla_sonuc;
    }
}