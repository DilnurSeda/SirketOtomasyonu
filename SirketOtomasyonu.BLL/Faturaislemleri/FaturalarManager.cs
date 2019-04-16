
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiketOtomasyonu.DLL;

namespace SirketOtomasyonu.BLL.Faturalar
{
    public class FaturalarManager : IFaturaInterface
    {

        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();

        #region FaturaDetayIslemleri
        public string FaturaDetayGuncelle(int faturadetaylarid, int urunid, short miktar, decimal fiyat, decimal tutar, int faturaid)
        {
            try
            {
                var guncelle = db.FaturaDetay.Where(k => k.FaturaDetaylarID == faturadetaylarid).FirstOrDefault();
                guncelle.UrunID = urunid;
                guncelle.Miktar = miktar;
                guncelle.Fiyat = fiyat;
                guncelle.Tutar = tutar;

                int sonucGuncelle = db.SaveChanges();
                if (sonucGuncelle > 0)
                {
                    return "Fatura detayları güncellendi";
                }
                return "Güncelleme yapılmadı";
            }
            catch (Exception)
            {

                return "HAta oluştu";
            }

        }

        public string FaturaDetayKaydet(int urunid, short miktar, decimal fiyat, decimal tutar, int faturaid)
        {
            try
            {
                FaturaDetay fatdetay = new FaturaDetay();
                fatdetay.UrunID = urunid;
                fatdetay.Miktar = miktar;
                fatdetay.Fiyat = fiyat;
                fatdetay.Tutar = tutar;
                fatdetay.FaturaID = faturaid;

                db.FaturaDetay.Add(fatdetay);
                int sonucKaydet = db.SaveChanges();
                if (sonucKaydet > 0)
                {
                    return "Kayıt Başarılı";
                }
                return "Kayıt başarısız";
            }
            catch (Exception)
            {

                return "Hata Oluştu!";
            }
        }

        public List<FaturaDetay> FaturaDetayListesi(int faturaid)
        {
            return db.FaturaDetay.Where(f => f.FaturaID == faturaid).ToList();
        }

        public string FaturaDetaySil(int faturadetaylarid)
        {
            var silfaturadetay = db.FaturaDetay.Where(f => f.FaturaDetaylarID == faturadetaylarid).FirstOrDefault();
            DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
            if (onay==DialogResult.OK)
            {
                db.FaturaDetay.Remove(silfaturadetay);
                int silSonuc = db.SaveChanges();
                if (silSonuc>0)
                {
                    return "Silme işlemi gerçekleşti";
                }
                              
            }
            return "Silme gerçekleşmedi";

        }

        #endregion
        //****************************************************
        #region FaturaIslemleri
        public string FaturaGuncelle(int faturaId, string seriNo, string siraNo, string tarih, string saat, string vergiDaireleri, string alici, string teslimeden, string teslimAlan)
        {
            try
            {
                var guncelle = db.Faturalar.Where(k => k.FaturalarID == faturaId).FirstOrDefault();
                guncelle.Seri = seriNo;
                guncelle.SiraNo = siraNo;
                guncelle.Tarih = Convert.ToDateTime(tarih);
                guncelle.Saat = TimeSpan.Parse(saat);
                guncelle.VergiDaileri = vergiDaireleri;
                guncelle.Alici = alici;
                guncelle.TeslimEden = teslimeden;
                guncelle.TeslimAlan = teslimAlan;

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

        public string FaturaKaydet(string seriNo, string siraNo, string tarih, string saat, string vergiDaireleri, string alici, string teslimeden, string teslimAlan)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(siraNo) && !string.IsNullOrWhiteSpace(seriNo))
                {
                    SiketOtomasyonu.DLL.Faturalar ekle = new SiketOtomasyonu.DLL.Faturalar();
                    ekle.Seri = seriNo;
                    ekle.SiraNo = siraNo;
                    ekle.Tarih = Convert.ToDateTime(tarih.ToString());
                    ekle.Saat = TimeSpan.Parse(saat);
                    ekle.VergiDaileri = vergiDaireleri;
                    ekle.Alici = alici;
                    ekle.TeslimEden = teslimeden;
                    ekle.TeslimAlan = teslimAlan;

                    db.Faturalar.Add(ekle);

                    int sonucKaydet = db.SaveChanges();
                    if (sonucKaydet > 0)
                    {
                        return "Ekleme başarılı";
                    }
                }
                return "ekleme başarısız";
            }
            catch (Exception)
            {

                return "Hata oluştu";
            }
        }

        public List<SiketOtomasyonu.DLL.Faturalar> FaturaListesi()
        {
            return db.Faturalar.ToList();
        }

        public string FaturaSil(int faturaId)
        {
            var sil = db.Faturalar.Where(k => k.FaturalarID == faturaId).FirstOrDefault();

            DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
            if (onay == DialogResult.OK)
            {
                db.Faturalar.Remove(sil);
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Silindi";
                }

            }
            return "Silme işlemi başarısız";
        }

        

        #endregion
    }
}
