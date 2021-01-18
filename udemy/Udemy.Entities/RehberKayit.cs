using System;
using System.Collections.Generic;
using System.Text;

namespace Udemy.Entities
{
    public class RehberKayit
    {
        public Guid ID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }
        public string Telefon3 { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string acıklama { get; set; }

        public override string ToString()
        {
            return $"{isim} {soyisim}";
        }
    }
}
