namespace SinemaBufeUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //35 TL  30TL 10TL 5TL 12TL 55TL
            /* Mýsýr:
cips:
Fanta:
çay:
Kola:
Bilet:
*/
            int ucretMisir = Convert.ToInt16(textBoxMisir.Text) * 35,
                ucretCips = Convert.ToInt16(textBoxCips.Text) * 30,
                ucretFanta = Convert.ToInt16(textBoxFanta.Text) * 10,
               ucretCay = Convert.ToInt16(textBoxCay.Text) * 5,
                ucretKola = Convert.ToInt16(textBoxKola.Text) * 12,
                ucretBilet = Convert.ToInt16(textBoxBilet.Text) * 55;
            float toplamTutar;
            toplamTutar = ucretBilet + ucretCay + ucretCips + ucretKola + ucretMisir;
            label20.Text = toplamTutar.ToString("0.00");


        }
    }
}