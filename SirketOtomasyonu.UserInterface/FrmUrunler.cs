using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SirketOtomasyonu.BLL;
using SiketOtomasyonu.DLL;

namespace SirketOtomasyonu.UserInterface
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        //*****************************************************************
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();
        //*****************************************************************
        UrunlerManager urn = new UrunlerManager();
        //******************************************************************
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = urn.UrunListele();
        }

        private void toolStripButtonUrunKaydet_Click(object sender, EventArgs e)
        {


            string sonuc = urn.urunKaydet(txtUrunAdi.Text, cmbMarkasi.Text, cmbModeli.Text, cmbYil.Text, Convert.ToInt16(nudStok.Value), Convert.ToDecimal(txtAlisFiyati.Text), Convert.ToDecimal(txtSatisFiyati.Text), txtDetay.Text);

            MessageBox.Show(sonuc);
            gridControl1.DataSource = urn.UrunListele();

        }
        int uruid;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            txtUrunAdi.Text = gridView1.GetFocusedRowCellValue("UrunAdi").ToString();
            txtAlisFiyati.Text = gridView1.GetFocusedRowCellValue("AlisFiyati").ToString();
            txtSatisFiyati.Text = gridView1.GetFocusedRowCellValue("SatisFiyati").ToString();
            cmbMarkasi.Text = gridView1.GetFocusedRowCellValue("UrunMarkasi").ToString();
            cmbModeli.Text = gridView1.GetFocusedRowCellValue("UrunModel").ToString();
            nudStok.Value = short.Parse(gridView1.GetFocusedRowCellValue("Stok").ToString());
            txtDetay.Text = gridView1.GetFocusedRowCellValue("Detay").ToString();
            cmbYil.Text = gridView1.GetFocusedRowCellValue("UrunUretimYili").ToString();
            uruid = Convert.ToInt32(gridView1.GetFocusedRowCellValue("UrunlerID").ToString());
            //******************************************




        }

        private void toolStripButtonUrunGuncelle_Click(object sender, EventArgs e)
        {
            string guncelleme = urn.urunGuncelle(uruid, txtUrunAdi.Text, cmbMarkasi.Text, cmbModeli.Text, cmbYil.Text, Convert.ToInt16(nudStok.Value), Convert.ToDecimal(txtAlisFiyati.Text), Convert.ToDecimal(txtSatisFiyati.Text), txtDetay.Text);
            gridControl1.DataSource = urn.UrunListele();
            MessageBox.Show(guncelleme);
        }

        private void toolStripButtonUrunSil_Click(object sender, EventArgs e)
        {
            string sonucSil = urn.UrunSil(uruid);
            gridControl1.DataSource = urn.UrunListele();
            MessageBox.Show("Urun silindi");
        }
    }
}
