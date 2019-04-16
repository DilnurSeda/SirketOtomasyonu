using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketOtomasyonu.BLL.SirketBankaislemleri
{
    interface ISirketBankaInterface
    {
        string bankaBilgileriKaydet(int sirketID, int bankaID, string iban, string hesapNo, string bankayetkiliAdSoyad, string hesapTuru);

        string bankaBilgileriGuncelle(int sirketbankabil_ID, int sirketID, int bankaID, string iban, string hesapNo, string bankayetkiliAdSoyad, string hesapTuru);

        string bankaBilgileriSil(int sirketbankabil_ID);
    }
}
