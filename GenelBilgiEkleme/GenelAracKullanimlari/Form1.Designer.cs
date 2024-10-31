namespace GenelAracKullanimlari
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            combobaxaOgeEkle = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            label1 = new Label();
            listboxOgeEkle = new Button();
            textBox2 = new TextBox();
            panel1 = new Panel();
            listboxBilgi = new ListBox();
            button2 = new Button();
            groupBox1 = new GroupBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            Maas = new Label();
            Meslek = new Label();
            Yas = new Label();
            Soyad = new Label();
            Ad = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bursa", "Ankara", "Balıkesir", "Elazığ", "Malatya", "İstanbul", "Kastamonu" });
            comboBox1.Location = new Point(2, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(217, 28);
            comboBox1.TabIndex = 0;
            // 
            // combobaxaOgeEkle
            // 
            combobaxaOgeEkle.BackColor = SystemColors.ControlLight;
            combobaxaOgeEkle.Location = new Point(2, 69);
            combobaxaOgeEkle.Name = "combobaxaOgeEkle";
            combobaxaOgeEkle.Size = new Size(92, 27);
            combobaxaOgeEkle.TabIndex = 1;
            combobaxaOgeEkle.Text = "Şehir Ekle";
            combobaxaOgeEkle.UseVisualStyleBackColor = false;
            combobaxaOgeEkle.Click += combobaxaOgeEkle_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Location = new Point(2, 114);
            button1.Name = "button1";
            button1.Size = new Size(105, 27);
            button1.TabIndex = 2;
            button1.Text = "Antalya Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 27);
            textBox1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Mühendis", "Öğretmen", "Doktor", "Manav", "Müdür", "Manav", "Kuryeci", "Pilot" });
            listBox1.Location = new Point(2, 207);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(273, 204);
            listBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Navy;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(51, 184);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 5;
            label1.Text = "      MESLEKLER      ";
            // 
            // listboxOgeEkle
            // 
            listboxOgeEkle.BackColor = SystemColors.ControlLight;
            listboxOgeEkle.Location = new Point(2, 422);
            listboxOgeEkle.Name = "listboxOgeEkle";
            listboxOgeEkle.Size = new Size(118, 27);
            listboxOgeEkle.TabIndex = 6;
            listboxOgeEkle.Text = "Meslek Ekle";
            listboxOgeEkle.UseVisualStyleBackColor = false;
            listboxOgeEkle.Click += listboxOgeEkle_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 422);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 27);
            textBox2.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(listboxBilgi);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(463, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 457);
            panel1.TabIndex = 8;
            // 
            // listboxBilgi
            // 
            listboxBilgi.FormattingEnabled = true;
            listboxBilgi.ItemHeight = 20;
            listboxBilgi.Location = new Point(8, 283);
            listboxBilgi.Name = "listboxBilgi";
            listboxBilgi.Size = new Size(276, 164);
            listboxBilgi.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkCyan;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.Cornsilk;
            button2.Location = new Point(8, 250);
            button2.Name = "button2";
            button2.Size = new Size(90, 27);
            button2.TabIndex = 11;
            button2.Text = "Görüntüle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(Maas);
            groupBox1.Controls.Add(Meslek);
            groupBox1.Controls.Add(Yas);
            groupBox1.Controls.Add(Soyad);
            groupBox1.Controls.Add(Ad);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Location = new Point(14, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 218);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişi Bilgileri";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(99, 63);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(106, 27);
            textBox7.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(99, 101);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(106, 27);
            textBox6.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(99, 140);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(106, 27);
            textBox5.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(99, 177);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(106, 27);
            textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(99, 25);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(106, 27);
            textBox3.TabIndex = 5;
            // 
            // Maas
            // 
            Maas.AutoSize = true;
            Maas.Location = new Point(12, 180);
            Maas.Name = "Maas";
            Maas.Size = new Size(49, 20);
            Maas.TabIndex = 4;
            Maas.Text = "Maas:";
            // 
            // Meslek
            // 
            Meslek.AutoSize = true;
            Meslek.Location = new Point(12, 143);
            Meslek.Name = "Meslek";
            Meslek.Size = new Size(62, 20);
            Meslek.TabIndex = 3;
            Meslek.Text = "Meslek:";
            // 
            // Yas
            // 
            Yas.AutoSize = true;
            Yas.Location = new Point(11, 104);
            Yas.Name = "Yas";
            Yas.Size = new Size(35, 20);
            Yas.TabIndex = 2;
            Yas.Text = "Yas:";
            // 
            // Soyad
            // 
            Soyad.AutoSize = true;
            Soyad.Location = new Point(11, 70);
            Soyad.Name = "Soyad";
            Soyad.Size = new Size(55, 20);
            Soyad.TabIndex = 1;
            Soyad.Text = "Soyad:";
            // 
            // Ad
            // 
            Ad.AutoSize = true;
            Ad.Location = new Point(11, 32);
            Ad.Name = "Ad";
            Ad.Size = new Size(32, 20);
            Ad.TabIndex = 0;
            Ad.Text = "Ad:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(755, 479);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(listboxOgeEkle);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(combobaxaOgeEkle);
            Controls.Add(comboBox1);
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button combobaxaOgeEkle;
        private Button button1;
        private TextBox textBox1;
        private ListBox listBox1;
        private Label label1;
        private Button listboxOgeEkle;
        private TextBox textBox2;
        private Panel panel1;
        private ListBox listboxBilgi;
        private Button button2;
        private GroupBox groupBox1;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label Maas;
        private Label Meslek;
        private Label Yas;
        private Label Soyad;
        private Label Ad;
    }
}