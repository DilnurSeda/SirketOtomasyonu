using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiketOtomasyonu.DLL;

namespace SirketOtomasyonu.BLL.GelirSatisislemleri
{
    public class GelirSatisManager : IGelirSatis
    {
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();

        #region Gelirler
        public string GelirGuncelle(int gelirlerid, DateTime gelirtarihi, decimal toplamtutar)
        {
            try
            {
                var guncelleKaydet = db.Gelirler.Where(d => d.GelirlerID == gelirlerid).FirstOrDefault();
                guncelleKaydet.GelirTarihi = gelirtarihi;
                guncelleKaydet.ToplamTutar = toplamtutar;

                int sonucGuncelle = db.SaveChanges();
                if (sonucGuncelle > 0)
                {
                    return "Güncelleme Başarılı";
                }
                return "Güncellenemedi";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }
        }

        public string GelirKaydet(DateTime gelirtarihi, decimal toplamtutar)
        {
            try
            {
                Gelirler gelirKaydet = new Gelirler();
                gelirKaydet.GelirTarihi = gelirtarihi;
                gelirKaydet.ToplamTutar = toplamtutar;

                db.Gelirler.Add(gelirKaydet);
                int sonucKaydet = db.SaveChanges();
                if (sonucKaydet > 0)
                {
                    return "Kayıt edildi";
                }
                return ".kayıt yapılamadı!!";
            }
            catch (Exception)
            {

                return "Hata oluştu";
            }
        }

        public List<Gelirler> GelirListesiAylik(DateTime aytarihi)
        {
            //return db.Gelirler.Where(k => k.GelirTarihi == aytarihi).FirstOrDefault();
            return db.Gelirler.ToList(); ;
        }

        public List<Gelirler> GelirListesi()
        {
            return db.Gelirler.ToList();
        }

        public string GelirSil(int gelirlerid)
        {
            var sil = db.Gelirler.Where(k => k.GelirlerID == gelirlerid).FirstOrDefault();

            DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
            if (onay == DialogResult.OK)
            {
                db.Gelirler.Remove(sil);
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Silindi";
                }

            }
            return "Silme işlemi başarısız";
        }
        #endregion

        #region Satışlar
        public string SatisGuncelle(int satislarid, int urunid, DateTime islemtarihi, TimeSpan islemsaati, int musteriid, decimal fiyat, int adet, decimal indirimorani, string indirimaciklamasi, int kullaniciid, int gelirid)
        {
            try
            {
                var guncelle = db.Satislar.Where(k => k.SatislarID == satislarid).FirstOrDefault();
                guncelle.UrunID = urunid;
                guncelle.islemTarihi = islemtarihi;
                guncelle.islemSaat = islemsaati;
                guncelle.MusteriID = musteriid;
                guncelle.Tutar = fiyat;
                guncelle.Adet = adet;
                guncelle.indirimOrani = indirimorani;
                guncelle.indirimAciklamasi = indirimaciklamasi;
                guncelle.KullaniciID = kullaniciid;
                guncelle.GelirID = gelirid;
                

                int sonucGuncelle = db.SaveChanges();
                if (sonucGuncelle > 0)
                {
                    return "Güncelleme Başarılı";
                }

                return "Güncelleme Başarısız";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }
        }

        private void ToplamGelirHesapla(int gelir_id,decimal satis_tutar)
        {
            var guncelleGelir = db.Gelirler.Where(k => k.GelirlerID == gelir_id).FirstOrDefault();
            if (guncelleGelir !=null)
            {
                decimal yeni_toplamTutar = (decimal)guncelleGelir.ToplamTutar + satis_tutar;
                guncelleGelir.ToplamTutar = yeni_toplamTutar;
                db.SaveChanges();
            }
        }
        public string SatisKaydet(int urunid, DateTime islemtarihi, TimeSpan islemsaati, int musteriid, decimal fiyat, int adet, decimal indirimorani, string indirimaciklamasi, int kullaniciid, int gelirid)
        {
            try
            {
                Satislar satisKaydet = new Satislar();
                satisKaydet.UrunID = urunid;
                satisKaydet.islemTarihi = islemtarihi;
                satisKaydet.islemSaat = islemsaati;
                satisKaydet.MusteriID = musteriid;
                satisKaydet.Tutar = fiyat;
                satisKaydet.Adet = adet;
                satisKaydet.indirimOrani = indirimorani;
                satisKaydet.indirimAciklamasi = indirimaciklamasi;
                satisKaydet.KullaniciID = kullaniciid;
                satisKaydet.GelirID = gelirid;

                db.Satislar.Add(satisKaydet);
                int sonucKaydet = db.SaveChanges();
                if (sonucKaydet > 0)
                {
                    //*************************************
                    decimal toplam_Satis = (fiyat - fiyat * indirimorani) * adet;
                    ToplamGelirHesapla(gelirid, toplam_Satis);
                    //*************************************
                    return "Satış oluşturuldu.";
                }
                return "Satış Kaydı ouşturulamadı.!!";
            }
            catch (Exception)
            {

                return "Hata oluştu";
            }
        }

        public List<Satislar> SatisListesi(int gelirid)
        {
            return db.Satislar.Where(s => s.GelirID == gelirid).ToList();
        }

        public string SatisSil(int satislarid)
        {
            var sil = db.Satislar.Where(k => k.SatislarID == satislarid).FirstOrDefault();

            DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
            if (onay == DialogResult.OK)
            {
                db.Satislar.Remove(sil);
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Silindi";
                }

            }
            return "Silme işlemi başarısız";
        } 
        #endregion

        public void UrunListesi(ComboBox cmbUrunler)
        {

        }
    }
}
