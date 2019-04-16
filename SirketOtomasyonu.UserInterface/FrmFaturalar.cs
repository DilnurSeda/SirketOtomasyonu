using System;
using System.Windows.Forms;
using SiketOtomasyonu.DLL;
using SirketOtomasyonu.BLL.Faturalar;
using System.Linq;
using DevExpress.XtraReports.UI;

namespace SirketOtomasyonu.UserInterface
{
    public partial class FrmFaturalar : Form
    {
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();
        FaturalarManager fatura = new FaturalarManager();
        
        public FrmFaturalar()
        {
            InitializeComponent();
        }
        
        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            string sonuc = fatura.FaturaKaydet(cmbSeri.Text, msbSirano.Text, dateTarih.Text, dateSaat.Text, cmbVergiDairesi.Text, txtAlici.Text, txtTeslimEden.Text, txtTeslimAlan.Text);
            MessageBox.Show(sonuc);
            gridControlfaturalar.DataSource = db.Faturalar.ToList();
        }
        int fatura_Id;
        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            string sonuc = fatura.FaturaGuncelle(fatura_Id,cmbSeri.Text, msbSirano.Text, dateTarih.Text, dateSaat.Text, cmbVergiDairesi.Text, txtAlici.Text, txtTeslimEden.Text, txtTeslimAlan.Text);
            MessageBox.Show(sonuc);
            gridControlfaturalar.DataSource = db.Faturalar.ToList();
        }

        private void FrmFaturalar_Load(object sender, EventArgs e)
        {

            gridControlfaturalar.DataSource = fatura.FaturaListesi();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            fatura_Id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("FaturalarID").ToString());
            cmbSeri.Text = gridView1.GetFocusedRowCellValue("Seri").ToString();
            msbSirano.Text = gridView1.GetFocusedRowCellValue("SiraNo").ToString();
            dateTarih.Text = gridView1.GetFocusedRowCellValue("Tarih").ToString();
            dateSaat.Text = TimeSpan.Parse(gridView1.GetFocusedRowCellValue("Saat").ToString()).ToString();
            cmbVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VergiDaileri").ToString();
            txtAlici.Text = gridView1.GetFocusedRowCellValue("Alici").ToString();
            txtTeslimEden.Text = gridView1.GetFocusedRowCellValue("TeslimEden").ToString();
            txtTeslimAlan.Text = gridView1.GetFocusedRowCellValue("TeslimAlan").ToString();
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            string sil = fatura.FaturaSil(fatura_Id);
            MessageBox.Show(sil);
            gridControlfaturalar.DataSource = db.Faturalar.ToList();
        }

        private void tabPane1_SelectedPageIndexChanged(object sender, EventArgs e)
        {
            //gridcontrol1=faturadetaylistesi grid
            if (tabPane1.SelectedPageIndex==0)
            {
                gridControl1.Visible = false;
                gridControlfaturalar.Visible = true;
                gridControlfaturalar.DataSource = fatura.FaturaListesi();
            }
            else
            {
                gridControl1.Visible = true;
                gridControlfaturalar.Visible = false;
                gridControl1.DataSource = fatura.FaturaDetayListesi(fatura_Id);
            }
        }

        int faturadetay_Id;

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            faturadetay_Id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("FaturaDetaylarID").ToString());
            labelurunId.Text = gridView2.GetFocusedRowCellValue("UrunID").ToString();
            textBoxmiktar.Text = gridView2.GetFocusedRowCellValue("Miktar").ToString();
            textBoxfiyat.Text = gridView2.GetFocusedRowCellValue("Fiyat").ToString();
            textBoxtutar.Text = gridView2.GetFocusedRowCellValue("Tutar").ToString();
            labelfaturaId.Text = gridView2.GetFocusedRowCellValue("FaturaID").ToString();

        }

        private void toolStripButtonKaydetDty_Click(object sender, EventArgs e)
        {
            string sonuc = fatura.FaturaDetayKaydet(int.Parse(labelurunId.Text),short.Parse(textBoxmiktar.Text), Convert.ToDecimal(textBoxfiyat.Text), Convert.ToDecimal(textBoxtutar.Text), int.Parse(labelfaturaId.Text));
            fatura.FaturaDetayListesi(faturadetay_Id);
            MessageBox.Show(sonuc);

        }

        private void toolStripButtonGuncelleDty_Click(object sender, EventArgs e)
        {
            string sonuc = fatura.FaturaDetayGuncelle(faturadetay_Id,int.Parse(labelurunId.Text), short.Parse(textBoxmiktar.Text), Convert.ToDecimal(textBoxfiyat.Text), Convert.ToDecimal(textBoxtutar.Text), int.Parse(labelfaturaId.Text));
            fatura.FaturaDetayListesi(faturadetay_Id);
            MessageBox.Show(sonuc);
        }

        private void toolStripButtonSilDty_Click(object sender, EventArgs e)
        {
            string sil = fatura.FaturaDetaySil(faturadetay_Id);
            MessageBox.Show(sil);
            gridControl1.DataSource = db.FaturaDetay.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            XtraReport raporFatura = new XtraReport();
            raporFatura.DataSource = db.Faturalar.Where(f => f.FaturalarID == fatura_Id).ToList();
            raporFatura.ShowDesigner();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            XtraReport raporFaturaDetay = new XtraReport();
            raporFaturaDetay.DataSource = db.FaturaDetay.Where(f => f.FaturaID == fatura_Id).ToList();
            raporFaturaDetay.ShowDesigner();
        }
    }
}
