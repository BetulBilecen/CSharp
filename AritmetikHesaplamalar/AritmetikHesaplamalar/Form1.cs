namespace AritmetikHesaplamalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int alan, cevre;
            alan = (Convert.ToInt32(textBox1.Text)) * (Convert.ToInt32(textBox2.Text));
            cevre = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)) * 2;

            labelAlanGoster.Text = alan.ToString();
            labelCevreGoster.Text = cevre.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam, carpim, bolum, fark;
            sayi1 = Convert.ToInt32(textBoxSayi1.Text);
            sayi2 = Convert.ToInt32(textBoxSayi2.Text);

            toplam = sayi1 + sayi2;
            if (sayi1 > sayi2)
                fark = sayi1 - sayi2;
            else if (sayi1 == sayi2)
                fark = 0;
            else
                fark = sayi2 - sayi1;

            carpim = sayi1 * sayi2;
            bolum = sayi1 / sayi2;

            MessageBox.Show("TOPLAM: " + toplam + "\nFARK: " + fark + "\nBÖLÜM: " + bolum + "\nÇARPIM: " + carpim);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int not1, not2, notProje;
            double ortalama;

            not1 = Convert.ToInt16(textBoxSinav1.Text);
            not2 = Convert.ToInt16(textBoxSýnav2.Text);
            notProje = Convert.ToInt16(textBoxproje.Text);

            ortalama = (not1 + not2 + notProje) / 3.0;
            listBox1.Items.Add(textBoxIsim.Text + " Ortalamasý: " + ortalama.ToString("0.00")); //basamak hassasiyeti için .ToString("0.00") kullanýldý
            if (ortalama < 70 && ortalama >= 48)
                listBox1.Items.Add(textBoxIsim.Text + " adlý öðrenci sýnýfý þartlý geçti \n");
            else if (ortalama >= 70)
                listBox1.Items.Add(textBoxIsim.Text + " adlý öðrenci sýnýfý baþarýyla geçti \n");
            else
                listBox1.Items.Add(textBoxIsim.Text + " adlý öðrenci sýnýfta kaldý \n");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //label 11 8 ve label 12 diðerin sonucu
            string ad = textBoxUrunAd.Text;
            float fiyat = Convert.ToSingle(textBoxUrunFiyat.Text), kdv8, kdv18;
            kdv8 = (fiyat * 8) / 100 + fiyat;
            kdv18 = (fiyat * 18) / 100 + fiyat;

            label12.Text = ad + kdv8;
            label11.Text = ad + kdv18;

        }
    }
}