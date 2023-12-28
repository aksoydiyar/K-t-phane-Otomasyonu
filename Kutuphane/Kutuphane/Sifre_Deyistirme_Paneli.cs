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
    public partial class Sifre_Deyistirme_Paneli : Form
    {
        public Sifre_Deyistirme_Paneli()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sifre_Deyistirme_Paneli_Load(object sender, EventArgs e)
        {
            Controler controller = new Controler();
            List<loginTable> loginnTableList = controller.getLoginTable();
           
            groupBoxSifreDeyistir.Enabled = false;//bu box form çalıştığında aktif olmayacak 
            foreach (loginTable lt in loginnTableList)
            {
                comboBox_gvnlkSorusu.Items.Add(lt.guvenli_soru.ToString());
            }
            comboBox_gvnlkSorusu.SelectedIndex = 0;//txt box oto doldurur
        }

        private void btn_surgula_Click(object sender, EventArgs e)
        {
            //Trim() fazla boşlıkları siler  ToLower() büyük harfleri küçük harf yapar databasede küçük har olduğu için
            Controler controller = new Controler();
           login_durumu sonuç= controller.doauthentication(txt_kullaniciAd.Text.Trim().ToLower(),comboBox_gvnlkSorusu.SelectedItem.ToString(),txt_gvnlkCvp.Text.ToLower() );
            if (sonuç==login_durumu.başarılı)
            {
                groupBoxSifreDeyistir.Enabled = true;// mail girme alanı açar
                MessageBox.Show("doğrulama tamamlandı şifreni deyiştirebilirsin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (sonuç==login_durumu.başarısız)
            {
                MessageBox.Show("girdiğiniz bilgileri kontrol ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("tüm boşlukları doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sifreDeyistir_Click(object sender, EventArgs e)
        {
            Controler controller = new Controler();
            if (txt_yeniSifre.Text==txt_sifreDogrula.Text)
            {
             login_durumu sonuç=   controller.changePassword(txt_kullaniciAd.Text,txt_yeniSifre.Text);
                if (sonuç==login_durumu.başarılı)
                {
                    MessageBox.Show("şifre deyiştirme başarılı","bilgilemdirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                        MessageBox.Show("bir hata oluştu","eror",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
