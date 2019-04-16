using SiketOtomasyonu.DLL;
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
    public partial class Frm_PersonelDetay : Form
    {
        public Frm_PersonelDetay()
        {
            InitializeComponent();
        }
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();
        PersonelManager persman = new PersonelManager();
        ililceGetir getirSehir = new ililceGetir();

        string mesajPersonel;
        //****************
        int personel_id;
        int personelAyrinti_id;
        int personelizinleriid;
        int personelmesaileriid;
        int personelmaasbilgisiid;

        private void Frm_PersonelDetay_Load(object sender, EventArgs e)
        {
            gridControlPerAyrinti.DataSource = persman.PersonelAyrintiListesi(personel_id);
            gridControlPerIzin.DataSource = persman.PersonelIzinleriListesi(personelizinleriid);
            gridControlPermesai.DataSource = persman.PersonelMesaileriListesi(personelmesaileriid);
            gridControlPerMaas.DataSource = persman.PersonelMaasBilgiListesi(personelmaasbilgisiid, personel_id);
            date_cikisTarihi.Visible = false;
            
        }

        #region Personel Ayrıntıları
        private void toolStripAyrintiKaydet_Click(object sender, EventArgs e)
        {
            if (date_cikisTarihi.Visible)
            {
                mesajPersonel = persman.PersonelAyrintisiKaydet(personelAyrintiEhliyet(), personel_id, date_girisTarihi.Value, date_cikisTarihi.Value, personelAyrintiAktifMi());
            }
            else
            {
                mesajPersonel = persman.PersonelAyrintisiKaydet(personelAyrintiEhliyet(), personel_id, date_girisTarihi.Value, null, personelAyrintiAktifMi());
            }

            gridControlPerAyrinti.DataSource = persman.PersonelAyrintiListesi(personelAyrinti_id);

            MessageBox.Show(mesajPersonel);
        }
        public bool personelAyrintiEhliyet()
        {
            if (comboBoxehliyet.Text == "Var")
            {
                return true;
            }
            if (comboBoxehliyet.Text == "Yok")
            {
                return false;
            }
            return false;
        }
        public bool personelAyrintiAktifMi()
        {
            if (date_cikisTarihi.Text == "")
            {
                labelAktifMi.Text = "AKTİF";
                //return true;
            }
            if (date_cikisTarihi.Text != "")
            {
                labelAktifMi.Text = "PASİF";
                //return true;
            }
            return false;

        }
        private void toolStripAyrintiGuncelle_Click(object sender, EventArgs e)
        {
            if (date_cikisTarihi.Visible)
            {
                mesajPersonel = persman.PersonelAyrintisiGuncelle(personelAyrinti_id, personelAyrintiEhliyet(), personel_id, date_girisTarihi.Value, date_cikisTarihi.Value, personelAyrintiAktifMi());
            }
            else
            {
                mesajPersonel = persman.PersonelAyrintisiGuncelle(personelAyrinti_id, personelAyrintiEhliyet(), personel_id, date_girisTarihi.Value, null, personelAyrintiAktifMi());
            }

            gridControlPerAyrinti.DataSource = persman.PersonelAyrintiListesi(personelAyrinti_id);

            MessageBox.Show(mesajPersonel);
        }

        private void toolStripAyrintiSil_Click(object sender, EventArgs e)
        {
            string sil = persman.PersonelAyrintisiSil(personelAyrinti_id);
            MessageBox.Show(sil);
            gridControlPerAyrinti.DataSource = db.PersonelAyrintisi.ToList();
        }



        private void btnCikisTarihiEkle_Click(object sender, EventArgs e)
        {
            date_cikisTarihi.Visible = true;
            labelCikis.Visible = true;
        }

        private void btnVazgecCikis_Click(object sender, EventArgs e)
        {
            date_cikisTarihi.Visible = false;
            labelCikis.Visible = false;
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                comboBoxehliyet.Text = gridView2.GetFocusedRowCellValue("EhliyetVarmi").ToString();
                personel_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("PersonelID").ToString());
                date_girisTarihi.Value = Convert.ToDateTime(gridView2.GetFocusedRowCellValue("GirisTarihi").ToString());
                date_cikisTarihi.Value = Convert.ToDateTime(gridView2.GetFocusedRowCellValue("CikisTarihi").ToString());               
                labelAktifMi.Text = gridView2.GetFocusedRowCellValue("Aktifmi").ToString();
            }
            catch (Exception)
            {
                date_cikisTarihi = null;
            }
        }

        #endregion

        #region Personel İzinleri
        private void toolStripiziKaydet_Click(object sender, EventArgs e)
        {
            string sonuc = persman.PersonelizinKaydet(date_izinbasTarihi.Value, date_izinBitisTarihi.Value, personel_id, txt_izinaciklamasi.Text, Convert.ToInt32(txt_yillikizin.Text), Convert.ToInt32(txt_kalanizin.Text));
            gridControlPerIzin.DataSource = persman.PersonelIzinleriListesi(personelizinleriid);
            MessageBox.Show(sonuc);
        }
        #endregion

        #region Personel Mesaileri
        private void toolStripmesaikaydet_Click(object sender, EventArgs e)
        {
            string sonuc = persman.PersonelMesaiKaydet(date_mesaiTarihi.Value,Convert.ToDecimal(mtb_mesaisurasi.Text),personelmaasbilgisiid,personel_id,Convert.ToDecimal(mtb_mesaiucreti.Text));
            gridControlPermesai.DataSource = persman.PersonelMesaileriListesi(personelmesaileriid);
            MessageBox.Show(sonuc);
        }

        #endregion

        private void toolStripPermaaskaydet_Click(object sender, EventArgs e)
        {
            string sonuc = persman.PersonelMaasBilgisiKaydet(date_maasBasTarihi.Value,date_maasBitisTarihi.Value,personelAyrinti_id,Convert.ToDecimal(txt_maas.Text));
            gridControlPerMaas.DataSource = persman.PersonelMaasBilgiListesi(personelmaasbilgisiid,personel_id);
            MessageBox.Show(sonuc);
        }
    }
}
