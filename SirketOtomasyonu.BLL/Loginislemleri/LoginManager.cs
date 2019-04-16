using SiketOtomasyonu.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirketOtomasyonu.BLL.Loginislemleri
{
    public class LoginManager : ILoginInterface
    {
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();
        
        //************************************************
        public string kullaniciAdiSoyadi;
        public int yetki_IDclass;
        //***************************************
        public bool Login(string kullaniciAdi, string kullanicisifre)
        {
                var giris = db.Kullanicilar.Where(k => k.KullaniciAdi == kullaniciAdi && k.Sifresi == kullanicisifre).FirstOrDefault();
                if (giris!=null)
                {
                    kullaniciAdiSoyadi = giris.Adi + " " + giris.Soyadi;
                    yetki_IDclass = (int)giris.YetkiID;
                    return true;                    
                }
                return false;           

        }

       
    }
}
