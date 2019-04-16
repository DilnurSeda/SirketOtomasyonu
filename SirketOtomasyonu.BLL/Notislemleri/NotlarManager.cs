using SiketOtomasyonu.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirketOtomasyonu.BLL.Notislemleri
{
    public class NotlarManager : INotlarInterface
    {

        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();
        Kullanicilar kullanici = new Kullanicilar();

        public string notGuncelle(int notlarid, DateTime nottarihi, TimeSpan notsaati, string notbaslik, string notdetay, string notOlusturan)
        {
            try
            {
                var guncelle = db.Notlar.Where(k => k.NotlarID == notlarid).FirstOrDefault();
                if (!string.IsNullOrWhiteSpace(notbaslik) && !string.IsNullOrWhiteSpace(notdetay))
                {
                    guncelle.NotlarID = notlarid;
                    guncelle.NotTarihi = nottarihi;
                    guncelle.NotSaati = notsaati;
                    guncelle.NotBaslik = notbaslik;
                    guncelle.NotDetay = notdetay;
                    guncelle.NotuOlusturan = notOlusturan;

                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        return "Not güncellendi";
                    }
                }
                return "Güncelleme başarısız.";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }
        }

        public string notKaydet(DateTime nottarihi, TimeSpan notsaati, string notbaslik, string notdetay, string notOlusturan)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(notbaslik) && !string.IsNullOrWhiteSpace(notdetay))
                {
                    Notlar ekle = new Notlar();
                    ekle.NotTarihi = nottarihi;
                    ekle.NotSaati = notsaati;
                    ekle.NotBaslik = notbaslik;
                    ekle.NotDetay = notdetay;
                    ekle.NotuOlusturan = notOlusturan;

                    db.Notlar.Add(ekle);

                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        return "Not eklendi";
                    }
                }
                return "Ekleme başarısız.";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }
        }

        public List<Notlar> notListesi(string notOlusturan)
        {
            return db.Notlar.ToList();
        }

        public string notSil(int notlarid)
        {
            var sil = db.Notlar.Where(k => k.NotlarID == notlarid).FirstOrDefault();

            DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
            if (onay == DialogResult.OK)
            {
                db.Notlar.Remove(sil);
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
