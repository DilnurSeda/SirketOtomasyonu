using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiketOtomasyonu.DLL;
using System.Windows.Forms;

namespace SirketOtomasyonu.BLL.Kullaniciislemleri
{
    public class KullanicilarManager : IKullaniciInterface
    {
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();

        public string kullaniciGuncelle(int kullaniciid, string adi, string soyadi, string kullaniciadi, string sifre, int yetkiId)
        {
            try
            {
                var guncelle = db.Kullanicilar.Where(k => k.KullanicilarID == kullaniciid).FirstOrDefault();
                if (!string.IsNullOrWhiteSpace(adi) && !string.IsNullOrWhiteSpace(kullaniciadi) && !string.IsNullOrWhiteSpace(sifre))
                {

                    guncelle.Adi = adi;
                    guncelle.Soyadi = soyadi;
                    guncelle.KullaniciAdi = kullaniciadi;
                    guncelle.Sifresi = sifre;
                    guncelle.YetkiID = yetkiId;
              
                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        return "Kullanıcı guncellendi";
                    }
                }
                return "Kullanıcı guncelleme başarısız";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }
        }

        public string kullaniciKaydet(string adi, string soyadi, string kullaniciadi, string sifre, int yetkiId)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(adi) && !string.IsNullOrWhiteSpace(kullaniciadi) && !string.IsNullOrWhiteSpace(sifre))
                {
                    Kullanicilar ekle = new Kullanicilar();
                    ekle.Adi = adi;
                    ekle.Soyadi = soyadi;
                    ekle.KullaniciAdi = kullaniciadi;
                    ekle.Sifresi = sifre;
                    ekle.YetkiID = yetkiId;

                    db.Kullanicilar.Add(ekle);
                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        return "Kullanıcı eklendi";
                    }
                }
                return "Kullanıcı ekleme başarısız";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }
        }

        public List<Kullanicilar> kullaniciListesi()
        {
            return db.Kullanicilar.ToList();
        }

        public string kullaniciSil(int kullaniciid)
        {
            var sil = db.Kullanicilar.Where(k => k.KullanicilarID == kullaniciid).FirstOrDefault();

            DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
            if (onay == DialogResult.OK)
            {
                db.Kullanicilar.Remove(sil);
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Silindi";
                }

            }
            return "Silme işlemi başarısız";
        }
    }
}
