using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator1
{
    class Zaman
    {
        /*
        Aritmetik(+, -, *, /)
        Karşılaştırma(<, >, <=, >=, ==)
        İlişkisel(true, false)
        Mantıksal(||, &&)
        */
        public int Saat { get; set; }
        public int Dakika { get; set; }
        public int Saniye { get; set; }
        public Zaman(int c_Saat, int c_Dakika, int c_Saniye)
        {
            Dakika = c_Dakika + c_Saniye % 60;
            Saniye = c_Saniye / 60;
            Saat = c_Saat + c_Dakika / 60;
            Dakika = Dakika % 60;
        }
        //İki Farklı Zamanı + Operatörü İle Toplayıp Geri Döndürdük
        public static Zaman operator + (Zaman zaman1, Zaman zaman2)
        {
            int SaatTopla = zaman1.Saat + zaman2.Saat;
            int DakikaTopla = zaman1.Dakika + zaman2.Dakika;
            int SaniyeTopla = zaman1.Saniye + zaman2.Saniye;
            return new Zaman(SaatTopla,DakikaTopla,SaniyeTopla);
        }
    }
}
