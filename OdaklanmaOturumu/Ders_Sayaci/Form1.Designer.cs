namespace Ders_Sayaci
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelHour = new Label();
            labelMoment = new Label();
            labelIkiNokta = new Label();
            buttonStart = new Button();
            buttonStop = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            buttonReset = new Button();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // labelHour
            // 
            labelHour.AutoSize = true;
            labelHour.Location = new Point(67, 107);
            labelHour.Margin = new Padding(8, 0, 8, 0);
            labelHour.Name = "labelHour";
            labelHour.Size = new Size(50, 46);
            labelHour.TabIndex = 0;
            labelHour.Text = "00";
            // 
            // labelMoment
            // 
            labelMoment.AutoSize = true;
            labelMoment.Location = new Point(234, 107);
            labelMoment.Margin = new Padding(8, 0, 8, 0);
            labelMoment.Name = "labelMoment";
            labelMoment.Size = new Size(50, 46);
            labelMoment.TabIndex = 1;
            labelMoment.Text = "00";
            // 
            // labelIkiNokta
            // 
            labelIkiNokta.AutoSize = true;
            labelIkiNokta.Font = new Font("Ravie", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelIkiNokta.Location = new Point(162, 109);
            labelIkiNokta.Margin = new Padding(8, 0, 8, 0);
            labelIkiNokta.Name = "labelIkiNokta";
            labelIkiNokta.Size = new Size(28, 36);
            labelIkiNokta.TabIndex = 2;
            labelIkiNokta.Text = ":";
            // 
            // buttonStart
            // 
            buttonStart.FlatStyle = FlatStyle.Popup;
            buttonStart.Font = new Font("Pristina", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.Location = new Point(2, 253);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(156, 39);
            buttonStart.TabIndex = 3;
            buttonStart.Text = " Start :)";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.FlatStyle = FlatStyle.Popup;
            buttonStop.Font = new Font("Pristina", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStop.Location = new Point(164, 253);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(156, 39);
            buttonStop.TabIndex = 4;
            buttonStop.Text = "Stop :(";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // timer1
            // 
            timer1.Interval = 60000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(474, 247);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // buttonReset
            // 
            buttonReset.FlatStyle = FlatStyle.Popup;
            buttonReset.Font = new Font("Pristina", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReset.Location = new Point(326, 253);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(156, 39);
            buttonReset.TabIndex = 6;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(474, 247);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Pristina", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(6, 296);
            button1.Name = "button1";
            button1.Size = new Size(475, 36);
            button1.TabIndex = 8;
            button1.Text = "Kapat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 46F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(493, 333);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(buttonReset);
            Controls.Add(pictureBox1);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Controls.Add(labelIkiNokta);
            Controls.Add(labelMoment);
            Controls.Add(labelHour);
            Font = new Font("Pristina", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(8, 9, 8, 9);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHour;
        private Label labelMoment;
        private Label labelIkiNokta;
        private Button buttonStart;
        private Button buttonStop;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Button buttonReset;
        private PictureBox pictureBox2;
        private Button button1;
    }
}