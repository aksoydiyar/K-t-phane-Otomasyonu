using Kutuphane.controller;
using Kutuphane.enum_aration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class kullanici : Form
    {
        controller.Controler controler=new controller.Controler();
        public kullanici()
        {
            InitializeComponent();
        }

        private void kullanici_Load(object sender, EventArgs e)
        {
            tumUrunleriGetir();
        }
        public void tumUrunleriGetir()
        {
            dataGridView1.DataSource = controler.tumUrunleriGetir();
        }

        

        private void btn_ara_Click_1(object sender, EventArgs e)
        {
            Controler controller = new Controler();
            login_durumu sonuç = controller.kullanıcıYazarAra(txt_kitap_ismi_ara.Text.Trim().ToLower(), txt_yazar_ismi_ara.Text.Trim().ToLower());
            if (sonuç == login_durumu.başarılı)
            {

                MessageBox.Show("doğrulama tamamlandı şifreni deyiştirebilirsin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (sonuç == login_durumu.başarısız)
            {
                MessageBox.Show("girdiğiniz bilgileri kontrol ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("tüm boşlukları doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
