using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiketOtomasyonu.DLL;
using System.Windows.Forms;

namespace SirketOtomasyonu.BLL.Bankaislemleri
{
    public class BankalarManager : IBankalarInterface
    {
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();
        public string BankaGuncelle(int bankaId, string bankaAdi, string subeAdi, string aciklama)
        {
            try
            {
                var guncelle = db.Bankalar.Where(k => k.BankalarID == bankaId).FirstOrDefault();

                guncelle.BankaAdi = bankaAdi;
                guncelle.SubeAdi = subeAdi;
                guncelle.Aciklama = aciklama;

                int guncelleSonuc = db.SaveChanges();
                if (guncelleSonuc > 0)
                {
                    return "Guncelleme başarılı";
                }
                return "Guncelleme başarısız";
            }
            catch (Exception)
            {

                return "Hata oluştu";
            }
        }

        public string BankaKaydet(string bankaAdi, string subeAdi, string aciklama)
        {
            try
            {
                Bankalar ekle = new Bankalar();
                ekle.BankaAdi = bankaAdi;
                ekle.SubeAdi = subeAdi;
                ekle.Aciklama = aciklama;

                db.Bankalar.Add(ekle);

                int sonucKaydet = db.SaveChanges();
                if (sonucKaydet > 0)
                {
                    return "Kayıt başarılı";

                }
                return "Kayıt başarısız";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }

        }

        public string BankaSil(int bankaId)
        {
            try
            {
                var sil = db.Bankalar.Where(h => h.BankalarID == bankaId).FirstOrDefault();
                DialogResult onay = MessageBox.Show(sil.BankaAdi + " adlı bankayı silmek istediğinize emin misiniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
                if (onay == DialogResult.OK)
                {
                    db.Bankalar.Remove(sil);
                    int silSonuc = db.SaveChanges();
                    if (silSonuc > 0)
                    {
                        return "Silme işlemi başarılı";
                    }
                   
                }
                return "Silme işlemi başarısız";
            }
            catch (Exception)
            {

                return "Hata oluştu";
            }
        }
    }
}
