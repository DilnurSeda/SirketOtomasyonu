using SiketOtomasyonu.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketOtomasyonu.BLL.Markaislemleri
{
    interface IMarkaInterface
    {
        string markaKaydet(string markaAdi,int urunid);

        string markaGuncelle(int markalarid,string markaAdi, int urunid);

        string markaSil(int markalarid);

        List<Markalar> markaListesi();

    }
}
