namespace MaskedTextboxVeResimEkleme
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
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            label3 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            label4 = new Label();
            buttonBilgiEkle = new Button();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            buttonTarihEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(102, 38);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(160, 23);
            maskedTextBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "T.C :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 46);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Telefon:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(102, 8);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(160, 23);
            maskedTextBox2.TabIndex = 3;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(11, 87);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Tarih:";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(102, 79);
            maskedTextBox3.Mask = "00/00/0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(160, 23);
            maskedTextBox3.TabIndex = 5;
            maskedTextBox3.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(102, 117);
            maskedTextBox4.Mask = "00:00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(160, 23);
            maskedTextBox4.TabIndex = 6;
            maskedTextBox4.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(11, 125);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 7;
            label4.Text = "Saat:";
            // 
            // buttonBilgiEkle
            // 
            buttonBilgiEkle.BackColor = Color.Brown;
            buttonBilgiEkle.FlatStyle = FlatStyle.Popup;
            buttonBilgiEkle.ForeColor = Color.Cornsilk;
            buttonBilgiEkle.Location = new Point(9, 257);
            buttonBilgiEkle.Name = "buttonBilgiEkle";
            buttonBilgiEkle.Size = new Size(98, 26);
            buttonBilgiEkle.TabIndex = 8;
            buttonBilgiEkle.Text = "Görüntüle";
            buttonBilgiEkle.UseVisualStyleBackColor = false;
            buttonBilgiEkle.Click += buttonBilgiEkle_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(9, 290);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(601, 140);
            listBox1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(768, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(maskedTextBox4);
            groupBox1.Controls.Add(maskedTextBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Location = new Point(9, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(292, 151);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(435, 135);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(153, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // buttonTarihEkle
            // 
            buttonTarihEkle.Location = new Point(435, 170);
            buttonTarihEkle.Name = "buttonTarihEkle";
            buttonTarihEkle.Size = new Size(99, 21);
            buttonTarihEkle.TabIndex = 13;
            buttonTarihEkle.Text = "Ekle";
            buttonTarihEkle.UseVisualStyleBackColor = true;
            buttonTarihEkle.Click += buttonTarihEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonTarihEkle);
            Controls.Add(dateTimePicker1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(buttonBilgiEkle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBox2;
        private Label label3;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
        private Label label4;
        private Button buttonBilgiEkle;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private Button buttonTarihEkle;
    }
}