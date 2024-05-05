namespace KelimeEzberlemeYazilimi
{
    partial class SifremiUnuttum
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
            geriButton = new Button();
            devamButton = new Button();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            favkelimeLabel = new Label();
            onaylaButton = new Button();
            sifreTextBox = new TextBox();
            sifreOnayTextBox = new TextBox();
            SifreOnayLabel = new Label();
            sifreLabel = new Label();
            panel2 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(favkelimeTextBox);
            panel1.Controls.Add(geriButton);
            panel1.Controls.Add(devamButton);
            panel1.Controls.Add(emailLabel);
            panel1.Controls.Add(emailTextBox);
            panel1.Controls.Add(favkelimeLabel);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // favkelimeTextBox
            // 
            favkelimeTextBox.Anchor = AnchorStyles.None;
            favkelimeTextBox.Location = new Point(298, 195);
            favkelimeTextBox.Name = "favkelimeTextBox";
            favkelimeTextBox.PlaceholderText = "elma";
            favkelimeTextBox.Size = new Size(277, 27);
            favkelimeTextBox.TabIndex = 2;
            // 
            // geriButton
            // 
            geriButton.Anchor = AnchorStyles.None;
            geriButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            geriButton.Location = new Point(298, 239);
            geriButton.Name = "geriButton";
            geriButton.Size = new Size(134, 34);
            geriButton.TabIndex = 4;
            geriButton.Text = "Geri Dön";
            geriButton.UseVisualStyleBackColor = true;
            geriButton.Click += geriButton_Click;
            // 
            // devamButton
            // 
            devamButton.Anchor = AnchorStyles.None;
            devamButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            devamButton.Location = new Point(438, 239);
            devamButton.Name = "devamButton";
            devamButton.Size = new Size(137, 34);
            devamButton.TabIndex = 3;
            devamButton.Text = "Devam Et";
            devamButton.UseVisualStyleBackColor = true;
            devamButton.Click += devamButton_Click;
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.None;
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            emailLabel.Location = new Point(202, 156);
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
            // 
            // favkelimeLabel
            // 
            favkelimeLabel.Anchor = AnchorStyles.None;
            favkelimeLabel.AutoSize = true;
            favkelimeLabel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            favkelimeLabel.Location = new Point(86, 193);
            favkelimeLabel.Name = "favkelimeLabel";
            favkelimeLabel.Size = new Size(206, 25);
            favkelimeLabel.TabIndex = 7;
            favkelimeLabel.Text = "Favori Kelimeniz:";
            // 
            // onaylaButton
            // 
            onaylaButton.Anchor = AnchorStyles.None;
            onaylaButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            onaylaButton.Location = new Point(438, 239);
            onaylaButton.Name = "onaylaButton";
            onaylaButton.Size = new Size(137, 34);
            onaylaButton.TabIndex = 7;
            onaylaButton.Text = "Onayla";
            onaylaButton.UseVisualStyleBackColor = true;
            onaylaButton.Click += onaylaButton_Click;
            // 
            // sifreTextBox
            // 
            sifreTextBox.Anchor = AnchorStyles.None;
            sifreTextBox.Location = new Point(298, 154);
            sifreTextBox.Name = "sifreTextBox";
            sifreTextBox.ShortcutsEnabled = false;
            sifreTextBox.Size = new Size(277, 27);
            sifreTextBox.TabIndex = 5;
            sifreTextBox.UseSystemPasswordChar = true;
            // 
            // sifreOnayTextBox
            // 
            sifreOnayTextBox.Anchor = AnchorStyles.None;
            sifreOnayTextBox.Location = new Point(298, 195);
            sifreOnayTextBox.Name = "sifreOnayTextBox";
            sifreOnayTextBox.ShortcutsEnabled = false;
            sifreOnayTextBox.Size = new Size(277, 27);
            sifreOnayTextBox.TabIndex = 6;
            sifreOnayTextBox.UseSystemPasswordChar = true;
            // 
            // SifreOnayLabel
            // 
            SifreOnayLabel.Anchor = AnchorStyles.None;
            SifreOnayLabel.AutoSize = true;
            SifreOnayLabel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            SifreOnayLabel.Location = new Point(107, 193);
            SifreOnayLabel.Name = "SifreOnayLabel";
            SifreOnayLabel.Size = new Size(185, 25);
            SifreOnayLabel.TabIndex = 15;
            SifreOnayLabel.Text = "Şifreniz Tekrar:";
            // 
            // sifreLabel
            // 
            sifreLabel.Anchor = AnchorStyles.None;
            sifreLabel.AutoSize = true;
            sifreLabel.BackColor = Color.Transparent;
            sifreLabel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            sifreLabel.Location = new Point(187, 152);
            sifreLabel.Name = "sifreLabel";
            sifreLabel.Size = new Size(105, 25);
            sifreLabel.TabIndex = 14;
            sifreLabel.Text = "Şifreniz:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(sifreOnayTextBox);
            panel2.Controls.Add(onaylaButton);
            panel2.Controls.Add(sifreLabel);
            panel2.Controls.Add(sifreTextBox);
            panel2.Controls.Add(SifreOnayLabel);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 426);
            panel2.TabIndex = 16;
            panel2.Visible = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(298, 239);
            button1.Name = "button1";
            button1.Size = new Size(134, 34);
            button1.TabIndex = 16;
            button1.Text = "Geri Dön";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SifremiUnuttum
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SifremiUnuttum";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelime Ezberleme Yazılımı";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox favkelimeTextBox;
        private Button geriButton;
        private Button devamButton;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label favkelimeLabel;
        private Label sifreLabel;
        private Label SifreOnayLabel;
        private TextBox sifreOnayTextBox;
        private TextBox sifreTextBox;
        private Button onaylaButton;
        private Panel panel2;
        private Button button1;
    }
}