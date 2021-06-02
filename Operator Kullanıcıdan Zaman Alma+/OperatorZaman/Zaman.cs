using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorZaman
{
    class Zaman
    {
        public int Saat { get; set; }
        public int Dakika { get; set; }
        public int Saniye { get; set; }

        public Zaman(int p_Saat, int p_Dakika, int p_Saniye)
        {
            Dakika = p_Dakika + p_Saniye / 60;
            Saniye = p_Saniye % 60;
            Saat = p_Saat + Dakika / 60;
            Dakika = Dakika % 60;
        }

        public static Zaman operator +(Zaman zaman1, Zaman zaman2)
        {
            int SaatTopla = zaman1.Saat + zaman2.Saat;
            int DakikaTopla = zaman1.Dakika + zaman2.Dakika;
            int SaniyeTopla = zaman1.Saniye + zaman2.Saniye;
            return new Zaman(SaatTopla, DakikaTopla, SaniyeTopla);
        }
    }
}
