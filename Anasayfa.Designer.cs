namespace KelimeEzberlemeYazilimi
{
    partial class Anasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            kayitOlButton = new Button();
            girisYapButton = new Button();
            sinavaBaslaButton = new Button();
            hosgeldinLabel = new Label();
            programAdiLabel = new Label();
            pictureBox1 = new PictureBox();
            settingsPanel = new Panel();
            pictureBox2 = new PictureBox();
            checkBox1 = new CheckBox();
            label4 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            kelimeEkleButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(kelimeEkleButton);
            panel1.Controls.Add(kayitOlButton);
            panel1.Controls.Add(girisYapButton);
            panel1.Controls.Add(sinavaBaslaButton);
            panel1.Controls.Add(hosgeldinLabel);
            panel1.Controls.Add(programAdiLabel);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // kayitOlButton
            // 
            kayitOlButton.Anchor = AnchorStyles.None;
            kayitOlButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kayitOlButton.Location = new Point(222, 221);
            kayitOlButton.Name = "kayitOlButton";
            kayitOlButton.Size = new Size(159, 53);
            kayitOlButton.TabIndex = 6;
            kayitOlButton.Text = "Kayıt Ol";
            kayitOlButton.UseVisualStyleBackColor = true;
            kayitOlButton.Click += kayitOlButton_Click;
            // 
            // girisYapButton
            // 
            girisYapButton.Anchor = AnchorStyles.None;
            girisYapButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            girisYapButton.Location = new Point(387, 221);
            girisYapButton.Name = "girisYapButton";
            girisYapButton.Size = new Size(159, 53);
            girisYapButton.TabIndex = 5;
            girisYapButton.Text = "Giriş Yap";
            girisYapButton.UseVisualStyleBackColor = true;
            girisYapButton.Click += girisYapButton_Click;
            // 
            // sinavaBaslaButton
            // 
            sinavaBaslaButton.Anchor = AnchorStyles.None;
            sinavaBaslaButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            sinavaBaslaButton.Location = new Point(282, 221);
            sinavaBaslaButton.Name = "sinavaBaslaButton";
            sinavaBaslaButton.Size = new Size(210, 68);
            sinavaBaslaButton.TabIndex = 3;
            sinavaBaslaButton.Text = "Sınava Başla!";
            sinavaBaslaButton.UseVisualStyleBackColor = true;
            sinavaBaslaButton.Click += sinavaBaslaButton_Click;
            // 
            // hosgeldinLabel
            // 
            hosgeldinLabel.Anchor = AnchorStyles.None;
            hosgeldinLabel.AutoSize = true;
            hosgeldinLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Underline, GraphicsUnit.Point, 162);
            hosgeldinLabel.Location = new Point(301, 139);
            hosgeldinLabel.Name = "hosgeldinLabel";
            hosgeldinLabel.Size = new Size(173, 38);
            hosgeldinLabel.TabIndex = 2;
            hosgeldinLabel.Text = "Hoş Geldiniz";
            // 
            // programAdiLabel
            // 
            programAdiLabel.Anchor = AnchorStyles.None;
            programAdiLabel.AutoSize = true;
            programAdiLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            programAdiLabel.ForeColor = Color.Red;
            programAdiLabel.Location = new Point(180, 69);
            programAdiLabel.Name = "programAdiLabel";
            programAdiLabel.Size = new Size(434, 46);
            programAdiLabel.TabIndex = 1;
            programAdiLabel.Text = "Kelime Ezberleme Yazılımı";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resource1.settings;
            pictureBox1.Location = new Point(627, 305);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // settingsPanel
            // 
            settingsPanel.Anchor = AnchorStyles.None;
            settingsPanel.Controls.Add(pictureBox2);
            settingsPanel.Controls.Add(checkBox1);
            settingsPanel.Controls.Add(label4);
            settingsPanel.Controls.Add(button1);
            settingsPanel.Controls.Add(comboBox1);
            settingsPanel.Controls.Add(numericUpDown1);
            settingsPanel.Controls.Add(label3);
            settingsPanel.Controls.Add(label2);
            settingsPanel.Controls.Add(label1);
            settingsPanel.Location = new Point(12, 12);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(776, 426);
            settingsPanel.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resource1.settings;
            pictureBox2.Location = new Point(627, 305);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(146, 118);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseEnter += pictureBox2_MouseEnter;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.None;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(568, 91);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(170, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Soru Sayısını Değiştir";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 122);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 7;
            label4.Text = "Ahmet Onur Malay";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(609, 187);
            button1.Name = "button1";
            button1.Size = new Size(117, 33);
            button1.TabIndex = 6;
            button1.Text = "Gün Atla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1 Gün", "1 Hafta", "1 Ay", "3 Ay", "6 Ay", "1 Yıl" });
            comboBox1.Location = new Point(575, 149);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "Atlanacak Gün";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.None;
            numericUpDown1.Location = new Point(575, 53);
            numericUpDown1.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(151, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(15, 83);
            label3.Name = "label3";
            label3.Size = new Size(204, 20);
            label3.TabIndex = 2;
            label3.Text = "Her Şeyi Yapan ve Hazırlayan:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(396, 150);
            label2.Name = "label2";
            label2.Size = new Size(173, 23);
            label2.TabIndex = 1;
            label2.Text = "Atlanacak Gün Sayısı:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(373, 53);
            label1.Name = "label1";
            label1.Size = new Size(196, 23);
            label1.TabIndex = 0;
            label1.Text = "Tercih Edilen Soru Sayısı:";
            // 
            // kelimeEkleButton
            // 
            kelimeEkleButton.Anchor = AnchorStyles.None;
            kelimeEkleButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kelimeEkleButton.Location = new Point(307, 303);
            kelimeEkleButton.Name = "kelimeEkleButton";
            kelimeEkleButton.Size = new Size(159, 53);
            kelimeEkleButton.TabIndex = 7;
            kelimeEkleButton.Text = "Kelime Ekle";
            kelimeEkleButton.UseVisualStyleBackColor = true;
            kelimeEkleButton.Click += kelimeEkleButton_Click;
            // 
            // Anasayfa
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(settingsPanel);
            Name = "Anasayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anasayfa";
            Load += Anasayfa_Load;
            Shown += Anasayfa_Shown;
            ClientSizeChanged += Anasayfa_ClientSizeChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            settingsPanel.ResumeLayout(false);
            settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label hosgeldinLabel;
        private Label programAdiLabel;
        private Button sinavaBaslaButton;
        private Panel settingsPanel;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private Label label4;
        private CheckBox checkBox1;
        private PictureBox pictureBox2;
        private Button kayitOlButton;
        private Button girisYapButton;
        private Button kelimeEkleButton;
    }
}