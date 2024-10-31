namespace Uygulama2_BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int soruNo = 0, dogru = 0, yanlis = 0;
        public void IsikKapat()
        {
            // YANAN TÜM IÞIKLARI KAPAT
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }

        private void buttonSonraki_Click(object sender, EventArgs e)
        {
            soruNo++;
            labelSoruSayisi.Text = soruNo.ToString();

            if (soruNo == 1)
            {

                richTextBox1.Text = "Cumhuriyet ne zaman ilan edilmiþtir?";
                buttonA.Text = "1920";
                buttonB.Text = "1921";
                buttonC.Text = "1922";
                buttonD.Text = "1923";
            }
            IsikKapat();


            if (soruNo == 2)
            {
                richTextBox1.Text = "Hangi il Ege bölgesinde bulunmaz?";
                buttonA.Text = "Ýzmir";
                buttonB.Text = "Balýkesir";
                buttonC.Text = "Aydýn";
                buttonD.Text = "Manisa";
            }
            IsikKapat();
            if (soruNo == 3)
            {
                richTextBox1.Text = "Son Kuþlar hangi yazarýmýza ait bir eserdir?";
                buttonA.Text = "Sait Faik";
                buttonB.Text = "Cemal Süreya";
                buttonC.Text = "Attila Ýlhan";
                buttonD.Text = "Reþat Nuri";
            }
            IsikKapat();

            if (soruNo == 4)
            {
                richTextBox1.Text = "Fatih Sultan Mehmet'in babasý kimdir?";
                buttonA.Text = "2.Murat";
                buttonB.Text = "1.Mehmet";
                buttonC.Text = "Yýldýrým Beyazýt";
                buttonD.Text = "Kanûnî Sultan Süleyman";
            }
            IsikKapat();

            if (soruNo == 5)
            {
                richTextBox1.Text = "Galatasaray hangi yýl UEFA kupasýný almýþtýr?";
                buttonA.Text = "1998";
                buttonB.Text = "2001";
                buttonC.Text = "2000";
                buttonD.Text = "2002";
            }
            IsikKapat();

            if (soruNo == 6)
            {
                richTextBox1.Text = "Hangi ülke Asya kýtasýndadýr?";
                buttonA.Text = "Madagaskar";
                buttonB.Text = "Singapur";
                buttonC.Text = "Peru";
                buttonD.Text = "Kanada";
            }
            IsikKapat();

            if (soruNo == 7)
            {
                richTextBox1.Text = "Hangisi Kanûnî Sultan Süleyman'ýn eþidir?";
                buttonA.Text = "Kösem Sultan";
                buttonB.Text = "Safiye Sultan";
                buttonC.Text = "Hürrem Sultan";
                buttonD.Text = "Nurbanu Sultan";
            }
            IsikKapat();

            if (soruNo == 8)
            {
                richTextBox1.Text = "Osmanlý Ýmparatorluðu yaklaþýk kaç asýr hüküm sürmüþtür?";
                buttonA.Text = "5";
                buttonB.Text = "7";
                buttonC.Text = "9";
                buttonD.Text = "6";
            }
            IsikKapat();

            if (soruNo == 9)
            {
                richTextBox1.Text = "Türk Silahlý Kuvvetlerinde hangi rütbe daha yüksektir?";
                buttonA.Text = "Korgeneral";
                buttonB.Text = "Tümgeneral";
                buttonC.Text = "Tuðgeneral";
                buttonD.Text = "Orgeneral";
            }
            IsikKapat();

            if (soruNo == 10)
            {
                richTextBox1.Text = "Kaç yýlda bir Þubat ayý 29 çeker?";
                buttonA.Text = "3";
                buttonB.Text = "5";
                buttonC.Text = "4";
                buttonD.Text = "8";
            }
            IsikKapat();

            if (soruNo == 11)
            {
                richTextBox1.Text = "Yarýþma bitmiþtir!";

                buttonSonraki.Visible = false;
                buttonA.Visible = false;
                buttonB.Visible = false;
                buttonC.Visible = false;
                buttonD.Visible = false;

                label4.Visible = false;

                if (dogru > yanlis)
                    richTextBox1.Text += "\nKazandýnýz :)";
                else 
                    richTextBox1.Text += "\n Kaybettiniz :(";
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            switch (soruNo)
            {
                case 1: //1.SORUNUN DOÐRU CEVABI
                    pictureBox1.Visible = true;
                    dogru++;
                    labelDogruSoru.Text = dogru.ToString();
                    label4.Text = "1923"; break;

                case 2:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Balýkesir";
                    break;

                case 3:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    break;

                case 4:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "2.Murat";
                    break;

                case 5:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "2000";
                    break;

                case 6:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Singapur";
                    break;

                case 7:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Hürrem Sultan";
                    break;

                case 8: //8.SORUNUN DOÐRU CEVABI
                    pictureBox1.Visible = true;
                    dogru++;
                    labelDogruSoru.Text = dogru.ToString();
                    label4.Text = "6"; break;

                case 9: //9.SORUNUN DOÐRU CEVABI
                    pictureBox1.Visible = true;
                    dogru++;
                    labelDogruSoru.Text = dogru.ToString();
                    label4.Text = "Orgeneral"; break;

                case 10:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "4";
                    break;

            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            switch (soruNo)
            {
                case 1:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "1923";
                    break;

                case 2:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Balýkesir";
                    break;

                case 3: //3.SORUNUN DOÐRU CEVABI
                    pictureBox1.Visible = true;
                    dogru++;
                    labelDogruSoru.Text = dogru.ToString();
                    label4.Text = "Sait Faik"; break;

                case 4: //4.SORUNUN DOÐRU CEVABI
                    pictureBox1.Visible = true;
                    dogru++;
                    labelDogruSoru.Text = dogru.ToString();
                    label4.Text = "2.Murat"; break;

                case 5:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "2000";
                    break;

                case 6:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Singapur";
                    break;

                case 7:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Hürrem Sultan";
                    break;

                case 8:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "6";
                    break;

                case 9:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Orgeneral";
                    break;

                case 10:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "4";
                    break;
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            switch (soruNo)
            {
                case 1:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "1923";
                    break;

                case 2: //ÝKÝNCÝ SORUNUN DÐRU CEVABI
                    pictureBox1.Visible = true;
                    dogru++;
                    labelDogruSoru.Text = dogru.ToString();
                    label4.Text = "Balýkesir"; break;

                case 3:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Sait Faik";
                    break;

                case 4:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "2.Murat";
                    break;

                case 5:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "2000";
                    break;

                case 6: //6.SORUNUN DOÐRU CEVABI
                    pictureBox1.Visible = true;
                    dogru++;
                    labelDogruSoru.Text = dogru.ToString();
                    label4.Text = "Singapur"; break;

                case 7:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Hürrem Sultan";
                    break;

                case 8:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "6";
                    break;

                case 9:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Orgeneral";
                    break;

                case 10:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "4";
                    break;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            switch (soruNo)
            {
                case 1:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "1923";
                    break;

                case 2:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Balýkesir";
                    break;

                case 3:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Sait Faik";
                    break;

                case 4:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "2.Murat";
                    break;

                case 5: //5.SORUNUN DOÐRU CEVABI
                    pictureBox1.Visible = true;
                    dogru++;
                    labelDogruSoru.Text = dogru.ToString();
                    label4.Text = "2000"; break;

                case 6:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Singapur";
                    break;

                case 7: //7.SORUNUN DOÐRU CEVABI
                    pictureBox1.Visible = true;
                    dogru++;
                    labelDogruSoru.Text = dogru.ToString();
                    label4.Text = "Hürrem Sultan"; break;

                case 8:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "6";
                    break;

                case 9:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Orgeneral";
                    break;

                case 10: //10.SORUNUN DOÐRU CEVABI
                    pictureBox1.Visible = true;
                    dogru++;
                    labelDogruSoru.Text = dogru.ToString();
                    label4.Text = "4"; break;
            }
        }
    }
}