namespace Ucus_Rezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text + "- " + comboBox2.Text + " " + maskedTextBox4.Text + " " + maskedTextBox1.Text + " " + maskedTextBox2.Text + " " + textBox1.Text + " " + maskedTextBox3.Text);
            MessageBox.Show("Yolcu Kayýt Ýþlemi Baþarýyla Tamamlanmýþtýr. \nTebrikler :");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string degisim;
            degisim = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = degisim;
        }
    }
}