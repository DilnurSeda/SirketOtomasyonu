using SiketOtomasyonu.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketOtomasyonu.BLL.Modelislemleri
{
    interface IModelInterface
    {
        string modelKaydet(string modelAdi, int urunid,int markaid);

        string modelGuncelle(int modellerid, string modelAdi, int urunid,int markaid);

        string modelSil(int modellerid);

        List<Modeller> modelListesi();
    }
}
