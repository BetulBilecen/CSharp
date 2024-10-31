namespace Uygulama2_BilgiYarismasi
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
            richTextBox1 = new RichTextBox();
            buttonA = new Button();
            buttonB = new Button();
            buttonC = new Button();
            buttonD = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelSoruSayisi = new Label();
            labelDogruSoru = new Label();
            labelYanlisSoru = new Label();
            buttonSonraki = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(338, 278);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // buttonA
            // 
            buttonA.BackColor = Color.Cornsilk;
            buttonA.Location = new Point(1, 286);
            buttonA.Name = "buttonA";
            buttonA.Size = new Size(162, 29);
            buttonA.TabIndex = 1;
            buttonA.Text = "A";
            buttonA.UseVisualStyleBackColor = false;
            buttonA.Click += buttonA_Click;
            // 
            // buttonB
            // 
            buttonB.BackColor = Color.Cornsilk;
            buttonB.Location = new Point(179, 287);
            buttonB.Name = "buttonB";
            buttonB.Size = new Size(162, 29);
            buttonB.TabIndex = 2;
            buttonB.Text = "B";
            buttonB.UseVisualStyleBackColor = false;
            buttonB.Click += buttonB_Click;
            // 
            // buttonC
            // 
            buttonC.BackColor = Color.Cornsilk;
            buttonC.Location = new Point(1, 321);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(162, 31);
            buttonC.TabIndex = 3;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = false;
            buttonC.Click += buttonC_Click;
            // 
            // buttonD
            // 
            buttonD.BackColor = Color.Cornsilk;
            buttonD.Location = new Point(179, 323);
            buttonD.Name = "buttonD";
            buttonD.Size = new Size(162, 29);
            buttonD.TabIndex = 4;
            buttonD.Text = "D";
            buttonD.UseVisualStyleBackColor = false;
            buttonD.Click += buttonD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 19);
            label1.TabIndex = 5;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 74);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 6;
            label2.Text = "Yanlış:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 40);
            label3.Name = "label3";
            label3.Size = new Size(55, 19);
            label3.TabIndex = 7;
            label3.Text = "Doğru:";
            // 
            // labelSoruSayisi
            // 
            labelSoruSayisi.AutoSize = true;
            labelSoruSayisi.Location = new Point(431, 9);
            labelSoruSayisi.Name = "labelSoruSayisi";
            labelSoruSayisi.Size = new Size(17, 19);
            labelSoruSayisi.TabIndex = 8;
            labelSoruSayisi.Text = "0";
            // 
            // labelDogruSoru
            // 
            labelDogruSoru.AutoSize = true;
            labelDogruSoru.Location = new Point(431, 40);
            labelDogruSoru.Name = "labelDogruSoru";
            labelDogruSoru.Size = new Size(17, 19);
            labelDogruSoru.TabIndex = 9;
            labelDogruSoru.Text = "0";
            // 
            // labelYanlisSoru
            // 
            labelYanlisSoru.AutoSize = true;
            labelYanlisSoru.Location = new Point(431, 74);
            labelYanlisSoru.Name = "labelYanlisSoru";
            labelYanlisSoru.Size = new Size(17, 19);
            labelYanlisSoru.TabIndex = 10;
            labelYanlisSoru.Text = "0";
            // 
            // buttonSonraki
            // 
            buttonSonraki.Location = new Point(345, 109);
            buttonSonraki.Name = "buttonSonraki";
            buttonSonraki.Size = new Size(116, 26);
            buttonSonraki.TabIndex = 11;
            buttonSonraki.Text = "Sonraki";
            buttonSonraki.UseVisualStyleBackColor = true;
            buttonSonraki.Click += buttonSonraki_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(384, 272);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(482, 272);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Corbel", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Indigo;
            label4.Location = new Point(395, 172);
            label4.Name = "label4";
            label4.Size = new Size(0, 33);
            label4.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(573, 386);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSonraki);
            Controls.Add(labelYanlisSoru);
            Controls.Add(labelDogruSoru);
            Controls.Add(labelSoruSayisi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonD);
            Controls.Add(buttonC);
            Controls.Add(buttonB);
            Controls.Add(buttonA);
            Controls.Add(richTextBox1);
            Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Bilgi Yarışması";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button buttonA;
        private Button buttonB;
        private Button buttonC;
        private Button buttonD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelSoruSayisi;
        private Label labelDogruSoru;
        private Label labelYanlisSoru;
        private Button buttonSonraki;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
    }
}