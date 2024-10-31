namespace GenelAracKullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void combobaxaOgeEkle_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Antalya");
        }

        private void listboxOgeEkle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listboxBilgi.Items.Add(textBox3.Text + " " + textBox7.Text + " " + textBox5.Text + " " + textBox6.Text + " " + textBox4.Text);

        }
    }
}