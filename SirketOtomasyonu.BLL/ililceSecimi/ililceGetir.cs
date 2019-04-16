using SiketOtomasyonu.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirketOtomasyonu.BLL.ililceSecimi
{
    public class ililceGetir
    {
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();
        //***************************************************************

        public List<iller> illerListesi(ComboBox cmbiller)
        {
            cmbiller.DisplayMember = "SehirAdi";
            cmbiller.ValueMember = "illerID";
            return db.iller.ToList();
        }

        public List<ilceler> ilcelerListesi(ComboBox cmbiller,ComboBox cmbilceler)
        {
            cmbilceler.DisplayMember = "ilceAdi";
            cmbilceler.ValueMember = "ilcelerID";
            return db.ilceler.Where(k => k.ilID == (int)cmbiller.SelectedValue).ToList();
        }
    }
}
