using System;
using System.Drawing;
using System.Windows.Forms;

namespace HayvanatBahcesiProje2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ArayuzuDuzenle();
        }

        private void ArayuzuDuzenle()
        {
            Temalar.FormuUygula(this, "Hayvanat Bahçesi Yönetim Sistemi");
            ClientSize = new Size(820, 500);

            Panel anaPanel = Temalar.PanelOlustur(70, 50, 680, 390);
            Controls.Add(anaPanel);
            anaPanel.SendToBack();

            Controls.Add(Temalar.BaslikOlustur("Hayvanat Bahçesi Yönetim Sistemi", 110, 80, 600));
            Controls.Add(Temalar.AciklamaOlustur("Admin paneli veya ziyaretçi bilgilendirme ekranına buradan erişebilirsiniz.", 112, 120, 590));

            btnZiyaretciGiris.Text = "Ziyaretçi Ekranı";
            btnZiyaretciGiris.Location = new Point(112, 180);
            btnZiyaretciGiris.Size = new Size(250, 42);
            Temalar.BirincilButonUygula(btnZiyaretciGiris);

            btnAdminGiris.Text = "Admin Girişi";
            btnAdminGiris.Location = new Point(392, 180);
            btnAdminGiris.Size = new Size(250, 42);
            Temalar.IkincilButonUygula(btnAdminGiris);

            lblKullanıcı.Text = "Kullanıcı Adı";
            lblKullanıcı.Location = new Point(112, 260);
            Temalar.EtiketUygula(lblKullanıcı);

            txtKullaniciAdi.Location = new Point(112, 288);
            txtKullaniciAdi.Size = new Size(210, 26);
            Temalar.GirisAlaniUygula(txtKullaniciAdi);

            lblSifre.Text = "Şifre";
            lblSifre.Location = new Point(344, 260);
            Temalar.EtiketUygula(lblSifre);

            txtSifre.Location = new Point(344, 288);
            txtSifre.Size = new Size(170, 26);
            txtSifre.PasswordChar = '*';
            Temalar.GirisAlaniUygula(txtSifre);

            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.Location = new Point(540, 280);
            btnGirisYap.Size = new Size(102, 40);
            Temalar.BirincilButonUygula(btnGirisYap);

            AdminGirisAlanlariniAyarla(false);
        }

        private void AdminGirisAlanlariniAyarla(bool visible)
        {
            lblKullanıcı.Visible = visible;
            txtKullaniciAdi.Visible = visible;
            lblSifre.Visible = visible;
            txtSifre.Visible = visible;
            btnGirisYap.Visible = visible;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            AdminGirisAlanlariniAyarla(true);
            txtKullaniciAdi.Focus();
        }

        private void btnZiyaretciGiris_Click(object sender, EventArgs e)
        {
            Form3 ziyaretciForm = new Form3();
            ziyaretciForm.FormClosed += (s, args) => this.Show();
            ziyaretciForm.Show();
            this.Hide();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string username = txtKullaniciAdi.Text.Trim();
            string password = txtSifre.Text;

            if (username == "admin" && password == "1234")
            {
                Form2 adminForm = new Form2();
                adminForm.FormClosed += (s, args) =>
                {
                    this.Show();
                    txtSifre.Clear();
                    AdminGirisAlanlariniAyarla(false);
                };
                adminForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSifre.Clear();
                txtSifre.Focus();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }
    }
}
