using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Udemy.Entities;

namespace Udemy.WFUI
{
    public partial class AnaForm : Form
    {
        Udemy.BLL.BusinessLogicLayer BLL;
        public AnaForm()
        {
            InitializeComponent();
            BLL = new BLL.BusinessLogicLayer();
        }

        private void btn_yenikayit_Click(object sender, EventArgs e)
        {
            int sonuc = BLL.YeniKayit(Guid.NewGuid(), txt_isim.Text, txt_soyisim.Text, txt_tel1.Text, txt_tel2.Text, txt_tel3.Text,
                txt_adres.Text, txt_email.Text, txt_website.Text, txt_aciklama.Text);
            if(sonuc > 0)
            {
                MessageBox.Show("Kaydınız başarılı bir şekilde eklendi");
                doldur();
            }else if( sonuc == -100)
            {
                MessageBox.Show("Eksik parametre hatası.Lütfen isim soyisim tel1 alanlarını doldurunuz.");
            }else
            {
                MessageBox.Show("Kayıt ekleme işleminde hata oluştu");
            }
        }
        private void doldur()
        {
            List<RehberKayit> RehberKayitlarim = BLL.RehberKayitlariGetir();
            if(RehberKayitlarim != null && RehberKayitlarim.Count > 0)
            {
                lst_liste.DataSource = RehberKayitlarim;
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void lst_liste_DoubleClick(object sender, EventArgs e)
        {
            ListBox L = (ListBox)sender;
            RehberKayit secilenDeger = (RehberKayit)L.SelectedItem;
            txt_isim.Text = secilenDeger.isim;
            txt_soyisim.Text = secilenDeger.soyisim;
            txt_tel1.Text = secilenDeger.Telefon1;
            txt_tel2.Text = secilenDeger.Telefon2;
            txt_tel3.Text = secilenDeger.Telefon3;
            txt_email.Text = secilenDeger.Email;
            txt_adres.Text = secilenDeger.Adres;
            txt_aciklama.Text = secilenDeger.acıklama;
            txt_website.Text = secilenDeger.Website;
            grp_Kayit.Text = "Güncelle";
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if(lst_liste.SelectedItem != null)
            {
                RehberKayit K = (RehberKayit)lst_liste.SelectedItem;
                int sonuc = BLL.KayitGuncelle(K.ID, txt_isim.Text, txt_soyisim.Text, txt_tel1.Text, txt_tel2.Text, txt_tel3.Text,
                txt_adres.Text, txt_email.Text, txt_website.Text, txt_aciklama.Text);
                if(sonuc > 0)
                {
                    MessageBox.Show("Kaydınız başarılı bir şekilde güncellendi.");
                    doldur();
                }else if(sonuc == -100)
                {
                    MessageBox.Show("Eksik parametre Hatası");
                }
                else
                {
                    MessageBox.Show("Kayıt güncelleme işleminde hata oluştu");
                }
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            Guid SilinecekID = ((RehberKayit)lst_liste.SelectedItem).ID;
            int sonuc = BLL.KayitSil(SilinecekID);
            if(sonuc > 0)
            {
                MessageBox.Show("Kaydınız başarılı bir şekilde silindi");
                doldur();
            }
            else
            {
                MessageBox.Show("Kayıt silme işleminde hata oluştu");
            }
        }

        private void btn_xmlVer_Click(object sender, EventArgs e)
        {
            int sonuc = BLL.XMLDataVer();
            if(sonuc > 0)
            {
                lbl_DataDurum.Text = "Durum : Başarılı";
            }
            else
            {
                lbl_DataDurum.Text = "Durum : Başarırız";
            }
        }
    }
}
