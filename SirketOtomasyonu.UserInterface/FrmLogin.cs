using SirketOtomasyonu.BLL.Loginislemleri;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        
       
        private void btnGiris_Click(object sender, EventArgs e)
        {
            LoginManager giris = new LoginManager();
            bool girisSorgu = giris.Login(txtKullaniciAdi.Text, txtSifre.Text);
            if (girisSorgu)
            {
                FrmMenu frm_menu = new FrmMenu();
                this.Hide();
                frm_menu.lblKullaniciBilgisi.Text = giris.kullaniciAdiSoyadi;

                frm_menu.yetki_Id = giris.yetki_IDclass;               
                frm_menu.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }

        }

    }
}
