namespace KelimeEzberlemeYazilimi
{
    partial class GirisYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisYap));
            emailLabel = new Label();
            emailTextBox = new TextBox();
            sifreLabel = new Label();
            sifreTextBox = new TextBox();
            unuttumButton = new Button();
            girisButton = new Button();
            girisPanel = new Panel();
            geriButton = new Button();
            girisPanel.SuspendLayout();
            SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.None;
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            emailLabel.Location = new Point(195, 154);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(90, 25);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "E-Mail:";
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.None;
            emailTextBox.Location = new Point(291, 152);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "örnek@hotmail.com";
            emailTextBox.Size = new Size(277, 27);
            emailTextBox.TabIndex = 1;
            // 
            // sifreLabel
            // 
            sifreLabel.Anchor = AnchorStyles.None;
            sifreLabel.AutoSize = true;
            sifreLabel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            sifreLabel.Location = new Point(195, 191);
            sifreLabel.Name = "sifreLabel";
            sifreLabel.Size = new Size(72, 25);
            sifreLabel.TabIndex = 0;
            sifreLabel.Text = "Şifre:";
            // 
            // sifreTextBox
            // 
            sifreTextBox.Anchor = AnchorStyles.None;
            sifreTextBox.Location = new Point(291, 193);
            sifreTextBox.Name = "sifreTextBox";
            sifreTextBox.ShortcutsEnabled = false;
            sifreTextBox.Size = new Size(277, 27);
            sifreTextBox.TabIndex = 2;
            sifreTextBox.UseSystemPasswordChar = true;
            // 
            // unuttumButton
            // 
            unuttumButton.Anchor = AnchorStyles.None;
            unuttumButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            unuttumButton.Location = new Point(291, 237);
            unuttumButton.Name = "unuttumButton";
            unuttumButton.Size = new Size(157, 34);
            unuttumButton.TabIndex = 4;
            unuttumButton.Text = "Şifremi Unuttum";
            unuttumButton.UseVisualStyleBackColor = true;
            unuttumButton.Click += unuttumButton_Click;
            // 
            // girisButton
            // 
            girisButton.Anchor = AnchorStyles.None;
            girisButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            girisButton.Location = new Point(454, 237);
            girisButton.Name = "girisButton";
            girisButton.Size = new Size(114, 34);
            girisButton.TabIndex = 3;
            girisButton.Text = "Giriş Yap";
            girisButton.UseVisualStyleBackColor = true;
            girisButton.Click += girisButton_Click;
            // 
            // girisPanel
            // 
            girisPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            girisPanel.Controls.Add(geriButton);
            girisPanel.Controls.Add(girisButton);
            girisPanel.Controls.Add(emailLabel);
            girisPanel.Controls.Add(unuttumButton);
            girisPanel.Controls.Add(emailTextBox);
            girisPanel.Controls.Add(sifreTextBox);
            girisPanel.Controls.Add(sifreLabel);
            girisPanel.Location = new Point(12, 12);
            girisPanel.Name = "girisPanel";
            girisPanel.Size = new Size(776, 426);
            girisPanel.TabIndex = 5;
            // 
            // geriButton
            // 
            geriButton.Anchor = AnchorStyles.None;
            geriButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            geriButton.Location = new Point(195, 237);
            geriButton.Name = "geriButton";
            geriButton.Size = new Size(90, 34);
            geriButton.TabIndex = 5;
            geriButton.Text = "Geri Dön";
            geriButton.UseVisualStyleBackColor = true;
            geriButton.Click += geriButton_Click;
            // 
            // GirisYap
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(girisPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GirisYap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelime Ezberleme Yazılımı";
            Load += Form1_Load;
            Shown += Form1_Shown;
            girisPanel.ResumeLayout(false);
            girisPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label emailLabel;
        private TextBox emailTextBox;
        private Label sifreLabel;
        private TextBox sifreTextBox;
        private Button unuttumButton;
        private Button girisButton;
        private Panel girisPanel;
        private Button geriButton;
    }
}
