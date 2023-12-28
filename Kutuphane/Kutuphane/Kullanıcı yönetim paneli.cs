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
    public partial class Kullanıcı_yönetim_paneli : Form
    {
       controller.Controler controller=new controller.Controler();
        public Kullanıcı_yönetim_paneli()
        {
            InitializeComponent();
            tumKullanicilariDoldur();
        }

        private void Kullanıcı_yönetim_paneli_Load(object sender, EventArgs e)
        {
            defaultDegerileriDoldur();

        }
        private void defaultDegerileriDoldur()
        {
            combo_yetki.Items.Add("Admin");
            combo_yetki.Items.Add("Kullanıcı");
            combo_yetki.SelectedIndex = 0;
            //--------------------------------------
            combo_guvenlikSorusu.Items.Add("En Sevdiginiz Hayvan Nedir ?");
            combo_guvenlikSorusu.Items.Add("En Sevdiginiz Araba ?");
            combo_guvenlikSorusu.Items.Add("En Sevdiginiz Renk ?");
            combo_guvenlikSorusu.SelectedIndex = 0;

        }
        private void tumKullanicilariDoldur()
        {

            List<kullanıcıı> userList = controller.tumKullanicilariGetir();
            dataGridView1.DataSource = userList;
        }

        private void btn_kayitEkle_Click(object sender, EventArgs e)
        {
            kullanıcıı user = new kullanıcıı();
            user.Kullanici_Adi = txt_kullaniciAdi.Text;
            user.Sifre = txt_sifre.Text;
            user.yetki = combo_yetki.SelectedItem.ToString();
           
            user.Eposta = txt_emailAdres.Text;
            user.guvenli_soru = combo_guvenlikSorusu.SelectedItem.ToString();
            user.guvenlik_cvp = txt_guvenlikCevabi.Text;

            login_durumu sonuc = controller.kullaniciEkle(user);
            if (sonuc == login_durumu.başarılı)
            {
                MessageBox.Show("Kayıt Eklendi :)", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumKullanicilariGetir();
            }
            else
            {
                MessageBox.Show("Gerekli alanların hepsini doldurun !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       

        private void dataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_kullaniciAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            combo_yetki.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_emailAdres.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            combo_guvenlikSorusu.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_guvenlikCevabi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_kayitGuncelle_Click(object sender, EventArgs e)
        {
            kullanıcıı user = new kullanıcıı();
            user.id = int.Parse(txt_id.Text);
            user.Kullanici_Adi = txt_kullaniciAdi.Text;
            user.Sifre = txt_sifre.Text;
            user.yetki = combo_yetki.SelectedItem.ToString();
            user.Eposta = txt_emailAdres.Text;
            user.guvenli_soru = combo_guvenlikSorusu.SelectedItem.ToString();
            user.guvenlik_cvp = txt_guvenlikCevabi.Text;
            login_durumu sonuc = controller.kullaniciGuncelle(user);

            if (sonuc == login_durumu.başarılı)
            {
                MessageBox.Show("Kayıt Güncellendi :)", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumKullanicilariGetir();
            }
            else
            {
                MessageBox.Show("Kayıt güncellenirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_kayitSil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_id.Text))
            {
                login_durumu sonuc = controller.kullaniciSil(int.Parse(txt_id.Text));
                if (sonuc ==login_durumu.başarılı)
                {
                    MessageBox.Show("Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = controller.tumKullanicilariGetir();

                }
                else if (sonuc == login_durumu.başarısız)
                {
                    MessageBox.Show("Kayıt Silinirken bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Silmek istediğiniz kaydın id değerini giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz kaydın id değerini giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            admin_paneli admin_Paneli = new admin_paneli();
            admin_Paneli.Show();
            this.Hide();
        }
    }
}
