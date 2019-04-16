using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiketOtomasyonu.DLL;

namespace SirketOtomasyonu.BLL.Giderislemleri
{
    public class GiderlerManager : IGiderInterface
    {
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();

        public string GiderGuncelle(int giderlerid, string giderturuadi, DateTime gidertarihi, string toplamtutar, string aciklama)
        {
            var giderGuncelle = db.Giderler.Where(g => g.GiderlerID == giderlerid).FirstOrDefault();

            giderGuncelle.GiderTuruAdi = giderturuadi;
            giderGuncelle.Tarihi = gidertarihi;
            giderGuncelle.GiderTutari = Convert.ToDecimal(toplamtutar);
            giderGuncelle.Aciklama = aciklama;

            int sonucGuncelle = db.SaveChanges();
            if (sonucGuncelle>0)
            {
                return "Guncelleme Başarılı";
            }
            return "Güncellenemedi";
        }

        public string GiderKaydet(string giderturuadi, DateTime gidertarihi, string toplamtutar, string aciklama)
        {
            Giderler giderEkle = new Giderler();
            giderEkle.GiderTuruAdi = giderturuadi;
            giderEkle.Tarihi = gidertarihi;
            giderEkle.GiderTutari = Convert.ToDecimal(toplamtutar);
            giderEkle.Aciklama = aciklama;

            db.Giderler.Add(giderEkle);

            int sonucKaydet = db.SaveChanges();
            if (sonucKaydet>0)
            {
                return "Kayıt Başarılı!";
            }
            return "Kayıt yapılamadı.";
        }

        public List<Giderler> GiderListesi()
        {
            return db.Giderler.ToList();
        }

        public string GiderSil(int giderlerid)
        {
            try
            {
                var sil = db.Giderler.Where(p => p.GiderlerID == giderlerid).FirstOrDefault();

                DialogResult onay = MessageBox.Show("Silmek istediğinize emin misniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
                if (onay == DialogResult.OK)
                {
                    db.Giderler.Remove(sil);
                    int silSonuc = db.SaveChanges();
                    if (silSonuc > 0)
                    {
                        return sil.GiderlerID + " id ye ait gider bilgileri silindi";
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
