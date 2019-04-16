namespace SirketOtomasyonu.UserInterface
{
    partial class FrmNotlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotlar));
            this.gridControlNotlar = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationGiderler = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.txt_notuolusturan = new System.Windows.Forms.TextBox();
            this.txt_notDetay = new System.Windows.Forms.TextBox();
            this.txt_notBaslik = new System.Windows.Forms.TextBox();
            this.date_notSaati = new System.Windows.Forms.DateTimePicker();
            this.date_notTarihi = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNotlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationGiderler.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlNotlar
            // 
            this.gridControlNotlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlNotlar.Location = new System.Drawing.Point(4, 2);
            this.gridControlNotlar.MainView = this.gridView1;
            this.gridControlNotlar.Name = "gridControlNotlar";
            this.gridControlNotlar.Size = new System.Drawing.Size(550, 455);
            this.gridControlNotlar.TabIndex = 6;
            this.gridControlNotlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlNotlar;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // tabPane1
            // 
            this.tabPane1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPane1.Controls.Add(this.tabNavigationGiderler);
            this.tabPane1.Location = new System.Drawing.Point(559, 2);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationGiderler});
            this.tabPane1.RegularSize = new System.Drawing.Size(300, 457);
            this.tabPane1.SelectedPage = this.tabNavigationGiderler;
            this.tabPane1.Size = new System.Drawing.Size(300, 457);
            this.tabPane1.TabIndex = 7;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationGiderler
            // 
            this.tabNavigationGiderler.Caption = "tabNavigationPage1";
            this.tabNavigationGiderler.Controls.Add(this.txt_notuolusturan);
            this.tabNavigationGiderler.Controls.Add(this.txt_notDetay);
            this.tabNavigationGiderler.Controls.Add(this.txt_notBaslik);
            this.tabNavigationGiderler.Controls.Add(this.date_notSaati);
            this.tabNavigationGiderler.Controls.Add(this.date_notTarihi);
            this.tabNavigationGiderler.Controls.Add(this.toolStrip1);
            this.tabNavigationGiderler.Controls.Add(this.label4);
            this.tabNavigationGiderler.Controls.Add(this.label3);
            this.tabNavigationGiderler.Controls.Add(this.label1);
            this.tabNavigationGiderler.Controls.Add(this.label5);
            this.tabNavigationGiderler.Controls.Add(this.label2);
            this.tabNavigationGiderler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationGiderler.ImageOptions.Image")));
            this.tabNavigationGiderler.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationGiderler.Name = "tabNavigationGiderler";
            this.tabNavigationGiderler.PageText = "Notlar";
            this.tabNavigationGiderler.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationGiderler.Size = new System.Drawing.Size(300, 411);
            // 
            // txt_notuolusturan
            // 
            this.txt_notuolusturan.Enabled = false;
            this.txt_notuolusturan.Location = new System.Drawing.Point(93, 185);
            this.txt_notuolusturan.Name = "txt_notuolusturan";
            this.txt_notuolusturan.Size = new System.Drawing.Size(155, 20);
            this.txt_notuolusturan.TabIndex = 19;
            // 
            // txt_notDetay
            // 
            this.txt_notDetay.Location = new System.Drawing.Point(93, 152);
            this.txt_notDetay.Name = "txt_notDetay";
            this.txt_notDetay.Size = new System.Drawing.Size(155, 20);
            this.txt_notDetay.TabIndex = 19;
            // 
            // txt_notBaslik
            // 
            this.txt_notBaslik.Location = new System.Drawing.Point(93, 121);
            this.txt_notBaslik.Name = "txt_notBaslik";
            this.txt_notBaslik.Size = new System.Drawing.Size(155, 20);
            this.txt_notBaslik.TabIndex = 18;
            // 
            // date_notSaati
            // 
            this.date_notSaati.Enabled = false;
            this.date_notSaati.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.date_notSaati.Location = new System.Drawing.Point(93, 88);
            this.date_notSaati.Name = "date_notSaati";
            this.date_notSaati.Size = new System.Drawing.Size(155, 20);
            this.date_notSaati.TabIndex = 17;
            // 
            // date_notTarihi
            // 
            this.date_notTarihi.Enabled = false;
            this.date_notTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_notTarihi.Location = new System.Drawing.Point(93, 54);
            this.date_notTarihi.Name = "date_notTarihi";
            this.date_notTarihi.Size = new System.Drawing.Size(155, 20);
            this.date_notTarihi.TabIndex = 17;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Not Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Not Saati:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Not Başlık:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Notu Oluşturan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Not Detay:";
            // 
            // FrmNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 460);
            this.Controls.Add(this.gridControlNotlar);
            this.Controls.Add(this.tabPane1);
            this.Name = "FrmNotlar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Notlar";
            this.Load += new System.EventHandler(this.FrmNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNotlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationGiderler.ResumeLayout(false);
            this.tabNavigationGiderler.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlNotlar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationGiderler;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonKaydet;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_notDetay;
        private System.Windows.Forms.TextBox txt_notBaslik;
        private System.Windows.Forms.DateTimePicker date_notSaati;
        private System.Windows.Forms.DateTimePicker date_notTarihi;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_notuolusturan;
        private System.Windows.Forms.Label label1;
    }
}