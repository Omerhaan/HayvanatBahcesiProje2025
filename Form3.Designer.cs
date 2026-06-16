namespace HayvanatBahcesiProje2025
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbHayvan = new System.Windows.Forms.ComboBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.dgvHayvanlar = new System.Windows.Forms.DataGridView();
            this.hayvanatBahcesiVTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hayvanatBahcesiVTDataSet = new HayvanatBahcesiProje2025.HayvanatBahcesiVTDataSet();
            this.dtpSaat = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHayvanlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanatBahcesiVTDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanatBahcesiVTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(522, 308);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 22);
            this.dtpTarih.TabIndex = 0;
            // 
            // cmbHayvan
            // 
            this.cmbHayvan.FormattingEnabled = true;
            this.cmbHayvan.Location = new System.Drawing.Point(331, 266);
            this.cmbHayvan.Name = "cmbHayvan";
            this.cmbHayvan.Size = new System.Drawing.Size(121, 24);
            this.cmbHayvan.TabIndex = 1;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(316, 237);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(149, 23);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "Hayvanları Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dgvHayvanlar
            // 
            this.dgvHayvanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHayvanlar.Location = new System.Drawing.Point(0, 1);
            this.dgvHayvanlar.Name = "dgvHayvanlar";
            this.dgvHayvanlar.RowHeadersWidth = 51;
            this.dgvHayvanlar.RowTemplate.Height = 24;
            this.dgvHayvanlar.Size = new System.Drawing.Size(868, 230);
            this.dgvHayvanlar.TabIndex = 3;
            this.dgvHayvanlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHayvanlar_CellContentClick);
            // 
            // hayvanatBahcesiVTDataSetBindingSource
            // 
            this.hayvanatBahcesiVTDataSetBindingSource.DataSource = this.hayvanatBahcesiVTDataSet;
            this.hayvanatBahcesiVTDataSetBindingSource.Position = 0;
            // 
            // hayvanatBahcesiVTDataSet
            // 
            this.hayvanatBahcesiVTDataSet.DataSetName = "HayvanatBahcesiVTDataSet";
            this.hayvanatBahcesiVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpSaat
            // 
            this.dtpSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSaat.Location = new System.Drawing.Point(522, 344);
            this.dtpSaat.Name = "dtpSaat";
            this.dtpSaat.ShowUpDown = true;
            this.dtpSaat.Size = new System.Drawing.Size(200, 22);
            this.dtpSaat.TabIndex = 4;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(351, 397);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad Soyad:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(122, 305);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(164, 22);
            this.txtAdSoyad.TabIndex = 7;
            this.txtAdSoyad.TextChanged += new System.EventHandler(this.txtAdSoyad_TextChanged);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek",
            "Belirtmek istemiyorum"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(122, 339);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(100, 24);
            this.cmbCinsiyet.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cinsiyet:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dtpSaat);
            this.Controls.Add(this.dgvHayvanlar);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.cmbHayvan);
            this.Controls.Add(this.dtpTarih);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHayvanlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanatBahcesiVTDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanatBahcesiVTDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ComboBox cmbHayvan;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dgvHayvanlar;
        private System.Windows.Forms.BindingSource hayvanatBahcesiVTDataSetBindingSource;
        private HayvanatBahcesiVTDataSet hayvanatBahcesiVTDataSet;
        private System.Windows.Forms.DateTimePicker dtpSaat;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label label2;
    }
}