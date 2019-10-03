namespace Matematiksel_İşlemler
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbxGirisBilgileri = new System.Windows.Forms.GroupBox();
            this.txtBitisSayisi = new System.Windows.Forms.MaskedTextBox();
            this.txtBaslangicSayisi = new System.Windows.Forms.MaskedTextBox();
            this.btnIleri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblBitisSayisi = new System.Windows.Forms.Label();
            this.lblBaslangicSayisi = new System.Windows.Forms.Label();
            this.tabIslemler = new System.Windows.Forms.TabControl();
            this.tabTekSayilar = new System.Windows.Forms.TabPage();
            this.listTekSayilar = new System.Windows.Forms.ListView();
            this.tabCiftSayilar = new System.Windows.Forms.TabPage();
            this.listCiftSayilar = new System.Windows.Forms.ListView();
            this.tabAsalSayilar = new System.Windows.Forms.TabPage();
            this.listAsalSayilar = new System.Windows.Forms.ListView();
            this.tabArmstrongSayılar = new System.Windows.Forms.TabPage();
            this.listArmstrongSayilar = new System.Windows.Forms.ListView();
            this.lblSayilarinToplami = new System.Windows.Forms.Label();
            this.lblSayilarinCarpimi = new System.Windows.Forms.Label();
            this.txtSayilarinToplami = new System.Windows.Forms.TextBox();
            this.txtSayilarinCarpimi = new System.Windows.Forms.TextBox();
            this.txtIslemZamani = new System.Windows.Forms.TextBox();
            this.lblIslemZamani = new System.Windows.Forms.Label();
            this.bildirimBalonu = new System.Windows.Forms.NotifyIcon(this.components);
            this.grbxGirisBilgileri.SuspendLayout();
            this.tabIslemler.SuspendLayout();
            this.tabTekSayilar.SuspendLayout();
            this.tabCiftSayilar.SuspendLayout();
            this.tabAsalSayilar.SuspendLayout();
            this.tabArmstrongSayılar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbxGirisBilgileri
            // 
            this.grbxGirisBilgileri.Controls.Add(this.txtBitisSayisi);
            this.grbxGirisBilgileri.Controls.Add(this.txtBaslangicSayisi);
            this.grbxGirisBilgileri.Controls.Add(this.btnIleri);
            this.grbxGirisBilgileri.Controls.Add(this.btnGeri);
            this.grbxGirisBilgileri.Controls.Add(this.btnHesapla);
            this.grbxGirisBilgileri.Controls.Add(this.lblBitisSayisi);
            this.grbxGirisBilgileri.Controls.Add(this.lblBaslangicSayisi);
            this.grbxGirisBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbxGirisBilgileri.Location = new System.Drawing.Point(12, 12);
            this.grbxGirisBilgileri.Name = "grbxGirisBilgileri";
            this.grbxGirisBilgileri.Size = new System.Drawing.Size(830, 82);
            this.grbxGirisBilgileri.TabIndex = 0;
            this.grbxGirisBilgileri.TabStop = false;
            this.grbxGirisBilgileri.Text = "Zamanı";
            // 
            // txtBitisSayisi
            // 
            this.txtBitisSayisi.Location = new System.Drawing.Point(329, 25);
            this.txtBitisSayisi.Mask = "00000";
            this.txtBitisSayisi.Name = "txtBitisSayisi";
            this.txtBitisSayisi.Size = new System.Drawing.Size(153, 26);
            this.txtBitisSayisi.TabIndex = 9;
            this.txtBitisSayisi.ValidatingType = typeof(int);
            // 
            // txtBaslangicSayisi
            // 
            this.txtBaslangicSayisi.Location = new System.Drawing.Point(119, 26);
            this.txtBaslangicSayisi.Mask = "00000";
            this.txtBaslangicSayisi.Name = "txtBaslangicSayisi";
            this.txtBaslangicSayisi.Size = new System.Drawing.Size(132, 26);
            this.txtBaslangicSayisi.TabIndex = 8;
            this.txtBaslangicSayisi.ValidatingType = typeof(int);
            // 
            // btnIleri
            // 
            this.btnIleri.Location = new System.Drawing.Point(734, 24);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(90, 34);
            this.btnIleri.TabIndex = 6;
            this.btnIleri.Text = "İLERİ>>";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.BtnIleri_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(626, 24);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(102, 34);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "<<GERİ";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(505, 24);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(99, 34);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // lblBitisSayisi
            // 
            this.lblBitisSayisi.AutoSize = true;
            this.lblBitisSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitisSayisi.Location = new System.Drawing.Point(257, 32);
            this.lblBitisSayisi.Name = "lblBitisSayisi";
            this.lblBitisSayisi.Size = new System.Drawing.Size(76, 16);
            this.lblBitisSayisi.TabIndex = 2;
            this.lblBitisSayisi.Text = "Bitiş Sayısı:";
            // 
            // lblBaslangicSayisi
            // 
            this.lblBaslangicSayisi.AutoSize = true;
            this.lblBaslangicSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslangicSayisi.Location = new System.Drawing.Point(6, 34);
            this.lblBaslangicSayisi.Name = "lblBaslangicSayisi";
            this.lblBaslangicSayisi.Size = new System.Drawing.Size(111, 16);
            this.lblBaslangicSayisi.TabIndex = 0;
            this.lblBaslangicSayisi.Text = "Başlangıç Sayısı:";
            // 
            // tabIslemler
            // 
            this.tabIslemler.Controls.Add(this.tabTekSayilar);
            this.tabIslemler.Controls.Add(this.tabCiftSayilar);
            this.tabIslemler.Controls.Add(this.tabAsalSayilar);
            this.tabIslemler.Controls.Add(this.tabArmstrongSayılar);
            this.tabIslemler.Location = new System.Drawing.Point(12, 100);
            this.tabIslemler.Name = "tabIslemler";
            this.tabIslemler.SelectedIndex = 0;
            this.tabIslemler.Size = new System.Drawing.Size(824, 305);
            this.tabIslemler.TabIndex = 1;
            // 
            // tabTekSayilar
            // 
            this.tabTekSayilar.Controls.Add(this.listTekSayilar);
            this.tabTekSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabTekSayilar.Location = new System.Drawing.Point(4, 22);
            this.tabTekSayilar.Name = "tabTekSayilar";
            this.tabTekSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabTekSayilar.Size = new System.Drawing.Size(816, 279);
            this.tabTekSayilar.TabIndex = 0;
            this.tabTekSayilar.Text = "Tek Sayılar";
            this.tabTekSayilar.UseVisualStyleBackColor = true;
            // 
            // listTekSayilar
            // 
            this.listTekSayilar.Location = new System.Drawing.Point(0, -3);
            this.listTekSayilar.Name = "listTekSayilar";
            this.listTekSayilar.Size = new System.Drawing.Size(820, 276);
            this.listTekSayilar.TabIndex = 0;
            this.listTekSayilar.UseCompatibleStateImageBehavior = false;
            // 
            // tabCiftSayilar
            // 
            this.tabCiftSayilar.Controls.Add(this.listCiftSayilar);
            this.tabCiftSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabCiftSayilar.Location = new System.Drawing.Point(4, 22);
            this.tabCiftSayilar.Name = "tabCiftSayilar";
            this.tabCiftSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCiftSayilar.Size = new System.Drawing.Size(816, 279);
            this.tabCiftSayilar.TabIndex = 1;
            this.tabCiftSayilar.Text = "Çift Sayılar";
            this.tabCiftSayilar.UseVisualStyleBackColor = true;
            // 
            // listCiftSayilar
            // 
            this.listCiftSayilar.Location = new System.Drawing.Point(-4, 0);
            this.listCiftSayilar.Name = "listCiftSayilar";
            this.listCiftSayilar.Size = new System.Drawing.Size(820, 283);
            this.listCiftSayilar.TabIndex = 0;
            this.listCiftSayilar.UseCompatibleStateImageBehavior = false;
            // 
            // tabAsalSayilar
            // 
            this.tabAsalSayilar.Controls.Add(this.listAsalSayilar);
            this.tabAsalSayilar.Location = new System.Drawing.Point(4, 22);
            this.tabAsalSayilar.Name = "tabAsalSayilar";
            this.tabAsalSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAsalSayilar.Size = new System.Drawing.Size(816, 279);
            this.tabAsalSayilar.TabIndex = 2;
            this.tabAsalSayilar.Text = "Asal Sayılar";
            this.tabAsalSayilar.UseVisualStyleBackColor = true;
            // 
            // listAsalSayilar
            // 
            this.listAsalSayilar.Location = new System.Drawing.Point(-4, 0);
            this.listAsalSayilar.Name = "listAsalSayilar";
            this.listAsalSayilar.Size = new System.Drawing.Size(820, 279);
            this.listAsalSayilar.TabIndex = 0;
            this.listAsalSayilar.UseCompatibleStateImageBehavior = false;
            // 
            // tabArmstrongSayılar
            // 
            this.tabArmstrongSayılar.Controls.Add(this.listArmstrongSayilar);
            this.tabArmstrongSayılar.Location = new System.Drawing.Point(4, 22);
            this.tabArmstrongSayılar.Name = "tabArmstrongSayılar";
            this.tabArmstrongSayılar.Padding = new System.Windows.Forms.Padding(3);
            this.tabArmstrongSayılar.Size = new System.Drawing.Size(816, 279);
            this.tabArmstrongSayılar.TabIndex = 3;
            this.tabArmstrongSayılar.Text = "Armstrong Sayılar";
            this.tabArmstrongSayılar.UseVisualStyleBackColor = true;
            // 
            // listArmstrongSayilar
            // 
            this.listArmstrongSayilar.Location = new System.Drawing.Point(-4, 0);
            this.listArmstrongSayilar.Name = "listArmstrongSayilar";
            this.listArmstrongSayilar.Size = new System.Drawing.Size(820, 279);
            this.listArmstrongSayilar.TabIndex = 0;
            this.listArmstrongSayilar.UseCompatibleStateImageBehavior = false;
            // 
            // lblSayilarinToplami
            // 
            this.lblSayilarinToplami.AutoSize = true;
            this.lblSayilarinToplami.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayilarinToplami.Location = new System.Drawing.Point(9, 425);
            this.lblSayilarinToplami.Name = "lblSayilarinToplami";
            this.lblSayilarinToplami.Size = new System.Drawing.Size(116, 16);
            this.lblSayilarinToplami.TabIndex = 2;
            this.lblSayilarinToplami.Text = "Sayıların Toplamı:";
            // 
            // lblSayilarinCarpimi
            // 
            this.lblSayilarinCarpimi.AutoSize = true;
            this.lblSayilarinCarpimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayilarinCarpimi.Location = new System.Drawing.Point(293, 425);
            this.lblSayilarinCarpimi.Name = "lblSayilarinCarpimi";
            this.lblSayilarinCarpimi.Size = new System.Drawing.Size(112, 16);
            this.lblSayilarinCarpimi.TabIndex = 3;
            this.lblSayilarinCarpimi.Text = "Sayıların Çarpımı:";
            // 
            // txtSayilarinToplami
            // 
            this.txtSayilarinToplami.Enabled = false;
            this.txtSayilarinToplami.Location = new System.Drawing.Point(131, 420);
            this.txtSayilarinToplami.Multiline = true;
            this.txtSayilarinToplami.Name = "txtSayilarinToplami";
            this.txtSayilarinToplami.Size = new System.Drawing.Size(156, 21);
            this.txtSayilarinToplami.TabIndex = 4;
            // 
            // txtSayilarinCarpimi
            // 
            this.txtSayilarinCarpimi.Enabled = false;
            this.txtSayilarinCarpimi.Location = new System.Drawing.Point(411, 420);
            this.txtSayilarinCarpimi.Multiline = true;
            this.txtSayilarinCarpimi.Name = "txtSayilarinCarpimi";
            this.txtSayilarinCarpimi.Size = new System.Drawing.Size(155, 21);
            this.txtSayilarinCarpimi.TabIndex = 5;
            // 
            // txtIslemZamani
            // 
            this.txtIslemZamani.Enabled = false;
            this.txtIslemZamani.Location = new System.Drawing.Point(681, 424);
            this.txtIslemZamani.Multiline = true;
            this.txtIslemZamani.Name = "txtIslemZamani";
            this.txtIslemZamani.Size = new System.Drawing.Size(155, 21);
            this.txtIslemZamani.TabIndex = 7;
            // 
            // lblIslemZamani
            // 
            this.lblIslemZamani.AutoSize = true;
            this.lblIslemZamani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIslemZamani.Location = new System.Drawing.Point(580, 425);
            this.lblIslemZamani.Name = "lblIslemZamani";
            this.lblIslemZamani.Size = new System.Drawing.Size(91, 16);
            this.lblIslemZamani.TabIndex = 6;
            this.lblIslemZamani.Text = "İşlem Zamanı:";
            // 
            // bildirimBalonu
            // 
            this.bildirimBalonu.Text = "notifyIcon1";
            this.bildirimBalonu.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.txtIslemZamani);
            this.Controls.Add(this.lblIslemZamani);
            this.Controls.Add(this.txtSayilarinCarpimi);
            this.Controls.Add(this.txtSayilarinToplami);
            this.Controls.Add(this.lblSayilarinCarpimi);
            this.Controls.Add(this.lblSayilarinToplami);
            this.Controls.Add(this.tabIslemler);
            this.Controls.Add(this.grbxGirisBilgileri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbxGirisBilgileri.ResumeLayout(false);
            this.grbxGirisBilgileri.PerformLayout();
            this.tabIslemler.ResumeLayout(false);
            this.tabTekSayilar.ResumeLayout(false);
            this.tabCiftSayilar.ResumeLayout(false);
            this.tabAsalSayilar.ResumeLayout(false);
            this.tabArmstrongSayılar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbxGirisBilgileri;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblBitisSayisi;
        private System.Windows.Forms.Label lblBaslangicSayisi;
        private System.Windows.Forms.TabControl tabIslemler;
        private System.Windows.Forms.TabPage tabTekSayilar;
        private System.Windows.Forms.ListView listTekSayilar;
        private System.Windows.Forms.TabPage tabCiftSayilar;
        private System.Windows.Forms.ListView listCiftSayilar;
        private System.Windows.Forms.TabPage tabAsalSayilar;
        private System.Windows.Forms.ListView listAsalSayilar;
        private System.Windows.Forms.TabPage tabArmstrongSayılar;
        private System.Windows.Forms.ListView listArmstrongSayilar;
        private System.Windows.Forms.Label lblSayilarinToplami;
        private System.Windows.Forms.Label lblSayilarinCarpimi;
        private System.Windows.Forms.TextBox txtSayilarinToplami;
        private System.Windows.Forms.TextBox txtSayilarinCarpimi;
        private System.Windows.Forms.TextBox txtIslemZamani;
        private System.Windows.Forms.Label lblIslemZamani;
        private System.Windows.Forms.MaskedTextBox txtBitisSayisi;
        private System.Windows.Forms.MaskedTextBox txtBaslangicSayisi;
        private System.Windows.Forms.NotifyIcon bildirimBalonu;
    }
}

