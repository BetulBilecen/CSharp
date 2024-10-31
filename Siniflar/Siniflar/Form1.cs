namespace Siniflar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Class1 araba = new Class1();
            araba.renk = "Mavi";
            araba.hiz = 160;
            araba.motor = 1245.56;
            araba.fiyat = 1000000000;
            araba.durum = 's';
            araba.YIL = -2016;
            araba.MARKA = "Golf";

            label1.Text = araba.renk; ;
            label2.Text = araba.hiz.ToString();
            label3.Text = araba.motor.ToString(); ;
            label4.Text = araba.fiyat.ToString();
            label5.Text = araba.durum.ToString();
            label6.Text = araba.YIL.ToString();
            label7.Text = araba.MARKA.ToString();

            pictureBox1.BackColor = Color.CadetBlue;
        }
    }
}