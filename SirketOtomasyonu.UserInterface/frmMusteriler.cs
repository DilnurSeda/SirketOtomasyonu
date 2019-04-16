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
using SirketOtomasyonu.BLL.Musteriler;

namespace SirketOtomasyonu.UserInterface
{
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }
        //***********************************************
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();
        MusterilerManager musteri = new MusterilerManager();
        //************************************************
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string sonuc = musteri.Kaydet(mskTc.Text, txtAdi.Text, txtSoyadi.Text, mskTel1.Text, mskTel2.Text, txtmail.Text, txtVergiDairesi.Text, cmbil.Text, cmbilce.Text, cmbSirketadi.Text, txtAdres.Text);

            MessageBox.Show(sonuc);

            gridControl1.DataSource = musteri.musteriListesi();
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.Musteriler.ToList();
            cmbil.DisplayMember = "SehirAdi";
            cmbil.ValueMember = "illerID";
            cmbil.SelectedIndex = -1;
            cmbilce.Enabled = false;
            cmbil.DataSource = db.iller.OrderBy(k=>k.SehirAdi).ToList();
            cmbil.SelectedIndex = -1;
            cmbilce.SelectedIndex = -1;

            cmbSirketadi.DisplayMember = "SirketAdi";
            cmbSirketadi.ValueMember = "SirketlerID";
            cmbSirketadi.DataSource = db.Sirketler.OrderBy(f => f.SirketAdi).ToList();
            cmbSirketadi.SelectedIndex = -1;


        }
        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilce.Enabled = true;
            if (cmbil.SelectedIndex!=-1)
            {
                cmbilce.Text = "";
                cmbilce.DisplayMember = "ilceAdi";
                cmbilce.ValueMember = "ilcelerID";
                cmbilce.DataSource = db.ilceler.Where(k => k.ilID == (int)cmbil.SelectedValue).ToList();

            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //sillll
            string silmusteri = musteri.Sil(musteriID);            
            MessageBox.Show(silmusteri);
            gridControl1.DataSource = musteri.musteriListesi();
        }

        int musteriID;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            musteriID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("MusterilerID").ToString());
            mskTc.Text = gridView1.GetFocusedRowCellValue("TC").ToString();
            txtAdi.Text = gridView1.GetFocusedRowCellValue("MusteriAdi").ToString();
            txtSoyadi.Text = gridView1.GetFocusedRowCellValue("MusteriSoyadi").ToString();
            mskTel1.Text = gridView1.GetFocusedRowCellValue("Telefon1").ToString();
            mskTel2.Text = gridView1.GetFocusedRowCellValue("Telefon2").ToString();
            txtmail.Text = gridView1.GetFocusedRowCellValue("Email").ToString();
            txtVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VergiDairesi").ToString();
            cmbil.Text = gridView1.GetFocusedRowCellValue("il").ToString();
            cmbilce.Text = gridView1.GetFocusedRowCellValue("ilce").ToString();
            txtAdres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
            cmbSirketadi.Text = gridView1.GetFocusedRowCellValue("SirketAdi").ToString();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //güncelleee
            string guncelle = musteri.Guncelle(musteriID,mskTc.Text,txtAdi.Text,txtSoyadi.Text,mskTel1.Text,mskTel2.Text,txtmail.Text,txtVergiDairesi.Text,cmbil.Text,cmbilce.Text,cmbSirketadi.Text,txtAdres.Text);
            gridControl1.DataSource = musteri.musteriListesi();
            MessageBox.Show(guncelle);
        }
    }
}
