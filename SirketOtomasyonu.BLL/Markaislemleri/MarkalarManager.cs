using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiketOtomasyonu.DLL;
using System.Windows.Forms;

namespace SirketOtomasyonu.BLL.Markaislemleri
{
    public class MarkalarManager : IMarkaInterface
    {
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();

        public string markaGuncelle(int markalarid, string markaAdi, int urunid)
        {
            try
            {
                var guncelle = db.Markalar.Where(k => k.MarkalarID == markalarid).FirstOrDefault();

                if (!string.IsNullOrWhiteSpace(markaAdi))
                {
                    guncelle.MarkaAdi = markaAdi;

                    int sonucGuncelle = db.SaveChanges();
                    if (sonucGuncelle > 0)
                    {
                        return "Marka adi guncellendi";
                    }
                }
                return "Marka adı guncellenemedi";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }

        }

        public string markaKaydet(string markaAdi, int urunid)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(markaAdi))
                {
                    Markalar ekle = new Markalar();
                    ekle.MarkaAdi = markaAdi;
                    ekle.UrunID = urunid;

                    db.Markalar.Add(ekle);

                    int sonucKaydet = db.SaveChanges();
                    if (sonucKaydet > 0)
                    {
                        return "Marka Başarıyla eklendi.";
                    }
                }
                return "Kayıt yapılamadı!";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }


        }

        public List<Markalar> markaListesi()
        {
            return db.Markalar.ToList();
        }

        public string markaSil(int markalarid)
        {
            try
            {
                var markaSil = db.Markalar.Where(s => s.MarkalarID == markalarid).FirstOrDefault();

                DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);

                if (onay == DialogResult.OK)
                {
                    db.Markalar.Remove(markaSil);

                    int sonucSil = db.SaveChanges();
                    if (sonucSil > 0)
                    {
                        return "Marka adı silindi.";
                    }
                    
                }
                return "Silme işlemi başarısız";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }
        }
    }
}
