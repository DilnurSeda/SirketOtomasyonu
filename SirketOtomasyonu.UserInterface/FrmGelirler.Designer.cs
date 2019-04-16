namespace SirketOtomasyonu.UserInterface
{
    partial class FrmGelirler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGelirler));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationGelirler = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
            this.txt_toplamtutar = new System.Windows.Forms.TextBox();
            this.date_gelirtarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.labelGelirTarihi = new System.Windows.Forms.Label();
            this.tabNavigationSatislar = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.dateEditIslemSaati = new System.Windows.Forms.MaskedTextBox();
            this.cmb_musteri = new System.Windows.Forms.ComboBox();
            this.cmb_urunler = new System.Windows.Forms.ComboBox();
            this.txt_indirimAciklmsi = new System.Windows.Forms.TextBox();
            this.txt_indirimorani = new System.Windows.Forms.TextBox();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.txt_tutar = new System.Windows.Forms.TextBox();
            this.date_islemtarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSatisKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSatisGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSatisSil = new System.Windows.Forms.ToolStripButton();
            this.gridControlGelirler = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlSatislar = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationGelirler.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabNavigationSatislar.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGelirler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSatislar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPane1.Controls.Add(this.tabNavigationGelirler);
            this.tabPane1.Controls.Add(this.tabNavigationSatislar);
            this.tabPane1.Location = new System.Drawing.Point(560, 2);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationGelirler,
            this.tabNavigationSatislar});
            this.tabPane1.RegularSize = new System.Drawing.Size(300, 457);
            this.tabPane1.SelectedPage = this.tabNavigationGelirler;
            this.tabPane1.Size = new System.Drawing.Size(300, 457);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            this.tabPane1.SelectedPageIndexChanged += new System.EventHandler(this.tabPane1_SelectedPageIndexChanged);
            // 
            // tabNavigationGelirler
            // 
            this.tabNavigationGelirler.Caption = "tabNavigationPage1";
            this.tabNavigationGelirler.Controls.Add(this.toolStrip1);
            this.tabNavigationGelirler.Controls.Add(this.txt_toplamtutar);
            this.tabNavigationGelirler.Controls.Add(this.date_gelirtarihi);
            this.tabNavigationGelirler.Controls.Add(this.label2);
            this.tabNavigationGelirler.Controls.Add(this.labelGelirTarihi);
            this.tabNavigationGelirler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationGelirler.ImageOptions.Image")));
            this.tabNavigationGelirler.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationGelirler.Name = "tabNavigationGelirler";
            this.tabNavigationGelirler.PageText = "Gelirler";
            this.tabNavigationGelirler.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationGelirler.Size = new System.Drawing.Size(300, 411);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonKaydet,
            this.toolStripButtonGuncelle,
            this.toolStripButtonSil});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(300, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonKaydet
            // 
            this.toolStripButtonKaydet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonKaydet.Image")));
            this.toolStripButtonKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonKaydet.Name = "toolStripButtonKaydet";
            this.toolStripButtonKaydet.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonKaydet.Text = "Kaydet";
            this.toolStripButtonKaydet.Click += new System.EventHandler(this.toolStripButtonKaydet_Click);
            // 
            // toolStripButtonGuncelle
            // 
            this.toolStripButtonGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGuncelle.Image")));
            this.toolStripButtonGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuncelle.Name = "toolStripButtonGuncelle";
            this.toolStripButtonGuncelle.Size = new System.Drawing.Size(73, 22);
            this.toolStripButtonGuncelle.Text = "Güncelle";
            this.toolStripButtonGuncelle.Click += new System.EventHandler(this.toolStripButtonGuncelle_Click);
            // 
            // toolStripButtonSil
            // 
            this.toolStripButtonSil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSil.Image")));
            this.toolStripButtonSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSil.Name = "toolStripButtonSil";
            this.toolStripButtonSil.Size = new System.Drawing.Size(39, 22);
            this.toolStripButtonSil.Text = "Sil";
            this.toolStripButtonSil.Click += new System.EventHandler(this.toolStripButtonSil_Click);
            // 
            // txt_toplamtutar
            // 
            this.txt_toplamtutar.Location = new System.Drawing.Point(102, 114);
            this.txt_toplamtutar.Name = "txt_toplamtutar";
            this.txt_toplamtutar.Size = new System.Drawing.Size(147, 20);
            this.txt_toplamtutar.TabIndex = 2;
            // 
            // date_gelirtarihi
            // 
            this.date_gelirtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_gelirtarihi.Location = new System.Drawing.Point(102, 58);
            this.date_gelirtarihi.Name = "date_gelirtarihi";
            this.date_gelirtarihi.Size = new System.Drawing.Size(147, 20);
            this.date_gelirtarihi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Toplam Tutar:";
            // 
            // labelGelirTarihi
            // 
            this.labelGelirTarihi.AutoSize = true;
            this.labelGelirTarihi.Location = new System.Drawing.Point(36, 63);
            this.labelGelirTarihi.Name = "labelGelirTarihi";
            this.labelGelirTarihi.Size = new System.Drawing.Size(60, 13);
            this.labelGelirTarihi.TabIndex = 0;
            this.labelGelirTarihi.Text = "Gelir Tarihi:";
            // 
            // tabNavigationSatislar
            // 
            this.tabNavigationSatislar.Caption = "tabNavigationSatislar";
            this.tabNavigationSatislar.Controls.Add(this.dateEditIslemSaati);
            this.tabNavigationSatislar.Controls.Add(this.cmb_musteri);
            this.tabNavigationSatislar.Controls.Add(this.cmb_urunler);
            this.tabNavigationSatislar.Controls.Add(this.txt_indirimAciklmsi);
            this.tabNavigationSatislar.Controls.Add(this.txt_indirimorani);
            this.tabNavigationSatislar.Controls.Add(this.txt_adet);
            this.tabNavigationSatislar.Controls.Add(this.txt_tutar);
            this.tabNavigationSatislar.Controls.Add(this.date_islemtarihi);
            this.tabNavigationSatislar.Controls.Add(this.label7);
            this.tabNavigationSatislar.Controls.Add(this.label6);
            this.tabNavigationSatislar.Controls.Add(this.label5);
            this.tabNavigationSatislar.Controls.Add(this.label1);
            this.tabNavigationSatislar.Controls.Add(this.label4);
            this.tabNavigationSatislar.Controls.Add(this.label9);
            this.tabNavigationSatislar.Controls.Add(this.label8);
            this.tabNavigationSatislar.Controls.Add(this.label3);
            this.tabNavigationSatislar.Controls.Add(this.toolStrip2);
            this.tabNavigationSatislar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationSatislar.ImageOptions.Image")));
            this.tabNavigationSatislar.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationSatislar.Name = "tabNavigationSatislar";
            this.tabNavigationSatislar.PageText = "Satışlar";
            this.tabNavigationSatislar.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationSatislar.Size = new System.Drawing.Size(300, 411);
            // 
            // dateEditIslemSaati
            // 
            this.dateEditIslemSaati.Location = new System.Drawing.Point(118, 150);
            this.dateEditIslemSaati.Mask = "00:00";
            this.dateEditIslemSaati.Name = "dateEditIslemSaati";
            this.dateEditIslemSaati.Size = new System.Drawing.Size(147, 20);
            this.dateEditIslemSaati.TabIndex = 23;
            this.dateEditIslemSaati.ValidatingType = typeof(System.DateTime);
           
            // 
            // cmb_musteri
            // 
            this.cmb_musteri.FormattingEnabled = true;
            this.cmb_musteri.Location = new System.Drawing.Point(118, 74);
            this.cmb_musteri.Name = "cmb_musteri";
            this.cmb_musteri.Size = new System.Drawing.Size(147, 21);
            this.cmb_musteri.TabIndex = 22;
            // 
            // cmb_urunler
            // 
            this.cmb_urunler.FormattingEnabled = true;
            this.cmb_urunler.Location = new System.Drawing.Point(118, 42);
            this.cmb_urunler.Name = "cmb_urunler";
            this.cmb_urunler.Size = new System.Drawing.Size(147, 21);
            this.cmb_urunler.TabIndex = 22;
            // 
            // txt_indirimAciklmsi
            // 
            this.txt_indirimAciklmsi.Location = new System.Drawing.Point(118, 302);
            this.txt_indirimAciklmsi.Name = "txt_indirimAciklmsi";
            this.txt_indirimAciklmsi.Size = new System.Drawing.Size(147, 20);
            this.txt_indirimAciklmsi.TabIndex = 21;
            // 
            // txt_indirimorani
            // 
            this.txt_indirimorani.Location = new System.Drawing.Point(118, 264);
            this.txt_indirimorani.Name = "txt_indirimorani";
            this.txt_indirimorani.Size = new System.Drawing.Size(147, 20);
            this.txt_indirimorani.TabIndex = 21;
            this.txt_indirimorani.TextChanged += new System.EventHandler(this.txt_indirimorani_TextChanged);
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(118, 226);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(147, 20);
            this.txt_adet.TabIndex = 21;
            this.txt_adet.Text = "0";
            // 
            // txt_tutar
            // 
            this.txt_tutar.Location = new System.Drawing.Point(118, 188);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Size = new System.Drawing.Size(147, 20);
            this.txt_tutar.TabIndex = 21;
            this.txt_tutar.Text = "0";
            // 
            // date_islemtarihi
            // 
            this.date_islemtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_islemtarihi.Location = new System.Drawing.Point(118, 112);
            this.date_islemtarihi.Name = "date_islemtarihi";
            this.date_islemtarihi.Size = new System.Drawing.Size(147, 20);
            this.date_islemtarihi.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "İndirim Açıklaması:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "İndirim Oranı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Adet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fiyat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "İşlem Saati:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Müşteri Seçin:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ürünler:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "İşlem Tarihi:";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSatisKaydet,
            this.toolStripSatisGuncelle,
            this.toolStripSatisSil});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(300, 25);
            this.toolStrip2.TabIndex = 17;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSatisKaydet
            // 
            this.toolStripSatisKaydet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSatisKaydet.Image")));
            this.toolStripSatisKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSatisKaydet.Name = "toolStripSatisKaydet";
            this.toolStripSatisKaydet.Size = new System.Drawing.Size(63, 22);
            this.toolStripSatisKaydet.Text = "Kaydet";
            this.toolStripSatisKaydet.Click += new System.EventHandler(this.toolStripSatisKaydet_Click);
            // 
            // toolStripSatisGuncelle
            // 
            this.toolStripSatisGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSatisGuncelle.Image")));
            this.toolStripSatisGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSatisGuncelle.Name = "toolStripSatisGuncelle";
            this.toolStripSatisGuncelle.Size = new System.Drawing.Size(73, 22);
            this.toolStripSatisGuncelle.Text = "Güncelle";
            this.toolStripSatisGuncelle.Click += new System.EventHandler(this.toolStripSatisGuncelle_Click);
            // 
            // toolStripSatisSil
            // 
            this.toolStripSatisSil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSatisSil.Image")));
            this.toolStripSatisSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSatisSil.Name = "toolStripSatisSil";
            this.toolStripSatisSil.Size = new System.Drawing.Size(39, 22);
            this.toolStripSatisSil.Text = "Sil";
            this.toolStripSatisSil.Click += new System.EventHandler(this.toolStripSatisSil_Click);
            // 
            // gridControlGelirler
            // 
            this.gridControlGelirler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlGelirler.Location = new System.Drawing.Point(1, 0);
            this.gridControlGelirler.MainView = this.gridView1;
            this.gridControlGelirler.Name = "gridControlGelirler";
            this.gridControlGelirler.Size = new System.Drawing.Size(553, 459);
            this.gridControlGelirler.TabIndex = 1;
            this.gridControlGelirler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlGelirler;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControlSatislar
            // 
            this.gridControlSatislar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlSatislar.Location = new System.Drawing.Point(1, 2);
            this.gridControlSatislar.MainView = this.gridView2;
            this.gridControlSatislar.Name = "gridControlSatislar";
            this.gridControlSatislar.Size = new System.Drawing.Size(553, 459);
            this.gridControlSatislar.TabIndex = 3;
            this.gridControlSatislar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControlSatislar.Visible = false;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlSatislar;
            this.gridView2.Name = "gridView2";
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // FrmGelirler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 460);
            this.Controls.Add(this.gridControlSatislar);
            this.Controls.Add(this.gridControlGelirler);
            this.Controls.Add(this.tabPane1);
            this.Name = "FrmGelirler";
            this.Text = "FrmGelirler";
            this.Load += new System.EventHandler(this.FrmGelirler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationGelirler.ResumeLayout(false);
            this.tabNavigationGelirler.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabNavigationSatislar.ResumeLayout(false);
            this.tabNavigationSatislar.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGelirler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSatislar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationGelirler;
        private DevExpress.XtraGrid.GridControl gridControlGelirler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationSatislar;
        private DevExpress.XtraGrid.GridControl gridControlSatislar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.TextBox txt_toplamtutar;
        private System.Windows.Forms.DateTimePicker date_gelirtarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelGelirTarihi;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonKaydet;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSil;
        private System.Windows.Forms.TextBox txt_indirimAciklmsi;
        private System.Windows.Forms.TextBox txt_indirimorani;
        private System.Windows.Forms.TextBox txt_adet;
        private System.Windows.Forms.TextBox txt_tutar;
        private System.Windows.Forms.DateTimePicker date_islemtarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripSatisKaydet;
        private System.Windows.Forms.ToolStripButton toolStripSatisGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripSatisSil;
        private System.Windows.Forms.ComboBox cmb_urunler;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_musteri;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox dateEditIslemSaati;
    }
}