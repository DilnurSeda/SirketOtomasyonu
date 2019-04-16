using SiketOtomasyonu.DLL;
using SirketOtomasyonu.BLL.SirketBankaislemleri;
using SirketOtomasyonu.BLL.Sirketislemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirketOtomasyonu.UserInterface
{
    public partial class FrmSirketler : Form
    {
        public FrmSirketler()
        {
            InitializeComponent();
        }
        //*****************************************************
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();
        SirketlerManager sirketmanager = new SirketlerManager();
        SirketBankaBilgiManager sirketbmanager = new SirketBankaBilgiManager();
        //******************************************************
        int sirketId;
        int sirketbankaID;
        int banka_Id;
        //*******************************************************
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                sirketId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("SirketlerID").ToString());
                txt_sirketadi.Text = gridView1.GetFocusedRowCellValue("SirketAdi").ToString();
                txt_yetkiligorevi.Text = gridView1.GetFocusedRowCellValue("YetkiliGorevi").ToString();
                txt_yetkiliadsoyad.Text = gridView1.GetFocusedRowCellValue("YetkiliAdiSoyadi").ToString();
                msb_tel1.Text = gridView1.GetFocusedRowCellValue("SirketTelefon1").ToString();
                msb_tel2.Text = gridView1.GetFocusedRowCellValue("SirketTelefon2").ToString();
                txt_email.Text = gridView1.GetFocusedRowCellValue("EMail").ToString();
                cmb_il.Text = gridView1.GetFocusedRowCellValue("il").ToString();
                cmb_ilce.Text = gridView1.GetFocusedRowCellValue("ilce").ToString();
                txt_vergidairesi.Text = gridView1.GetFocusedRowCellValue("VergiDairesi").ToString();
                txt_adres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Null değerler girilmiş")
;            }
        }

        private void FrmSirketler_Load(object sender, EventArgs e)
        {
            gridControlBankaBilgileri.Visible = false;
            
            //cmb_bankaadi.DataSource = db.Bankalar.Where(k => k.BankalarID == banka_Id).FirstOrDefault();
            //cmb_bankaadi.DataSource = db.Bankalar.Where(k => k.BankalarID == banka_Id).FirstOrDefault();
            cmb_bankaadi.DisplayMember = "BankaAdi";
            cmb_bankaadi.ValueMember = "BankalarID";
            cmb_bankaadi.DataSource = db.Bankalar.OrderBy(k => k.BankaAdi).ToList();

            //*******************************************
            gridControl1.DataSource = db.Sirketler.ToList();
            cmb_il.DisplayMember = "SehirAdi";
            cmb_il.ValueMember = "illerID";
            cmb_il.SelectedIndex = -1;
            cmb_ilce.Enabled = false;
            cmb_il.DataSource = db.iller.OrderBy(k => k.SehirAdi).ToList();
            cmb_il.SelectedIndex = -1;
            cmb_ilce.SelectedIndex = -1;

        }

        private void cmb_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_ilce.Enabled = true;
            if (cmb_il.SelectedIndex != -1)
            {
                cmb_ilce.Text = "";
                cmb_ilce.DisplayMember = "ilceAdi";
                cmb_ilce.ValueMember = "ilcelerID";
                cmb_ilce.DataSource = db.ilceler.Where(k => k.ilID == (int)cmb_il.SelectedValue).ToList();

            }
        }

        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            string sonuc = sirketmanager.sirketKaydet(txt_sirketadi.Text, txt_yetkiligorevi.Text, txt_yetkiliadsoyad.Text, msb_tel1.Text, msb_tel2.Text, txt_email.Text, cmb_il.Text, cmb_ilce.Text, txt_vergidairesi.Text, txt_adres.Text);
            gridControl1.DataSource = db.Sirketler.ToList();
            MessageBox.Show(sonuc);
        }
           
          

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            string sonuc = sirketmanager.sirketGuncelle(sirketId, txt_sirketadi.Text, txt_yetkiligorevi.Text, txt_yetkiliadsoyad.Text, msb_tel1.Text, msb_tel2.Text, txt_email.Text, cmb_il.Text, cmb_ilce.Text, txt_vergidairesi.Text, txt_adres.Text);

            gridControl1.DataSource = db.Sirketler.ToList();

            MessageBox.Show(sonuc);
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            string sonuc = sirketmanager.sirketSil(sirketId);
            MessageBox.Show(sonuc);
            gridControl1.DataSource = db.Sirketler.ToList();
        }
        //****************************************************************************
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab==tabPage1)
            {
                gridControlBankaBilgileri.Visible = false;
                gridControl1.Visible = true;
            }
            else if (tabControl1.SelectedTab==tabPage2)
            {
                gridControl1.Visible = false;
                gridControlBankaBilgileri.Visible = true;

                gridControlBankaBilgileri.DataSource = db.SirketBankaBilgileri.Where(k => k.SirketID == sirketId).ToList();
            }
        }
        //************************************************************************************
        private void toolStripButtonKaydet2_Click(object sender, EventArgs e)
        {
             //cmb_bankaadi.DataSource = db.Bankalar.Where(k => k.BankalarID == banka_Id).FirstOrDefault();
             
            string sonuc = sirketbmanager.bankaBilgileriKaydet(sirketId,(int)cmb_bankaadi.SelectedValue,msb_Iban.Text, msb_hesapno.Text, txt_bankayetkiliAdsoyad.Text, txt_hesapturu.Text);
            MessageBox.Show(sonuc);
            gridControlBankaBilgileri.DataSource = db.SirketBankaBilgileri.Where(k => k.SirketID == sirketId).ToList();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.Sirketler.ToList();
        }

        private void toolStripButtonGuncelle2_Click(object sender, EventArgs e)
        {
            string sonuc = sirketbmanager.bankaBilgileriGuncelle(sirketbankaID,sirketId, (int)cmb_bankaadi.SelectedValue, msb_Iban.Text, msb_hesapno.Text, txt_bankayetkiliAdsoyad.Text, txt_hesapturu.Text);
            MessageBox.Show(sonuc);
            gridControlBankaBilgileri.DataSource = db.SirketBankaBilgileri.Where(k => k.SirketID == sirketId).ToList();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                sirketbankaID = Convert.ToInt32(gridView2.GetFocusedRowCellValue("SirketBankaBilgileriID").ToString());
                sirketId = Convert.ToInt32(gridView2.GetFocusedRowCellValue("SirketID").ToString());
                banka_Id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("BankaID").ToString());
                msb_Iban.Text = gridView2.GetFocusedRowCellValue("Iban").ToString();
                msb_hesapno.Text = gridView2.GetFocusedRowCellValue("HesapNo").ToString();
                txt_bankayetkiliAdsoyad.Text = gridView2.GetFocusedRowCellValue("BankaYetkiliAdiSoyadi").ToString();
                txt_hesapturu.Text = gridView2.GetFocusedRowCellValue("HesapTuru").ToString();
                cmb_bankaadi.Text = sirketbmanager.bankaAdi(banka_Id);
            }
            catch (Exception)
            {

                MessageBox.Show("Sirkete ait Banka bilgisi bulunmamaktadır");

            }
        }

        private void toolStripButtonSil2_Click(object sender, EventArgs e)
        {
            string sonuc = sirketbmanager.bankaBilgileriSil(sirketId);
            MessageBox.Show(sonuc);
            gridControlBankaBilgileri.DataSource = db.SirketBankaBilgileri.Where(k => k.SirketID == sirketId).ToList();
        }
    }
}
