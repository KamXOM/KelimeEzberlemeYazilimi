namespace KelimeEzberlemeYazilimi
{
    partial class SinavEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinavEkrani));
            label1 = new Label();
            label2 = new Label();
            turkceTextBox = new TextBox();
            cevapTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            sinavBitirButton = new Button();
            kelimeComboBox = new ComboBox();
            oncekiButton = new Button();
            sonrakiButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(48, 57);
            label1.Name = "label1";
            label1.Size = new Size(95, 28);
            label1.TabIndex = 0;
            label1.Text = "Türkçesi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(32, 134);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 1;
            label2.Text = "İngilizcesi:";
            // 
            // turkceTextBox
            // 
            turkceTextBox.Enabled = false;
            turkceTextBox.Location = new Point(149, 61);
            turkceTextBox.Name = "turkceTextBox";
            turkceTextBox.ReadOnly = true;
            turkceTextBox.Size = new Size(209, 27);
            turkceTextBox.TabIndex = 0;
            turkceTextBox.TabStop = false;
            turkceTextBox.Text = "zfdfsdfs";
            // 
            // cevapTextBox
            // 
            cevapTextBox.Location = new Point(149, 138);
            cevapTextBox.Name = "cevapTextBox";
            cevapTextBox.Size = new Size(209, 27);
            cevapTextBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Location = new Point(66, 203);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(506, 138);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.MouseEnter += pictureBox2_MouseEnter;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            // 
            // panel1
            // 
            panel1.Controls.Add(sinavBitirButton);
            panel1.Controls.Add(kelimeComboBox);
            panel1.Controls.Add(oncekiButton);
            panel1.Controls.Add(sonrakiButton);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cevapTextBox);
            panel1.Controls.Add(turkceTextBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 8;
            // 
            // sinavBitirButton
            // 
            sinavBitirButton.Anchor = AnchorStyles.None;
            sinavBitirButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            sinavBitirButton.Location = new Point(438, 322);
            sinavBitirButton.Name = "sinavBitirButton";
            sinavBitirButton.Size = new Size(276, 64);
            sinavBitirButton.TabIndex = 4;
            sinavBitirButton.Text = "Sınavı Bitir!";
            sinavBitirButton.UseVisualStyleBackColor = true;
            sinavBitirButton.Click += sinavBitirButton_Click;
            // 
            // kelimeComboBox
            // 
            kelimeComboBox.Anchor = AnchorStyles.None;
            kelimeComboBox.FormattingEnabled = true;
            kelimeComboBox.Location = new Point(597, 23);
            kelimeComboBox.Name = "kelimeComboBox";
            kelimeComboBox.Size = new Size(156, 28);
            kelimeComboBox.TabIndex = 10;
            kelimeComboBox.Text = "Soru Seçebilirsiniz";
            kelimeComboBox.SelectionChangeCommitted += kelimeComboBox_SelectionChangeCommitted;
            // 
            // oncekiButton
            // 
            oncekiButton.Anchor = AnchorStyles.None;
            oncekiButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            oncekiButton.Location = new Point(438, 249);
            oncekiButton.Name = "oncekiButton";
            oncekiButton.Size = new Size(101, 51);
            oncekiButton.TabIndex = 3;
            oncekiButton.Text = "Önceki";
            oncekiButton.UseVisualStyleBackColor = true;
            oncekiButton.Click += oncekiButton_Click;
            // 
            // sonrakiButton
            // 
            sonrakiButton.Anchor = AnchorStyles.None;
            sonrakiButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            sonrakiButton.Location = new Point(613, 249);
            sonrakiButton.Name = "sonrakiButton";
            sonrakiButton.Size = new Size(101, 51);
            sonrakiButton.TabIndex = 2;
            sonrakiButton.Text = "Sonraki";
            sonrakiButton.UseVisualStyleBackColor = true;
            sonrakiButton.Click += sonrakiButton_Click;
            // 
            // SinavEkrani
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "SinavEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelime Ezberleme Yazılımı";
            Load += SinavEkrani_Load;
            Shown += SinavEkrani_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox turkceTextBox;
        private TextBox cevapTextBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Button oncekiButton;
        private Button sonrakiButton;
        private ComboBox kelimeComboBox;
        private Button sinavBitirButton;
    }
}