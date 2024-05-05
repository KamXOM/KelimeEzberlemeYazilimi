using System.Windows.Forms;
using System;

namespace KelimeEzberlemeYazilimi
{
    public partial class GirisYap : Form
    {
        public GirisYap()
        {
            InitializeComponent();
        }
        public static bool GirisYapildi = false;
        private void girisButton_Click(object sender, EventArgs e)
        {
            bool girisBasarili = GirisYapma.GirisKontrol(emailTextBox.Text,sifreTextBox.Text);
            if (girisBasarili)
            {
                MessageBox.Show("Giriþ baþarýyla yapýldý!","Baþarýlý!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                GirisYapildi = true;
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("E-posta veya þifre hatalý. Lütfen tekrar deneyin.",
                    "Baþarýsýz!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void unuttumButton_Click(object sender, EventArgs e)
        {
            SifremiUnuttum sifreformu = new SifremiUnuttum();
            sifreformu.Show();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelOrtalama();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void PanelOrtalama()
        {
            if (girisPanel != null)
            {
                girisPanel.Left = (ClientSize.Width - girisPanel.Width) / 2;
                girisPanel.Top = (ClientSize.Height - girisPanel.Height) / 2;
            }
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            Hide();
        }
    }
}
