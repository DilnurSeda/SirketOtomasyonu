using SiketOtomasyonu.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketOtomasyonu.BLL.Giderislemleri
{
    interface IGiderInterface
    {
        string GiderKaydet(string giderturuadi, DateTime gelirtarihi, string toplamtutar, string aciklama);

        string GiderGuncelle(int giderlerid,string giderturuadi, DateTime gelirtarihi, string toplamtutar, string aciklama);

        string GiderSil(int giderlerid);

        List<Giderler> GiderListesi();
    }
}
