using SiketOtomasyonu.DLL;
using SirketOtomasyonu.BLL.Bankaislemleri;
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
    public partial class FrmBankalar : Form
    {
        public FrmBankalar()
        {
            InitializeComponent();
        }
        BankalarManager banka = new BankalarManager();
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();
        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            string sonucKaydet = banka.BankaKaydet(txt_Aciklama.Text,txt_SubeAdi.Text,txt_BankaAdi.Text);

            MessageBox.Show(sonucKaydet);
            gridControl1.DataSource = db.Bankalar.ToList();
        }

        private void FrmBankalar_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.Bankalar.ToList();
        }
        int banka_Id;

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            string sonucGuncelle = banka.BankaGuncelle(banka_Id, txt_BankaAdi.Text, txt_SubeAdi.Text, txt_Aciklama.Text);            
            MessageBox.Show(sonucGuncelle);
            gridControl1.DataSource = db.Bankalar.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            banka_Id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("BankalarID").ToString());
            txt_BankaAdi.Text = gridView1.GetFocusedRowCellValue("BankaAdi").ToString();
            txt_SubeAdi.Text = gridView1.GetFocusedRowCellValue("SubeAdi").ToString();
            txt_Aciklama.Text = gridView1.GetFocusedRowCellValue("Aciklama").ToString();
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            string bankaSil = banka.BankaSil(banka_Id);
            gridControl1.DataSource = db.Bankalar.ToList();
        }
    }
}
