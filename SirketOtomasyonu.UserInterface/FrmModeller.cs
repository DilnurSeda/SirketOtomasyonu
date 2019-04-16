using SirketOtomasyonu.BLL.Modelislemleri;
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
    public partial class FrmModeller : Form
    {
        public FrmModeller()
        {
            InitializeComponent();
        }
        ModellerManager modelmng = new ModellerManager();
        //*******************
        int modeller_id,urun_id=1, marka_id=2;
        //***********************
        private void FrmModeller_Load(object sender, EventArgs e)
        {
            gridControlModel.DataSource = modelmng.modelListesi();
        }


        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            string sonucKaydet = modelmng.modelKaydet(txt_modelAdi.Text, urun_id, marka_id);
            MessageBox.Show(sonucKaydet);
            gridControlModel.DataSource = modelmng.modelListesi();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            modeller_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ModellerID").ToString());
            txt_modelAdi.Text = gridView1.GetFocusedRowCellValue("ModelAdi").ToString();
            urun_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("UrunID").ToString());
            marka_id= Convert.ToInt32(gridView1.GetFocusedRowCellValue("MarkaID").ToString());
        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            string sonucGuncelle = modelmng.modelGuncelle(modeller_id, txt_modelAdi.Text, urun_id, marka_id);
            MessageBox.Show(sonucGuncelle);
            gridControlModel.DataSource = modelmng.modelListesi();
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            string sonucSil = modelmng.modelSil(modeller_id);
            MessageBox.Show(sonucSil);
            gridControlModel.DataSource = modelmng.modelListesi();
        }

    }
}
