using SiketOtomasyonu.DLL;
using SirketOtomasyonu.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirketOtomasyonu.UserInterface
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }
        SirketOtomasyonDBEntities db = new SirketOtomasyonDBEntities();
        Anasayfaislemleri anasayfa = new Anasayfaislemleri();

        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            anasayfa.UrunlerdenEldeEdilenGelir(gridControl1);
            gridControl4.DataSource = db.SP_EnAzKalanUrunler();
            

        }


    }
}
