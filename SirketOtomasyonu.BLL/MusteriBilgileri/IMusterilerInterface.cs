using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketOtomasyonu.BLL.Musteriler
{
    interface IMusterilerInterface
    {
        string Kaydet(string TC,string Adi,string Soyadi,string Tel1,string Tel2,string eMail,string VerigiD,string il,string ilce,string sirketAdi,string adres);
        string Guncelle(int musteriID, string TC, string Adi, string Soyadi, string Tel1, string Tel2, string eMail, string VerigiD, string il, string ilce, string sirketAdi, string adres);
        string Sil(int musteriID);
    }
}
