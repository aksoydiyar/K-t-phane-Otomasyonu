using Kutuphane.controller;
using Kutuphane.enum_aration;
using Kutuphane.model;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            Controler controler = new Controler();
            kullanıcıı  sonuc = controler.login(txt_kullanıcı_adi.Text,txt_sifre.Text);
            if (sonuc != null && sonuc.status == login_durumu.başarılı && sonuc.yetki == "Admin")
            {
                admin_paneli admin = new admin_paneli();
                admin.Show();
                this.Hide();
            }
            else if (sonuc != null && sonuc.status == login_durumu.başarılı && sonuc.yetki == "Kullanıcı")
            {
                kullanici kasiyer = new kullanici();
                kasiyer.Show();
                this.Hide();
            }
            else if (sonuc != null && sonuc.status == login_durumu.başarısız)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Eksik parametre hatası", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Sifre_Deyistirme_Paneli sd = new Sifre_Deyistirme_Paneli();
            sd.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
