using SiketOtomasyonu.DLL;
using SirketOtomasyonu.BLL.Giderislemleri;
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
    public partial class FrmGiderler : Form
    {
        GiderlerManager gidermanager = new GiderlerManager();
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();

        public FrmGiderler()
        {
            InitializeComponent();
        }

        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = gidermanager.GiderListesi();

            cmb_giderturuadi.DisplayMember = "GiderAdi";
            cmb_giderturuadi.ValueMember = "GiderTurleriID";
            cmb_giderturuadi.DataSource = db.GiderTurleri.OrderBy(h => h.GiderTurleriID).ToList();
        }

        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            string sonuc = gidermanager.GiderKaydet(cmb_giderturuadi.Text, date_gelirtarihi.Value, txt_toplamtutar.Text, txt_aciklama.Text);
            gridControl1.DataSource = gidermanager.GiderListesi();
            MessageBox.Show(sonuc);
        }
        int giderid;
        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            string sonuc = gidermanager.GiderGuncelle(giderid,cmb_giderturuadi.Text, date_gelirtarihi.Value, txt_toplamtutar.Text, txt_aciklama.Text);
            gridControl1.DataSource = gidermanager.GiderListesi();
            MessageBox.Show(sonuc);
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            string sonuc = gidermanager.GiderSil(giderid);
            gridControl1.DataSource = gidermanager.GiderListesi();
            MessageBox.Show(sonuc);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            giderid = Convert.ToInt32(gridView1.GetFocusedRowCellValue("GiderlerID").ToString());
            cmb_giderturuadi.Text = gridView1.GetFocusedRowCellValue("GiderTuruAdi").ToString();
            date_gelirtarihi.Text = gridView1.GetFocusedRowCellValue("Tarihi").ToString();
            txt_toplamtutar.Text = gridView1.GetFocusedRowCellValue("GiderTutari").ToString();
            txt_aciklama.Text = gridView1.GetFocusedRowCellValue("Aciklama").ToString();
        }
    }
}
