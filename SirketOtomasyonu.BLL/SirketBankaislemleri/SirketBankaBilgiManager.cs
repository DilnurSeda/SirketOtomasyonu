using SiketOtomasyonu.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirketOtomasyonu.BLL.SirketBankaislemleri
{
    public class SirketBankaBilgiManager :ISirketBankaInterface
    {
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();

        public string bankaBilgileriKaydet(int sirketID, int bankaID, string iban, string hesapNo, string bankayetkiliAdSoyad, string hesapTuru)
        {

            SirketBankaBilgileri ekle = new SirketBankaBilgileri();
            ekle.SirketID = sirketID;
            ekle.BankaID = bankaID;
            ekle.Iban = iban;
            ekle.HesapNo = hesapNo;
            ekle.BankaYetkiliAdiSoyadi = bankayetkiliAdSoyad;
            ekle.HesapTuru = hesapTuru;

            db.SirketBankaBilgileri.Add(ekle);
            int sonucKaydet = db.SaveChanges();
            if (sonucKaydet > 0)
            {
                return "Kayıt BAŞARILI!";
            }
            return "KAYIT BAŞARISIZ!";

        }
        public string bankaAdi(int bankaID)
        {
            var bankAdi = db.Bankalar.Where(k => k.BankalarID == bankaID).FirstOrDefault();
            return bankAdi.BankaAdi;
        }
        public string bankaBilgileriGuncelle(int sirketbankabil_ID,int sirketID, int bankaID, string iban, string hesapNo, string bankayetkiliAdSoyad, string hesapTuru)
        {
            var guncelle = db.SirketBankaBilgileri.Where(k => k.SirketBankaBilgileriID==sirketbankabil_ID).FirstOrDefault();

            guncelle.SirketID = sirketID;
            guncelle.BankaID = bankaID;
            guncelle.Iban = iban;
            guncelle.HesapNo = hesapNo;
            guncelle.BankaYetkiliAdiSoyadi = bankayetkiliAdSoyad;
            guncelle.HesapTuru = hesapTuru;

            int sonucGunc = db.SaveChanges();
            if (sonucGunc>0)
            {
                return "GÜNCELLEME BAŞARILI";
            }
            return "GÜNCELLEME BAŞARISIZ";
        }
        public string bankaBilgileriSil(int sirketbankabil_ID)
        {
            try
            {
                var sil = db.SirketBankaBilgileri.Where(p => p.SirketBankaBilgileriID == sirketbankabil_ID).FirstOrDefault();

                DialogResult onay = MessageBox.Show("Silmek istediğinize emin misniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
                if (onay == DialogResult.OK)
                {
                    db.SirketBankaBilgileri.Remove(sil);
                    int silSonuc = db.SaveChanges();
                    if (silSonuc > 0)
                    {
                        return sil.SirketBankaBilgileriID + " id ye sahip şirketin banka bilgileri silindi";
                    }
                }
                return "silme başarısız";
            }
            catch (Exception)
            {

                return "Bir hata oluştu tekrar deneyiniz.";
            }
        }

    }
}
