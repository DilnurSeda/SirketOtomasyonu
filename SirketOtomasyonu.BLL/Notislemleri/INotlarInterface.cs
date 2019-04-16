using SiketOtomasyonu.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketOtomasyonu.BLL.Notislemleri
{
    interface INotlarInterface
    {
        string notKaydet(DateTime nottarihi, TimeSpan notsaati, string notbaslik, string notdetay, string notOlusturan);

        string notGuncelle(int notlarid,DateTime nottarihi, TimeSpan notsaati, string notbaslik, string notdetay, string notOlusturan);

        string notSil(int notlarid);

        List<Notlar> notListesi(string notOlusturan);


    }
}
