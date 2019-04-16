using SiketOtomasyonu.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirketOtomasyonu.BLL.Sirketislemleri
{
    public class SirketlerManager : ISirketInterface
    {
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();
        public string sirketGuncelle(int sirket_ID, string sirketAdi, string yetkiliGorevi, string yetkiliAdSoyad, string tel1, string tel2, string email, string il, string ilce, string vergiDairesi, string adres)
        {
            try
            {
                var guncelle = db.Sirketler.Where(k => k.SirketlerID == sirket_ID).FirstOrDefault();

                if (!string.IsNullOrWhiteSpace(sirketAdi))
                {
                    guncelle.SirketAdi = sirketAdi;
                    guncelle.YetkiliGorevi = yetkiliGorevi;
                    guncelle.YetkiliAdiSoyadi = yetkiliAdSoyad;
                    guncelle.SirketTelefon1 = tel1;
                    guncelle.SirketTelefon2 = tel2;
                    guncelle.EMail = email;
                    guncelle.il = il;
                    guncelle.ilce = ilce;
                    guncelle.VergiDairesi = vergiDairesi;
                    guncelle.Adres = adres;

                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        return "Guncelleme Başarılı";
                    }
                    
                }
                return "Güncelleme Başarısız";
            }
            catch (Exception)
            {

                return "HATA OLUŞTU!";
            }
           
        }

        public string sirketKaydet(string sirketAdi, string yetkiliGorevi, string yetkiliAdSoyad, string tel1, string tel2, string email, string il, string ilce, string vergiDairesi, string adres)
        {
            try
            {
                Sirketler ekle = new Sirketler();
                ekle.SirketAdi = sirketAdi;
                ekle.YetkiliGorevi = yetkiliGorevi;
                ekle.YetkiliAdiSoyadi = yetkiliAdSoyad;
                ekle.SirketTelefon1 = tel1;
                ekle.SirketTelefon2 = tel2;
                ekle.EMail = email;
                ekle.il = il;
                ekle.ilce = ilce;
                ekle.VergiDairesi = vergiDairesi;
                ekle.Adres = adres;

                db.Sirketler.Add(ekle);

                int sonucKaydet = db.SaveChanges();
                if (sonucKaydet > 0)
                {
                    return "Şirket ekleme başarılı!";
                }
                return "Şirket ekleme başarısız";
            }
            catch (Exception)
            {

                return "Hata Oluştu!";
            }
        }

        public string sirketSil(int sirket_ID)
        {
            try
            {
                var sil = db.Sirketler.Where(p => p.SirketlerID == sirket_ID).FirstOrDefault();

                DialogResult onay = MessageBox.Show("Sirketi silmek istediğinize emin misiniz?", "Silme Onay Penceresi", MessageBoxButtons.OKCancel);

                if (onay == DialogResult.OK)
                {
                    db.Sirketler.Remove(sil);
                    int silSonuc = db.SaveChanges();
                    if (silSonuc > 0)
                    {
                        return "Sirket Silindi!";
                    }
                }
                return "Silmeişlemi Başarısız!";
            }
            catch (Exception)
            {

                return "Hata oluştu";
            }

        }
    }
}
