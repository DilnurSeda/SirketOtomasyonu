using SiketOtomasyonu.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketOtomasyonu.BLL.GelirSatisislemleri
{
    interface IGelirSatis
    {
        #region Gelirler

        string GelirKaydet(DateTime gelirtarihi, decimal toplamtutar);
        //****
        string GelirGuncelle(int gelirlerid, DateTime gelirtarihi, decimal toplamtutar);
        //****
        string GelirSil(int gelirlerid);
        //****
        List<Gelirler> GelirListesi();
        //***
        List<Gelirler> GelirListesiAylik(DateTime aytarihi);
        #endregion

        #region Satışlar
        string SatisKaydet(int urunid, DateTime islemtarihi, TimeSpan islemsaati, int musteriid, decimal fiyat, int adet, decimal indirimorani, string indirimaciklamasi,int kullaniciid ,int gelirid);
        //****
        string SatisGuncelle(int satislarid,int urunid, DateTime islemtarihi, TimeSpan islemsaati, int musteriid, decimal fiyat, int adet, decimal indirimorani, string indirimaciklamasi, int kullaniciid, int gelirid);
        //****
        string SatisSil(int satislarid);
        //****
        List<Satislar> SatisListesi(int gelirid);

        #endregion
    }
}
