using SiketOtomasyonu.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketOtomasyonu.BLL.Kullaniciislemleri
{
    interface IKullaniciInterface
    {
        string kullaniciKaydet(string adi,string soyadi,string kullaniciadi,string sifre,int yetkiId);

        string kullaniciGuncelle(int kullaniciid, string adi, string soyadi, string kullaniciadi, string sifre, int yetkiId);

        string kullaniciSil(int kullaniciid);

        List<Kullanicilar> kullaniciListesi();
    }
}
