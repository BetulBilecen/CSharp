namespace Ucus_Rezervasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            maskedTextBox4 = new MaskedTextBox();
            comboBox2 = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            comboBox1 = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(667, 424);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGreen;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 100);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(580, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(306, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(297, 28);
            label1.Name = "label1";
            label1.Size = new Size(214, 29);
            label1.TabIndex = 2;
            label1.Text = "BAHAR  AIRLINES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 44);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 2;
            label2.Text = "İSİM-SOYİSİM:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(maskedTextBox3);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(14, 112);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(416, 237);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "YOLCU BİLGİLERİ";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(158, 133);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(100, 27);
            maskedTextBox3.TabIndex = 8;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(158, 87);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 27);
            maskedTextBox2.TabIndex = 7;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 27);
            textBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 136);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 4;
            label4.Text = "TELEFON NO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 87);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 3;
            label3.Text = "T.C KİMLİK NO:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(maskedTextBox4);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(maskedTextBox1);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(437, 112);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(464, 237);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "UÇUŞ BİLGİLERİ";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.Location = new Point(277, 55);
            button2.Name = "button2";
            button2.Size = new Size(49, 28);
            button2.TabIndex = 11;
            button2.Text = "< >";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumAquamarine;
            button1.Location = new Point(264, 198);
            button1.Name = "button1";
            button1.Size = new Size(131, 32);
            button1.TabIndex = 10;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(118, 136);
            maskedTextBox4.Mask = "00/00/0000";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(100, 27);
            maskedTextBox4.TabIndex = 9;
            maskedTextBox4.ValidatingType = typeof(DateTime);
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Adana     ", "Adıyaman ", "Afyon      ", "Ağrı         ", "Amasya   ", "Ankara    ", "Antalya   ", "Artvin      ", "Aydın       ", "Balıkesir  ", "Bilecik     ", "Bingöl    ", "Bitlis       ", "Bolu       ", "Burdur     ", "Bursa      ", "Çanakkale ", "Çankırı     ", "Çorum     ", "Denizli     ", "Diyarbakır ", "Edirne    ", "Elazığ      ", "Erzincan  ", "Erzurum  ", "Eskişehir ", "Gaziantep ", "Giresun   ", "Gümüşhane ", "Hakkari   ", "Hatay      ", "Isparta    ", "Mersin    ", "İstanbul   ", "İzmir       ", "Kars         ", "Kastamonu ", "Kayseri    ", "Kırklareli ", "Kırşehir   ", "Kocaeli    ", "Konya      ", "Kütahya   ", "Malatya  ", "Manisa    ", "Kahramanmaraş    ", "Mardin    ", "Muğla     ", "Muş         ", "Nevşehir ", "Niğde      ", "Ordu        ", "Rize         ", "Sakarya   ", "Samsun   ", "Siirt         ", "Sinop       ", "Sivas       ", "Tekirdağ  ", "Tokat       ", "Trabzon   ", "Tunceli    ", "Şanlıurfa ", "Uşak        ", "Van         ", "Yozgat     ", "Zonguldak ", "Aksaray   ", "Bayburt   ", "Karaman ", "Kırıkkale  ", "Batman   ", "Şırnak      ", "Bartın      ", "Ardahan  ", "Iğdır        ", "Yalova     ", "Karabük  ", "Kilis         ", "Osmaniye ", "Düzce      " });
            comboBox2.Location = new Point(118, 83);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(119, 28);
            comboBox2.TabIndex = 9;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(118, 178);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 27);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Adana     ", "Adıyaman ", "Afyon      ", "Ağrı         ", "Amasya   ", "Ankara    ", "Antalya   ", "Artvin      ", "Aydın       ", "Balıkesir  ", "Bilecik     ", "Bingöl    ", "Bitlis       ", "Bolu       ", "Burdur     ", "Bursa      ", "Çanakkale ", "Çankırı     ", "Çorum     ", "Denizli     ", "Diyarbakır ", "Edirne    ", "Elazığ      ", "Erzincan  ", "Erzurum  ", "Eskişehir ", "Gaziantep ", "Giresun   ", "Gümüşhane ", "Hakkari   ", "Hatay      ", "Isparta    ", "Mersin    ", "İstanbul   ", "İzmir       ", "Kars         ", "Kastamonu ", "Kayseri    ", "Kırklareli ", "Kırşehir   ", "Kocaeli    ", "Konya      ", "Kütahya   ", "Malatya  ", "Manisa    ", "Kahramanmaraş    ", "Mardin    ", "Muğla     ", "Muş         ", "Nevşehir ", "Niğde      ", "Ordu        ", "Rize         ", "Sakarya   ", "Samsun   ", "Siirt         ", "Sinop       ", "Sivas       ", "Tekirdağ  ", "Tokat       ", "Trabzon   ", "Tunceli    ", "Şanlıurfa ", "Uşak        ", "Van         ", "Yozgat     ", "Zonguldak ", "Aksaray   ", "Bayburt   ", "Karaman ", "Kırıkkale  ", "Batman   ", "Şırnak      ", "Bartın      ", "Ardahan  ", "Iğdır        ", "Yalova     ", "Karabük  ", "Kilis         ", "Osmaniye ", "Düzce      " });
            comboBox1.Location = new Point(118, 41);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(119, 28);
            comboBox1.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 44);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 7;
            label8.Text = "NEREDEN:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 91);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 6;
            label7.Text = "NEREYE:";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 136);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 5;
            label6.Text = "TARİH:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 178);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 4;
            label5.Text = "SAAT:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 406);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(636, 184);
            listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox4;
        private ComboBox comboBox2;
        private MaskedTextBox maskedTextBox1;
        private ComboBox comboBox1;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private PictureBox pictureBox2;
    }
}