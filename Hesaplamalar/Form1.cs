namespace Hesaplamalar
{
    public partial class anasayfa : Form
    {
        public Hesaplama hsp = new Hesaplama();
        public double sayi1;
        public double sayi2;
        public double toplam;
        public bool sureklisilemkontrol = false;
        int durum = 1;
        // 1 deðeri toplama 2 deðeri çýkarma 3 deðeri bölme 4 deðeri bölme iþlemi 5 daha önceki iþlemler 6 geçmiþ iþlemler
        public anasayfa()
        {
            InitializeComponent();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            radioButton_surekiislem.Checked = true;
            radioButton_tekislem.Checked = false;
            maskedTextBox_Sayi1.Text = "";
            maskedTextBox_Sayi2.Text = "";
        }

        private void button_Toplama_Click(object sender, EventArgs e)
        {
            label_sembol.Text = "+";
            durum = 1;
            panel_dahaoncekiislemler.Visible = false;
            listBox_Listececmisi.Visible = false;
            panel_toplama.Visible = true;
        }

        private void button_Cikarma_Click(object sender, EventArgs e)
        {
            label_sembol.Text = "-";
            durum = 2;
            panel_dahaoncekiislemler.Visible = false;
            listBox_Listececmisi.Visible = false;
            panel_toplama.Visible = true;
        }

        private void button2_Bolme_Click(object sender, EventArgs e)
        {
            label_sembol.Text = "÷";
            durum = 4;
            panel_dahaoncekiislemler.Visible = false;
            listBox_Listececmisi.Visible = false;
            panel_toplama.Visible = true;
        }

        private void button_Carpma_Click(object sender, EventArgs e)
        {
            label_sembol.Text = "x";
            durum = 3;
            panel_dahaoncekiislemler.Visible = false;
            listBox_Listececmisi.Visible = false;
            panel_toplama.Visible = true;
        }

        private void button_Daha_onceki_islemler_Click(object sender, EventArgs e)
        {
            durum = 5;
            panel_dahaoncekiislemler.Visible = true;
            listBox_Listececmisi.Visible = false;
            panel_toplama.Visible = false;
        }

        private void button_Liste_gecmisi_Click(object sender, EventArgs e)
        {
            durum = 6;
            panel_dahaoncekiislemler.Visible = false;
            listBox_Listececmisi.Visible = true;
            panel_toplama.Visible = false;
        }
        public void hesapla()
        {
            sayi1 = Convert.ToDouble(maskedTextBox_Sayi1.Text);
            sayi2 = Convert.ToDouble(maskedTextBox_Sayi2.Text);
            if (radioButton_surekiislem.Checked == true)
            {
                if (sureklisilemkontrol == true)
                {
                    maskedTextBox_Sayi1.Enabled = false;
                    maskedTextBox_Sayi1.Text = Convert.ToString(toplam);
                    if (durum == 1)
                    {
                        label_Sonuc.Text = "Sonuç: " + (toplam = hsp.Toplama(toplam, sayi2));
                        maskedTextBox_Sayi1.Text = Convert.ToString(toplam);
                        sureklisilemkontrol = true;
                    }
                    if (durum == 2)
                    {
                        label_Sonuc.Text = "Sonuç: " + (toplam = hsp.Cikartma(toplam, sayi2));
                        maskedTextBox_Sayi1.Text = Convert.ToString(toplam);
                        sureklisilemkontrol = true;
                    }
                    if (durum == 3)
                    {
                        label_Sonuc.Text = "Sonuç: " + (toplam = hsp.Carpma(toplam, sayi2));
                        maskedTextBox_Sayi1.Text = Convert.ToString(toplam);
                        sureklisilemkontrol = true;
                    }
                    if (durum == 4)
                    {
                        label_Sonuc.Text = "Sonuç: " + (toplam = hsp.Bolme(toplam, sayi2)) + " Kalan: " + hsp.kalanbolme(toplam, sayi2);
                        maskedTextBox_Sayi1.Text = Convert.ToString(toplam);
                        sureklisilemkontrol = true;
                    }
                }
                if (sureklisilemkontrol == false)
                {
                    maskedTextBox_Sayi1.Enabled = true;
                    if (durum == 1)
                    {
                        label_Sonuc.Text = "Sonuç: " + (toplam = hsp.Toplama(sayi1, sayi2));
                        sureklisilemkontrol = true;
                    }
                    if (durum == 2)
                    {
                        label_Sonuc.Text = "Sonuç: " + (toplam = hsp.Cikartma(sayi1, sayi2));
                        sureklisilemkontrol = true;
                    }
                    if (durum == 3)
                    {
                        label_Sonuc.Text = "Sonuç: " + (toplam = hsp.Carpma(sayi1, sayi2));
                        sureklisilemkontrol = true;
                    }
                    if (durum == 4)
                    {
                        label_Sonuc.Text = "Sonuç: " + (toplam = hsp.Bolme(sayi1, sayi2)) + " Kalan: " + hsp.kalanbolme(sayi2, sayi2);
                        sureklisilemkontrol = true;
                    }
                }
            }
            if (radioButton_tekislem.Checked == true)
            {
                maskedTextBox_Sayi1.Enabled = true;
                if (durum == 1)
                {
                    label_Sonuc.Text = "Sonuç: " + (toplam = hsp.Toplama(sayi1, sayi2));
                    sureklisilemkontrol = true;
                }
                if (durum == 2)
                {
                    label_Sonuc.Text = "Sonuç: " + (toplam = hsp.Cikartma(sayi1, sayi2));
                    sureklisilemkontrol = true;
                }
                if (durum == 3)
                {
                    label_Sonuc.Text = "Sonuç: " + (toplam = hsp.Carpma(sayi1, sayi2));
                    sureklisilemkontrol = true;
                }
                if (durum == 4)
                {
                    label_Sonuc.Text = "Sonuç: " + (toplam = hsp.Bolme(sayi1, sayi2)) + " Kalan: " + hsp.kalanbolme(sayi2, sayi2);
                    sureklisilemkontrol = true;
                }
            }
            listBox_dahaoncekiislemler.Items.Add(sayi1 + label_sembol.Text + toplam);
        }

        private void maskedTextBox_Sayi2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                hesapla();
            }
        }
        private void button_topla_sonuc_Click(object sender, EventArgs e)
        {
            hesapla();
        }

        private void maskedTextBox_Sayi1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-';
        }

        private void maskedTextBox_Sayi2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-';
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            listBox_dahaoncekiislemler.Items.Clear();
        }

        private void button_CE_sil_Click(object sender, EventArgs e)
        {
            maskedTextBox_Sayi1.Text = "";
            maskedTextBox_Sayi2.Text = "";
            label_Sonuc.Text = "Sonuç: ";
            sayi1 = 0;
            sayi2 = 0;
            toplam = 0;
        }
    }
}