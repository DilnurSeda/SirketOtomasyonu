using SiketOtomasyonu.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirketOtomasyonu.BLL.Personelislemleri
{

    public class PersonelManager:IPersonelInterface
    {
        //*****************************************************
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();

        

        #region Personel Ayrıntısı
        public string PersonelAyrintisiGuncelle(int personelayrintilariid, bool ehliyetvarmi, int personelid, DateTime giristarihi, DateTime? cikistarihi, bool aktifmi)
        {
            var guncelle = db.PersonelAyrintisi.Where(k => k.PersonelAyrintilariID == personelayrintilariid).FirstOrDefault();
            try
            {
                guncelle.PersonelAyrintilariID = personelayrintilariid;
                guncelle.EhliyetVarmi = ehliyetvarmi;
                guncelle.PersonelID = personelid;
                guncelle.GirisTarihi = Convert.ToDateTime(giristarihi);
                guncelle.CikisTarihi = cikistarihi;
                guncelle.Aktifmi = aktifmi;
                db.PersonelAyrintisi.Add(guncelle);

                int sonucGuncelle = db.SaveChanges();
                if (sonucGuncelle > 0)
                {
                    return "Güncelleme işlemi Başarılı!";
                }
                return "Güncelleme Yapılamadı!";
            }
            catch (Exception)
            {

                return "Hata Oluştu!";
            }
        }

        public string PersonelAyrintisiKaydet(bool ehliyetvarmi, int personelid, DateTime giristarihi, DateTime? cikistarihi, bool aktifmi)
        {
            try
            {
                PersonelAyrintisi ekle = new PersonelAyrintisi();
                ekle.EhliyetVarmi = ehliyetvarmi;
                ekle.PersonelID = personelid;
                ekle.GirisTarihi = Convert.ToDateTime(giristarihi);
                ekle.CikisTarihi = cikistarihi;                
                ekle.Aktifmi = aktifmi;
                db.PersonelAyrintisi.Add(ekle);
                 
                int sonucKaydet = db.SaveChanges();
                if (sonucKaydet > 0)
                {
                    return "Kayıt işlemi Başarılı!";
                }
                return "Kayıt Yapılamadı!";
            }
            catch (Exception)
            {

                return "Hata Oluştu!";
            }
        }

        public string PersonelAyrintisiSil(int personelayrintilariid)
        {
            throw new NotImplementedException();
        }

        public List<PersonelAyrintisi> PersonelAyrintiListesi(int personelid)
        {
            return db.PersonelAyrintisi.Where(k => k.PersonelID == personelid).ToList();
        }
        #endregion

        //****************************************************

        #region Personeller
        public string PersonelGuncelle(int personellerid, string tc, string adi, string soyadi, string telefon, string email, string il, string ilce, string adres)
        {
            throw new NotImplementedException();
        }
        public string PersonelKaydet(string tc, string adi, string soyadi, string telefon, string email, string il, string ilce, string adres)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(adi) && !string.IsNullOrWhiteSpace(telefon))
                {
                    Personeller ekle = new Personeller();
                    ekle.TC = tc;
                    ekle.PersonelAdi = adi;
                    ekle.PersonelSoyadi = soyadi;
                    ekle.Telefon = telefon;
                    ekle.Email = email;
                    ekle.il = il;
                    ekle.ilce = ilce;
                    ekle.Adres = adres;

                    db.Personeller.Add(ekle);
                    int sonucKaydet = db.SaveChanges();
                    if (sonucKaydet > 0)
                    {
                        return "Kayıt işlemi Başarılı!";
                    }
                }
                return "Kayıt Yapılamadı!";
            }
            catch (Exception)
            {

                return "Hata Oluştu!";
            }
        }

        public string PersonelSil(int personellerid)
        {
            throw new NotImplementedException();
        }

        public List<Personeller> PersonelListesi()
        {
            return db.Personeller.ToList();
        } 
        #endregion

        //************************************************

        #region Personel İzinleri
        public string PersonelizinGuncelle(int personelizinleriid, DateTime izinbaslangictarihi, DateTime izinbitistarihi, int personelid, string aciklama, int yillikizingunsayisi, int kalanizingunsayisi)
        {
            throw new NotImplementedException();
        }

        public string PersonelizinKaydet(DateTime izinbaslangictarihi, DateTime izinbitistarihi, int personelid, string aciklama, int yillikizingunsayisi, int kalanizingunsayisi)
        {
            try
            {
                Personelizinleri ekle = new Personelizinleri();
                ekle.izinBaslangicTarihi = izinbitistarihi;
                ekle.izinBitisTarihi= izinbaslangictarihi;
                ekle.PersonelID = personelid;
                ekle.izinAciklamasi = aciklama;
                ekle.YillikIzinGunSayisi = yillikizingunsayisi;
                ekle.KalanIzınGunSayisi = kalanizingunsayisi;

                db.Personelizinleri.Add(ekle);

                int sonucKaydet = db.SaveChanges();
                if (sonucKaydet > 0)
                {
                    return "Kayıt işlemi Başarılı!";
                }
                return "Kayıt Yapılamadı!";
            }
            catch (Exception)
            {

                return "Hata Oluştu!";
            }
        }

        public List<Personelizinleri> PersonelIzinleriListesi(int personelid)
        {
            return db.Personelizinleri.ToList();
        }

        public string PersonelizinSil(int personelizinleriid)
        {
            throw new NotImplementedException();
        }
        #endregion

        //**************************************************

        #region Personel Maas Bilgisi
        public string PersonelMaasBilgisiGuncelle(int personelmaasbilgileriid, DateTime maasbaslangictarihi, DateTime maasbitistarihi, int personelayrintisiid, decimal maas)
        {
            throw new NotImplementedException();
        }

        public string PersonelMaasBilgisiKaydet(DateTime maasbaslangictarihi, DateTime maasbitistarihi, int personelayrintisiid, decimal maas)
        {
            try
            {

                PersonelMaasBilgisi ekle = new PersonelMaasBilgisi();
                ekle.MaasBaslangicTarihi = maasbaslangictarihi;
                ekle.MaasBitisTarihi = maasbitistarihi;
                ekle.PersonelAyrintisiID = personelayrintisiid;
                ekle.Maas = maas;

                db.PersonelMaasBilgisi.Add(ekle);
                int sonucKaydet = db.SaveChanges();
                if (sonucKaydet > 0)
                {
                    return "Kayıt işlemi Başarılı!";
                }
                return "Kayıt Yapılamadı!";
            }
            catch (Exception)
            {

                return "Hata Oluştu!";
            }
        }

        public string PersonelMaasBilgisiSil(int personelmaasbilgileriid)
        {
            throw new NotImplementedException();
        }
        public List<PersonelMaasBilgisi> PersonelMaasBilgiListesi(int personelayrintisiid, int personelid)
        {
            return db.PersonelMaasBilgisi.Where(k => k.PersonelAyrintisiID == k.PersonelAyrintisiID).ToList();
        }
        #endregion

        //**************************************************

        #region Personel Mesaileri
        public string PersonelMesaiGuncelle(int personelmesaileriid, DateTime mesaitarihi, decimal mesaisuresi, int personelmaasbilgisiid, int personelid, decimal toplamgunlukmesaiucreti)
        {
            throw new NotImplementedException();
        }

        public string PersonelMesaiKaydet(DateTime mesaitarihi, decimal mesaisuresi, int personelmaasbilgisiid, int personelid, decimal toplamgunlukmesaiucreti)
        {
            try
            {

                PersonelMesaileri ekle = new PersonelMesaileri();
                ekle.MesaiTarihi = mesaitarihi;
                ekle.MesaiSuresi = mesaisuresi;
                ekle.PersonelMaasBilgisiID = personelmaasbilgisiid;
                ekle.PersonelID = personelid;
                ekle.ToplamMesaiUcreti = toplamgunlukmesaiucreti;

                db.PersonelMesaileri.Add(ekle);
                int sonucKaydet = db.SaveChanges();
                if (sonucKaydet > 0)
                {
                    return "Kayıt işlemi Başarılı!";
                }
                return "Kayıt Yapılamadı!";
            }
            catch (Exception)
            {

                return "Hata Oluştu!";
            }
        }

        public List<PersonelMesaileri> PersonelMesaileriListesi(int personelid)
        {
            return db.PersonelMesaileri.ToList();
        }

        public string PersonelMesaiSil(int personelmesaileriid)
        {
            throw new NotImplementedException();
        }
        #endregion
        //**********************************************

        //*****************************************************

        public void PersonelListesi(DataGridView dgv_liste)
        {
            var Listepersonel = (from p in db.Personeller
                                join pa in db.PersonelAyrintisi on p.PersonellerID equals pa.PersonelID
                                join pm in db.PersonelMesaileri on p.PersonellerID equals pm.PersonelID
                                join pmaas in db.PersonelMaasBilgisi on pa.PersonelAyrintilariID equals pmaas.PersonelAyrintisiID
                                select new
                                {
                                    PersonelID = p.PersonellerID,
                                    Adi = p.PersonelAdi,
                                    Ehliyet = pa.EhliyetVarmi,
                                    Giris_Tarihi = pa.GirisTarihi,
                                    Maas = pmaas.Maas,
                                    MesaiTarihi = pm.MesaiTarihi,
                                    MesaiSuresi = pm.MesaiSuresi
                                });
            dgv_liste.DataSource = Listepersonel.ToList();
        }
        






    }
}
