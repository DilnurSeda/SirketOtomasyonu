using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SirketOtomasyonu.BLL.Loginislemleri;

namespace SirketOtomasyonu.UserInterface
{
    public partial class FrmMenu : DevExpress.XtraEditors.XtraForm
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        
        FrmAnasayfa frm_anasayfa;
        private void barButtonItemAnasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_anasayfa==null || frm_anasayfa.IsDisposed==true)
            {
                frm_anasayfa = new FrmAnasayfa();
                frm_anasayfa.MdiParent = this;
                frm_anasayfa.Show();
            }
        }
        FrmUrunler fr_urun;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr_urun==null || fr_urun.IsDisposed==true)
            {
                fr_urun = new FrmUrunler();
                fr_urun.MdiParent = this;
                fr_urun.Show();

            }

        }
        frmMusteriler frm_Mus;
        private void barButtonItemMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_Mus == null || frm_Mus.IsDisposed == true)
            {
                frm_Mus = new frmMusteriler();
                frm_Mus.MdiParent = this;
                frm_Mus.Show();
            }
        }
        FrmBankalar frm_Banka;
        private void barButtonItemBankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_Banka == null || frm_Banka.IsDisposed == true)
            {
                frm_Banka = new FrmBankalar();
                frm_Banka.MdiParent = this;
                frm_Banka.Show();
            }
        }
        FrmFaturalar frm_Fatura;
        private void barButtonItemFaturaDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_Fatura==null || frm_Fatura.IsDisposed==true)
            {
                frm_Fatura = new FrmFaturalar();
                frm_Fatura.MdiParent = this;
                frm_Fatura.Show();
            }
            else
            {
                MessageBox.Show("Faturalar formu açık");
            }
            
        }
        //***************************
        public int yetki_Id;
        //***************************
        public string yetki_Adi;
        //***************************
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            if (yetki_Id==2)
            {
                //Yönetici
                barButtonItemKasa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                barButtonItemGider.Enabled = false;
            }
            if (yetki_Id==3)
            {
                //muhasebe1
                barButtonItemAyarlar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItemUrunler.Enabled = false;
            }
            if (yetki_Id==4)
            {
                //muhasebe2
                barButtonItemKasa.Enabled = false;
                barButtonItemUrunler.Enabled = false;
                barButtonItemNotlar.Enabled = false;
                barButtonItemAyarlar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (yetki_Id==5)
            {
                //Müdür
                barButtonItemKasa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItemAyarlar.Enabled = false;

            }
            if (yetki_Id==6)
            {
                //Şef
                barButtonItemKasa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItemAyarlar.Enabled = false;
                barButtonItemNotlar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (yetki_Id==7)
            {
                //Personel Yöneticisi
                barButtonItemKasa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItemAyarlar.Enabled = false;
            }
            if (yetki_Id==8)
            {
                //Personel
                barButtonItemPersoneller.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItemKasa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItemNotlar.Enabled = false;
            }
            //MessageBox.Show(yetki_Id.ToString());
        }
        FrmSirketler frm_sirket;
        private void barButtonItemSirket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_sirket==null || frm_sirket.IsDisposed == true)
            {
                frm_sirket = new FrmSirketler();
                frm_sirket.MdiParent = this;
                frm_sirket.Show();
            }
        }
        FrmGiderler frm_gider;
        private void barButtonItemGider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_gider == null || frm_gider.IsDisposed == true)
            {
                frm_gider = new FrmGiderler();
                frm_gider.MdiParent = this;
                frm_gider.Show();
            }
        }
        FrmGelirler frm_gel;
        private void barButtonItemGelirler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_gel==null || frm_gel.IsDisposed==true)
            {
                frm_gel = new FrmGelirler();
                frm_gel.MdiParent = this;
                frm_gel.Show();
            }
        }
        FrmPersoneller frm_per;
        private void barButtonItemPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_per ==null || frm_per.IsDisposed==true)
            {
                frm_per = new FrmPersoneller();
                frm_per.MdiParent = this;
                frm_per.Show();
            }

        }

        FrmMarkalar frm_marka;
        private void barButtonItemUrunMarkasi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_marka == null || frm_marka.IsDisposed == true)
            {
                frm_marka = new FrmMarkalar();
                frm_marka.MdiParent = this;
                frm_marka.Show();
            }
        }

        FrmModeller frm_model;
        private void barButtonItemUrunModel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_model==null || frm_model.IsDisposed==true)
            {
                frm_model = new FrmModeller();
                frm_model.MdiParent = this;
                frm_model.Show();
            }
        }
        FrmKullanicilar frm_kullanici;
        private void barButtonItemAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_kullanici==null || frm_kullanici.IsDisposed==true)
            {
                frm_kullanici = new FrmKullanicilar();
                frm_kullanici.MdiParent = this;
                frm_kullanici.Show();
            }
        }
        Frm_PersonelDetay frm_perDetay;
        private void barButtonPersonelDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_perDetay==null || frm_perDetay.IsDisposed==true)
            {
                frm_perDetay = new Frm_PersonelDetay();
                frm_perDetay.MdiParent = this;
                frm_perDetay.Show();
            }
        }
        FrmNotlar frm_not;
        private void barButtonItemNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_not==null || frm_not.IsDisposed==true)
            {
                frm_not = new FrmNotlar();
                frm_not.MdiParent = this;
                frm_not.Show();
                frm_not.txt_notuolusturan.Text = lblKullaniciBilgisi.Text;
                
            }
        }
    }
}