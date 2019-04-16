using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiketOtomasyonu.DLL;
using System.Windows.Forms;

namespace SirketOtomasyonu.BLL.Musteriler
{
    public class MusterilerManager : IMusterilerInterface
    {
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();

        public string Kaydet(string TC, string Adi, string Soyadi, string Tel1, string Tel2, string eMail, string VerigiD, string il, string ilce, string sirketAdi, string adres)
        {
            SiketOtomasyonu.DLL.Musteriler musteri = new SiketOtomasyonu.DLL.Musteriler();

            try
            {
                musteri.TC = TC;
                musteri.MusteriAdi = Adi;
                musteri.MusteriSoyadi = Soyadi;
                musteri.Telefon1 = Tel1;
                musteri.Telefon2 = Tel2;
                musteri.Email = eMail;
                musteri.VergiDairesi = VerigiD;
                musteri.il = il;
                musteri.ilce = ilce;
                musteri.Adres = adres;
                musteri.SirketAdi = sirketAdi;
                db.Musteriler.Add(musteri);

                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Müşteri Ekleme İşlemi Başarılı.";
                }
                return "Müşteri Ekleme İşlemi Başarısız.";


            }
            catch (Exception)
            {
                return "Hata Oluştu";

            }
        }

        public string Guncelle(int musteriID,string TC, string Adi, string Soyadi, string Tel1, string Tel2, string eMail, string VerigiD, string il, string ilce, string sirketAdi, string adres)
        {
            var guncelle = db.Musteriler.Where(k => k.MusterilerID == musteriID).FirstOrDefault();

            if (!string.IsNullOrWhiteSpace(Adi))
            {
                guncelle.TC = TC;
                guncelle.MusteriAdi = Adi;
                guncelle.MusteriSoyadi = Soyadi;
                guncelle.Telefon1 = Tel1;
                guncelle.Telefon2 = Tel2;
                guncelle.Email = eMail;
                guncelle.VergiDairesi = VerigiD;
                guncelle.il = il;
                guncelle.ilce = ilce;
                guncelle.SirketAdi = sirketAdi;
                guncelle.Adres = adres;

                int guncelleSonuc = db.SaveChanges();
                if (guncelleSonuc>0)
                {
                    return "Güncelleme başarılı";
                }
                return "Güncelleme başarısız";
            }
            return "";
        }

        public string Sil(int musteriID)
        {
            try
            {
                var sil = db.Musteriler.Where(p => p.MusterilerID == musteriID).FirstOrDefault();

                DialogResult onay = MessageBox.Show("Silmek istediğinize emin misniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
                if (onay == DialogResult.OK)
                {
                    db.Musteriler.Remove(sil);
                    int silSonuc = db.SaveChanges();
                    if (silSonuc > 0)
                    {
                        return sil.MusteriAdi + " adlı müşteri silindi";
                    }
                }
                return "silme başarısız";
            }
            catch (Exception)
            {

                return "Bir hata oluştu tekrar deneyiniz.";
            }
        }
        
        public List<SiketOtomasyonu.DLL.Musteriler>
            musteriListesi()
        {
            return db.Musteriler.ToList();
        }
    }
}
