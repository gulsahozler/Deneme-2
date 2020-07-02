using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_userinterface
{
    public partial class frm_loginekrani : Form
    {
        public frm_loginekrani()
        {
            InitializeComponent();
        }

        private void btn_giris_yap_Click(object sender, EventArgs e)
        {
            string kullaniciadi;
            string parola;
            kullaniciadi = txt_kullanici_adi.Text;
            parola = txt_parola.Text;
            if (kullaniciadi == "Uluç" && parola == "1234") MessageBox.Show("Giriş Başarılı");
            else MessageBox.Show("Hatalı Giriş Yapıldı");
        }

        private void txt_kullanici_adi_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_parola_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pcbx_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
