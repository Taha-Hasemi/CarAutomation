
namespace OtogaleriOtomasyonu
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.t_arama = new System.Windows.Forms.TextBox();
            this.l_arama = new System.Windows.Forms.Label();
            this.ekle_butonu = new System.Windows.Forms.Button();
            this.fiyat_guncelle_butonu = new System.Windows.Forms.Button();
            this.sil_butonu = new System.Windows.Forms.Button();
            this.l_ruhsat_no = new System.Windows.Forms.Label();
            this.l_marka = new System.Windows.Forms.Label();
            this.l_model = new System.Windows.Forms.Label();
            this.l_yakit_tipi = new System.Windows.Forms.Label();
            this.l_kasa_tipi = new System.Windows.Forms.Label();
            this.l_kilometresi = new System.Windows.Forms.Label();
            this.l_fiyati = new System.Windows.Forms.Label();
            this.t_ruhsat_no = new System.Windows.Forms.TextBox();
            this.t_fiyat = new System.Windows.Forms.TextBox();
            this.t_kilometre = new System.Windows.Forms.TextBox();
            this.c_marka = new System.Windows.Forms.ComboBox();
            this.c_kasa_tipi = new System.Windows.Forms.ComboBox();
            this.c_model = new System.Windows.Forms.ComboBox();
            this.c_yakit_tipi = new System.Windows.Forms.ComboBox();
            this.ara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(738, 163);
            this.dataGridView1.TabIndex = 0;
            // 
            // t_arama
            // 
            this.t_arama.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.t_arama.Location = new System.Drawing.Point(12, 161);
            this.t_arama.Name = "t_arama";
            this.t_arama.Size = new System.Drawing.Size(206, 23);
            this.t_arama.TabIndex = 1;
            this.t_arama.Click += new System.EventHandler(this.t_arama_Click);
            this.t_arama.Leave += new System.EventHandler(this.t_arama_Leave);
            // 
            // l_arama
            // 
            this.l_arama.AutoSize = true;
            this.l_arama.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.l_arama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_arama.Location = new System.Drawing.Point(12, 136);
            this.l_arama.Name = "l_arama";
            this.l_arama.Size = new System.Drawing.Size(56, 20);
            this.l_arama.TabIndex = 2;
            this.l_arama.Text = "Arama";
            this.l_arama.Click += new System.EventHandler(this.l_arama_Click);
            // 
            // ekle_butonu
            // 
            this.ekle_butonu.BackColor = System.Drawing.Color.Gray;
            this.ekle_butonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ekle_butonu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ekle_butonu.Location = new System.Drawing.Point(290, 161);
            this.ekle_butonu.Name = "ekle_butonu";
            this.ekle_butonu.Size = new System.Drawing.Size(74, 24);
            this.ekle_butonu.TabIndex = 3;
            this.ekle_butonu.Text = "KAYIT EKLE";
            this.ekle_butonu.UseVisualStyleBackColor = false;
            this.ekle_butonu.Click += new System.EventHandler(this.ekle_butonu_Click);
            // 
            // fiyat_guncelle_butonu
            // 
            this.fiyat_guncelle_butonu.BackColor = System.Drawing.Color.Gray;
            this.fiyat_guncelle_butonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fiyat_guncelle_butonu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fiyat_guncelle_butonu.Location = new System.Drawing.Point(370, 161);
            this.fiyat_guncelle_butonu.Name = "fiyat_guncelle_butonu";
            this.fiyat_guncelle_butonu.Size = new System.Drawing.Size(113, 24);
            this.fiyat_guncelle_butonu.TabIndex = 4;
            this.fiyat_guncelle_butonu.Text = "FIYAT GÜNCELLE";
            this.fiyat_guncelle_butonu.UseVisualStyleBackColor = false;
            this.fiyat_guncelle_butonu.Click += new System.EventHandler(this.fiyat_guncelle_butonu_Click);
            // 
            // sil_butonu
            // 
            this.sil_butonu.BackColor = System.Drawing.Color.Gray;
            this.sil_butonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sil_butonu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sil_butonu.Location = new System.Drawing.Point(489, 161);
            this.sil_butonu.Name = "sil_butonu";
            this.sil_butonu.Size = new System.Drawing.Size(75, 24);
            this.sil_butonu.TabIndex = 5;
            this.sil_butonu.Text = "SIL";
            this.sil_butonu.UseVisualStyleBackColor = false;
            this.sil_butonu.Click += new System.EventHandler(this.sil_butonu_Click);
            // 
            // l_ruhsat_no
            // 
            this.l_ruhsat_no.AutoSize = true;
            this.l_ruhsat_no.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.l_ruhsat_no.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_ruhsat_no.Location = new System.Drawing.Point(12, 15);
            this.l_ruhsat_no.Name = "l_ruhsat_no";
            this.l_ruhsat_no.Size = new System.Drawing.Size(72, 17);
            this.l_ruhsat_no.TabIndex = 6;
            this.l_ruhsat_no.Text = "Ruhsat No";
            // 
            // l_marka
            // 
            this.l_marka.AutoSize = true;
            this.l_marka.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.l_marka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_marka.Location = new System.Drawing.Point(13, 44);
            this.l_marka.Name = "l_marka";
            this.l_marka.Size = new System.Drawing.Size(46, 17);
            this.l_marka.TabIndex = 7;
            this.l_marka.Text = "Marka";
            // 
            // l_model
            // 
            this.l_model.AutoSize = true;
            this.l_model.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.l_model.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_model.Location = new System.Drawing.Point(13, 75);
            this.l_model.Name = "l_model";
            this.l_model.Size = new System.Drawing.Size(47, 17);
            this.l_model.TabIndex = 8;
            this.l_model.Text = "Model";
            // 
            // l_yakit_tipi
            // 
            this.l_yakit_tipi.AutoSize = true;
            this.l_yakit_tipi.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.l_yakit_tipi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_yakit_tipi.Location = new System.Drawing.Point(13, 102);
            this.l_yakit_tipi.Name = "l_yakit_tipi";
            this.l_yakit_tipi.Size = new System.Drawing.Size(66, 17);
            this.l_yakit_tipi.TabIndex = 9;
            this.l_yakit_tipi.Text = "Yakıt Tipi";
            // 
            // l_kasa_tipi
            // 
            this.l_kasa_tipi.AutoSize = true;
            this.l_kasa_tipi.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.l_kasa_tipi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_kasa_tipi.Location = new System.Drawing.Point(217, 49);
            this.l_kasa_tipi.Name = "l_kasa_tipi";
            this.l_kasa_tipi.Size = new System.Drawing.Size(64, 17);
            this.l_kasa_tipi.TabIndex = 10;
            this.l_kasa_tipi.Text = "Kasa Tipi";
            // 
            // l_kilometresi
            // 
            this.l_kilometresi.AutoSize = true;
            this.l_kilometresi.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.l_kilometresi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_kilometresi.Location = new System.Drawing.Point(217, 75);
            this.l_kilometresi.Name = "l_kilometresi";
            this.l_kilometresi.Size = new System.Drawing.Size(78, 17);
            this.l_kilometresi.TabIndex = 11;
            this.l_kilometresi.Text = "Kilometresi";
            // 
            // l_fiyati
            // 
            this.l_fiyati.AutoSize = true;
            this.l_fiyati.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.l_fiyati.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_fiyati.Location = new System.Drawing.Point(217, 102);
            this.l_fiyati.Name = "l_fiyati";
            this.l_fiyati.Size = new System.Drawing.Size(42, 17);
            this.l_fiyati.TabIndex = 12;
            this.l_fiyati.Text = "Fiyatı";
            // 
            // t_ruhsat_no
            // 
            this.t_ruhsat_no.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.t_ruhsat_no.Location = new System.Drawing.Point(90, 14);
            this.t_ruhsat_no.Name = "t_ruhsat_no";
            this.t_ruhsat_no.Size = new System.Drawing.Size(121, 23);
            this.t_ruhsat_no.TabIndex = 13;
            this.t_ruhsat_no.Click += new System.EventHandler(this.t_arama_Click);
            this.t_ruhsat_no.Leave += new System.EventHandler(this.t_arama_Leave);
            // 
            // t_fiyat
            // 
            this.t_fiyat.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.t_fiyat.Location = new System.Drawing.Point(304, 101);
            this.t_fiyat.Name = "t_fiyat";
            this.t_fiyat.Size = new System.Drawing.Size(122, 23);
            this.t_fiyat.TabIndex = 14;
            this.t_fiyat.Click += new System.EventHandler(this.t_arama_Click);
            this.t_fiyat.Leave += new System.EventHandler(this.t_arama_Leave);
            // 
            // t_kilometre
            // 
            this.t_kilometre.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.t_kilometre.Location = new System.Drawing.Point(304, 72);
            this.t_kilometre.Name = "t_kilometre";
            this.t_kilometre.Size = new System.Drawing.Size(122, 23);
            this.t_kilometre.TabIndex = 15;
            this.t_kilometre.Click += new System.EventHandler(this.t_arama_Click);
            this.t_kilometre.Leave += new System.EventHandler(this.t_arama_Leave);
            // 
            // c_marka
            // 
            this.c_marka.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.c_marka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_marka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_marka.FormattingEnabled = true;
            this.c_marka.Items.AddRange(new object[] {
            "Toyota",
            "Honda",
            "Opel"});
            this.c_marka.Location = new System.Drawing.Point(90, 43);
            this.c_marka.Name = "c_marka";
            this.c_marka.Size = new System.Drawing.Size(121, 23);
            this.c_marka.TabIndex = 16;
            this.c_marka.SelectedIndexChanged += new System.EventHandler(this.c_marka_SelectedIndexChanged);
            this.c_marka.Click += new System.EventHandler(this.t_arama_Click);
            this.c_marka.Leave += new System.EventHandler(this.t_arama_Leave);
            // 
            // c_kasa_tipi
            // 
            this.c_kasa_tipi.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.c_kasa_tipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_kasa_tipi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_kasa_tipi.FormattingEnabled = true;
            this.c_kasa_tipi.Items.AddRange(new object[] {
            "Sedan",
            "Hatchback"});
            this.c_kasa_tipi.Location = new System.Drawing.Point(304, 43);
            this.c_kasa_tipi.Name = "c_kasa_tipi";
            this.c_kasa_tipi.Size = new System.Drawing.Size(122, 23);
            this.c_kasa_tipi.TabIndex = 17;
            this.c_kasa_tipi.Click += new System.EventHandler(this.t_arama_Click);
            this.c_kasa_tipi.Leave += new System.EventHandler(this.t_arama_Leave);
            // 
            // c_model
            // 
            this.c_model.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.c_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_model.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_model.FormattingEnabled = true;
            this.c_model.Location = new System.Drawing.Point(90, 72);
            this.c_model.Name = "c_model";
            this.c_model.Size = new System.Drawing.Size(121, 23);
            this.c_model.TabIndex = 18;
            this.c_model.Click += new System.EventHandler(this.t_arama_Click);
            this.c_model.Leave += new System.EventHandler(this.t_arama_Leave);
            // 
            // c_yakit_tipi
            // 
            this.c_yakit_tipi.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.c_yakit_tipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_yakit_tipi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_yakit_tipi.FormattingEnabled = true;
            this.c_yakit_tipi.Items.AddRange(new object[] {
            "Benzinli",
            "Dizel",
            "Benzinli ve Tüplü"});
            this.c_yakit_tipi.Location = new System.Drawing.Point(90, 101);
            this.c_yakit_tipi.Name = "c_yakit_tipi";
            this.c_yakit_tipi.Size = new System.Drawing.Size(121, 23);
            this.c_yakit_tipi.TabIndex = 19;
            this.c_yakit_tipi.Click += new System.EventHandler(this.t_arama_Click);
            this.c_yakit_tipi.Leave += new System.EventHandler(this.t_arama_Leave);
            // 
            // ara
            // 
            this.ara.BackColor = System.Drawing.Color.Gray;
            this.ara.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ara.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ara.Location = new System.Drawing.Point(224, 161);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(57, 24);
            this.ara.TabIndex = 20;
            this.ara.Text = "ARA";
            this.ara.UseVisualStyleBackColor = false;
            this.ara.Click += new System.EventHandler(this.ara_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(762, 368);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.c_yakit_tipi);
            this.Controls.Add(this.c_model);
            this.Controls.Add(this.c_kasa_tipi);
            this.Controls.Add(this.c_marka);
            this.Controls.Add(this.t_kilometre);
            this.Controls.Add(this.t_fiyat);
            this.Controls.Add(this.t_ruhsat_no);
            this.Controls.Add(this.l_fiyati);
            this.Controls.Add(this.l_kilometresi);
            this.Controls.Add(this.l_kasa_tipi);
            this.Controls.Add(this.l_yakit_tipi);
            this.Controls.Add(this.l_model);
            this.Controls.Add(this.l_marka);
            this.Controls.Add(this.l_ruhsat_no);
            this.Controls.Add(this.sil_butonu);
            this.Controls.Add(this.fiyat_guncelle_butonu);
            this.Controls.Add(this.ekle_butonu);
            this.Controls.Add(this.l_arama);
            this.Controls.Add(this.t_arama);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox t_arama;
        private System.Windows.Forms.Label l_arama;
        private System.Windows.Forms.Button ekle_butonu;
        private System.Windows.Forms.Button fiyat_guncelle_butonu;
        private System.Windows.Forms.Button sil_butonu;
        private System.Windows.Forms.Label l_ruhsat_no;
        private System.Windows.Forms.Label l_marka;
        private System.Windows.Forms.Label l_model;
        private System.Windows.Forms.Label l_yakit_tipi;
        private System.Windows.Forms.Label l_kasa_tipi;
        private System.Windows.Forms.Label l_kilometresi;
        private System.Windows.Forms.Label l_fiyati;
        private System.Windows.Forms.TextBox t_ruhsat_no;
        private System.Windows.Forms.TextBox t_fiyat;
        private System.Windows.Forms.TextBox t_kilometre;
        private System.Windows.Forms.ComboBox c_marka;
        private System.Windows.Forms.ComboBox c_kasa_tipi;
        private System.Windows.Forms.ComboBox c_model;
        private System.Windows.Forms.ComboBox c_yakit_tipi;
        private System.Windows.Forms.Button ara;
    }
}

