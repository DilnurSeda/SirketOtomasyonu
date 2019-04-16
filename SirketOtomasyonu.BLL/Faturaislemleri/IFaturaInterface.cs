using SiketOtomasyonu.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketOtomasyonu.BLL.Faturalar
{
    interface IFaturaInterface
    {
        string FaturaKaydet(string seriNo,string siraNo,string tarih,string saat,string vergiDaireleri,string alici,string teslimeden,string teslimAlan);

        string FaturaGuncelle(int faturaId,string seriNo, string siraNo, string tarih, string saat, string vergiDaireleri, string alici, string teslimeden, string teslimAlan);

        string FaturaSil(int faturaId);

        List<SiketOtomasyonu.DLL.Faturalar> FaturaListesi();
        //*****************************************************************

        string FaturaDetayKaydet(int urunid, short miktar, decimal fiyat, decimal tutar, int faturaid);

        string FaturaDetayGuncelle(int faturadetaylarid, int urunid, short miktar, decimal fiyat, decimal tutar, int faturaid);

        string FaturaDetaySil(int faturadetaylarid);

        //**********
        List<FaturaDetay> FaturaDetayListesi(int faturaid);
    }
}
