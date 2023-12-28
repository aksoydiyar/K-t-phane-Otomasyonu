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
    public partial class Kitap_yönetim_paneli : Form
    {
        controller.Controler controler = new controller.Controler();
        public Kitap_yönetim_paneli()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Kitap_yönetim_paneli_Load(object sender, EventArgs e)
        {
            tumUrunleriGetir();

        }
        public void tumUrunleriGetir()
        {
            dataGridView1.DataSource = controler.tumUrunleriGetir();
        }

        private void btn_kayitEkle_Click(object sender, EventArgs e)
        {
            urun urun = new urun();
            urun.kitapAd = txt_kitapad.Text;
            urun.yazarAd = txt_yazarad.Text;
            urun.adet = txt_adet.Text;


            login_durumu sonuc = controler.urunEkle(urun);

            if (sonuc == login_durumu.başarılı)
            {
                MessageBox.Show("Ürün Eklendi :)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controler.tumUrunleriGetir();
            }
            else if (sonuc == login_durumu.başarısız)
            {
                MessageBox.Show("Ürün Eklenemedi :(", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Gerekli alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void dataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_kitapad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_yazarad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_adet.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
        private void btn_kayitGuncelle_Click(object sender, EventArgs e)
            {
                urun urun = new urun();
                urun.id = int.Parse(txt_id.Text);
                urun.kitapAd = txt_kitapad.Text;
                urun.yazarAd = txt_yazarad.Text;
                urun.adet = txt_adet.Text;



                login_durumu sonuc = controler.urunGuncelle(urun);
                if (sonuc == login_durumu.başarılı)
                {
                    MessageBox.Show("Ürün Güncellendi :)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = controler.tumUrunleriGetir();
                }
                else if (sonuc == login_durumu.başarısız)
                {
                    MessageBox.Show("Ürün Güncellenemedi :(", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Gerekli alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

        private void btn_kayitSil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_id.Text))
            {
                login_durumu sonuc = controler.urunSil(txt_id.Text);
                if (sonuc == login_durumu.başarılı)
                {
                    MessageBox.Show("Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = controler.tumUrunleriGetir();

                }
                else
                {
                    MessageBox.Show("Silmek istediğiniz ürünün id değerini giriniz!", "Eksik Parametre", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz ürünün id değerini giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
