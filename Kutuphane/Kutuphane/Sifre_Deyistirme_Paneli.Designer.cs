namespace Kutuphane
{
    partial class Sifre_Deyistirme_Paneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sifre_Deyistirme_Paneli));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_surgula = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBox_gvnlkSorusu = new System.Windows.Forms.ComboBox();
            this.txt_gvnlkCvp = new System.Windows.Forms.TextBox();
            this.txt_kullaniciAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxSifreDeyistir = new System.Windows.Forms.GroupBox();
            this.btn_sifreDeyistir = new System.Windows.Forms.Button();
            this.txt_sifreDogrula = new System.Windows.Forms.TextBox();
            this.txt_yeniSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxSifreDeyistir.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_surgula);
            this.groupBox1.Controls.Add(this.comboBox_gvnlkSorusu);
            this.groupBox1.Controls.Add(this.txt_gvnlkCvp);
            this.groupBox1.Controls.Add(this.txt_kullaniciAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(25, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güvenlik soru yöntemi";
            // 
            // btn_surgula
            // 
            this.btn_surgula.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_surgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_surgula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_surgula.ImageIndex = 1;
            this.btn_surgula.ImageList = this.ımageList1;
            this.btn_surgula.Location = new System.Drawing.Point(153, 169);
            this.btn_surgula.Name = "btn_surgula";
            this.btn_surgula.Size = new System.Drawing.Size(129, 49);
            this.btn_surgula.TabIndex = 3;
            this.btn_surgula.Text = "Sorgula";
            this.btn_surgula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_surgula.UseVisualStyleBackColor = false;
            this.btn_surgula.Click += new System.EventHandler(this.btn_surgula_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "güncelleme.png");
            this.ımageList1.Images.SetKeyName(1, "ara.png");
            this.ımageList1.Images.SetKeyName(2, "geri.png");
            // 
            // comboBox_gvnlkSorusu
            // 
            this.comboBox_gvnlkSorusu.FormattingEnabled = true;
            this.comboBox_gvnlkSorusu.Location = new System.Drawing.Point(168, 69);
            this.comboBox_gvnlkSorusu.Name = "comboBox_gvnlkSorusu";
            this.comboBox_gvnlkSorusu.Size = new System.Drawing.Size(226, 26);
            this.comboBox_gvnlkSorusu.TabIndex = 1;
            // 
            // txt_gvnlkCvp
            // 
            this.txt_gvnlkCvp.Location = new System.Drawing.Point(168, 118);
            this.txt_gvnlkCvp.Name = "txt_gvnlkCvp";
            this.txt_gvnlkCvp.Size = new System.Drawing.Size(226, 24);
            this.txt_gvnlkCvp.TabIndex = 2;
            this.txt_gvnlkCvp.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_kullaniciAd
            // 
            this.txt_kullaniciAd.Location = new System.Drawing.Point(168, 28);
            this.txt_kullaniciAd.Name = "txt_kullaniciAd";
            this.txt_kullaniciAd.Size = new System.Drawing.Size(226, 24);
            this.txt_kullaniciAd.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Güvenlik soru cevabı :        ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Güvenlik sorusu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı adı :        ";
            // 
            // groupBoxSifreDeyistir
            // 
            this.groupBoxSifreDeyistir.Controls.Add(this.btn_sifreDeyistir);
            this.groupBoxSifreDeyistir.Controls.Add(this.txt_sifreDogrula);
            this.groupBoxSifreDeyistir.Controls.Add(this.txt_yeniSifre);
            this.groupBoxSifreDeyistir.Controls.Add(this.label4);
            this.groupBoxSifreDeyistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxSifreDeyistir.Location = new System.Drawing.Point(25, 289);
            this.groupBoxSifreDeyistir.Name = "groupBoxSifreDeyistir";
            this.groupBoxSifreDeyistir.Size = new System.Drawing.Size(423, 197);
            this.groupBoxSifreDeyistir.TabIndex = 1;
            this.groupBoxSifreDeyistir.TabStop = false;
            this.groupBoxSifreDeyistir.Text = "Şifre deyiştir";
            // 
            // btn_sifreDeyistir
            // 
            this.btn_sifreDeyistir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_sifreDeyistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sifreDeyistir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sifreDeyistir.ImageIndex = 0;
            this.btn_sifreDeyistir.ImageList = this.ımageList1;
            this.btn_sifreDeyistir.Location = new System.Drawing.Point(153, 129);
            this.btn_sifreDeyistir.Name = "btn_sifreDeyistir";
            this.btn_sifreDeyistir.Size = new System.Drawing.Size(129, 49);
            this.btn_sifreDeyistir.TabIndex = 2;
            this.btn_sifreDeyistir.Text = "Deyiştir";
            this.btn_sifreDeyistir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sifreDeyistir.UseVisualStyleBackColor = false;
            this.btn_sifreDeyistir.Click += new System.EventHandler(this.btn_sifreDeyistir_Click);
            // 
            // txt_sifreDogrula
            // 
            this.txt_sifreDogrula.Location = new System.Drawing.Point(117, 89);
            this.txt_sifreDogrula.Name = "txt_sifreDogrula";
            this.txt_sifreDogrula.Size = new System.Drawing.Size(226, 24);
            this.txt_sifreDogrula.TabIndex = 1;
            // 
            // txt_yeniSifre
            // 
            this.txt_yeniSifre.Location = new System.Drawing.Point(117, 49);
            this.txt_yeniSifre.Name = "txt_yeniSifre";
            this.txt_yeniSifre.Size = new System.Drawing.Size(226, 24);
            this.txt_yeniSifre.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yeni şifre :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageIndex = 2;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(25, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 56);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sifre_Deyistirme_Paneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(468, 560);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxSifreDeyistir);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Sifre_Deyistirme_Paneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sifre Deyistirme Paneli";
            this.Load += new System.EventHandler(this.Sifre_Deyistirme_Paneli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSifreDeyistir.ResumeLayout(false);
            this.groupBoxSifreDeyistir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox_gvnlkSorusu;
        private System.Windows.Forms.TextBox txt_kullaniciAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_gvnlkCvp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_surgula;
        private System.Windows.Forms.GroupBox groupBoxSifreDeyistir;
        private System.Windows.Forms.Button btn_sifreDeyistir;
        private System.Windows.Forms.TextBox txt_sifreDogrula;
        private System.Windows.Forms.TextBox txt_yeniSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}