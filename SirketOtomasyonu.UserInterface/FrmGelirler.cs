using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiketOtomasyonu.DLL;
using SirketOtomasyonu.BLL.GelirSatisislemleri;

namespace SirketOtomasyonu.UserInterface
{
    public partial class FrmGelirler : Form
    {
        public FrmGelirler()
        {
            InitializeComponent();
        }
        //************************************
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();
        GelirSatisManager gelsat = new GelirSatisManager();
        
        //*************************************
        int gelir_ID;
        int satis_id;
        int urun_id;
        int musteri_id, kullanici_id;
        //******************************************
        private void FrmGelirler_Load(object sender, EventArgs e)
        {
            gelir_ID = 1;
            gridControlGelirler.DataSource = gelsat.GelirListesi();

            gridControlSatislar.DataSource = gelsat.SatisListesi(gelir_ID);
            cmb_urunler.DisplayMember = "UrunAdi";
            cmb_urunler.ValueMember = "UrunlerID";
            cmb_urunler.DataSource = db.Urunler.OrderBy(k => k.UrunAdi).ToList();
            cmb_urunler.SelectedIndex = -1;
            cmb_musteri.DisplayMember = "MusteriAdi";
            cmb_musteri.ValueMember = "MusterilerID";
            cmb_musteri.DataSource = db.Musteriler.OrderBy(m => m.MusteriAdi).ToList();
            cmb_musteri.SelectedIndex = -1;

        }

        #region Gelirler
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gelir_ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("GelirlerID").ToString());
            date_gelirtarihi.Text = gridView1.GetFocusedRowCellValue("GelirTarihi").ToString();
            txt_toplamtutar.Text = gridView1.GetFocusedRowCellValue("ToplamTutar").ToString();
        }

        private void tabPane1_SelectedPageIndexChanged(object sender, EventArgs e)
        {
            if (tabPane1.SelectedPageIndex == 0)
            {
                gridControlGelirler.Visible = true;
                gridControlSatislar.Visible = false;
                gridControlGelirler.DataSource = gelsat.GelirListesi();
            }
            else
            {
                gridControlSatislar.Visible = true;
                gridControlGelirler.Visible = false;
                gridControlSatislar.DataSource = gelsat.SatisListesi(gelir_ID);
            }

        }

        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            string sonucKaydet = gelsat.GelirKaydet(date_gelirtarihi.Value, Convert.ToDecimal(txt_toplamtutar.Text));
            MessageBox.Show(sonucKaydet);
            gridControlGelirler.DataSource = gelsat.GelirListesi();

        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            string sonucGuncelle = gelsat.GelirGuncelle(gelir_ID, date_gelirtarihi.Value, Convert.ToDecimal(txt_toplamtutar.Text));
            MessageBox.Show(sonucGuncelle);
            gridControlGelirler.DataSource = gelsat.GelirListesi();
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            string sonucSil = gelsat.GelirSil(gelir_ID);
            MessageBox.Show(sonucSil);
            gridControlGelirler.DataSource = gelsat.GelirListesi();
        }
        #endregion

        #region Satışlar
        private void toolStripSatisKaydet_Click(object sender, EventArgs e)
        {
            if (IndirimKontrol(Convert.ToDecimal(txt_indirimorani.Text)))
            {
                string sonucKaydet = gelsat.SatisKaydet(urun_id, date_islemtarihi.Value, TimeSpan.Parse(dateEditIslemSaati.Text), musteri_id, Convert.ToDecimal(txt_tutar.Text), Convert.ToInt32(txt_adet.Text), Convert.ToDecimal(txt_indirimorani.Text), txt_indirimAciklmsi.Text, kullanici_id, gelir_ID);
                gridControlSatislar.DataSource = gelsat.SatisListesi(gelir_ID);
                MessageBox.Show(sonucKaydet);
            }
            else
            {

                MessageBox.Show("İndirim oranı geçersiz");
            }

        }

        private void toolStripSatisGuncelle_Click(object sender, EventArgs e)
        {
            string sonucGuncelle = gelsat.SatisGuncelle(satis_id, urun_id, date_islemtarihi.Value, TimeSpan.Parse(dateEditIslemSaati.Text), musteri_id, Convert.ToDecimal(txt_tutar.Text), Convert.ToInt32(txt_adet.Text), Convert.ToDecimal(txt_indirimorani.Text), txt_indirimAciklmsi.Text, kullanici_id, gelir_ID);
            MessageBox.Show(sonucGuncelle);
            gridControlSatislar.DataSource = gelsat.SatisListesi(gelir_ID);
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                satis_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("SatislarID").ToString());
                urun_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("UrunID").ToString());
                date_islemtarihi.Value = Convert.ToDateTime(gridView2.GetFocusedRowCellValue("islemTarihi"));
                dateEditIslemSaati.Text = gridView2.GetFocusedRowCellValue("islemSaat").ToString();
                musteri_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("MusteriID").ToString());
                txt_tutar.Text = gridView2.GetFocusedRowCellValue("Tutar").ToString();
                txt_adet.Text = gridView2.GetFocusedRowCellValue("Adet").ToString();
                txt_indirimorani.Text = gridView2.GetFocusedRowCellValue("indirimOrani").ToString();
                txt_indirimAciklmsi.Text = gridView2.GetFocusedRowCellValue("indirimAciklamasi").ToString();
                kullanici_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("KullaniciID").ToString());
                gelir_ID = Convert.ToInt32(gridView2.GetFocusedRowCellValue("GelirID").ToString());


                int urunsec_Id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("UrunID").ToString());
                cmb_urunler.Text = db.Urunler.Where(k => k.UrunlerID == urunsec_Id).FirstOrDefault().UrunAdi.ToString();
            }
            catch (Exception)
            {


            }

        }

        private void toolStripSatisSil_Click(object sender, EventArgs e)
        {
            string sonucSil = gelsat.SatisSil(satis_id);
            MessageBox.Show(sonucSil);
            gridControlSatislar.DataSource = gelsat.SatisListesi(gelir_ID);
        } 
        #endregion

        private void txt_indirimorani_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (IndirimKontrol(Convert.ToDecimal(txt_indirimorani.Text)))
                {
                    txt_indirimorani.BackColor = Color.White;
                }
                else
                {
                    txt_indirimorani.BackColor = Color.Beige;
                }
            }
            catch (Exception)
            {

                txt_indirimorani.Text = 0.ToString();
                txt_indirimorani.BackColor = Color.PaleVioletRed;
            }

        }



        private bool IndirimKontrol(decimal oran)
        {
            if (oran > 0 && oran < 1)
            {
                return true;
            }
            return false;
        }
    }
}
