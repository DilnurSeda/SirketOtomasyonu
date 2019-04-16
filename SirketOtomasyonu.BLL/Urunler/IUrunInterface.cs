using SiketOtomasyonu.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketOtomasyonu.BLL
{
    interface IUrunInterface
    {
        string urunKaydet( string adi,string marka,string model,string uretimYili,short stok,decimal alisFiyati,decimal satisFiyati,string detay);
        string urunGuncelle(int urun_id, string adi, string marka, string model, string uretimYili, short stok, decimal alisFiyati, decimal satisFiyati, string detay);
        string UrunSil(int urunID);

        List<Urunler> UrunListele();
    }
}
