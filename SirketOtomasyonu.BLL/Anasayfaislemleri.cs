using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiketOtomasyonu.DLL;
using System.Windows.Forms;
using DevExpress.XtraGrid;

namespace SirketOtomasyonu.BLL
{
    public class Anasayfaislemleri
    {
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();

        public void UrunlerdenEldeEdilenGelir(GridControl dgv_liste)
        {
            var ListeGelir = (from s in db.Satislar
                              join u in db.Urunler on s.UrunID equals u.UrunlerID
                              group s by u.UrunAdi into g
                              select new
                              {
                                  UrunAdi = g.Key,
                                  Sum = g.Sum(s => s.Adet * s.Tutar)
                              }
                            );
            dgv_liste.DataSource = ListeGelir.ToList();
        }

    }

    
}
