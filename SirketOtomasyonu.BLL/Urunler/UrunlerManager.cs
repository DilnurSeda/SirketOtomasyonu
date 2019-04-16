using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiketOtomasyonu.DLL;
using System.Windows.Forms;

namespace SirketOtomasyonu.BLL
{
    public class UrunlerManager : IUrunInterface
    {
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();
        //******************************************************
        public string urunGuncelle(int urun_id, string adi, string marka, string model, string uretimYili, short stok, decimal alisFiyati, decimal satisFiyati, string detay)
        {
            var guncelle = db.Urunler.Where(p => p.UrunlerID == urun_id).FirstOrDefault();

            if (!string.IsNullOrWhiteSpace(adi) && alisFiyati > 0)
            {
                try
                {
                    guncelle.UrunAdi = adi;
                    guncelle.UrunMarkasi = marka;
                    guncelle.UrunModel = model;
                    guncelle.UrunUretimYili = uretimYili;
                    guncelle.Stok = stok;
                    guncelle.AlisFiyati = alisFiyati;
                    guncelle.SatisFiyati = satisFiyati;
                    guncelle.Detay = detay;


                    int guncelleSonuc = db.SaveChanges();

                    if (guncelleSonuc>0)
                    {
                        return "Ürün Güncelleme Başarılı";
                    }

                    return "Ürün Güncelleme Başarısız";


                }
                catch (Exception)
                {

                    return "Hata Oluştu";
                }

            }
            return "Zorunlu Alanları Doldurun";
        }

        public string urunKaydet(string adi, string marka, string model, string uretimYili, short stok, decimal alisFiyati, decimal satisFiyati, string detay)
        {
            Urunler ekle = new Urunler();

            if (!string.IsNullOrWhiteSpace(adi) && alisFiyati > 0)
            {
                try
                {
                    ekle.UrunAdi = adi;
                    ekle.UrunMarkasi = marka;
                    ekle.UrunModel = model;
                    ekle.UrunUretimYili = uretimYili;
                    ekle.Stok = stok;
                    ekle.AlisFiyati = alisFiyati;
                    ekle.SatisFiyati = satisFiyati;
                    ekle.Detay = detay;

                    db.Urunler.Add(ekle);

                    int sonuc = db.SaveChanges();

                    if (sonuc > 0)
                    {
                        return "Ürün Ekleme Başarılı";
                    }
                    return "Ürün Ekleme Başarısız";
                }
                catch (Exception)
                {
                    //throw;
                    return "Hata Okuştu";
                }
            }
            else
            {
                return "Zorunlu Alanları Doldurun";
            }
        }

        public string UrunSil(int urunID)
        {
            try
            {
                var sil = db.Urunler.Where(j => j.UrunlerID == urunID).FirstOrDefault();
                DialogResult onay = MessageBox.Show(sil.UrunAdi + " adlı ürünü silmek istediğinize emin msiniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
                if (onay == DialogResult.OK)
                {
                    db.Urunler.Remove(sil);
                    int silSonuc = db.SaveChanges();
                    if (silSonuc > 0)
                    {
                        return sil.UrunAdi + "adlı ürünün sildiniz";
                    }                 
                }
                return "Silme başarısız";
            }
            catch (Exception)
            {

                return "Bir hata oluştu tekrar deneyiniz.";
            }
        }

        public List<Urunler> UrunListele()
        {
            return db.Urunler.ToList();
        }
    }
}
