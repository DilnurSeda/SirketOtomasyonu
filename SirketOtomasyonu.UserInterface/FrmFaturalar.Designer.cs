namespace SirketOtomasyonu.UserInterface
{
    partial class FrmFaturalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturalar));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlfaturalar = new DevExpress.XtraGrid.GridControl();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPageFatura = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dateSaat = new System.Windows.Forms.DateTimePicker();
            this.cmbSeri = new System.Windows.Forms.ComboBox();
            this.txtTeslimAlan = new System.Windows.Forms.TextBox();
            this.txtTeslimEden = new System.Windows.Forms.TextBox();
            this.txtAlici = new System.Windows.Forms.TextBox();
            this.cmbVergiDairesi = new System.Windows.Forms.ComboBox();
            this.dateTarih = new System.Windows.Forms.DateTimePicker();
            this.msbSirano = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
            this.tabNavigationPageFaturaDetay = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonKaydetDty = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuncelleDty = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSilDty = new System.Windows.Forms.ToolStripButton();
            this.textBoxtutar = new System.Windows.Forms.TextBox();
            this.textBoxfiyat = new System.Windows.Forms.TextBox();
            this.textBoxmiktar = new System.Windows.Forms.TextBox();
            this.labelfaturaId = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelurunId = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlfaturalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPageFatura.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabNavigationPageFaturaDetay.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlfaturalar;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControlfaturalar
            // 
            this.gridControlfaturalar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlfaturalar.Location = new System.Drawing.Point(-1, 0);
            this.gridControlfaturalar.MainView = this.gridView1;
            this.gridControlfaturalar.Name = "gridControlfaturalar";
            this.gridControlfaturalar.Size = new System.Drawing.Size(589, 494);
            this.gridControlfaturalar.TabIndex = 5;
            this.gridControlfaturalar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tabPane1
            // 
            this.tabPane1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPane1.Controls.Add(this.tabNavigationPageFatura);
            this.tabPane1.Controls.Add(this.tabNavigationPageFaturaDetay);
            this.tabPane1.Location = new System.Drawing.Point(594, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPageFatura,
            this.tabNavigationPageFaturaDetay});
            this.tabPane1.RegularSize = new System.Drawing.Size(328, 494);
            this.tabPane1.SelectedPage = this.tabNavigationPageFatura;
            this.tabPane1.Size = new System.Drawing.Size(328, 494);
            this.tabPane1.TabIndex = 6;
            this.tabPane1.Text = "tabPane1";
            this.tabPane1.SelectedPageIndexChanged += new System.EventHandler(this.tabPane1_SelectedPageIndexChanged);
            // 
            // tabNavigationPageFatura
            // 
            this.tabNavigationPageFatura.Caption = "FATURA";
            this.tabNavigationPageFatura.Controls.Add(this.simpleButton2);
            this.tabNavigationPageFatura.Controls.Add(this.simpleButton1);
            this.tabNavigationPageFatura.Controls.Add(this.dateSaat);
            this.tabNavigationPageFatura.Controls.Add(this.cmbSeri);
            this.tabNavigationPageFatura.Controls.Add(this.txtTeslimAlan);
            this.tabNavigationPageFatura.Controls.Add(this.txtTeslimEden);
            this.tabNavigationPageFatura.Controls.Add(this.txtAlici);
            this.tabNavigationPageFatura.Controls.Add(this.cmbVergiDairesi);
            this.tabNavigationPageFatura.Controls.Add(this.dateTarih);
            this.tabNavigationPageFatura.Controls.Add(this.msbSirano);
            this.tabNavigationPageFatura.Controls.Add(this.label8);
            this.tabNavigationPageFatura.Controls.Add(this.label7);
            this.tabNavigationPageFatura.Controls.Add(this.label6);
            this.tabNavigationPageFatura.Controls.Add(this.label5);
            this.tabNavigationPageFatura.Controls.Add(this.label4);
            this.tabNavigationPageFatura.Controls.Add(this.label3);
            this.tabNavigationPageFatura.Controls.Add(this.label2);
            this.tabNavigationPageFatura.Controls.Add(this.label1);
            this.tabNavigationPageFatura.Controls.Add(this.toolStrip1);
            this.tabNavigationPageFatura.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPageFatura.ImageOptions.Image")));
            this.tabNavigationPageFatura.Name = "tabNavigationPageFatura";
            this.tabNavigationPageFatura.Size = new System.Drawing.Size(328, 448);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(29, 359);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(130, 60);
            this.simpleButton1.TabIndex = 34;
            this.simpleButton1.Text = "FATURA ÇIKAR";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dateSaat
            // 
            this.dateSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateSaat.Location = new System.Drawing.Point(108, 160);
            this.dateSaat.Name = "dateSaat";
            this.dateSaat.Size = new System.Drawing.Size(188, 20);
            this.dateSaat.TabIndex = 33;
            // 
            // cmbSeri
            // 
            this.cmbSeri.FormattingEnabled = true;
            this.cmbSeri.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "J",
            "K",
            "L",
            "M",
            "N"});
            this.cmbSeri.Location = new System.Drawing.Point(108, 56);
            this.cmbSeri.Name = "cmbSeri";
            this.cmbSeri.Size = new System.Drawing.Size(188, 21);
            this.cmbSeri.TabIndex = 32;
            // 
            // txtTeslimAlan
            // 
            this.txtTeslimAlan.Location = new System.Drawing.Point(109, 311);
            this.txtTeslimAlan.Name = "txtTeslimAlan";
            this.txtTeslimAlan.Size = new System.Drawing.Size(187, 20);
            this.txtTeslimAlan.TabIndex = 31;
            // 
            // txtTeslimEden
            // 
            this.txtTeslimEden.Location = new System.Drawing.Point(109, 276);
            this.txtTeslimEden.Name = "txtTeslimEden";
            this.txtTeslimEden.Size = new System.Drawing.Size(187, 20);
            this.txtTeslimEden.TabIndex = 30;
            // 
            // txtAlici
            // 
            this.txtAlici.Location = new System.Drawing.Point(109, 241);
            this.txtAlici.Name = "txtAlici";
            this.txtAlici.Size = new System.Drawing.Size(187, 20);
            this.txtAlici.TabIndex = 29;
            // 
            // cmbVergiDairesi
            // 
            this.cmbVergiDairesi.FormattingEnabled = true;
            this.cmbVergiDairesi.Location = new System.Drawing.Point(109, 199);
            this.cmbVergiDairesi.Name = "cmbVergiDairesi";
            this.cmbVergiDairesi.Size = new System.Drawing.Size(187, 21);
            this.cmbVergiDairesi.TabIndex = 28;
            // 
            // dateTarih
            // 
            this.dateTarih.Location = new System.Drawing.Point(109, 127);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Size = new System.Drawing.Size(187, 20);
            this.dateTarih.TabIndex = 26;
            // 
            // msbSirano
            // 
            this.msbSirano.Location = new System.Drawing.Point(109, 92);
            this.msbSirano.Mask = "0000000000";
            this.msbSirano.Name = "msbSirano";
            this.msbSirano.Size = new System.Drawing.Size(187, 20);
            this.msbSirano.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "TESLİM ALAN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "TESLİM EDEN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "ALICI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "VERGİ \r\nDAİRELERİ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "SAAT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "TARİH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "SIRA NO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "SERİ:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonKaydet,
            this.toolStripButtonGuncelle,
            this.toolStripButtonSil});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(328, 25);
            this.toolStrip1.TabIndex = 15;
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
            // tabNavigationPageFaturaDetay
            // 
            this.tabNavigationPageFaturaDetay.Caption = "tabNavigationPageFaturaDetay";
            this.tabNavigationPageFaturaDetay.Controls.Add(this.toolStrip2);
            this.tabNavigationPageFaturaDetay.Controls.Add(this.textBoxtutar);
            this.tabNavigationPageFaturaDetay.Controls.Add(this.textBoxfiyat);
            this.tabNavigationPageFaturaDetay.Controls.Add(this.textBoxmiktar);
            this.tabNavigationPageFaturaDetay.Controls.Add(this.labelfaturaId);
            this.tabNavigationPageFaturaDetay.Controls.Add(this.label13);
            this.tabNavigationPageFaturaDetay.Controls.Add(this.label12);
            this.tabNavigationPageFaturaDetay.Controls.Add(this.label11);
            this.tabNavigationPageFaturaDetay.Controls.Add(this.label10);
            this.tabNavigationPageFaturaDetay.Controls.Add(this.labelurunId);
            this.tabNavigationPageFaturaDetay.Controls.Add(this.label9);
            this.tabNavigationPageFaturaDetay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPageFaturaDetay.ImageOptions.Image")));
            this.tabNavigationPageFaturaDetay.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPageFaturaDetay.Name = "tabNavigationPageFaturaDetay";
            this.tabNavigationPageFaturaDetay.PageText = "FATURA DETAY";
            this.tabNavigationPageFaturaDetay.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPageFaturaDetay.Size = new System.Drawing.Size(328, 448);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonKaydetDty,
            this.toolStripButtonGuncelleDty,
            this.toolStripButtonSilDty});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(328, 25);
            this.toolStrip2.TabIndex = 16;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButtonKaydetDty
            // 
            this.toolStripButtonKaydetDty.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonKaydetDty.Image")));
            this.toolStripButtonKaydetDty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonKaydetDty.Name = "toolStripButtonKaydetDty";
            this.toolStripButtonKaydetDty.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonKaydetDty.Text = "Kaydet";
            this.toolStripButtonKaydetDty.Click += new System.EventHandler(this.toolStripButtonKaydetDty_Click);
            // 
            // toolStripButtonGuncelleDty
            // 
            this.toolStripButtonGuncelleDty.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGuncelleDty.Image")));
            this.toolStripButtonGuncelleDty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuncelleDty.Name = "toolStripButtonGuncelleDty";
            this.toolStripButtonGuncelleDty.Size = new System.Drawing.Size(73, 22);
            this.toolStripButtonGuncelleDty.Text = "Güncelle";
            this.toolStripButtonGuncelleDty.Click += new System.EventHandler(this.toolStripButtonGuncelleDty_Click);
            // 
            // toolStripButtonSilDty
            // 
            this.toolStripButtonSilDty.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSilDty.Image")));
            this.toolStripButtonSilDty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSilDty.Name = "toolStripButtonSilDty";
            this.toolStripButtonSilDty.Size = new System.Drawing.Size(39, 22);
            this.toolStripButtonSilDty.Text = "Sil";
            this.toolStripButtonSilDty.Click += new System.EventHandler(this.toolStripButtonSilDty_Click);
            // 
            // textBoxtutar
            // 
            this.textBoxtutar.Location = new System.Drawing.Point(104, 201);
            this.textBoxtutar.Name = "textBoxtutar";
            this.textBoxtutar.Size = new System.Drawing.Size(173, 20);
            this.textBoxtutar.TabIndex = 1;
            // 
            // textBoxfiyat
            // 
            this.textBoxfiyat.Location = new System.Drawing.Point(104, 153);
            this.textBoxfiyat.Name = "textBoxfiyat";
            this.textBoxfiyat.Size = new System.Drawing.Size(173, 20);
            this.textBoxfiyat.TabIndex = 1;
            // 
            // textBoxmiktar
            // 
            this.textBoxmiktar.Location = new System.Drawing.Point(104, 105);
            this.textBoxmiktar.Name = "textBoxmiktar";
            this.textBoxmiktar.Size = new System.Drawing.Size(173, 20);
            this.textBoxmiktar.TabIndex = 1;
            // 
            // labelfaturaId
            // 
            this.labelfaturaId.AutoSize = true;
            this.labelfaturaId.Location = new System.Drawing.Point(104, 245);
            this.labelfaturaId.Name = "labelfaturaId";
            this.labelfaturaId.Size = new System.Drawing.Size(67, 13);
            this.labelfaturaId.TabIndex = 0;
            this.labelfaturaId.Text = "FATURA ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "FATURA ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "TUTAR:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "FİYAT:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "MİKTAR:";
            // 
            // labelurunId
            // 
            this.labelurunId.AutoSize = true;
            this.labelurunId.Location = new System.Drawing.Point(104, 65);
            this.labelurunId.Name = "labelurunId";
            this.labelurunId.Size = new System.Drawing.Size(56, 13);
            this.labelurunId.TabIndex = 0;
            this.labelurunId.Text = "URUN ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "ÜRÜN ID:";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(-1, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(589, 494);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl1.Visible = false;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(165, 359);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(131, 60);
            this.simpleButton2.TabIndex = 35;
            this.simpleButton2.Text = "FATURA DETAY";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // FrmFaturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 498);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.gridControlfaturalar);
            this.Name = "FrmFaturalar";
            this.Text = "FrmFaturalar";
            this.Load += new System.EventHandler(this.FrmFaturalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlfaturalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPageFatura.ResumeLayout(false);
            this.tabNavigationPageFatura.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabNavigationPageFaturaDetay.ResumeLayout(false);
            this.tabNavigationPageFaturaDetay.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControlfaturalar;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPageFatura;
        private System.Windows.Forms.TextBox txtTeslimAlan;
        private System.Windows.Forms.TextBox txtTeslimEden;
        private System.Windows.Forms.TextBox txtAlici;
        private System.Windows.Forms.ComboBox cmbVergiDairesi;
        private System.Windows.Forms.DateTimePicker dateTarih;
        private System.Windows.Forms.MaskedTextBox msbSirano;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonKaydet;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSil;
        private System.Windows.Forms.ComboBox cmbSeri;
        private System.Windows.Forms.DateTimePicker dateSaat;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPageFaturaDetay;
        private System.Windows.Forms.TextBox textBoxtutar;
        private System.Windows.Forms.TextBox textBoxfiyat;
        private System.Windows.Forms.TextBox textBoxmiktar;
        private System.Windows.Forms.Label labelfaturaId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelurunId;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonKaydetDty;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuncelleDty;
        private System.Windows.Forms.ToolStripButton toolStripButtonSilDty;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}