using SirketOtomasyonu.BLL.Markaislemleri;
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
    public partial class FrmMarkalar : Form
    {
        
        MarkalarManager markamng = new MarkalarManager();

        public FrmMarkalar()
        {
            InitializeComponent();
        }
        //******
        int marka_id;
        int urun_id=0;
        //******

        private void FrmMarkalar_Load(object sender, EventArgs e)
        {
            gridControlMarka.DataSource = markamng.markaListesi();
        }
        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            string kaydet = markamng.markaKaydet(txt_markaAdi.Text, urun_id);
            MessageBox.Show(kaydet);
            gridControlMarka.DataSource = markamng.markaListesi();
        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            string guncelle = markamng.markaGuncelle(marka_id,txt_markaAdi.Text, urun_id);
            MessageBox.Show(guncelle);
            gridControlMarka.DataSource = markamng.markaListesi();
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            string sil = markamng.markaSil(marka_id);
            MessageBox.Show(sil);
            gridControlMarka.DataSource = markamng.markaListesi();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            marka_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("MarkalarID").ToString());
            txt_markaAdi.Text = gridView1.GetFocusedRowCellValue("MarkaAdi").ToString();
            //urun_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("UrunID").ToString());
        }

    }
}
