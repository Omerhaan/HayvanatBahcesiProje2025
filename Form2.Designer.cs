namespace HayvanatBahcesiProje2025
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dgvHayvanlar = new System.Windows.Forms.DataGridView();
            this.hayvanatBahcesiVTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hayvanatBahcesiVTDataSet = new HayvanatBahcesiProje2025.HayvanatBahcesiVTDataSet();
            this.dtpYemek = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmbHayvanlar = new System.Windows.Forms.ComboBox();
            this.cmbSaglik = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHayvanlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanatBahcesiVTDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanatBahcesiVTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHayvanlar
            // 
            this.dgvHayvanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHayvanlar.Location = new System.Drawing.Point(-1, -1);
            this.dgvHayvanlar.Name = "dgvHayvanlar";
            this.dgvHayvanlar.RowHeadersWidth = 51;
            this.dgvHayvanlar.RowTemplate.Height = 24;
            this.dgvHayvanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHayvanlar.Size = new System.Drawing.Size(945, 260);
            this.dgvHayvanlar.TabIndex = 0;
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
            // dtpYemek
            // 
            this.dtpYemek.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpYemek.Location = new System.Drawing.Point(625, 283);
            this.dtpYemek.Name = "dtpYemek";
            this.dtpYemek.ShowUpDown = true;
            this.dtpYemek.Size = new System.Drawing.Size(121, 22);
            this.dtpYemek.TabIndex = 2;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpBaslangic.Location = new System.Drawing.Point(625, 325);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.ShowUpDown = true;
            this.dtpBaslangic.Size = new System.Drawing.Size(121, 22);
            this.dtpBaslangic.TabIndex = 3;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuncelle.Location = new System.Drawing.Point(435, 405);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmbHayvanlar
            // 
            this.cmbHayvanlar.FormattingEnabled = true;
            this.cmbHayvanlar.Location = new System.Drawing.Point(285, 280);
            this.cmbHayvanlar.Name = "cmbHayvanlar";
            this.cmbHayvanlar.Size = new System.Drawing.Size(121, 24);
            this.cmbHayvanlar.TabIndex = 6;
            this.cmbHayvanlar.SelectedIndexChanged += new System.EventHandler(this.cmbHayvanlar_SelectedIndexChanged);
            // 
            // cmbSaglik
            // 
            this.cmbSaglik.FormattingEnabled = true;
            this.cmbSaglik.Location = new System.Drawing.Point(285, 319);
            this.cmbSaglik.Name = "cmbSaglik";
            this.cmbSaglik.Size = new System.Drawing.Size(121, 24);
            this.cmbSaglik.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hayvan Seç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Beslenme Saati";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dolaşma Başlangıç";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Durumu";
            // 
            // dtpBitis
            // 
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpBitis.Location = new System.Drawing.Point(625, 373);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.ShowUpDown = true;
            this.dtpBitis.Size = new System.Drawing.Size(121, 22);
            this.dtpBitis.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dolaşma Bitiş";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSaglik);
            this.Controls.Add(this.cmbHayvanlar);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.dtpYemek);
            this.Controls.Add(this.dgvHayvanlar);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHayvanlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanatBahcesiVTDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanatBahcesiVTDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHayvanlar;
        private System.Windows.Forms.DateTimePicker dtpYemek;
        private System.Windows.Forms.BindingSource hayvanatBahcesiVTDataSetBindingSource;
        private HayvanatBahcesiVTDataSet hayvanatBahcesiVTDataSet;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cmbHayvanlar;
        private System.Windows.Forms.ComboBox cmbSaglik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label label5;
    }
}