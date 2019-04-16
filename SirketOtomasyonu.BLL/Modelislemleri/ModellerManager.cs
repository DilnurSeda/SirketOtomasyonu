using SiketOtomasyonu.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirketOtomasyonu.BLL.Modelislemleri
{
    public class ModellerManager : IModelInterface
    {
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();
        //************************************************************

        public string modelGuncelle(int modellerid, string modelAdi, int urunid, int markaid)
        {
            try
            { 
                var guncelle = db.Modeller.Where(m => m.ModellerID == modellerid).FirstOrDefault();

                guncelle.ModelAdi = modelAdi;
                guncelle.UrunID = urunid;
                guncelle.MarkaID = markaid;

                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Model güncellendi.";
                }
            
                    return "Ekleme Başarısız";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }
            
        }

        public string modelKaydet(string modelAdi, int urunid, int markaid)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(modelAdi))
                {
                    Modeller ekle = new Modeller();
                    ekle.ModelAdi = modelAdi;
                    ekle.UrunID = urunid;
                    ekle.MarkaID = markaid;

                    db.Modeller.Add(ekle);

                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        return "Model eklendi.";
                    }
                }
                return "Güncelleme Başarısız";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }

        }

        public List<Modeller> modelListesi()
        {
            return db.Modeller.ToList();
        }

        public string modelSil(int modellerid)
        {
            try
            {
                var Sil = db.Modeller.Where(s => s.ModellerID == modellerid).FirstOrDefault();

                DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);

                if (onay == DialogResult.OK)
                {
                    db.Modeller.Remove(Sil);

                    int sonucSil = db.SaveChanges();
                    if (sonucSil > 0)
                    {
                        return "Model adı silindi.";
                    }

                }
                return "Silme işlemi başarısız";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }
        }
    }
}
