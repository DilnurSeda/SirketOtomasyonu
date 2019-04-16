using SiketOtomasyonu.DLL;
using SirketOtomasyonu.BLL.Loginislemleri;
using SirketOtomasyonu.BLL.Notislemleri;
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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();
        NotlarManager notMng = new NotlarManager();
        string notolusturan;
        int not_id;

        private void FrmNotlar_Load(object sender, EventArgs e)
        {
                        
        }

        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            string sonuc = notMng.notKaydet(date_notTarihi.Value, TimeSpan.Parse(date_notSaati.Text), txt_notBaslik.Text, txt_notDetay.Text,txt_notuolusturan.Text);

            gridControlNotlar.DataSource = notMng.notListesi(notolusturan);
            MessageBox.Show(sonuc);
        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            string sonuc = notMng.notGuncelle(not_id,date_notTarihi.Value, TimeSpan.Parse(date_notSaati.Text), txt_notBaslik.Text, txt_notDetay.Text, txt_notuolusturan.Text);

            gridControlNotlar.DataSource = notMng.notListesi(notolusturan);
            MessageBox.Show(sonuc);
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            string sonuc = notMng.notSil(not_id);

            gridControlNotlar.DataSource = notMng.notListesi(notolusturan);
            MessageBox.Show(sonuc);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            not_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("NotlarID").ToString());
            date_notTarihi.Value= Convert.ToDateTime(gridView1.GetFocusedRowCellValue("NotTarihi").ToString());
            date_notSaati.Text= gridView1.GetFocusedRowCellValue("NotSaati").ToString();
            txt_notBaslik.Text= gridView1.GetFocusedRowCellValue("NotBaslik").ToString();
            txt_notDetay.Text= gridView1.GetFocusedRowCellValue("NotDetay").ToString();
            txt_notuolusturan.Text= gridView1.GetFocusedRowCellValue("NotuOlusturan").ToString();
        }
    }
}
