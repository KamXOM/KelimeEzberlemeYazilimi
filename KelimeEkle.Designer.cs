namespace KelimeEzberlemeYazilimi
{
    partial class KelimeEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelimeEkle));
            kelimePanel = new Panel();
            resimYukleLabel = new Label();
            temizleButton = new Button();
            geriButton = new Button();
            devamButton = new Button();
            kaydetButton = new Button();
            sentenceTextBox = new TextBox();
            enTextBox = new TextBox();
            trTextBox = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            kelimePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // kelimePanel
            // 
            kelimePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kelimePanel.Controls.Add(resimYukleLabel);
            kelimePanel.Controls.Add(temizleButton);
            kelimePanel.Controls.Add(geriButton);
            kelimePanel.Controls.Add(devamButton);
            kelimePanel.Controls.Add(kaydetButton);
            kelimePanel.Controls.Add(sentenceTextBox);
            kelimePanel.Controls.Add(enTextBox);
            kelimePanel.Controls.Add(trTextBox);
            kelimePanel.Controls.Add(pictureBox2);
            kelimePanel.Controls.Add(pictureBox);
            kelimePanel.Location = new Point(12, 12);
            kelimePanel.Name = "kelimePanel";
            kelimePanel.Size = new Size(776, 426);
            kelimePanel.TabIndex = 1;
            // 
            // resimYukleLabel
            // 
            resimYukleLabel.Anchor = AnchorStyles.None;
            resimYukleLabel.AutoSize = true;
            resimYukleLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            resimYukleLabel.Location = new Point(582, 212);
            resimYukleLabel.Name = "resimYukleLabel";
            resimYukleLabel.Size = new Size(104, 23);
            resimYukleLabel.TabIndex = 8;
            resimYukleLabel.Text = "Resim Yükle";
            resimYukleLabel.Click += resimYukleLabel_Click;
            // 
            // temizleButton
            // 
            temizleButton.Anchor = AnchorStyles.None;
            temizleButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            temizleButton.Location = new Point(188, 320);
            temizleButton.Name = "temizleButton";
            temizleButton.Size = new Size(108, 61);
            temizleButton.TabIndex = 6;
            temizleButton.Text = "Temizle";
            temizleButton.UseVisualStyleBackColor = true;
            temizleButton.Click += temizleButton_Click;
            // 
            // geriButton
            // 
            geriButton.Anchor = AnchorStyles.None;
            geriButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            geriButton.Location = new Point(74, 320);
            geriButton.Name = "geriButton";
            geriButton.Size = new Size(108, 61);
            geriButton.TabIndex = 7;
            geriButton.Text = "Geri Dön";
            geriButton.UseVisualStyleBackColor = true;
            geriButton.Click += geriButton_Click;
            // 
            // devamButton
            // 
            devamButton.Anchor = AnchorStyles.None;
            devamButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            devamButton.Location = new Point(468, 320);
            devamButton.Name = "devamButton";
            devamButton.Size = new Size(108, 61);
            devamButton.TabIndex = 4;
            devamButton.Text = "Kaydet ve Devam Et";
            devamButton.UseVisualStyleBackColor = true;
            devamButton.Click += devamButton_Click;
            // 
            // kaydetButton
            // 
            kaydetButton.Anchor = AnchorStyles.None;
            kaydetButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kaydetButton.Location = new Point(582, 320);
            kaydetButton.Name = "kaydetButton";
            kaydetButton.Size = new Size(116, 61);
            kaydetButton.TabIndex = 5;
            kaydetButton.Text = "Kaydet \r\nve Çık";
            kaydetButton.UseVisualStyleBackColor = true;
            kaydetButton.Click += kaydetButton_Click;
            // 
            // sentenceTextBox
            // 
            sentenceTextBox.Anchor = AnchorStyles.None;
            sentenceTextBox.Location = new Point(74, 246);
            sentenceTextBox.Multiline = true;
            sentenceTextBox.Name = "sentenceTextBox";
            sentenceTextBox.PlaceholderText = "I like to eat apples.";
            sentenceTextBox.Size = new Size(624, 45);
            sentenceTextBox.TabIndex = 3;
            // 
            // enTextBox
            // 
            enTextBox.Anchor = AnchorStyles.None;
            enTextBox.Location = new Point(74, 165);
            enTextBox.Name = "enTextBox";
            enTextBox.PlaceholderText = "apple";
            enTextBox.Size = new Size(195, 27);
            enTextBox.TabIndex = 2;
            // 
            // trTextBox
            // 
            trTextBox.Anchor = AnchorStyles.None;
            trTextBox.Location = new Point(74, 76);
            trTextBox.Name = "trTextBox";
            trTextBox.PlaceholderText = "elma";
            trTextBox.Size = new Size(195, 27);
            trTextBox.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(318, 314);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseEnter += pictureBox2_MouseEnter;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.None;
            pictureBox.Location = new Point(428, 18);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(270, 191);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "\"JPEG dosyaları|*.jpeg|PNG dosyaları|*.png\"";
            openFileDialog1.Title = "Bir Fotoğraf Seçin.";
            // 
            // KelimeEkle
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(kelimePanel);
            Name = "KelimeEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelime Ezberleme Yazılımı";
            Load += Form2_Load;
            Shown += Form2_Shown;
            kelimePanel.ResumeLayout(false);
            kelimePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel kelimePanel;
        private PictureBox pictureBox;
        private PictureBox pictureBox2;
        private TextBox trTextBox;
        private TextBox sentenceTextBox;
        private TextBox enTextBox;
        private Button kaydetButton;
        private Button devamButton;
        private Button geriButton;
        private Button temizleButton;
        private Label resimYukleLabel;
        private OpenFileDialog openFileDialog1;
    }
}