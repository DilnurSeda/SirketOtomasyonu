namespace SirketOtomasyonu.UserInterface
{
    partial class FrmSirketler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSirketler));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.txt_vergidairesi = new System.Windows.Forms.TextBox();
            this.cmb_ilce = new System.Windows.Forms.ComboBox();
            this.cmb_il = new System.Windows.Forms.ComboBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.msb_tel2 = new System.Windows.Forms.MaskedTextBox();
            this.msb_tel1 = new System.Windows.Forms.MaskedTextBox();
            this.txt_yetkiliadsoyad = new System.Windows.Forms.TextBox();
            this.txt_yetkiligorevi = new System.Windows.Forms.TextBox();
            this.txt_sirketadi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_bankayetkiliAdsoyad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonKaydet2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuncelle2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSil2 = new System.Windows.Forms.ToolStripButton();
            this.txt_hesapturu = new System.Windows.Forms.TextBox();
            this.msb_hesapno = new System.Windows.Forms.MaskedTextBox();
            this.msb_Iban = new System.Windows.Forms.MaskedTextBox();
            this.cmb_bankaadi = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gridControlBankaBilgileri = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBankaBilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-1, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(589, 494);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tabControl1);
            this.groupControl1.Location = new System.Drawing.Point(594, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(331, 499);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Fatura Bilgileri";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(321, 471);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_adres);
            this.tabPage1.Controls.Add(this.txt_vergidairesi);
            this.tabPage1.Controls.Add(this.cmb_ilce);
            this.tabPage1.Controls.Add(this.cmb_il);
            this.tabPage1.Controls.Add(this.txt_email);
            this.tabPage1.Controls.Add(this.msb_tel2);
            this.tabPage1.Controls.Add(this.msb_tel1);
            this.tabPage1.Controls.Add(this.txt_yetkiliadsoyad);
            this.tabPage1.Controls.Add(this.txt_yetkiligorevi);
            this.tabPage1.Controls.Add(this.txt_sirketadi);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(313, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ŞİRKET BİLGİLERİ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(125, 372);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(133, 51);
            this.txt_adres.TabIndex = 36;
            // 
            // txt_vergidairesi
            // 
            this.txt_vergidairesi.Location = new System.Drawing.Point(125, 336);
            this.txt_vergidairesi.Name = "txt_vergidairesi";
            this.txt_vergidairesi.Size = new System.Drawing.Size(133, 21);
            this.txt_vergidairesi.TabIndex = 36;
            // 
            // cmb_ilce
            // 
            this.cmb_ilce.FormattingEnabled = true;
            this.cmb_ilce.Location = new System.Drawing.Point(125, 300);
            this.cmb_ilce.Name = "cmb_ilce";
            this.cmb_ilce.Size = new System.Drawing.Size(133, 21);
            this.cmb_ilce.TabIndex = 35;
            // 
            // cmb_il
            // 
            this.cmb_il.FormattingEnabled = true;
            this.cmb_il.Location = new System.Drawing.Point(125, 264);
            this.cmb_il.Name = "cmb_il";
            this.cmb_il.Size = new System.Drawing.Size(133, 21);
            this.cmb_il.TabIndex = 35;
            this.cmb_il.SelectedIndexChanged += new System.EventHandler(this.cmb_il_SelectedIndexChanged);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(125, 228);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(133, 21);
            this.txt_email.TabIndex = 34;
            // 
            // msb_tel2
            // 
            this.msb_tel2.Location = new System.Drawing.Point(125, 192);
            this.msb_tel2.Mask = "(999) 000-0000";
            this.msb_tel2.Name = "msb_tel2";
            this.msb_tel2.Size = new System.Drawing.Size(133, 21);
            this.msb_tel2.TabIndex = 33;
            // 
            // msb_tel1
            // 
            this.msb_tel1.Location = new System.Drawing.Point(125, 156);
            this.msb_tel1.Mask = "(999) 000-0000";
            this.msb_tel1.Name = "msb_tel1";
            this.msb_tel1.Size = new System.Drawing.Size(133, 21);
            this.msb_tel1.TabIndex = 33;
            // 
            // txt_yetkiliadsoyad
            // 
            this.txt_yetkiliadsoyad.Location = new System.Drawing.Point(125, 120);
            this.txt_yetkiliadsoyad.Name = "txt_yetkiliadsoyad";
            this.txt_yetkiliadsoyad.Size = new System.Drawing.Size(133, 21);
            this.txt_yetkiliadsoyad.TabIndex = 32;
            // 
            // txt_yetkiligorevi
            // 
            this.txt_yetkiligorevi.Location = new System.Drawing.Point(125, 84);
            this.txt_yetkiligorevi.Name = "txt_yetkiligorevi";
            this.txt_yetkiligorevi.Size = new System.Drawing.Size(133, 21);
            this.txt_yetkiligorevi.TabIndex = 32;
            // 
            // txt_sirketadi
            // 
            this.txt_sirketadi.Location = new System.Drawing.Point(125, 49);
            this.txt_sirketadi.Name = "txt_sirketadi";
            this.txt_sirketadi.Size = new System.Drawing.Size(133, 21);
            this.txt_sirketadi.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "ADRES:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "VERGİ DAİRESİ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "İLÇE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "İL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "EMAIL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "TELEFON 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "TELEFON 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "YETKİLİ ADI SOYADI:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "YETKİLİ GÖREVİ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ŞİRKET ADI:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonKaydet,
            this.toolStripButtonGuncelle,
            this.toolStripButtonSil,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(307, 25);
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
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(64, 22);
            this.toolStripButton1.Text = "YENİLE";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_bankayetkiliAdsoyad);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Controls.Add(this.txt_hesapturu);
            this.tabPage2.Controls.Add(this.msb_hesapno);
            this.tabPage2.Controls.Add(this.msb_Iban);
            this.tabPage2.Controls.Add(this.cmb_bankaadi);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(313, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ŞİRKET BANKA BİLGİLERİ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_bankayetkiliAdsoyad
            // 
            this.txt_bankayetkiliAdsoyad.Location = new System.Drawing.Point(56, 93);
            this.txt_bankayetkiliAdsoyad.Name = "txt_bankayetkiliAdsoyad";
            this.txt_bankayetkiliAdsoyad.Size = new System.Drawing.Size(164, 21);
            this.txt_bankayetkiliAdsoyad.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(53, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "BANKA YETKİLİ ADI SOYADI:";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonKaydet2,
            this.toolStripButtonGuncelle2,
            this.toolStripButtonSil2});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(307, 25);
            this.toolStrip2.TabIndex = 16;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButtonKaydet2
            // 
            this.toolStripButtonKaydet2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonKaydet2.Image")));
            this.toolStripButtonKaydet2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonKaydet2.Name = "toolStripButtonKaydet2";
            this.toolStripButtonKaydet2.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonKaydet2.Text = "Kaydet";
            this.toolStripButtonKaydet2.Click += new System.EventHandler(this.toolStripButtonKaydet2_Click);
            // 
            // toolStripButtonGuncelle2
            // 
            this.toolStripButtonGuncelle2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGuncelle2.Image")));
            this.toolStripButtonGuncelle2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuncelle2.Name = "toolStripButtonGuncelle2";
            this.toolStripButtonGuncelle2.Size = new System.Drawing.Size(73, 22);
            this.toolStripButtonGuncelle2.Text = "Güncelle";
            this.toolStripButtonGuncelle2.Click += new System.EventHandler(this.toolStripButtonGuncelle2_Click);
            // 
            // toolStripButtonSil2
            // 
            this.toolStripButtonSil2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSil2.Image")));
            this.toolStripButtonSil2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSil2.Name = "toolStripButtonSil2";
            this.toolStripButtonSil2.Size = new System.Drawing.Size(39, 22);
            this.toolStripButtonSil2.Text = "Sil";
            this.toolStripButtonSil2.Click += new System.EventHandler(this.toolStripButtonSil2_Click);
            // 
            // txt_hesapturu
            // 
            this.txt_hesapturu.Location = new System.Drawing.Point(56, 306);
            this.txt_hesapturu.Name = "txt_hesapturu";
            this.txt_hesapturu.Size = new System.Drawing.Size(164, 21);
            this.txt_hesapturu.TabIndex = 3;
            // 
            // msb_hesapno
            // 
            this.msb_hesapno.Location = new System.Drawing.Point(56, 253);
            this.msb_hesapno.Mask = "0000 0000 0000 0000";
            this.msb_hesapno.Name = "msb_hesapno";
            this.msb_hesapno.Size = new System.Drawing.Size(164, 21);
            this.msb_hesapno.TabIndex = 2;
            // 
            // msb_Iban
            // 
            this.msb_Iban.Location = new System.Drawing.Point(56, 198);
            this.msb_Iban.Mask = "TR-00 0000 0000 0000 0000 0000 00";
            this.msb_Iban.Name = "msb_Iban";
            this.msb_Iban.Size = new System.Drawing.Size(164, 21);
            this.msb_Iban.TabIndex = 2;
            // 
            // cmb_bankaadi
            // 
            this.cmb_bankaadi.FormattingEnabled = true;
            this.cmb_bankaadi.Location = new System.Drawing.Point(56, 141);
            this.cmb_bankaadi.Name = "cmb_bankaadi";
            this.cmb_bankaadi.Size = new System.Drawing.Size(164, 21);
            this.cmb_bankaadi.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(53, 290);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "HESAP TÜRÜ:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(53, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "HESAP NO:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "IBAN:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "BANKA ADI:";
            // 
            // gridControlBankaBilgileri
            // 
            this.gridControlBankaBilgileri.Location = new System.Drawing.Point(0, 1);
            this.gridControlBankaBilgileri.MainView = this.gridView2;
            this.gridControlBankaBilgileri.Name = "gridControlBankaBilgileri";
            this.gridControlBankaBilgileri.Size = new System.Drawing.Size(589, 494);
            this.gridControlBankaBilgileri.TabIndex = 8;
            this.gridControlBankaBilgileri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlBankaBilgileri;
            this.gridView2.Name = "gridView2";
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // FrmSirketler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 498);
            this.Controls.Add(this.gridControlBankaBilgileri);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmSirketler";
            this.Text = "FrmSirketler";
            this.Load += new System.EventHandler(this.FrmSirketler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBankaBilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.TextBox txt_vergidairesi;
        private System.Windows.Forms.ComboBox cmb_ilce;
        private System.Windows.Forms.ComboBox cmb_il;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.MaskedTextBox msb_tel2;
        private System.Windows.Forms.MaskedTextBox msb_tel1;
        private System.Windows.Forms.TextBox txt_yetkiliadsoyad;
        private System.Windows.Forms.TextBox txt_yetkiligorevi;
        private System.Windows.Forms.TextBox txt_sirketadi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonKaydet;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSil;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_hesapturu;
        private System.Windows.Forms.MaskedTextBox msb_hesapno;
        private System.Windows.Forms.MaskedTextBox msb_Iban;
        private System.Windows.Forms.ComboBox cmb_bankaadi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_bankayetkiliAdsoyad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonKaydet2;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle2;
        private System.Windows.Forms.ToolStripButton toolStripButtonSil2;
        private DevExpress.XtraGrid.GridControl gridControlBankaBilgileri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}