
namespace Udemy.WFUI
{
    partial class AnaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grp_Kayit = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_website = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tel3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tel2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tel1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_yenikayit = new System.Windows.Forms.Button();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.lst_liste = new System.Windows.Forms.ListBox();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_xmlVer = new System.Windows.Forms.Button();
            this.btn_cvsVer = new System.Windows.Forms.Button();
            this.btn_jsonVer = new System.Windows.Forms.Button();
            this.btn_xmlAL = new System.Windows.Forms.Button();
            this.lbl_DataDurum = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grp_Kayit.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_liste);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 513);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rehber Liste";
            // 
            // grp_Kayit
            // 
            this.grp_Kayit.Controls.Add(this.btn_Sil);
            this.grp_Kayit.Controls.Add(this.tabControl1);
            this.grp_Kayit.Controls.Add(this.btn_guncelle);
            this.grp_Kayit.Controls.Add(this.btn_yenikayit);
            this.grp_Kayit.Location = new System.Drawing.Point(309, 12);
            this.grp_Kayit.Name = "grp_Kayit";
            this.grp_Kayit.Size = new System.Drawing.Size(961, 393);
            this.grp_Kayit.TabIndex = 0;
            this.grp_Kayit.TabStop = false;
            this.grp_Kayit.Text = "Yeni Rehber Kayıt";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(949, 289);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_adres);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txt_website);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txt_email);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_tel3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_tel2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_tel1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_soyisim);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_isim);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(941, 260);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kişisel Bilgiler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(420, 55);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(503, 165);
            this.txt_adres.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Adres";
            // 
            // txt_website
            // 
            this.txt_website.Location = new System.Drawing.Point(120, 200);
            this.txt_website.Name = "txt_website";
            this.txt_website.Size = new System.Drawing.Size(243, 22);
            this.txt_website.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Website";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(120, 172);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(243, 22);
            this.txt_email.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email Adres";
            // 
            // txt_tel3
            // 
            this.txt_tel3.Location = new System.Drawing.Point(120, 144);
            this.txt_tel3.Name = "txt_tel3";
            this.txt_tel3.Size = new System.Drawing.Size(243, 22);
            this.txt_tel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefon III";
            // 
            // txt_tel2
            // 
            this.txt_tel2.Location = new System.Drawing.Point(120, 116);
            this.txt_tel2.Name = "txt_tel2";
            this.txt_tel2.Size = new System.Drawing.Size(243, 22);
            this.txt_tel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon II";
            // 
            // txt_tel1
            // 
            this.txt_tel1.Location = new System.Drawing.Point(120, 88);
            this.txt_tel1.Name = "txt_tel1";
            this.txt_tel1.Size = new System.Drawing.Size(243, 22);
            this.txt_tel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefon I";
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(120, 60);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(243, 22);
            this.txt_soyisim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(120, 32);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(243, 22);
            this.txt_isim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_aciklama);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(941, 260);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Açıklama";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_yenikayit
            // 
            this.btn_yenikayit.Location = new System.Drawing.Point(6, 316);
            this.btn_yenikayit.Name = "btn_yenikayit";
            this.btn_yenikayit.Size = new System.Drawing.Size(949, 32);
            this.btn_yenikayit.TabIndex = 0;
            this.btn_yenikayit.Text = "Yeni Kayıt";
            this.btn_yenikayit.UseVisualStyleBackColor = true;
            this.btn_yenikayit.Click += new System.EventHandler(this.btn_yenikayit_Click);
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(6, 3);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(929, 251);
            this.txt_aciklama.TabIndex = 0;
            // 
            // lst_liste
            // 
            this.lst_liste.FormattingEnabled = true;
            this.lst_liste.ItemHeight = 16;
            this.lst_liste.Location = new System.Drawing.Point(6, 21);
            this.lst_liste.Name = "lst_liste";
            this.lst_liste.Size = new System.Drawing.Size(267, 484);
            this.lst_liste.TabIndex = 0;
            this.lst_liste.DoubleClick += new System.EventHandler(this.lst_liste_DoubleClick);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(6, 354);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(480, 32);
            this.btn_guncelle.TabIndex = 0;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_DataDurum);
            this.groupBox3.Controls.Add(this.btn_xmlAL);
            this.groupBox3.Controls.Add(this.btn_jsonVer);
            this.groupBox3.Controls.Add(this.btn_cvsVer);
            this.groupBox3.Controls.Add(this.btn_xmlVer);
            this.groupBox3.Location = new System.Drawing.Point(315, 411);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(949, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Ver/Al";
            // 
            // btn_xmlVer
            // 
            this.btn_xmlVer.Location = new System.Drawing.Point(10, 21);
            this.btn_xmlVer.Name = "btn_xmlVer";
            this.btn_xmlVer.Size = new System.Drawing.Size(75, 61);
            this.btn_xmlVer.TabIndex = 0;
            this.btn_xmlVer.Text = "XML Ver";
            this.btn_xmlVer.UseVisualStyleBackColor = true;
            this.btn_xmlVer.Click += new System.EventHandler(this.btn_xmlVer_Click);
            // 
            // btn_cvsVer
            // 
            this.btn_cvsVer.Location = new System.Drawing.Point(91, 21);
            this.btn_cvsVer.Name = "btn_cvsVer";
            this.btn_cvsVer.Size = new System.Drawing.Size(75, 61);
            this.btn_cvsVer.TabIndex = 0;
            this.btn_cvsVer.Text = "CVS Ver";
            this.btn_cvsVer.UseVisualStyleBackColor = true;
            // 
            // btn_jsonVer
            // 
            this.btn_jsonVer.Location = new System.Drawing.Point(172, 21);
            this.btn_jsonVer.Name = "btn_jsonVer";
            this.btn_jsonVer.Size = new System.Drawing.Size(75, 61);
            this.btn_jsonVer.TabIndex = 0;
            this.btn_jsonVer.Text = "JSON Ver";
            this.btn_jsonVer.UseVisualStyleBackColor = true;
            // 
            // btn_xmlAL
            // 
            this.btn_xmlAL.Location = new System.Drawing.Point(253, 21);
            this.btn_xmlAL.Name = "btn_xmlAL";
            this.btn_xmlAL.Size = new System.Drawing.Size(75, 61);
            this.btn_xmlAL.TabIndex = 0;
            this.btn_xmlAL.Text = "XML Al";
            this.btn_xmlAL.UseVisualStyleBackColor = true;
            // 
            // lbl_DataDurum
            // 
            this.lbl_DataDurum.AutoSize = true;
            this.lbl_DataDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_DataDurum.Location = new System.Drawing.Point(359, 43);
            this.lbl_DataDurum.Name = "lbl_DataDurum";
            this.lbl_DataDurum.Size = new System.Drawing.Size(226, 29);
            this.lbl_DataDurum.TabIndex = 1;
            this.lbl_DataDurum.Text = "Durum : Beklemede";
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(492, 355);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(463, 31);
            this.btn_Sil.TabIndex = 2;
            this.btn_Sil.Text = "Kayıt Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 537);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grp_Kayit);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.grp_Kayit.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grp_Kayit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_yenikayit;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_website;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.ListBox lst_liste;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_DataDurum;
        private System.Windows.Forms.Button btn_xmlAL;
        private System.Windows.Forms.Button btn_jsonVer;
        private System.Windows.Forms.Button btn_cvsVer;
        private System.Windows.Forms.Button btn_xmlVer;
        private System.Windows.Forms.Button btn_Sil;
    }
}