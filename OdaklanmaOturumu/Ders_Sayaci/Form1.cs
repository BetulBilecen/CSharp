namespace Ders_Sayaci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        int hour = 0, moment = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelMoment.Text = moment.ToString();
            moment++;
            if (moment == 59)
            {
                moment = 0;
                hour++;
                labelHour.Text = hour.ToString();
            }


        }

        bool key;
        int key2 = 1;
        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (hour < 2)
                key = true;

            if (key)
            {
                timer1.Stop();
                MessageBox.Show("HAAAADÝ AMAAAAAA \n BU  KADAR MI ÇALICAKSIN\n\t\tKENDÝNE GEL ");
                pictureBox2.Visible = true;
                key2 *= -1;
            }

            else
            {
                pictureBox1.Visible = true;
                hour = 0;
                moment = 0;
                labelHour.Text = "00";
                labelMoment.Text = "00";
                timer1.Stop();

            }

            if (key2 == 1)
            {
                pictureBox2.Visible = false;
                hour = 0;
                moment = 0;
                labelHour.Text = "00";
                labelMoment.Text = "00";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}