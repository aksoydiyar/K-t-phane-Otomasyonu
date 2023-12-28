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
    public partial class admin_paneli : Form
    {
        public admin_paneli()
        {
            InitializeComponent();
        }

        private void btn_kullanici_Click(object sender, EventArgs e)
        {
            Kullanıcı_yönetim_paneli kyp= new Kullanıcı_yönetim_paneli();
            kyp.Show();
            this.Hide();

        }

        private void btn_kitap_Click(object sender, EventArgs e)
        {
            Kitap_yönetim_paneli kitap_Yönetim = new Kitap_yönetim_paneli();
            kitap_Yönetim.Show();
            this.Hide();
        }

        private void admin_paneli_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
