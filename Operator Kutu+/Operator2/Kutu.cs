using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator2
{
    class Kutu
    {
        public double Uzunluk;
        public double Genislik;
        public double Yukseklik;
        public Kutu()
        {

        }
        public Kutu(double c_Uzunluk, double c_Genislik , double c_Yukseklik)
        {
            Uzunluk = c_Uzunluk;
            Genislik = c_Genislik;
            Yukseklik = c_Yukseklik;
        }

        public double GetirHacim()
        {
            return Yukseklik * Genislik * Uzunluk;
        }     
        public static Kutu operator + (Kutu b, Kutu c)
        {
            return new Kutu(b.Yukseklik + c.Yukseklik, b.Genislik + c.Genislik, b.Uzunluk + c.Uzunluk);
        }

        public static bool operator == (Kutu birinciKutu, Kutu ikinciKutu)
        {
            bool durum = false;
            if (birinciKutu.Uzunluk == ikinciKutu.Uzunluk && birinciKutu.Yukseklik == ikinciKutu.Yukseklik && birinciKutu.Genislik == ikinciKutu.Genislik)
            {
                durum = true;
            }
            return durum;
        }

        public static bool operator != (Kutu birinciKutu, Kutu ikinciKutu)
        {
            bool durum = false;
            if (birinciKutu.Uzunluk != ikinciKutu.Uzunluk || birinciKutu.Yukseklik != ikinciKutu.Yukseklik || birinciKutu.Genislik != ikinciKutu.Genislik)
            {
                durum = true;
            }
            return durum;
        }

        public static bool operator < (Kutu birinciKutu, Kutu ikinciKutu)
        {
            bool durum = false;
            if (birinciKutu.Uzunluk < ikinciKutu.Uzunluk || birinciKutu.Yukseklik < ikinciKutu.Yukseklik || birinciKutu.Genislik < ikinciKutu.Genislik)
            {
                durum = true;
            }
            return durum;
        }

        public static bool operator > (Kutu birinciKutu, Kutu ikinciKutu)
        {
            bool durum = false;
            if (birinciKutu.Uzunluk > ikinciKutu.Uzunluk || birinciKutu.Yukseklik > ikinciKutu.Yukseklik || birinciKutu.Genislik > ikinciKutu.Genislik)
            {
                durum = true;
            }
            return durum;
        }
        public static bool operator <= (Kutu birinciKutu, Kutu ikinciKutu)
        {
            bool durum = false;
            if (birinciKutu.Uzunluk <= ikinciKutu.Uzunluk || birinciKutu.Yukseklik <= ikinciKutu.Yukseklik || birinciKutu.Genislik <= ikinciKutu.Genislik)
            {
                durum = true;
            }
            return durum;
        }
        public static bool operator >= (Kutu birinciKutu, Kutu ikinciKutu)
        {
            bool durum = false;
            if (birinciKutu.Uzunluk >= ikinciKutu.Uzunluk || birinciKutu.Yukseklik >= ikinciKutu.Yukseklik || birinciKutu.Genislik >= ikinciKutu.Genislik)
            {
                durum = true;
            }
            return durum;
        }
    }
}
