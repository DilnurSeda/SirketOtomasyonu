using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketOtomasyonu.BLL.Bankaislemleri
{
    interface IBankalarInterface
    {
        string BankaKaydet(string bankaAdi, string subeAdi, string aciklama);

        string BankaGuncelle(int bankaId, string bankaAdi, string subeAdi, string aciklama);

        string BankaSil(int bankaId);
    }
}
