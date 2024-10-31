namespace Dijital_Saat
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
            labelSaatBirlerBasamagi = new Label();
            label3 = new Label();
            labelDakikaOnlarBasamagi = new Label();
            labelSaniyeBirlerBasamagi = new Label();
            label4 = new Label();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelSaatBirlerBasamagi
            // 
            labelSaatBirlerBasamagi.AutoSize = true;
            labelSaatBirlerBasamagi.Location = new Point(101, 101);
            labelSaatBirlerBasamagi.Margin = new Padding(7, 0, 7, 0);
            labelSaatBirlerBasamagi.Name = "labelSaatBirlerBasamagi";
            labelSaatBirlerBasamagi.Size = new Size(29, 32);
            labelSaatBirlerBasamagi.TabIndex = 1;
            labelSaatBirlerBasamagi.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 101);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(24, 32);
            label3.TabIndex = 2;
            label3.Text = ":";
            // 
            // labelDakikaOnlarBasamagi
            // 
            labelDakikaOnlarBasamagi.AutoSize = true;
            labelDakikaOnlarBasamagi.Location = new Point(182, 101);
            labelDakikaOnlarBasamagi.Margin = new Padding(7, 0, 7, 0);
            labelDakikaOnlarBasamagi.Name = "labelDakikaOnlarBasamagi";
            labelDakikaOnlarBasamagi.Size = new Size(29, 32);
            labelDakikaOnlarBasamagi.TabIndex = 4;
            labelDakikaOnlarBasamagi.Text = "0";
            // 
            // labelSaniyeBirlerBasamagi
            // 
            labelSaniyeBirlerBasamagi.AutoSize = true;
            labelSaniyeBirlerBasamagi.Location = new Point(263, 101);
            labelSaniyeBirlerBasamagi.Margin = new Padding(7, 0, 7, 0);
            labelSaniyeBirlerBasamagi.Name = "labelSaniyeBirlerBasamagi";
            labelSaniyeBirlerBasamagi.Size = new Size(29, 32);
            labelSaniyeBirlerBasamagi.TabIndex = 6;
            labelSaniyeBirlerBasamagi.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(225, 101);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(24, 32);
            label4.TabIndex = 5;
            label4.Text = ":";
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(204, 233);
            button1.Name = "button1";
            button1.Size = new Size(170, 30);
            button1.TabIndex = 8;
            button1.Text = "Bas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(477, 264);
            Controls.Add(button1);
            Controls.Add(labelSaniyeBirlerBasamagi);
            Controls.Add(label4);
            Controls.Add(labelDakikaOnlarBasamagi);
            Controls.Add(label3);
            Controls.Add(labelSaatBirlerBasamagi);
            Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(7, 6, 7, 6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelSaatBirlerBasamagi;
        private Label label3;
        private Label labelDakikaOnlarBasamagi;
        private Label labelSaniyeBirlerBasamagi;
        private Label label4;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}