namespace AMP12A_2876_StokTakipProgram
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
            this.lblbilgirişi = new System.Windows.Forms.Label();
            this.lblfirma = new System.Windows.Forms.Label();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.lbltelefon = new System.Windows.Forms.Label();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lblyetkil = new System.Windows.Forms.Label();
            this.txtYetkiliAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lbladres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.İmgTedarik = new System.Windows.Forms.ImageList(this.components);
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.grdTedarikciler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdTedarikciler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbilgirişi
            // 
            this.lblbilgirişi.AutoSize = true;
            this.lblbilgirişi.Location = new System.Drawing.Point(13, 13);
            this.lblbilgirişi.Name = "lblbilgirişi";
            this.lblbilgirişi.Size = new System.Drawing.Size(69, 13);
            this.lblbilgirişi.TabIndex = 0;
            this.lblbilgirişi.Text = "BİLGİ GİRİŞİ";
            // 
            // lblfirma
            // 
            this.lblfirma.AutoSize = true;
            this.lblfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfirma.Location = new System.Drawing.Point(23, 65);
            this.lblfirma.Name = "lblfirma";
            this.lblfirma.Size = new System.Drawing.Size(70, 16);
            this.lblfirma.TabIndex = 1;
            this.lblfirma.Text = "Firma Adı :";
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtFirmaAdi.Location = new System.Drawing.Point(100, 65);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(126, 20);
            this.txtFirmaAdi.TabIndex = 2;
            // 
            // lbltelefon
            // 
            this.lbltelefon.AutoSize = true;
            this.lbltelefon.Location = new System.Drawing.Point(26, 127);
            this.lbltelefon.Name = "lbltelefon";
            this.lbltelefon.Size = new System.Drawing.Size(49, 13);
            this.lbltelefon.TabIndex = 3;
            this.lbltelefon.Text = "Telefon :";
            // 
            // mskTelefon
            // 
            this.mskTelefon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mskTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTelefon.Location = new System.Drawing.Point(100, 127);
            this.mskTelefon.Mask = "(____) _____ - _______";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(126, 22);
            this.mskTelefon.TabIndex = 4;
            // 
            // lblyetkil
            // 
            this.lblyetkil.AutoSize = true;
            this.lblyetkil.Location = new System.Drawing.Point(296, 71);
            this.lblyetkil.Name = "lblyetkil";
            this.lblyetkil.Size = new System.Drawing.Size(90, 13);
            this.lblyetkil.TabIndex = 5;
            this.lblyetkil.Text = "Yetkili Ad Soyad :";
            // 
            // txtYetkiliAdi
            // 
            this.txtYetkiliAdi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtYetkiliAdi.Location = new System.Drawing.Point(399, 64);
            this.txtYetkiliAdi.Name = "txtYetkiliAdi";
            this.txtYetkiliAdi.Size = new System.Drawing.Size(105, 20);
            this.txtYetkiliAdi.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mail :";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMail.Location = new System.Drawing.Point(399, 124);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(105, 20);
            this.txtMail.TabIndex = 8;
            // 
            // lbladres
            // 
            this.lbladres.AutoSize = true;
            this.lbladres.Location = new System.Drawing.Point(571, 67);
            this.lbladres.Name = "lbladres";
            this.lbladres.Size = new System.Drawing.Size(40, 13);
            this.lbladres.TabIndex = 9;
            this.lbladres.Text = "Adres :";
            this.lbladres.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(629, 71);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(192, 96);
            this.txtAdres.TabIndex = 10;
            this.txtAdres.Text = "";
            // 
            // btnEkle
            // 
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.ImageKey = "plus.png";
            this.btnEkle.ImageList = this.İmgTedarik;
            this.btnEkle.Location = new System.Drawing.Point(560, 219);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(79, 37);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // İmgTedarik
            // 
            this.İmgTedarik.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("İmgTedarik.ImageStream")));
            this.İmgTedarik.TransparentColor = System.Drawing.Color.Transparent;
            this.İmgTedarik.Images.SetKeyName(0, "images (1).jpg");
            this.İmgTedarik.Images.SetKeyName(1, "images.jpg");
            this.İmgTedarik.Images.SetKeyName(2, "plus.png");
            this.İmgTedarik.Images.SetKeyName(3, "pngimg.com - minus_PNG39.png");
            // 
            // btnSil
            // 
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.ImageKey = "pngimg.com - minus_PNG39.png";
            this.btnSil.ImageList = this.İmgTedarik;
            this.btnSil.Location = new System.Drawing.Point(645, 219);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(79, 37);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.ImageKey = "images (1).jpg";
            this.btnGuncelle.ImageList = this.İmgTedarik;
            this.btnGuncelle.Location = new System.Drawing.Point(730, 219);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(107, 37);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // grdTedarikciler
            // 
            this.grdTedarikciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTedarikciler.Location = new System.Drawing.Point(26, 262);
            this.grdTedarikciler.Name = "grdTedarikciler";
            this.grdTedarikciler.Size = new System.Drawing.Size(795, 176);
            this.grdTedarikciler.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.grdTedarikciler);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.lbladres);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYetkiliAdi);
            this.Controls.Add(this.lblyetkil);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.lbltelefon);
            this.Controls.Add(this.txtFirmaAdi);
            this.Controls.Add(this.lblfirma);
            this.Controls.Add(this.lblbilgirişi);
            this.Name = "Form2";
            this.Text = "TEDARİKÇİ İŞLEMLERİ";
            ((System.ComponentModel.ISupportInitialize)(this.grdTedarikciler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbilgirişi;
        private System.Windows.Forms.Label lblfirma;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.Label lbltelefon;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.Label lblyetkil;
        private System.Windows.Forms.TextBox txtYetkiliAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lbladres;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ImageList İmgTedarik;
        private System.Windows.Forms.DataGridView grdTedarikciler;
    }
}