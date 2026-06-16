using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HayvanatBahcesiProje2025
{
    public partial class Form1 : Form
    {
      

        public void listele()
        {
        }
        public Form1()
        {
            InitializeComponent();
            ArayuzuDuzenle();
        }

        private void ArayuzuDuzenle()
        {
            Temalar.FormuUygula(this, "Hayvanat Bahcesi Yonetim Sistemi");
            ClientSize = new Size(820, 500);

            Panel anaPanel = Temalar.PanelOlustur(70, 62, 680, 350);
            Controls.Add(anaPanel);
            anaPanel.SendToBack();

            Controls.Add(Temalar.BaslikOlustur("Hayvanat Bahcesi Yonetim Sistemi", 110, 100, 600));
            Controls.Add(Temalar.AciklamaOlustur("Admin paneli ve ziyaretci bilgilendirme ekranina buradan erisebilirsiniz.", 112, 140, 590));

            btnZiyaretciGiris.Text = "Ziyaretci Ekrani";
            btnZiyaretciGiris.Location = new Point(112, 210);
            btnZiyaretciGiris.Size = new Size(250, 42);
            Temalar.BirincilButonUygula(btnZiyaretciGiris);

            btnAdminGiris.Text = "Admin Girisi";
            btnAdminGiris.Location = new Point(392, 210);
            btnAdminGiris.Size = new Size(250, 42);
            Temalar.IkincilButonUygula(btnAdminGiris);

            lblKullanıcı.Text = "Kullanici adi";
            lblKullanıcı.Location = new Point(112, 295);
            Temalar.EtiketUygula(lblKullanıcı);

            txtKullaniciAdi.Location = new Point(112, 322);
            txtKullaniciAdi.Size = new Size(210, 26);
            Temalar.GirisAlaniUygula(txtKullaniciAdi);

            lblSifre.Text = "Sifre";
            lblSifre.Location = new Point(344, 295);
            Temalar.EtiketUygula(lblSifre);

            txtSifre.Location = new Point(344, 322);
            txtSifre.Size = new Size(170, 26);
            txtSifre.PasswordChar = '*';
            Temalar.GirisAlaniUygula(txtSifre);

            btnGirisYap.Text = "Giris Yap";
            btnGirisYap.Location = new Point(540, 310);
            btnGirisYap.Size = new Size(102, 40);
            Temalar.BirincilButonUygula(btnGirisYap);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.Visible = true;
            txtSifre.Visible = true;
            btnZiyaretciGiris.Visible = true;
            lblSifre.Visible=true;
            lblKullanıcı.Visible=true;
            btnGirisYap.Visible=true;
        }

       

      

        private void btnZiyaretciGiris_Click(object sender, EventArgs e)
        {
            Form3 ziyaretciForm = new Form3();
            ziyaretciForm.Show();
            this.Hide();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            if (kullaniciAdi == "admin" && sifre == "1234")
            {
                Form2 adminForm = new Form2();
                adminForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                txtKullaniciAdi.Clear();
                txtSifre.Clear();
            }
        }



        //string sql = "INSERT INTO ziyaretci_loglari (tarih, ziyaretci_sayisi) VALUES (@tarih, @sayi)";




    }
}
