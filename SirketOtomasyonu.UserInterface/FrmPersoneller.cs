using SirketOtomasyonu.BLL.ililceSecimi;
using SirketOtomasyonu.BLL.Personelislemleri;
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
    public partial class FrmPersoneller : Form
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }
        PersonelManager persman = new PersonelManager();
        ililceGetir getirSehir = new ililceGetir();

        string mesajPersonel;
        //****************
        int personel_id;
        int personelAyrinti_id;
        //********************

        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            persman.PersonelListesi();
            gridControlPerBilgi.DataSource = persman.PersonelListesi();
            comboBoxil.DataSource = getirSehir.illerListesi(comboBoxil);
            //*********************************************

        }

        #region Personeller
        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            mesajPersonel = persman.PersonelKaydet(mtb_TC.Text, txt_PersonelAdi.Text, txt_PersonelsoyAdi.Text, mtb_Telefon.Text, txt_Email.Text, comboBoxil.Text, comboBoxilce.Text, txt_Adres.Text);
            gridControlPerBilgi.DataSource = persman.PersonelListesi();
            MessageBox.Show(mesajPersonel);
        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            personel_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("PersonellerID").ToString());
            mtb_TC.Text = gridView1.GetFocusedRowCellValue("TC").ToString();
            txt_PersonelAdi.Text = gridView1.GetFocusedRowCellValue("PersonelAdi").ToString();
            txt_PersonelsoyAdi.Text = gridView1.GetFocusedRowCellValue("PersonelSoyadi").ToString();
            mtb_Telefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            txt_Email.Text = gridView1.GetFocusedRowCellValue("Email").ToString();
            comboBoxil.Text = gridView1.GetFocusedRowCellValue("il").ToString();
            comboBoxilce.Text = gridView1.GetFocusedRowCellValue("ilce").ToString();
            txt_Adres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
        }

        private void comboBoxil_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxilce.DataSource = getirSehir.ilcelerListesi(comboBoxil, comboBoxilce);
        } 
        #endregion

    }
}
