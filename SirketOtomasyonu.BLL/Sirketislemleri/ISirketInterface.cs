using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketOtomasyonu.BLL.Sirketislemleri
{
    interface ISirketInterface
    {
        string sirketKaydet(string sirketAdi,string yetkiliGorevi,string yetkiliAdSoyad,string tel1,string tel2,string email,string il,string ilce,string vergiDairesi,string adres);

        string sirketGuncelle(int sirket_ID,string sirketAdi, string yetkiliGorevi, string yetkiliAdSoyad, string tel1, string tel2, string email, string il, string ilce, string vergiDairesi, string adres);

        string sirketSil(int sirket_ID);
    }
}
