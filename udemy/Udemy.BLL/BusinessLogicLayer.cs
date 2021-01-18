using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Udemy.Entities;

namespace Udemy.BLL
{
    public class BusinessLogicLayer
    {
        Udemy.Core.DatabaseLogicLAyer DLL;
        public BusinessLogicLayer()
        {
            DLL = new Core.DatabaseLogicLAyer();
        }
        public int KullaniciKontrol(string kullaniciAdi , string sifre)
        {
            int sonuc = 0;
            if(!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre))
            {
                Kullanici kullanici = new Kullanici();
                kullanici.KullaniciAdi = kullaniciAdi;
                kullanici.sifre = sifre;
                sonuc = DLL.KullaniciKontrol(kullanici);
            }
            else
            {
                sonuc = -100;// Eksik parametre hatası
            }
            return sonuc;
        }
        public int YeniKayit(Guid ID, String isim, string soyisim, string telefon1, string telefon2, string telefon3, string Adres,
            string Email, string website, string Acıklama)
        {
            int sonuc = 0;
            if (ID != Guid.Empty && !string.IsNullOrEmpty(isim) && !string.IsNullOrEmpty(soyisim) && !string.IsNullOrEmpty(telefon1))
            {
                RehberKayit Kayit = new RehberKayit();
                Kayit.ID = ID;
                Kayit.isim = isim;
                Kayit.soyisim = soyisim;
                Kayit.Telefon1 = telefon1;
                Kayit.Telefon2 = telefon2;
                Kayit.Telefon3 = telefon3;
                Kayit.Adres = Adres;
                Kayit.Email = Email;
                Kayit.Website = website;
                Kayit.acıklama = Acıklama;
                sonuc = DLL.YeniKayit(Kayit);
            }
            return sonuc;
        }
        public int KayitGuncelle(Guid ID, String isim, string soyisim, string telefon1, string telefon2, string telefon3, string Adres,
            string Email, string website, string Acıklama)
        {
            int sonuc = 0;
            if (ID != Guid.Empty && !string.IsNullOrEmpty(isim) && !string.IsNullOrEmpty(soyisim) && !string.IsNullOrEmpty(telefon1))
            {
                RehberKayit Kayit = new RehberKayit();
                Kayit.ID = ID;
                Kayit.isim = isim;
                Kayit.soyisim = soyisim;
                Kayit.Telefon1 = telefon1;
                Kayit.Telefon2 = telefon2;
                Kayit.Telefon3 = telefon3;
                Kayit.Adres = Adres;
                Kayit.Email = Email;
                Kayit.Website = website;
                Kayit.acıklama = Acıklama;
                sonuc = DLL.KayitGuncelle(Kayit);
            }
            return sonuc;
        }
        public int KayitSil(Guid ID)
        {
            return DLL.KayitSil(ID);
        }
        public List<RehberKayit> RehberKayitlariGetir()
        {
            return DLL.RehberKayitlariGetir();
        }
        public int XMLDataVer()
        {
            int sonuc = 0;
            try
            {
                List<RehberKayit> Kayitlarim = DLL.RehberKayitlariGetir();

                XDocument Doc = new XDocument(new XDeclaration("1.0.0.1", "UFT-8", "yes"), new XElement("RehberKayitlar", Kayitlarim.Select
                    (I => new XElement("Kayit", new XElement("ID", I.ID), new XElement("isim",I.isim), new XElement("soyisim", I.soyisim)))));
                Doc.Save(@"c:\TelefonRehberiDB\DataVerXML.xml");
                sonuc = 1;
            }
            catch (Exception ex)
            {

                sonuc = 0;
            }
            return sonuc;
        }
    }
}
