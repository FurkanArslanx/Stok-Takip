namespace AMP12A_2876_StokTakipProgram
{
    partial class frmPersonelIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelIslemleri));
            this.lblBilgi = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lblKullanıcı = new System.Windows.Forms.Label();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblSıfre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.lblYetkı = new System.Windows.Forms.Label();
            this.cmbYetkı = new System.Windows.Forms.ComboBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.İmgPersonel = new System.Windows.Forms.ImageList(this.components);
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.grdPersoneller = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdPersoneller)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Location = new System.Drawing.Point(12, 18);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(69, 13);
            this.lblBilgi.TabIndex = 0;
            this.lblBilgi.Text = "BİLGİ GİRİŞİ";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(81, 60);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(26, 13);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(114, 60);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(111, 20);
            this.txtAd.TabIndex = 2;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(61, 102);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(46, 13);
            this.lblTelefon.TabIndex = 3;
            this.lblTelefon.Text = "Telefon:";
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(114, 102);
            this.mskTelefon.Mask = "(____) _____ - _____";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(111, 20);
            this.mskTelefon.TabIndex = 4;
            // 
            // lblKullanıcı
            // 
            this.lblKullanıcı.AutoSize = true;
            this.lblKullanıcı.Location = new System.Drawing.Point(37, 142);
            this.lblKullanıcı.Name = "lblKullanıcı";
            this.lblKullanıcı.Size = new System.Drawing.Size(70, 13);
            this.lblKullanıcı.TabIndex = 5;
            this.lblKullanıcı.Text = "Kullanıcı Adı :";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(114, 139);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(111, 20);
            this.txtKullanici.TabIndex = 6;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(297, 66);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(43, 13);
            this.lblSoyad.TabIndex = 7;
            this.lblSoyad.Text = "Soyad :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(346, 63);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(129, 20);
            this.txtSoyad.TabIndex = 8;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(300, 105);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(29, 13);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "Mail:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(346, 102);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(129, 20);
            this.txtMail.TabIndex = 10;
            // 
            // lblSıfre
            // 
            this.lblSıfre.AutoSize = true;
            this.lblSıfre.Location = new System.Drawing.Point(300, 146);
            this.lblSıfre.Name = "lblSıfre";
            this.lblSıfre.Size = new System.Drawing.Size(31, 13);
            this.lblSıfre.TabIndex = 11;
            this.lblSıfre.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(346, 146);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(129, 20);
            this.txtSifre.TabIndex = 12;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(561, 60);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(37, 13);
            this.lblAdres.TabIndex = 13;
            this.lblAdres.Text = "Adres:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(604, 57);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(140, 87);
            this.txtAdres.TabIndex = 14;
            this.txtAdres.Text = "";
            // 
            // lblYetkı
            // 
            this.lblYetkı.AutoSize = true;
            this.lblYetkı.Location = new System.Drawing.Point(561, 153);
            this.lblYetkı.Name = "lblYetkı";
            this.lblYetkı.Size = new System.Drawing.Size(37, 13);
            this.lblYetkı.TabIndex = 15;
            this.lblYetkı.Text = "Yetki :";
            // 
            // cmbYetkı
            // 
            this.cmbYetkı.FormattingEnabled = true;
            this.cmbYetkı.Location = new System.Drawing.Point(604, 150);
            this.cmbYetkı.Name = "cmbYetkı";
            this.cmbYetkı.Size = new System.Drawing.Size(140, 21);
            this.cmbYetkı.TabIndex = 16;
            // 
            // btnYeni
            // 
            this.btnYeni.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYeni.ImageKey = "plus-icon-2048x2048-z6v59bd6.png";
            this.btnYeni.ImageList = this.İmgPersonel;
            this.btnYeni.Location = new System.Drawing.Point(40, 196);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(102, 23);
            this.btnYeni.TabIndex = 17;
            this.btnYeni.Text = "YENİ KAYIT";
            this.btnYeni.UseVisualStyleBackColor = true;
            // 
            // İmgPersonel
            // 
            this.İmgPersonel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("İmgPersonel.ImageStream")));
            this.İmgPersonel.TransparentColor = System.Drawing.Color.Transparent;
            this.İmgPersonel.Images.SetKeyName(0, "plus-icon-2048x2048-z6v59bd6.png");
            this.İmgPersonel.Images.SetKeyName(1, "929430.png");
            this.İmgPersonel.Images.SetKeyName(2, "png-transparent-firefox-computer-icons-computer-software-patch-update-button-comp" +
        "uter-network-trademark-computer-wallpaper-thumbnail.png");
            // 
            // btnEkle
            // 
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.ImageKey = "plus-icon-2048x2048-z6v59bd6.png";
            this.btnEkle.ImageList = this.İmgPersonel;
            this.btnEkle.Location = new System.Drawing.Point(477, 195);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 18;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.ImageKey = "929430.png";
            this.btnSil.ImageList = this.İmgPersonel;
            this.btnSil.Location = new System.Drawing.Point(564, 196);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 19;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.ImageKey = "png-transparent-firefox-computer-icons-computer-software-patch-update-button-comp" +
    "uter-network-trademark-computer-wallpaper-thumbnail.png";
            this.btnGuncelle.ImageList = this.İmgPersonel;
            this.btnGuncelle.Location = new System.Drawing.Point(657, 195);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(105, 23);
            this.btnGuncelle.TabIndex = 20;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // grdPersoneller
            // 
            this.grdPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPersoneller.Location = new System.Drawing.Point(28, 288);
            this.grdPersoneller.Name = "grdPersoneller";
            this.grdPersoneller.Size = new System.Drawing.Size(745, 150);
            this.grdPersoneller.TabIndex = 21;
            // 
            // frmPersonelIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdPersoneller);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.cmbYetkı);
            this.Controls.Add(this.lblYetkı);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSıfre);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.lblKullanıcı);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblBilgi);
            this.Name = "frmPersonelIslemleri";
            this.Text = "PERSONEL İŞLEMLERİ";
            ((System.ComponentModel.ISupportInitialize)(this.grdPersoneller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.Label lblKullanıcı;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblSıfre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.Label lblYetkı;
        private System.Windows.Forms.ComboBox cmbYetkı;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.ImageList İmgPersonel;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView grdPersoneller;
    }
}