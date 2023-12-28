namespace Kutuphane
{
    partial class Kullanıcı_yönetim_paneli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanıcı_yönetim_paneli));
            this.grpbox_kullanici = new System.Windows.Forms.GroupBox();
            this.btn_kayitSil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_kayitEkle = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_kayitGuncelle = new System.Windows.Forms.Button();
            this.combo_guvenlikSorusu = new System.Windows.Forms.ComboBox();
            this.combo_yetki = new System.Windows.Forms.ComboBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_guvenlikCevabi = new System.Windows.Forms.TextBox();
            this.txt_emailAdres = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpbox_kullanici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbox_kullanici
            // 
            this.grpbox_kullanici.Controls.Add(this.btn_kayitSil);
            this.grpbox_kullanici.Controls.Add(this.btn_kayitEkle);
            this.grpbox_kullanici.Controls.Add(this.btn_geri);
            this.grpbox_kullanici.Controls.Add(this.btn_kayitGuncelle);
            this.grpbox_kullanici.Controls.Add(this.combo_guvenlikSorusu);
            this.grpbox_kullanici.Controls.Add(this.combo_yetki);
            this.grpbox_kullanici.Controls.Add(this.txt_sifre);
            this.grpbox_kullanici.Controls.Add(this.txt_guvenlikCevabi);
            this.grpbox_kullanici.Controls.Add(this.txt_emailAdres);
            this.grpbox_kullanici.Controls.Add(this.txt_id);
            this.grpbox_kullanici.Controls.Add(this.txt_kullaniciAdi);
            this.grpbox_kullanici.Controls.Add(this.label6);
            this.grpbox_kullanici.Controls.Add(this.label7);
            this.grpbox_kullanici.Controls.Add(this.label3);
            this.grpbox_kullanici.Controls.Add(this.label5);
            this.grpbox_kullanici.Controls.Add(this.label8);
            this.grpbox_kullanici.Controls.Add(this.label2);
            this.grpbox_kullanici.Controls.Add(this.label1);
            this.grpbox_kullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbox_kullanici.Location = new System.Drawing.Point(22, 254);
            this.grpbox_kullanici.Name = "grpbox_kullanici";
            this.grpbox_kullanici.Size = new System.Drawing.Size(825, 295);
            this.grpbox_kullanici.TabIndex = 3;
            this.grpbox_kullanici.TabStop = false;
            this.grpbox_kullanici.Text = "Kullanıcı Panel";
            // 
            // btn_kayitSil
            // 
            this.btn_kayitSil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_kayitSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayitSil.ImageIndex = 3;
            this.btn_kayitSil.ImageList = this.ımageList1;
            this.btn_kayitSil.Location = new System.Drawing.Point(600, 229);
            this.btn_kayitSil.Name = "btn_kayitSil";
            this.btn_kayitSil.Size = new System.Drawing.Size(176, 37);
            this.btn_kayitSil.TabIndex = 9;
            this.btn_kayitSil.Text = "Kayıt Sil";
            this.btn_kayitSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kayitSil.UseVisualStyleBackColor = false;
            this.btn_kayitSil.Click += new System.EventHandler(this.btn_kayitSil_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ekle.png");
            this.ımageList1.Images.SetKeyName(1, "geri.png");
            this.ımageList1.Images.SetKeyName(2, "güncelleme.png");
            this.ımageList1.Images.SetKeyName(3, "sil.png");
            // 
            // btn_kayitEkle
            // 
            this.btn_kayitEkle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_kayitEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayitEkle.ImageKey = "ekle.png";
            this.btn_kayitEkle.ImageList = this.ımageList1;
            this.btn_kayitEkle.Location = new System.Drawing.Point(233, 229);
            this.btn_kayitEkle.Name = "btn_kayitEkle";
            this.btn_kayitEkle.Size = new System.Drawing.Size(176, 37);
            this.btn_kayitEkle.TabIndex = 7;
            this.btn_kayitEkle.Text = "Kayıt Ekle";
            this.btn_kayitEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kayitEkle.UseVisualStyleBackColor = false;
            this.btn_kayitEkle.Click += new System.EventHandler(this.btn_kayitEkle_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_geri.ImageIndex = 1;
            this.btn_geri.ImageList = this.ımageList1;
            this.btn_geri.Location = new System.Drawing.Point(18, 248);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(82, 41);
            this.btn_geri.TabIndex = 8;
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_kayitGuncelle
            // 
            this.btn_kayitGuncelle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_kayitGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayitGuncelle.ImageIndex = 2;
            this.btn_kayitGuncelle.ImageList = this.ımageList1;
            this.btn_kayitGuncelle.Location = new System.Drawing.Point(418, 229);
            this.btn_kayitGuncelle.Name = "btn_kayitGuncelle";
            this.btn_kayitGuncelle.Size = new System.Drawing.Size(176, 37);
            this.btn_kayitGuncelle.TabIndex = 8;
            this.btn_kayitGuncelle.Text = "Kayıt Güncelle";
            this.btn_kayitGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kayitGuncelle.UseVisualStyleBackColor = false;
            this.btn_kayitGuncelle.Click += new System.EventHandler(this.btn_kayitGuncelle_Click);
            // 
            // combo_guvenlikSorusu
            // 
            this.combo_guvenlikSorusu.FormattingEnabled = true;
            this.combo_guvenlikSorusu.Location = new System.Drawing.Point(505, 115);
            this.combo_guvenlikSorusu.Name = "combo_guvenlikSorusu";
            this.combo_guvenlikSorusu.Size = new System.Drawing.Size(271, 24);
            this.combo_guvenlikSorusu.TabIndex = 5;
            // 
            // combo_yetki
            // 
            this.combo_yetki.FormattingEnabled = true;
            this.combo_yetki.Location = new System.Drawing.Point(141, 154);
            this.combo_yetki.Name = "combo_yetki";
            this.combo_yetki.Size = new System.Drawing.Size(191, 24);
            this.combo_yetki.TabIndex = 2;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(141, 115);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(191, 22);
            this.txt_sifre.TabIndex = 1;
            // 
            // txt_guvenlikCevabi
            // 
            this.txt_guvenlikCevabi.Location = new System.Drawing.Point(505, 163);
            this.txt_guvenlikCevabi.Name = "txt_guvenlikCevabi";
            this.txt_guvenlikCevabi.Size = new System.Drawing.Size(271, 22);
            this.txt_guvenlikCevabi.TabIndex = 6;
            // 
            // txt_emailAdres
            // 
            this.txt_emailAdres.Location = new System.Drawing.Point(505, 78);
            this.txt_emailAdres.Name = "txt_emailAdres";
            this.txt_emailAdres.Size = new System.Drawing.Size(271, 22);
            this.txt_emailAdres.TabIndex = 4;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(141, 35);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(191, 22);
            this.txt_id.TabIndex = 0;
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(141, 78);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(191, 22);
            this.txt_kullaniciAdi.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(365, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Güvenlik Sorusu :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(365, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Güvenlik Cevabı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yetki :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(365, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email Adres :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "İd :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(821, 234);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick_1);
            // 
            // Kullanıcı_yönetim_paneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(877, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpbox_kullanici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Kullanıcı_yönetim_paneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Yönetim Paneli";
            this.Load += new System.EventHandler(this.Kullanıcı_yönetim_paneli_Load);
            this.grpbox_kullanici.ResumeLayout(false);
            this.grpbox_kullanici.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbox_kullanici;
        private System.Windows.Forms.Button btn_kayitSil;
        private System.Windows.Forms.Button btn_kayitEkle;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_kayitGuncelle;
        private System.Windows.Forms.ComboBox combo_guvenlikSorusu;
        private System.Windows.Forms.ComboBox combo_yetki;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_guvenlikCevabi;
        private System.Windows.Forms.TextBox txt_emailAdres;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}