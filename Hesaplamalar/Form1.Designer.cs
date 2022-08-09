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
            System.Windows.Forms.Button button_Toplama;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.tabControl_Menu = new System.Windows.Forms.TabControl();
            this.tabPage_Hesap_Makinesi = new System.Windows.Forms.TabPage();
            this.panel_toplama = new System.Windows.Forms.Panel();
            this.maskedTextBox_Sayi2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Sayi1 = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox_sembol = new System.Windows.Forms.PictureBox();
            this.panel_number = new System.Windows.Forms.Panel();
            this.button2_Bolme = new System.Windows.Forms.Button();
            this.button_Daha_onceki_islemler = new System.Windows.Forms.Button();
            this.button_number_c_sil = new System.Windows.Forms.Button();
            this.button_number_eksi = new System.Windows.Forms.Button();
            this.button_CE_sil = new System.Windows.Forms.Button();
            this.button_topla_sonuc = new System.Windows.Forms.Button();
            this.button_Carpma = new System.Windows.Forms.Button();
            this.button_Cikarma = new System.Windows.Forms.Button();
            this.button_number_dokuz = new System.Windows.Forms.Button();
            this.button_numbervirgul = new System.Windows.Forms.Button();
            this.button_number_yedi = new System.Windows.Forms.Button();
            this.button_number_sifir = new System.Windows.Forms.Button();
            this.button_number_altı = new System.Windows.Forms.Button();
            this.button_number_iki = new System.Windows.Forms.Button();
            this.button_number_4 = new System.Windows.Forms.Button();
            this.button_number_bes = new System.Windows.Forms.Button();
            this.button_number_uc = new System.Windows.Forms.Button();
            this.button_number_sekiz = new System.Windows.Forms.Button();
            this.button_number_bir = new System.Windows.Forms.Button();
            this.label_Sonuc = new System.Windows.Forms.Label();
            this.radioButton_tekislem = new System.Windows.Forms.RadioButton();
            this.radioButton_surekiislem = new System.Windows.Forms.RadioButton();
            this.panel_dahaoncekiislemler = new System.Windows.Forms.Panel();
            this.button_temizle = new System.Windows.Forms.Button();
            this.listBox_dahaoncekiislemler = new System.Windows.Forms.ListBox();
            this.listBox_Listececmisi = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_geri_don = new System.Windows.Forms.Button();
            this.button_Liste_gecmisi = new System.Windows.Forms.Button();
            this.tabPage_Yol_Hız_Zaman = new System.Windows.Forms.TabPage();
            button_Toplama = new System.Windows.Forms.Button();
            this.tabControl_Menu.SuspendLayout();
            this.tabPage_Hesap_Makinesi.SuspendLayout();
            this.panel_toplama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sembol)).BeginInit();
            this.panel_number.SuspendLayout();
            this.panel_dahaoncekiislemler.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Toplama
            // 
            button_Toplama.BackColor = System.Drawing.Color.Transparent;
            button_Toplama.BackgroundImage = global::Hesaplamalar.Properties.Resources.Toplama_isareti;
            button_Toplama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button_Toplama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_Toplama.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button_Toplama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            button_Toplama.Location = new System.Drawing.Point(182, 178);
            button_Toplama.Name = "button_Toplama";
            button_Toplama.Size = new System.Drawing.Size(50, 50);
            button_Toplama.TabIndex = 0;
            button_Toplama.UseVisualStyleBackColor = false;
            button_Toplama.Click += new System.EventHandler(this.button_Toplama_Click);
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
            this.tabControl_Menu.Size = new System.Drawing.Size(890, 567);
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
            this.tabPage_Hesap_Makinesi.Size = new System.Drawing.Size(882, 533);
            this.tabPage_Hesap_Makinesi.TabIndex = 0;
            this.tabPage_Hesap_Makinesi.Text = "4 İşlem";
            // 
            // panel_toplama
            // 
            this.panel_toplama.Controls.Add(this.maskedTextBox_Sayi2);
            this.panel_toplama.Controls.Add(this.maskedTextBox_Sayi1);
            this.panel_toplama.Controls.Add(this.pictureBox_sembol);
            this.panel_toplama.Controls.Add(this.panel_number);
            this.panel_toplama.Controls.Add(this.label_Sonuc);
            this.panel_toplama.Controls.Add(this.radioButton_tekislem);
            this.panel_toplama.Controls.Add(this.radioButton_surekiislem);
            this.panel_toplama.Location = new System.Drawing.Point(49, 141);
            this.panel_toplama.Name = "panel_toplama";
            this.panel_toplama.Size = new System.Drawing.Size(799, 343);
            this.panel_toplama.TabIndex = 2;
            // 
            // maskedTextBox_Sayi2
            // 
            this.maskedTextBox_Sayi2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.maskedTextBox_Sayi2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox_Sayi2.Dock = System.Windows.Forms.DockStyle.Right;
            this.maskedTextBox_Sayi2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox_Sayi2.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox_Sayi2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.maskedTextBox_Sayi2.Location = new System.Drawing.Point(422, 0);
            this.maskedTextBox_Sayi2.Name = "maskedTextBox_Sayi2";
            this.maskedTextBox_Sayi2.PromptChar = ' ';
            this.maskedTextBox_Sayi2.Size = new System.Drawing.Size(377, 39);
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
            this.maskedTextBox_Sayi1.Size = new System.Drawing.Size(377, 39);
            this.maskedTextBox_Sayi1.TabIndex = 0;
            this.maskedTextBox_Sayi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maskedTextBox_Sayi1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox_Sayi1_KeyPress);
            // 
            // pictureBox_sembol
            // 
            this.pictureBox_sembol.BackgroundImage = global::Hesaplamalar.Properties.Resources.Toplama_isareti;
            this.pictureBox_sembol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_sembol.Location = new System.Drawing.Point(376, 0);
            this.pictureBox_sembol.Name = "pictureBox_sembol";
            this.pictureBox_sembol.Size = new System.Drawing.Size(47, 39);
            this.pictureBox_sembol.TabIndex = 21;
            this.pictureBox_sembol.TabStop = false;
            // 
            // panel_number
            // 
            this.panel_number.Controls.Add(this.button2_Bolme);
            this.panel_number.Controls.Add(this.button_Daha_onceki_islemler);
            this.panel_number.Controls.Add(this.button_number_c_sil);
            this.panel_number.Controls.Add(this.button_number_eksi);
            this.panel_number.Controls.Add(this.button_CE_sil);
            this.panel_number.Controls.Add(this.button_topla_sonuc);
            this.panel_number.Controls.Add(this.button_Carpma);
            this.panel_number.Controls.Add(button_Toplama);
            this.panel_number.Controls.Add(this.button_Cikarma);
            this.panel_number.Controls.Add(this.button_number_dokuz);
            this.panel_number.Controls.Add(this.button_numbervirgul);
            this.panel_number.Controls.Add(this.button_number_yedi);
            this.panel_number.Controls.Add(this.button_number_sifir);
            this.panel_number.Controls.Add(this.button_number_altı);
            this.panel_number.Controls.Add(this.button_number_iki);
            this.panel_number.Controls.Add(this.button_number_4);
            this.panel_number.Controls.Add(this.button_number_bes);
            this.panel_number.Controls.Add(this.button_number_uc);
            this.panel_number.Controls.Add(this.button_number_sekiz);
            this.panel_number.Controls.Add(this.button_number_bir);
            this.panel_number.Location = new System.Drawing.Point(282, 53);
            this.panel_number.Name = "panel_number";
            this.panel_number.Size = new System.Drawing.Size(249, 290);
            this.panel_number.TabIndex = 20;
            // 
            // button2_Bolme
            // 
            this.button2_Bolme.BackColor = System.Drawing.Color.Transparent;
            this.button2_Bolme.BackgroundImage = global::Hesaplamalar.Properties.Resources.Bolme_islemi;
            this.button2_Bolme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2_Bolme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_Bolme.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2_Bolme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2_Bolme.Location = new System.Drawing.Point(182, 10);
            this.button2_Bolme.Name = "button2_Bolme";
            this.button2_Bolme.Size = new System.Drawing.Size(50, 50);
            this.button2_Bolme.TabIndex = 2;
            this.button2_Bolme.UseVisualStyleBackColor = false;
            this.button2_Bolme.Click += new System.EventHandler(this.button2_Bolme_Click);
            // 
            // button_Daha_onceki_islemler
            // 
            this.button_Daha_onceki_islemler.AutoSize = true;
            this.button_Daha_onceki_islemler.BackColor = System.Drawing.Color.Transparent;
            this.button_Daha_onceki_islemler.BackgroundImage = global::Hesaplamalar.Properties.Resources.daha_onceki_islemler1;
            this.button_Daha_onceki_islemler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Daha_onceki_islemler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Daha_onceki_islemler.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Daha_onceki_islemler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(241)))), ((int)(((byte)(172)))));
            this.button_Daha_onceki_islemler.Location = new System.Drawing.Point(126, 10);
            this.button_Daha_onceki_islemler.Name = "button_Daha_onceki_islemler";
            this.button_Daha_onceki_islemler.Size = new System.Drawing.Size(50, 50);
            this.button_Daha_onceki_islemler.TabIndex = 4;
            this.button_Daha_onceki_islemler.UseVisualStyleBackColor = false;
            this.button_Daha_onceki_islemler.Click += new System.EventHandler(this.button_Daha_onceki_islemler_Click);
            // 
            // button_number_c_sil
            // 
            this.button_number_c_sil.BackgroundImage = global::Hesaplamalar.Properties.Resources.c_hesapmakinesi;
            this.button_number_c_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_number_c_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_number_c_sil.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_number_c_sil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_number_c_sil.Location = new System.Drawing.Point(14, 10);
            this.button_number_c_sil.Name = "button_number_c_sil";
            this.button_number_c_sil.Size = new System.Drawing.Size(50, 50);
            this.button_number_c_sil.TabIndex = 20;
            this.button_number_c_sil.TabStop = false;
            this.button_number_c_sil.UseVisualStyleBackColor = true;
            this.button_number_c_sil.Click += new System.EventHandler(this.button_number_c_sil_Click);
            // 
            // button_number_eksi
            // 
            this.button_number_eksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_number_eksi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_number_eksi.ForeColor = System.Drawing.Color.White;
            this.button_number_eksi.Location = new System.Drawing.Point(14, 234);
            this.button_number_eksi.Name = "button_number_eksi";
            this.button_number_eksi.Size = new System.Drawing.Size(50, 50);
            this.button_number_eksi.TabIndex = 19;
            this.button_number_eksi.TabStop = false;
            this.button_number_eksi.Text = "-";
            this.button_number_eksi.UseVisualStyleBackColor = true;
            // 
            // button_CE_sil
            // 
            this.button_CE_sil.BackgroundImage = global::Hesaplamalar.Properties.Resources.CE_hesapmakinesi;
            this.button_CE_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_CE_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CE_sil.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_CE_sil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_CE_sil.Location = new System.Drawing.Point(70, 10);
            this.button_CE_sil.Name = "button_CE_sil";
            this.button_CE_sil.Size = new System.Drawing.Size(50, 50);
            this.button_CE_sil.TabIndex = 6;
            this.button_CE_sil.TabStop = false;
            this.button_CE_sil.UseVisualStyleBackColor = true;
            this.button_CE_sil.Click += new System.EventHandler(this.button_CE_sil_Click);
            // 
            // button_topla_sonuc
            // 
            this.button_topla_sonuc.BackColor = System.Drawing.Color.Green;
            this.button_topla_sonuc.BackgroundImage = global::Hesaplamalar.Properties.Resources.esittir_isareti;
            this.button_topla_sonuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_topla_sonuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_topla_sonuc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_topla_sonuc.ForeColor = System.Drawing.Color.White;
            this.button_topla_sonuc.Location = new System.Drawing.Point(182, 234);
            this.button_topla_sonuc.Name = "button_topla_sonuc";
            this.button_topla_sonuc.Size = new System.Drawing.Size(50, 50);
            this.button_topla_sonuc.TabIndex = 7;
            this.button_topla_sonuc.TabStop = false;
            this.button_topla_sonuc.UseVisualStyleBackColor = false;
            this.button_topla_sonuc.Click += new System.EventHandler(this.button_topla_sonuc_Click);
            // 
            // button_Carpma
            // 
            this.button_Carpma.BackColor = System.Drawing.Color.Transparent;
            this.button_Carpma.BackgroundImage = global::Hesaplamalar.Properties.Resources.carpma_isareti;
            this.button_Carpma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Carpma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Carpma.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Carpma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Carpma.Location = new System.Drawing.Point(182, 66);
            this.button_Carpma.Name = "button_Carpma";
            this.button_Carpma.Size = new System.Drawing.Size(50, 50);
            this.button_Carpma.TabIndex = 3;
            this.button_Carpma.UseVisualStyleBackColor = false;
            this.button_Carpma.Click += new System.EventHandler(this.button_Carpma_Click);
            // 
            // button_Cikarma
            // 
            this.button_Cikarma.BackColor = System.Drawing.Color.Transparent;
            this.button_Cikarma.BackgroundImage = global::Hesaplamalar.Properties.Resources.Eksi_isareti;
            this.button_Cikarma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Cikarma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cikarma.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Cikarma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Cikarma.Location = new System.Drawing.Point(182, 122);
            this.button_Cikarma.Name = "button_Cikarma";
            this.button_Cikarma.Size = new System.Drawing.Size(50, 50);
            this.button_Cikarma.TabIndex = 1;
            this.button_Cikarma.UseVisualStyleBackColor = false;
            this.button_Cikarma.Click += new System.EventHandler(this.button_Cikarma_Click);
            // 
            // button_number_dokuz
            // 
            this.button_number_dokuz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_number_dokuz.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_number_dokuz.ForeColor = System.Drawing.Color.White;
            this.button_number_dokuz.Location = new System.Drawing.Point(126, 66);
            this.button_number_dokuz.Name = "button_number_dokuz";
            this.button_number_dokuz.Size = new System.Drawing.Size(50, 50);
            this.button_number_dokuz.TabIndex = 18;
            this.button_number_dokuz.TabStop = false;
            this.button_number_dokuz.Text = "9";
            this.button_number_dokuz.UseVisualStyleBackColor = true;
            // 
            // button_numbervirgul
            // 
            this.button_numbervirgul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_numbervirgul.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_numbervirgul.ForeColor = System.Drawing.Color.White;
            this.button_numbervirgul.Location = new System.Drawing.Point(126, 234);
            this.button_numbervirgul.Name = "button_numbervirgul";
            this.button_numbervirgul.Size = new System.Drawing.Size(50, 50);
            this.button_numbervirgul.TabIndex = 8;
            this.button_numbervirgul.TabStop = false;
            this.button_numbervirgul.Text = ",";
            this.button_numbervirgul.UseVisualStyleBackColor = true;
            // 
            // button_number_yedi
            // 
            this.button_number_yedi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_number_yedi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_number_yedi.ForeColor = System.Drawing.Color.White;
            this.button_number_yedi.Location = new System.Drawing.Point(14, 66);
            this.button_number_yedi.Name = "button_number_yedi";
            this.button_number_yedi.Size = new System.Drawing.Size(50, 50);
            this.button_number_yedi.TabIndex = 17;
            this.button_number_yedi.TabStop = false;
            this.button_number_yedi.Text = "7";
            this.button_number_yedi.UseVisualStyleBackColor = true;
            // 
            // button_number_sifir
            // 
            this.button_number_sifir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_number_sifir.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_number_sifir.ForeColor = System.Drawing.Color.White;
            this.button_number_sifir.Location = new System.Drawing.Point(70, 234);
            this.button_number_sifir.Name = "button_number_sifir";
            this.button_number_sifir.Size = new System.Drawing.Size(50, 50);
            this.button_number_sifir.TabIndex = 9;
            this.button_number_sifir.TabStop = false;
            this.button_number_sifir.Text = "0";
            this.button_number_sifir.UseVisualStyleBackColor = true;
            // 
            // button_number_altı
            // 
            this.button_number_altı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_number_altı.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_number_altı.ForeColor = System.Drawing.Color.White;
            this.button_number_altı.Location = new System.Drawing.Point(126, 122);
            this.button_number_altı.Name = "button_number_altı";
            this.button_number_altı.Size = new System.Drawing.Size(50, 50);
            this.button_number_altı.TabIndex = 16;
            this.button_number_altı.TabStop = false;
            this.button_number_altı.Text = "6";
            this.button_number_altı.UseVisualStyleBackColor = true;
            // 
            // button_number_iki
            // 
            this.button_number_iki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_number_iki.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_number_iki.ForeColor = System.Drawing.Color.White;
            this.button_number_iki.Location = new System.Drawing.Point(70, 178);
            this.button_number_iki.Name = "button_number_iki";
            this.button_number_iki.Size = new System.Drawing.Size(50, 50);
            this.button_number_iki.TabIndex = 10;
            this.button_number_iki.TabStop = false;
            this.button_number_iki.Text = "2";
            this.button_number_iki.UseVisualStyleBackColor = true;
            // 
            // button_number_4
            // 
            this.button_number_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_number_4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_number_4.ForeColor = System.Drawing.Color.White;
            this.button_number_4.Location = new System.Drawing.Point(14, 122);
            this.button_number_4.Name = "button_number_4";
            this.button_number_4.Size = new System.Drawing.Size(50, 50);
            this.button_number_4.TabIndex = 15;
            this.button_number_4.TabStop = false;
            this.button_number_4.Text = "4";
            this.button_number_4.UseVisualStyleBackColor = true;
            // 
            // button_number_bes
            // 
            this.button_number_bes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_number_bes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_number_bes.ForeColor = System.Drawing.Color.White;
            this.button_number_bes.Location = new System.Drawing.Point(70, 122);
            this.button_number_bes.Name = "button_number_bes";
            this.button_number_bes.Size = new System.Drawing.Size(50, 50);
            this.button_number_bes.TabIndex = 11;
            this.button_number_bes.TabStop = false;
            this.button_number_bes.Text = "5";
            this.button_number_bes.UseVisualStyleBackColor = true;
            // 
            // button_number_uc
            // 
            this.button_number_uc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_number_uc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_number_uc.ForeColor = System.Drawing.Color.White;
            this.button_number_uc.Location = new System.Drawing.Point(126, 178);
            this.button_number_uc.Name = "button_number_uc";
            this.button_number_uc.Size = new System.Drawing.Size(50, 50);
            this.button_number_uc.TabIndex = 14;
            this.button_number_uc.TabStop = false;
            this.button_number_uc.Text = "3";
            this.button_number_uc.UseVisualStyleBackColor = true;
            // 
            // button_number_sekiz
            // 
            this.button_number_sekiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_number_sekiz.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_number_sekiz.ForeColor = System.Drawing.Color.White;
            this.button_number_sekiz.Location = new System.Drawing.Point(70, 66);
            this.button_number_sekiz.Name = "button_number_sekiz";
            this.button_number_sekiz.Size = new System.Drawing.Size(50, 50);
            this.button_number_sekiz.TabIndex = 12;
            this.button_number_sekiz.TabStop = false;
            this.button_number_sekiz.Text = "8";
            this.button_number_sekiz.UseVisualStyleBackColor = true;
            // 
            // button_number_bir
            // 
            this.button_number_bir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_number_bir.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_number_bir.ForeColor = System.Drawing.Color.White;
            this.button_number_bir.Location = new System.Drawing.Point(14, 178);
            this.button_number_bir.Name = "button_number_bir";
            this.button_number_bir.Size = new System.Drawing.Size(50, 50);
            this.button_number_bir.TabIndex = 13;
            this.button_number_bir.TabStop = false;
            this.button_number_bir.Text = "1";
            this.button_number_bir.UseVisualStyleBackColor = true;
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
            this.radioButton_tekislem.Checked = true;
            this.radioButton_tekislem.Location = new System.Drawing.Point(177, 305);
            this.radioButton_tekislem.Name = "radioButton_tekislem";
            this.radioButton_tekislem.Size = new System.Drawing.Size(99, 25);
            this.radioButton_tekislem.TabIndex = 4;
            this.radioButton_tekislem.TabStop = true;
            this.radioButton_tekislem.Text = "Tek işlem";
            this.radioButton_tekislem.UseVisualStyleBackColor = true;
            this.radioButton_tekislem.CheckedChanged += new System.EventHandler(this.radioButton_tekislem_CheckedChanged);
            // 
            // radioButton_surekiislem
            // 
            this.radioButton_surekiislem.AutoSize = true;
            this.radioButton_surekiislem.Location = new System.Drawing.Point(42, 305);
            this.radioButton_surekiislem.Name = "radioButton_surekiislem";
            this.radioButton_surekiislem.Size = new System.Drawing.Size(126, 25);
            this.radioButton_surekiislem.TabIndex = 3;
            this.radioButton_surekiislem.Text = "Sürekli işlem";
            this.radioButton_surekiislem.UseVisualStyleBackColor = true;
            this.radioButton_surekiislem.CheckedChanged += new System.EventHandler(this.radioButton_surekiislem_CheckedChanged);
            // 
            // panel_dahaoncekiislemler
            // 
            this.panel_dahaoncekiislemler.Controls.Add(this.button_temizle);
            this.panel_dahaoncekiislemler.Controls.Add(this.listBox_dahaoncekiislemler);
            this.panel_dahaoncekiislemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_dahaoncekiislemler.Location = new System.Drawing.Point(3, 492);
            this.panel_dahaoncekiislemler.Name = "panel_dahaoncekiislemler";
            this.panel_dahaoncekiislemler.Size = new System.Drawing.Size(876, 38);
            this.panel_dahaoncekiislemler.TabIndex = 4;
            // 
            // button_temizle
            // 
            this.button_temizle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_temizle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_temizle.Location = new System.Drawing.Point(0, -15);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(876, 53);
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
            this.listBox_dahaoncekiislemler.Size = new System.Drawing.Size(876, 444);
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
            this.listBox_Listececmisi.Location = new System.Drawing.Point(3, 48);
            this.listBox_Listececmisi.Name = "listBox_Listececmisi";
            this.listBox_Listececmisi.Size = new System.Drawing.Size(876, 444);
            this.listBox_Listececmisi.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_geri_don);
            this.panel1.Controls.Add(this.button_Liste_gecmisi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 45);
            this.panel1.TabIndex = 1;
            // 
            // button_geri_don
            // 
            this.button_geri_don.BackColor = System.Drawing.Color.Black;
            this.button_geri_don.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_geri_don.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_geri_don.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_geri_don.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_geri_don.ForeColor = System.Drawing.Color.LightGray;
            this.button_geri_don.Location = new System.Drawing.Point(437, 0);
            this.button_geri_don.Name = "button_geri_don";
            this.button_geri_don.Size = new System.Drawing.Size(437, 45);
            this.button_geri_don.TabIndex = 6;
            this.button_geri_don.Text = "Geri";
            this.button_geri_don.UseVisualStyleBackColor = false;
            this.button_geri_don.Click += new System.EventHandler(this.button_geri_don_Click);
            // 
            // button_Liste_gecmisi
            // 
            this.button_Liste_gecmisi.BackColor = System.Drawing.Color.Black;
            this.button_Liste_gecmisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Liste_gecmisi.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Liste_gecmisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Liste_gecmisi.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Liste_gecmisi.ForeColor = System.Drawing.Color.LightGray;
            this.button_Liste_gecmisi.Location = new System.Drawing.Point(0, 0);
            this.button_Liste_gecmisi.Name = "button_Liste_gecmisi";
            this.button_Liste_gecmisi.Size = new System.Drawing.Size(437, 45);
            this.button_Liste_gecmisi.TabIndex = 5;
            this.button_Liste_gecmisi.Text = "Liste Geçmişi";
            this.button_Liste_gecmisi.UseVisualStyleBackColor = false;
            this.button_Liste_gecmisi.Click += new System.EventHandler(this.button_Liste_gecmisi_Click);
            // 
            // tabPage_Yol_Hız_Zaman
            // 
            this.tabPage_Yol_Hız_Zaman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabPage_Yol_Hız_Zaman.ForeColor = System.Drawing.Color.White;
            this.tabPage_Yol_Hız_Zaman.Location = new System.Drawing.Point(4, 30);
            this.tabPage_Yol_Hız_Zaman.Name = "tabPage_Yol_Hız_Zaman";
            this.tabPage_Yol_Hız_Zaman.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Yol_Hız_Zaman.Size = new System.Drawing.Size(882, 533);
            this.tabPage_Yol_Hız_Zaman.TabIndex = 1;
            this.tabPage_Yol_Hız_Zaman.Text = "Farkı İşlemler";
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(890, 567);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sembol)).EndInit();
            this.panel_number.ResumeLayout(false);
            this.panel_number.PerformLayout();
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
        private Panel panel_number;
        private Button button_number_c_sil;
        private Button button_number_eksi;
        private Button button_number_dokuz;
        private Button button_numbervirgul;
        private Button button_number_yedi;
        private Button button_number_sifir;
        private Button button_number_altı;
        private Button button_number_iki;
        private Button button_number_4;
        private Button button_number_bes;
        private Button button_number_uc;
        private Button button_number_sekiz;
        private Button button_number_bir;
        private PictureBox pictureBox_sembol;
        private Button button_geri_don;
    }
}