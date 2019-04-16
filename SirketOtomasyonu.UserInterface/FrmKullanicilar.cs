using SiketOtomasyonu.DLL;
using SirketOtomasyonu.BLL.Kullaniciislemleri;
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
    public partial class FrmKullanicilar : Form
    {
        public FrmKullanicilar()
        {
            InitializeComponent();
        }
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();
        KullanicilarManager kullanicimng = new KullanicilarManager();
        //*********************
        int yetki_id;
        int kullanici_id;
        //**********************

        private void FrmKullanicilar_Load(object sender, EventArgs e)
        {
            gridControlKullanici.DataSource = kullanicimng.kullaniciListesi();
        }
        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            string sonuc = kullanicimng.kullaniciKaydet(txt_Adi.Text, txt_soyadi.Text, txt_kullaniciAdi.Text, txt_sifresi.Text, yetki_id);
            MessageBox.Show(sonuc);
            gridControlKullanici.DataSource = kullanicimng.kullaniciListesi();
        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            string sonuc = kullanicimng.kullaniciGuncelle(kullanici_id,txt_Adi.Text, txt_soyadi.Text, txt_kullaniciAdi.Text, txt_sifresi.Text, yetki_id);
            MessageBox.Show(sonuc);
            gridControlKullanici.DataSource = kullanicimng.kullaniciListesi();
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            string sonuc = kullanicimng.kullaniciSil(kullanici_id);
            MessageBox.Show(sonuc);
            gridControlKullanici.DataSource = kullanicimng.kullaniciListesi();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            kullanici_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("KullanicilarID").ToString());
            txt_Adi.Text = gridView1.GetFocusedRowCellValue("Adi").ToString();
            txt_soyadi.Text = gridView1.GetFocusedRowCellValue("Soyadi").ToString();
            txt_kullaniciAdi.Text = gridView1.GetFocusedRowCellValue("KullaniciAdi").ToString();
            txt_sifresi.Text = gridView1.GetFocusedRowCellValue("Sifresi").ToString();
            yetki_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("YetkiID").ToString());
        }
    }
}
