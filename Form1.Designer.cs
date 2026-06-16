namespace HayvanatBahcesiProje2025
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hayvanatBahcesiVTDataSet = new HayvanatBahcesiProje2025.HayvanatBahcesiVTDataSet();
            this.hayvanatBahcesiVTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.btnZiyaretciGiris = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblKullanıcı = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanatBahcesiVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanatBahcesiVTDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hayvanatBahcesiVTDataSet
            // 
            this.hayvanatBahcesiVTDataSet.DataSetName = "HayvanatBahcesiVTDataSet";
            this.hayvanatBahcesiVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hayvanatBahcesiVTDataSetBindingSource
            // 
            this.hayvanatBahcesiVTDataSetBindingSource.DataSource = this.hayvanatBahcesiVTDataSet;
            this.hayvanatBahcesiVTDataSetBindingSource.Position = 0;
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.Location = new System.Drawing.Point(547, 212);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(109, 23);
            this.btnAdminGiris.TabIndex = 0;
            this.btnAdminGiris.Text = "Admin Girişi";
            this.btnAdminGiris.UseVisualStyleBackColor = true;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // btnZiyaretciGiris
            // 
            this.btnZiyaretciGiris.Location = new System.Drawing.Point(283, 212);
            this.btnZiyaretciGiris.Name = "btnZiyaretciGiris";
            this.btnZiyaretciGiris.Size = new System.Drawing.Size(109, 23);
            this.btnZiyaretciGiris.TabIndex = 1;
            this.btnZiyaretciGiris.Text = "Kullanıcı Girişi";
            this.btnZiyaretciGiris.UseVisualStyleBackColor = true;
            this.btnZiyaretciGiris.Click += new System.EventHandler(this.btnZiyaretciGiris_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(547, 300);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 22);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.Visible = false;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(547, 254);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 22);
            this.txtKullaniciAdi.TabIndex = 3;
            this.txtKullaniciAdi.Visible = false;
            // 
            // lblKullanıcı
            // 
            this.lblKullanıcı.AutoSize = true;
            this.lblKullanıcı.Location = new System.Drawing.Point(430, 254);
            this.lblKullanıcı.Name = "lblKullanıcı";
            this.lblKullanıcı.Size = new System.Drawing.Size(78, 16);
            this.lblKullanıcı.TabIndex = 4;
            this.lblKullanıcı.Text = "Kullanıcı adı";
            this.lblKullanıcı.Visible = false;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(430, 300);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(34, 16);
            this.lblSifre.TabIndex = 5;
            this.lblSifre.Text = "Şifre";
            this.lblSifre.Visible = false;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(434, 331);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(75, 23);
            this.btnGirisYap.TabIndex = 6;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Visible = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(903, 446);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullanıcı);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.btnZiyaretciGiris);
            this.Controls.Add(this.btnAdminGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hayvanatBahcesiVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanatBahcesiVTDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource hayvanatBahcesiVTDataSetBindingSource;
        private HayvanatBahcesiVTDataSet hayvanatBahcesiVTDataSet;
        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Button btnZiyaretciGiris;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblKullanıcı;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Button btnGirisYap;
    }
}

