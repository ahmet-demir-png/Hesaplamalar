namespace Hesaplamalar
{
    public partial class anasayfa : Form
    {
        public Hesaplama hsp = new Hesaplama();
        public double sayi1;
        public double sayi2;
        public double toplam;
        public bool sureklisilemkontrol = false;
        int durum_4islem = 1;
        int durum_farkli_islem = 1;
        string islemmodu = "+";
        //  DURUM değer : 1 değeri toplama, 2 değeri çıkarma, 3 değeri bölme, 4 değeri bölme, 5 değeri daha öneci işlemler, 6 değeri liste geçmişi.
        public anasayfa()
        {
            InitializeComponent();
        }
        private void anasayfa_Load(object sender, EventArgs e)
        {
            if (durum_4islem == 1)
            {
                radioButton_surekiislem.Checked = false;
                radioButton_tekislem.Checked = true;
                maskedTextBox_Sayi1.Text = "";
                maskedTextBox_Sayi2.Text = "";
                panel_dahaoncekiislemler.Visible = false;
                panel_toplama.Visible = true;
            }
            if(durum_farkli_islem == 1)
            {
                maskedTextBox_a.Text = "";
                maskedTextBox_b.Text = "";
                maskedTextBox_c.Text = "";
            }
        }

        private void button_Toplama_Click(object sender, EventArgs e)
        {
            islemmodu = "+";
            durum_4islem = 1;
            panel_dahaoncekiislemler.Visible = false;
            panel_toplama.Visible = true;
            pictureBox_sembol.BackgroundImage = new Bitmap(@"A:\bilgisiyarim\Masaustu\Visual-studio-projeleri\staj-zamaninda-yaptigim-dosyalar\Hesaplamalar\Hesaplamalar\Resources\Toplama-isareti.png");
            //Resources dosyasında bulunan fotoğrafı dosya konumu yapıştırdık
        }
        private void button_Cikarma_Click(object sender, EventArgs e)
        {
            islemmodu = "−";
            durum_4islem = 2;
            panel_dahaoncekiislemler.Visible = false;
            panel_toplama.Visible = true;
            pictureBox_sembol.BackgroundImage = new Bitmap(@"A:\bilgisiyarim\Masaustu\Visual-studio-projeleri\staj-zamaninda-yaptigim-dosyalar\Hesaplamalar\Hesaplamalar\Resources\Eksi-isareti.png");
        }
        private void button2_Bolme_Click(object sender, EventArgs e)
        {
            islemmodu = "÷";
            durum_4islem = 4;
            panel_dahaoncekiislemler.Visible = false;
            panel_toplama.Visible = true;
            pictureBox_sembol.BackgroundImage = new Bitmap(@"A:\bilgisiyarim\Masaustu\Visual-studio-projeleri\staj-zamaninda-yaptigim-dosyalar\Hesaplamalar\Hesaplamalar\Resources\Bolme-islemi.png");
        }
        private void button_Carpma_Click(object sender, EventArgs e)
        {
            islemmodu = "×";
            durum_4islem = 3;
            panel_dahaoncekiislemler.Visible = false;
            panel_toplama.Visible = true;
            pictureBox_sembol.BackgroundImage = new Bitmap(@"A:\bilgisiyarim\Masaustu\Visual-studio-projeleri\staj-zamaninda-yaptigim-dosyalar\Hesaplamalar\Hesaplamalar\Resources\carpma-isareti.png");
        }
        private void button_Daha_onceki_islemler_Click(object sender, EventArgs e)
        {
            durum_4islem = 5;
            panel_dahaoncekiislemler.Visible = true;
            panel_toplama.Visible = false;
        }

        // Hesaplama ve sonuç işlemleri
        public void hesapla_4islem()   
        {
            sayi1 = Convert.ToDouble(maskedTextBox_Sayi1.Text);
            sayi2 = Convert.ToDouble(maskedTextBox_Sayi2.Text);

            if (radioButton_surekiislem.Checked == true)
            {
                if (sureklisilemkontrol == true)
                {
                    maskedTextBox_Sayi1.Enabled = false;
                    maskedTextBox_Sayi1.Text = Convert.ToString(toplam);
                    if (durum_4islem == 1)
                    {
                        label_Sonuc.Text = "Sonuç: " + (toplam = hsp.Toplama(toplam, sayi2));
                        maskedTextBox_Sayi1.Text = Convert.ToString(toplam);
                        sureklisilemkontrol = true;
                    }
                    if (durum_4islem == 2)
                    {
                        label_Sonuc.Text = "Sonuç: " + (toplam = hsp.Cikartma(toplam, sayi2));
                        maskedTextBox_Sayi1.Text = Convert.ToString(toplam);
                        sureklisilemkontrol = true;
                    }
                    if (durum_4islem == 3)
                    {
                        label_Sonuc.Text = "Sonuç: " + (toplam = hsp.Carpma(toplam, sayi2));
                        maskedTextBox_Sayi1.Text = Convert.ToString(toplam);
                        sureklisilemkontrol = true;
                    }
                    if (durum_4islem == 4)
                    {
                        label_Sonuc.Text = "Sonuç: " + (toplam = hsp.Bolme(toplam, sayi2)) + " Kalan: " + hsp.kalanbolme(toplam, sayi2);
                        maskedTextBox_Sayi1.Text = Convert.ToString(toplam);
                        sureklisilemkontrol = true;
                    }
                }
                if (sureklisilemkontrol == false)
                {
                    maskedTextBox_Sayi1.Enabled = true;
                    if (durum_4islem == 1)
                    {
                        label_Sonuc.Text = "Sonuç: " + (toplam = hsp.Toplama(sayi1, sayi2));
                        sureklisilemkontrol = true;
                    }
                    if (durum_4islem == 2)
                    {
                        label_Sonuc.Text = "Sonuç: " + (toplam = hsp.Cikartma(sayi1, sayi2));
                        sureklisilemkontrol = true;
                    }
                    if (durum_4islem == 3)
                    {
                        label_Sonuc.Text = "Sonuç: " + (toplam = hsp.Carpma(sayi1, sayi2));
                        sureklisilemkontrol = true;
                    }
                    if (durum_4islem == 4)
                    {
                        label_Sonuc.Text = "Sonuç: " + (toplam = hsp.Bolme(sayi1, sayi2)) + " Kalan: " + hsp.kalanbolme(sayi2, sayi2);
                        sureklisilemkontrol = true;
                    }
                }
            }
            if (radioButton_tekislem.Checked == true)
            {
                maskedTextBox_Sayi1.Enabled = true;
                if (durum_4islem == 1)
                {
                    label_Sonuc.Text = "Sonuç: " + (toplam = hsp.Toplama(sayi1, sayi2));
                    sureklisilemkontrol = true;
                }
                if (durum_4islem == 2)
                {
                    label_Sonuc.Text = "Sonuç: " + (toplam = hsp.Cikartma(sayi1, sayi2));
                    sureklisilemkontrol = true;
                }
                if (durum_4islem == 3)
                {
                    label_Sonuc.Text = "Sonuç: " + (toplam = hsp.Carpma(sayi1, sayi2));
                    sureklisilemkontrol = true;
                }
                if (durum_4islem == 4)
                {
                    label_Sonuc.Text = "Sonuç: " + (toplam = hsp.Bolme(sayi1, sayi2)) + " Kalan: " + hsp.kalanbolme(sayi2, sayi2);
                    sureklisilemkontrol = true;
                }
            }
            listBox_Listececmisi.Items.Add(sayi1 + islemmodu + sayi2 + " = " + toplam);
            listBox_dahaoncekiislemler.Items.Add(sayi1 + islemmodu + sayi2 + " = " + toplam);
        }
        private void maskedTextBox_Sayi2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(maskedTextBox_Sayi2.Text) || string.IsNullOrEmpty(maskedTextBox_Sayi1.Text))
                {
                    MessageBox.Show("Boş bakamazsınız");
                }
                else
                {
                    hesapla_4islem();
                }
            }
        }
        private void button_topla_sonuc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBox_Sayi2.Text) || string.IsNullOrEmpty(maskedTextBox_Sayi1.Text))
            {
                MessageBox.Show("Boş bakamazsınız");
            }
            else
            {
                hesapla_4islem();
            }
        }

        //MaskedTextBoXların olduğu bölge
        private void maskedTextBox_Sayi1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void maskedTextBox_Sayi2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) /*&& e.KeyChar != ',' && e.KeyChar != '-'*/;
        }
        private void maskedTextBox_Sayi1_Click(object sender, EventArgs e)
        {
            if (odaktext2 == true)
            {
                odaktext2 = false;
            }
            odaktext1 = true;
        }
        private void maskedTextBox_Sayi2_Click(object sender, EventArgs e)
        {
            if (odaktext1 == true)
            {
                odaktext1 = false;
            }
            odaktext2 = true;
        }

        //Butonların işlemleri
        private void button_temizle_Click(object sender, EventArgs e)
        {
            listBox_dahaoncekiislemler.Items.Clear();
        }
        private void button_CE_sil_Click(object sender, EventArgs e)
        {
            if (odaktext1 == true)
            {
                maskedTextBox_Sayi1.Text = "";
            }
            if (odaktext2 == true)
            {
                maskedTextBox_Sayi2.Text = "";
            }
        }
        private void button_number_c_sil_Click(object sender, EventArgs e)
        {
            maskedTextBox_Sayi1.Text = "";
            maskedTextBox_Sayi2.Text = "";
            label_Sonuc.Text = "Sonuç: ";
            sayi1 = 0;
            sayi2 = 0;
            toplam = 0;
        }
        private void button_geri_don_Click(object sender, EventArgs e)
        {
            islemmodu = "+";
            durum_4islem = 1;
            panel_dahaoncekiislemler.Visible = false;
            panel_toplama.Visible = true;
            pictureBox_sembol.BackgroundImage = new Bitmap(@"A:\bilgisiyarim\Masaustu\Visual-studio-projeleri\staj-zamaninda-yaptigim-dosyalar\Hesaplamalar\Hesaplamalar\Resources\Toplama-isareti.png");
            //Resources dosyasında bulunan fotoğrafı dosya konumu yapıştırdık
        }

        //Radio Butonlarının oldğu kısım
        private void radioButton_surekiislem_CheckedChanged(object sender, EventArgs e)
        {
            if(sureklisilemkontrol == false)
            {
                radioButton_tekislem.Checked = true;
                MessageBox.Show("Önce Tekil işlem yapmanız gerekiyor. Ön işlem yapılmamıştır.");
            }
            if (sureklisilemkontrol == true)
            {
                maskedTextBox_Sayi1.Text = Convert.ToString(toplam);
                maskedTextBox_Sayi1.Enabled = false;
            }

        }
        private void radioButton_tekislem_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox_Sayi1.Enabled = true;
        }

        //Number button bolgesinde değerler
        bool odaktext1 = true;
        bool odaktext2 = false;
        private void button_number_sifir_Click(object sender, EventArgs e)
        {
            if(odaktext1 == true)
            {
                maskedTextBox_Sayi1.Text = maskedTextBox_Sayi1.Text + "0";
            }
            if (odaktext2 == true)
            {
                maskedTextBox_Sayi2.Text = maskedTextBox_Sayi2.Text + "0";
            }

        }
        private void button_number_bir_Click(object sender, EventArgs e)
        {
            if (odaktext1 == true)
            {
                maskedTextBox_Sayi1.Text = maskedTextBox_Sayi1.Text + "1";
            }
            if (odaktext2 == true)
            {
                maskedTextBox_Sayi2.Text = maskedTextBox_Sayi2.Text + "1";
            }
        }
        private void button_number_iki_Click(object sender, EventArgs e)
        {
            if (odaktext1 == true)
            {
                maskedTextBox_Sayi1.Text = maskedTextBox_Sayi1.Text + "2";
            }
            if (odaktext2 == true)
            {
                maskedTextBox_Sayi2.Text = maskedTextBox_Sayi2.Text + "2";
            }
        }
        private void button_number_uc_Click(object sender, EventArgs e)
        {
            if (odaktext1 == true)
            {
                maskedTextBox_Sayi1.Text = maskedTextBox_Sayi1.Text + "3";
            }
            if (odaktext2 == true)
            {
                maskedTextBox_Sayi2.Text = maskedTextBox_Sayi2.Text + "3";
            }
        }
        private void button_number_4_Click(object sender, EventArgs e)
        {
            if (odaktext1 == true)
            {
                maskedTextBox_Sayi1.Text = maskedTextBox_Sayi1.Text + "4";
            }
            if (odaktext2 == true)
            {
                maskedTextBox_Sayi2.Text = maskedTextBox_Sayi2.Text + "4";
            }
        }
        private void button_number_bes_Click(object sender, EventArgs e)
        {
            if (odaktext1 == true)
            {
                maskedTextBox_Sayi1.Text = maskedTextBox_Sayi1.Text + "5";
            }
            if (odaktext2 == true)
            {
                maskedTextBox_Sayi2.Text = maskedTextBox_Sayi2.Text + "5";
            }
        }
        private void button_number_altı_Click(object sender, EventArgs e)
        {
            if (odaktext1 == true)
            {
                maskedTextBox_Sayi1.Text = maskedTextBox_Sayi1.Text + "6";
            }
            if (odaktext2 == true)
            {
                maskedTextBox_Sayi2.Text = maskedTextBox_Sayi2.Text + "6";
            }
        }
        private void button_number_yedi_Click(object sender, EventArgs e)
        {
            if (odaktext1 == true)
            {
                maskedTextBox_Sayi1.Text = maskedTextBox_Sayi1.Text + "7";
            }
            if (odaktext2 == true)
            {
                maskedTextBox_Sayi2.Text = maskedTextBox_Sayi2.Text + "7";
            }
        }
        private void button_number_sekiz_Click(object sender, EventArgs e)
        {
            if (odaktext1 == true)
            {
                maskedTextBox_Sayi1.Text = maskedTextBox_Sayi1.Text + "8";
            }
            if (odaktext2 == true)
            {
                maskedTextBox_Sayi2.Text = maskedTextBox_Sayi2.Text + "8";
            }
        }
        private void button_number_dokuz_Click(object sender, EventArgs e)
        {
            if (odaktext1 == true)
            {
                maskedTextBox_Sayi1.Text = maskedTextBox_Sayi1.Text + "9";
            }
            if (odaktext2 == true)
            {
                maskedTextBox_Sayi2.Text = maskedTextBox_Sayi2.Text + "9";
            }
        }
        private void button_number_eksi_Click(object sender, EventArgs e)
        {
            if (odaktext1 == true)
            {
                if(maskedTextBox_Sayi1.Text.Contains("-") == true)
                {
                    MessageBox.Show("Zaten bir tane kullanmışsınız");
                }
                else
                {
                    maskedTextBox_Sayi1.Text = "-" + maskedTextBox_Sayi1.Text;
                }
            }
            if (odaktext2 == true)
            {
                if (maskedTextBox_Sayi2.Text.Contains("-") == true)
                {
                    MessageBox.Show("Zaten bir tane kullanmışsınız");
                }
                else
                {
                    maskedTextBox_Sayi2.Text = "-" + maskedTextBox_Sayi2.Text;
                }
            }
        }
        private void button_numbervirgul_Click(object sender, EventArgs e)
        {
            if (odaktext1 == true)
            {
                if (maskedTextBox_Sayi1.Text.Contains(",") == true)
                {
                    MessageBox.Show("Zaten bir tane kullanmışsınız");
                }
                else
                {
                    maskedTextBox_Sayi1.Text = maskedTextBox_Sayi1.Text + ",";
                }
            }
            if (odaktext2 == true)
            {
                if (maskedTextBox_Sayi2.Text.Contains(",") == true)
                {
                    MessageBox.Show("Zaten bir tane kullanmışsınız");
                }
                else
                {
                    maskedTextBox_Sayi2.Text = maskedTextBox_Sayi2.Text + ",";
                }
            }
        }

        //Farkı işlemler alanı __________________________________________________________________________

        private void button_dairealan_Click(object sender, EventArgs e)
        {
            durum_farkli_islem = 1;
        }

        private void button_dairecevre_Click(object sender, EventArgs e)
        {
            durum_farkli_islem = 2;
        }

        private void button_dikdortgenalan_Click(object sender, EventArgs e)
        {
            durum_farkli_islem = 3;
        }

        private void button_dikdortgencevre_Click(object sender, EventArgs e)
        {
            durum_farkli_islem = 4;
        }

        private void button_karealan_Click(object sender, EventArgs e)
        {
            durum_farkli_islem = 5;
        }

        private void button_karecevre_Click(object sender, EventArgs e)
        {
            durum_farkli_islem = 6;
        }

        private void button_yolhesap_Click(object sender, EventArgs e)
        {
            durum_farkli_islem = 7;
        }

        private void button_hizhesap_Click(object sender, EventArgs e)
        {
            durum_farkli_islem =8;
        }

        private void button_zamanhesap_Click(object sender, EventArgs e)
        {
            durum_farkli_islem = 9;
        }

        private void hesapla_farkli()
        {
            if(durum_farkli_islem == 1)
            {
                label_a.Text = "Dairenin Yarı Çapı Giriniz:";
            }
        }

        private void button_2_number_equals_Click(object sender, EventArgs e)
        {

        }
    }
}