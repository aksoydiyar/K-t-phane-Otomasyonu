namespace Kutuphane
{
    partial class Kitap_yönetim_paneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitap_yönetim_paneli));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ggrp_urun = new System.Windows.Forms.GroupBox();
            this.btn_kayitSil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_kayitEkle = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_kayitGuncelle = new System.Windows.Forms.Button();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.txt_yazarad = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_kitapad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ggrp_urun.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(624, 242);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick_1);
            // 
            // ggrp_urun
            // 
            this.ggrp_urun.Controls.Add(this.btn_kayitSil);
            this.ggrp_urun.Controls.Add(this.btn_kayitEkle);
            this.ggrp_urun.Controls.Add(this.btn_geri);
            this.ggrp_urun.Controls.Add(this.btn_kayitGuncelle);
            this.ggrp_urun.Controls.Add(this.txt_adet);
            this.ggrp_urun.Controls.Add(this.txt_yazarad);
            this.ggrp_urun.Controls.Add(this.txt_id);
            this.ggrp_urun.Controls.Add(this.txt_kitapad);
            this.ggrp_urun.Controls.Add(this.label3);
            this.ggrp_urun.Controls.Add(this.label8);
            this.ggrp_urun.Controls.Add(this.label2);
            this.ggrp_urun.Controls.Add(this.label1);
            this.ggrp_urun.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggrp_urun.Location = new System.Drawing.Point(38, 283);
            this.ggrp_urun.Name = "ggrp_urun";
            this.ggrp_urun.Size = new System.Drawing.Size(624, 244);
            this.ggrp_urun.TabIndex = 5;
            this.ggrp_urun.TabStop = false;
            this.ggrp_urun.Text = "Ürün panel";
            // 
            // btn_kayitSil
            // 
            this.btn_kayitSil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_kayitSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayitSil.ImageIndex = 2;
            this.btn_kayitSil.ImageList = this.ımageList1;
            this.btn_kayitSil.Location = new System.Drawing.Point(414, 138);
            this.btn_kayitSil.Name = "btn_kayitSil";
            this.btn_kayitSil.Size = new System.Drawing.Size(173, 39);
            this.btn_kayitSil.TabIndex = 11;
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
            this.ımageList1.Images.SetKeyName(2, "sil.png");
            this.ımageList1.Images.SetKeyName(3, "güncelleme.png");
            // 
            // btn_kayitEkle
            // 
            this.btn_kayitEkle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_kayitEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayitEkle.ImageIndex = 0;
            this.btn_kayitEkle.ImageList = this.ımageList1;
            this.btn_kayitEkle.Location = new System.Drawing.Point(414, 29);
            this.btn_kayitEkle.Name = "btn_kayitEkle";
            this.btn_kayitEkle.Size = new System.Drawing.Size(173, 39);
            this.btn_kayitEkle.TabIndex = 10;
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
            this.btn_geri.Location = new System.Drawing.Point(531, 198);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(56, 36);
            this.btn_geri.TabIndex = 12;
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_kayitGuncelle
            // 
            this.btn_kayitGuncelle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_kayitGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayitGuncelle.ImageIndex = 3;
            this.btn_kayitGuncelle.ImageList = this.ımageList1;
            this.btn_kayitGuncelle.Location = new System.Drawing.Point(414, 80);
            this.btn_kayitGuncelle.Name = "btn_kayitGuncelle";
            this.btn_kayitGuncelle.Size = new System.Drawing.Size(173, 39);
            this.btn_kayitGuncelle.TabIndex = 9;
            this.btn_kayitGuncelle.Text = "Kayıt Güncelle";
            this.btn_kayitGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kayitGuncelle.UseVisualStyleBackColor = false;
            this.btn_kayitGuncelle.Click += new System.EventHandler(this.btn_kayitGuncelle_Click);
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(127, 157);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(191, 22);
            this.txt_adet.TabIndex = 2;
            // 
            // txt_yazarad
            // 
            this.txt_yazarad.Location = new System.Drawing.Point(127, 117);
            this.txt_yazarad.Name = "txt_yazarad";
            this.txt_yazarad.Size = new System.Drawing.Size(191, 22);
            this.txt_yazarad.TabIndex = 2;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(127, 39);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(191, 22);
            this.txt_id.TabIndex = 0;
            // 
            // txt_kitapad
            // 
            this.txt_kitapad.Location = new System.Drawing.Point(127, 80);
            this.txt_kitapad.Name = "txt_kitapad";
            this.txt_kitapad.Size = new System.Drawing.Size(191, 22);
            this.txt_kitapad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adet :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "İd :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yazar Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap adı :";
            // 
            // Kitap_yönetim_paneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(697, 555);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ggrp_urun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Kitap_yönetim_paneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Yönetim Paneli";
            this.Load += new System.EventHandler(this.Kitap_yönetim_paneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ggrp_urun.ResumeLayout(false);
            this.ggrp_urun.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox ggrp_urun;
        private System.Windows.Forms.Button btn_kayitSil;
        private System.Windows.Forms.Button btn_kayitEkle;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_kayitGuncelle;
        private System.Windows.Forms.TextBox txt_yazarad;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_kitapad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_adet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList ımageList1;
    }
}