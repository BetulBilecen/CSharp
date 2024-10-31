using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//FORM1'İ ÇALIŞTIRMAK İÇİN ÇÖZÜM GEZGİNİN EN ALTINDA YAZAN Program:cs'YE ÇİFT TIKLA Form2
 //YAZAN YERE Form1 YAZ
namespace Siniflar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Class1 araba2 = new Class1(); ;
            araba2.renk = "Yeşil";
            araba2.durum = 'i';
            araba2.hiz = 140;
            araba2.fiyat = 35982;
            araba2.motor = 1220.36;

            label1.Text = araba2.renk;
            label2.Text = araba2.hiz.ToString();
            label3.Text = araba2.motor.ToString();
            label4.Text=araba2.fiyat.ToString();
            label5.Text=araba2.durum.ToString();

            pictureBox1.BackColor = Color.LightSeaGreen;
        }
    }
}
