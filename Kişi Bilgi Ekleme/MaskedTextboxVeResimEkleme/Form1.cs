namespace MaskedTextboxVeResimEkleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBilgiEkle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(maskedTextBox2.Text + " " + maskedTextBox1.Text + " " + maskedTextBox3.Text + " " + maskedTextBox4.Text);
        }

        private void buttonTarihEkle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Ýþlem Tarihi: " + dateTimePicker1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Text = " ";
        }
    }
}