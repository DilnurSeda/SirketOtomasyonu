using SiketOtomasyonu.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketOtomasyonu.BLL.Personelislemleri
{
    interface IPersonelInterface
    {
        #region Personeller

        string PersonelKaydet(string tc, string adi, string soyadi, string telefon, string email, string il, string ilce, string adres);
        //***
        string PersonelGuncelle(int personellerid, string tc, string adi, string soyadi, string telefon, string email, string il, string ilce, string adres);
        string PersonelSil(int personellerid);

        List<Personeller> PersonelListesi();

        #endregion

        #region Personel İzinleri

        string PersonelizinKaydet(DateTime izinbaslangictarihi, DateTime izinbitistarihi, int personelid, string aciklama, int yillikizingunsayisi, int kalanizingunsayisi);
        //**
        string PersonelizinGuncelle(int personelizinleriid, DateTime izinbaslangictarihi, DateTime izinbitistarihi, int personelid, string aciklama, int yillikizingunsayisi, int kalanizingunsayisi);
        //**
        string PersonelizinSil(int personelizinleriid);
        //**
        List<Personelizinleri> PersonelIzinleriListesi(int personelid);

        #endregion

        #region Personel Ayrıntısı
        string PersonelAyrintisiKaydet(bool ehliyetvarmi, int personelid, DateTime giristarihi, DateTime? cikistarihi, bool aktifmi);
        //***
        string PersonelAyrintisiGuncelle(int personelayrintilariid, bool ehliyetvarmi, int personelid, DateTime giristarihi, DateTime? cikistarihi, bool aktifmi);
        //**
        string PersonelAyrintisiSil(int personelayrintilariid);
        //***
        List<PersonelAyrintisi> PersonelAyrintiListesi(int personelid);
        #endregion

        #region Personel Maas Bilgisi
        string PersonelMaasBilgisiKaydet(DateTime maasbaslangictarihi, DateTime maasbitistarihi, int personelayrintisiid, decimal maas);
        //**
        string PersonelMaasBilgisiGuncelle(int personelmaasbilgileriid, DateTime maasbaslangictarihi, DateTime maasbitistarihi, int personelayrintisiid, decimal maas);
        //***
        string PersonelMaasBilgisiSil(int personelmaasbilgileriid);
        //***
        List<PersonelMaasBilgisi> PersonelMaasBilgiListesi(int personelayrintisiid, int personelid);
        #endregion

        #region Personel Mesaileri
        string PersonelMesaiKaydet(DateTime mesaitarihi, decimal mesaisuresi, int personelmaasbilgisiid, int personelid, decimal toplamgunlukmesaiucreti);
        //***
        string PersonelMesaiGuncelle(int personelmesaileriid, DateTime mesaitarihi, decimal mesaisuresi, int personelmaasbilgisiid, int personelid, decimal toplamgunlukmesaiucreti);
        //***
        string PersonelMesaiSil(int personelmesaileriid);
        //***
        List<PersonelMesaileri> PersonelMesaileriListesi(int personelid);
        #endregion
    }
}
