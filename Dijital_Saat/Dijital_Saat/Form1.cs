namespace Dijital_Saat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int saniye = 0, dakika = 0, saat = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            labelSaniyeBirlerBasamagi.Text = saniye.ToString();
            if (saniye == 60)
            {
                dakika++;
                saniye = 0;
                labelDakikaOnlarBasamagi.Text = dakika.ToString();
            }

            if (dakika == 60)
            {
                saat++;
                dakika = 0;
                labelSaatBirlerBasamagi.Text = saat.ToString();
            }

            if (saat == 23 && dakika == 59 && saniye == 59)
            {
                saat = 0;
                dakika = 0;
                saniye = 0;
            }
        }
    }
}