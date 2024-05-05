namespace KelimeEzberlemeYazilimi
{
    partial class KayitOl
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
            favkelimeTextBox = new TextBox();
            label1 = new Label();
            geriButton = new Button();
            kayitButton = new Button();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            sifreTextBox = new TextBox();
            sifreLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(favkelimeTextBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(geriButton);
            panel1.Controls.Add(kayitButton);
            panel1.Controls.Add(emailLabel);
            panel1.Controls.Add(emailTextBox);
            panel1.Controls.Add(sifreTextBox);
            panel1.Controls.Add(sifreLabel);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // favkelimeTextBox
            // 
            favkelimeTextBox.Anchor = AnchorStyles.None;
            favkelimeTextBox.Location = new Point(298, 238);
            favkelimeTextBox.Name = "favkelimeTextBox";
            favkelimeTextBox.PlaceholderText = "elma";
            favkelimeTextBox.Size = new Size(277, 27);
            favkelimeTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(86, 236);
            label1.Name = "label1";
            label1.Size = new Size(206, 25);
            label1.TabIndex = 13;
            label1.Text = "Favori Kelimeniz:";
            // 
            // geriButton
            // 
            geriButton.Anchor = AnchorStyles.None;
            geriButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            geriButton.Location = new Point(298, 280);
            geriButton.Name = "geriButton";
            geriButton.Size = new Size(135, 34);
            geriButton.TabIndex = 5;
            geriButton.Text = "Geri Dön";
            geriButton.UseVisualStyleBackColor = true;
            geriButton.Click += geriButton_Click;
            // 
            // kayitButton
            // 
            kayitButton.Anchor = AnchorStyles.None;
            kayitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kayitButton.Location = new Point(439, 280);
            kayitButton.Name = "kayitButton";
            kayitButton.Size = new Size(136, 34);
            kayitButton.TabIndex = 4;
            kayitButton.Text = "Kayıt Ol";
            kayitButton.UseVisualStyleBackColor = true;
            kayitButton.Click += kayitButton_Click;
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.None;
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            emailLabel.Location = new Point(202, 152);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(90, 25);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "E-Mail:";
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.None;
            emailTextBox.Location = new Point(298, 154);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "örnek@hotmail.com";
            emailTextBox.Size = new Size(277, 27);
            emailTextBox.TabIndex = 1;
            emailTextBox.TextChanged += emailTextBox_TextChanged;
            // 
            // sifreTextBox
            // 
            sifreTextBox.Anchor = AnchorStyles.None;
            sifreTextBox.Location = new Point(298, 195);
            sifreTextBox.Name = "sifreTextBox";
            sifreTextBox.ShortcutsEnabled = false;
            sifreTextBox.Size = new Size(277, 27);
            sifreTextBox.TabIndex = 2;
            sifreTextBox.UseSystemPasswordChar = true;
            // 
            // sifreLabel
            // 
            sifreLabel.Anchor = AnchorStyles.None;
            sifreLabel.AutoSize = true;
            sifreLabel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            sifreLabel.Location = new Point(220, 193);
            sifreLabel.Name = "sifreLabel";
            sifreLabel.Size = new Size(72, 25);
            sifreLabel.TabIndex = 7;
            sifreLabel.Text = "Şifre:";
            // 
            // KayitOl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "KayitOl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button geriButton;
        private Button kayitButton;
        private Label emailLabel;
        private TextBox emailTextBox;
        private TextBox sifreTextBox;
        private Label sifreLabel;
        private TextBox favkelimeTextBox;
        private Label label1;
    }
}