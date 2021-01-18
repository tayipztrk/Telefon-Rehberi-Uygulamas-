using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Udemy.Entities;
namespace Udemy.Core
{
    public class DatabaseLogicLAyer
    {
        List<RehberKayit> Kayitlarim;
        public DatabaseLogicLAyer()
        {
            Kayitlarim = new List<RehberKayit>();

            VeriTabaniKontrol();
        }

        private void VeriTabaniKontrol()
        {
            
            //bool KlasorKontrol = File.Exists(@"c:\TelefonRehberiDB\");
            if (Directory.Exists(@"c:\TelefonRehberiDB\")== true)
            {
               
            }
            else if (Directory.Exists(@"c:\TelefonRehberiDB\")== false)
            {
                Directory.CreateDirectory(@"c:\TelefonRehberiDB\");

                Kullanici Demo = new Kullanici();
                Demo.ID = Guid.NewGuid();
                Demo.KullaniciAdi = "Demo";
                Demo.sifre = "Demo";

                string JsonKullaniciText = Newtonsoft.Json.JsonConvert.SerializeObject(Demo);
                File.WriteAllText(@"c:\TelefonRehberiDB\kullanici.json", JsonKullaniciText);
                

            }
        }
        public int YeniKayit(RehberKayit K)
        {
            int sonuc;
            try
            {
                RehberKayitlariGetir();
                Kayitlarim.Add(K);
                JsonGuncelle();
                sonuc = 10;

            }
            catch (Exception ex)
            {

                sonuc = 0;
            }
            return sonuc;
        }
        public int KayitGuncelle(RehberKayit K)
        {
            int sonuc = 0;
            try
            {
                RehberKayitlariGetir();
                int index = Kayitlarim.FindIndex(I => I.ID == K.ID);
                if(index > -1)
                {
                    Kayitlarim[index].isim = K.isim;
                    Kayitlarim[index].soyisim = K.soyisim;
                    Kayitlarim[index].Telefon1 = K.Telefon1;
                    Kayitlarim[index].Telefon2 = K.Telefon2;
                    Kayitlarim[index].Telefon3 = K.Telefon3;
                    Kayitlarim[index].Website = K.Website;
                    Kayitlarim[index].acıklama = K.acıklama;
                    Kayitlarim[index].Adres = K.Adres;
                    Kayitlarim[index].Email = K.Email;
                }
                JsonGuncelle();
                sonuc = 1;
            }
            catch (Exception ex)
            {

                throw;
            }
            return sonuc;   
        }
        public int KayitSil(Guid ID)
        {
            int sonuc = 0;
            try
            {
                RehberKayitlariGetir();
                RehberKayit silinecekdeger = Kayitlarim.Find(I => I.ID == ID);
                if(silinecekdeger != null)
                {
                    Kayitlarim.Remove(silinecekdeger);

                }
                JsonGuncelle();
                sonuc = 1;
            }
            catch (Exception ex)
            {

                throw;
            }    

            return sonuc;
        }
        public List<RehberKayit> RehberKayitlariGetir()
        {
            if(File.Exists(@"c:\TelefonRehberiDB\Rehber.json"))
            {
                string JsonDbtext = File.ReadAllText(@"c:\TelefonRehberiDB\Rehber.json");
                Kayitlarim = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RehberKayit>>(JsonDbtext);
            }
            return Kayitlarim;
        }
        public int KullaniciKontrol(Kullanici kullanici)
        {
            int kullanicisonuc = 0;
            if (File.Exists(@"c:\TelefonRehberiDB\kullanici.json"))
            {
                string JsonKullaniciText = File.ReadAllText(@"c:\TelefonRehberiDB\kullanici.json");
                List<Kullanici> Kullanicilar = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Kullanici>>(JsonKullaniciText);
                kullanicisonuc = Kullanicilar.FindAll(i => i.KullaniciAdi == kullanici.KullaniciAdi && i.sifre == kullanici.sifre)
                    .ToList().Count(); 
            }
            return kullanicisonuc;
        }
        private void JsonGuncelle()
        {
            if(Kayitlarim != null && Kayitlarim.Count > 0)
            {
                string JsonDb = Newtonsoft.Json.JsonConvert.SerializeObject(Kayitlarim);
                File.WriteAllText(@"c:\TelefonRehberiDB\Rehber.json", JsonDb);
            }
        }
    }
}
