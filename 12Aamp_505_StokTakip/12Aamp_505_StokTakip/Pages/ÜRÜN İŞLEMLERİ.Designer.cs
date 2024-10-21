namespace AMP12A_2876_StokTakipProgram
{
    partial class ÜRÜN_İŞLEMLERİ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÜRÜN_İŞLEMLERİ));
            this.lblGiriş = new System.Windows.Forms.Label();
            this.lblÜrünAdı = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lblaçıklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.btnKategori = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTedarikci = new System.Windows.Forms.ComboBox();
            this.lblstok = new System.Windows.Forms.Label();
            this.nmrStok = new System.Windows.Forms.DomainUpDown();
            this.lblfiyat = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnYeniKayıt = new System.Windows.Forms.Button();
            this.imgÜrün = new System.Windows.Forms.ImageList(this.components);
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.grdUrunler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGiriş
            // 
            this.lblGiriş.AutoSize = true;
            this.lblGiriş.Location = new System.Drawing.Point(13, 13);
            this.lblGiriş.Name = "lblGiriş";
            this.lblGiriş.Size = new System.Drawing.Size(69, 13);
            this.lblGiriş.TabIndex = 0;
            this.lblGiriş.Text = "BİLGİ GİRİŞİ";
            // 
            // lblÜrünAdı
            // 
            this.lblÜrünAdı.AutoSize = true;
            this.lblÜrünAdı.Location = new System.Drawing.Point(36, 62);
            this.lblÜrünAdı.Name = "lblÜrünAdı";
            this.lblÜrünAdı.Size = new System.Drawing.Size(54, 13);
            this.lblÜrünAdı.TabIndex = 1;
            this.lblÜrünAdı.Text = "Ürün Adı :";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUrunAdi.Location = new System.Drawing.Point(123, 59);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(122, 20);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // lblaçıklama
            // 
            this.lblaçıklama.AutoSize = true;
            this.lblaçıklama.Location = new System.Drawing.Point(39, 109);
            this.lblaçıklama.Name = "lblaçıklama";
            this.lblaçıklama.Size = new System.Drawing.Size(56, 13);
            this.lblaçıklama.TabIndex = 3;
            this.lblaçıklama.Text = "Açıklama :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtAciklama.Location = new System.Drawing.Point(123, 109);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(122, 96);
            this.txtAciklama.TabIndex = 4;
            this.txtAciklama.Text = "";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(369, 61);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(52, 13);
            this.lblKategori.TabIndex = 5;
            this.lblKategori.Text = "Kategori :";
            // 
            // cmbKategori
            // 
            this.cmbKategori.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(428, 62);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 21);
            this.cmbKategori.TabIndex = 6;
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(555, 59);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(37, 23);
            this.btnKategori.TabIndex = 7;
            this.btnKategori.Text = "...";
            this.btnKategori.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(624, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tedarikçi :";
            // 
            // cmbTedarikci
            // 
            this.cmbTedarikci.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbTedarikci.FormattingEnabled = true;
            this.cmbTedarikci.Location = new System.Drawing.Point(687, 61);
            this.cmbTedarikci.Name = "cmbTedarikci";
            this.cmbTedarikci.Size = new System.Drawing.Size(121, 21);
            this.cmbTedarikci.TabIndex = 9;
            // 
            // lblstok
            // 
            this.lblstok.AutoSize = true;
            this.lblstok.Location = new System.Drawing.Point(369, 112);
            this.lblstok.Name = "lblstok";
            this.lblstok.Size = new System.Drawing.Size(65, 13);
            this.lblstok.TabIndex = 10;
            this.lblstok.Text = "Stok Adedi :";
            // 
            // nmrStok
            // 
            this.nmrStok.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nmrStok.Location = new System.Drawing.Point(429, 107);
            this.nmrStok.Name = "nmrStok";
            this.nmrStok.Size = new System.Drawing.Size(120, 20);
            this.nmrStok.TabIndex = 11;
            this.nmrStok.Text = "0";
            // 
            // lblfiyat
            // 
            this.lblfiyat.AutoSize = true;
            this.lblfiyat.Location = new System.Drawing.Point(624, 112);
            this.lblfiyat.Name = "lblfiyat";
            this.lblfiyat.Size = new System.Drawing.Size(37, 13);
            this.lblfiyat.TabIndex = 12;
            this.lblfiyat.Text = "Fiyatı :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(687, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // BtnYeniKayıt
            // 
            this.BtnYeniKayıt.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnYeniKayıt.ImageKey = "plus-icon-2048x2048-z6v59bd6.png";
            this.BtnYeniKayıt.ImageList = this.imgÜrün;
            this.BtnYeniKayıt.Location = new System.Drawing.Point(265, 245);
            this.BtnYeniKayıt.Name = "BtnYeniKayıt";
            this.BtnYeniKayıt.Size = new System.Drawing.Size(99, 24);
            this.BtnYeniKayıt.TabIndex = 14;
            this.BtnYeniKayıt.Text = "YENİ KAYIT";
            this.BtnYeniKayıt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnYeniKayıt.UseVisualStyleBackColor = true;
            // 
            // imgÜrün
            // 
            this.imgÜrün.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgÜrün.ImageStream")));
            this.imgÜrün.TransparentColor = System.Drawing.Color.Transparent;
            this.imgÜrün.Images.SetKeyName(0, "plus-icon-2048x2048-z6v59bd6.png");
            this.imgÜrün.Images.SetKeyName(1, "png-transparent-computer-icons-tango-desktop-project-update-button-miscellaneous-" +
        "blue-angle-thumbnail.png");
            this.imgÜrün.Images.SetKeyName(2, "images.png");
            this.imgÜrün.Images.SetKeyName(3, "929430.png");
            this.imgÜrün.Images.SetKeyName(4, "png-transparent-firefox-computer-icons-computer-software-patch-update-button-comp" +
        "uter-network-trademark-computer-wallpaper-thumbnail.png");
            // 
            // BtnEkle
            // 
            this.BtnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEkle.ImageKey = "plus-icon-2048x2048-z6v59bd6.png";
            this.BtnEkle.ImageList = this.imgÜrün;
            this.BtnEkle.Location = new System.Drawing.Point(440, 245);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(79, 24);
            this.BtnEkle.TabIndex = 15;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = true;
            // 
            // BtnSil
            // 
            this.BtnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSil.ImageKey = "929430.png";
            this.BtnSil.ImageList = this.imgÜrün;
            this.BtnSil.Location = new System.Drawing.Point(555, 245);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(75, 24);
            this.BtnSil.TabIndex = 16;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = true;
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGüncelle.ImageKey = "png-transparent-firefox-computer-icons-computer-software-patch-update-button-comp" +
    "uter-network-trademark-computer-wallpaper-thumbnail.png";
            this.BtnGüncelle.ImageList = this.imgÜrün;
            this.BtnGüncelle.Location = new System.Drawing.Point(665, 246);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(102, 23);
            this.BtnGüncelle.TabIndex = 17;
            this.BtnGüncelle.Text = "GÜNCELLE";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            // 
            // grdUrunler
            // 
            this.grdUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUrunler.Location = new System.Drawing.Point(12, 288);
            this.grdUrunler.Name = "grdUrunler";
            this.grdUrunler.Size = new System.Drawing.Size(796, 150);
            this.grdUrunler.TabIndex = 18;
            // 
            // ÜRÜN_İŞLEMLERİ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.grdUrunler);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BtnYeniKayıt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblfiyat);
            this.Controls.Add(this.nmrStok);
            this.Controls.Add(this.lblstok);
            this.Controls.Add(this.cmbTedarikci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKategori);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblaçıklama);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lblÜrünAdı);
            this.Controls.Add(this.lblGiriş);
            this.Name = "ÜRÜN_İŞLEMLERİ";
            this.Text = "ÜRÜN İŞLEMLERİ";
            ((System.ComponentModel.ISupportInitialize)(this.grdUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGiriş;
        private System.Windows.Forms.Label lblÜrünAdı;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label lblaçıklama;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTedarikci;
        private System.Windows.Forms.Label lblstok;
        private System.Windows.Forms.DomainUpDown nmrStok;
        private System.Windows.Forms.Label lblfiyat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnYeniKayıt;
        private System.Windows.Forms.ImageList imgÜrün;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.DataGridView grdUrunler;
    }
}