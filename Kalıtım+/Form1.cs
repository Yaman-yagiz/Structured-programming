using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalıtım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            #region Öğrenci Tanımları
            Öğrenci öğrenci1 = new Öğrenci();
            öğrenci1.Fakülte = "Mühendislik";
            öğrenci1.Bölüm = "Bilgisayar";
            öğrenci1.Danışman = "ERDAL ERDAL";
            öğrenci1.ÖğrenciNo = "6616564";
            öğrenci1.Sınıf = "2";
            // Kalıtım Sonrası
            öğrenci1.Ad = "Öğrenci Adı";
            öğrenci1.Soyad = "Öğrenci Soyadı";
            öğrenci1.TC = "432423423";
            öğrenci1.Telefon = "0546261614";
            öğrenci1.DoğumYeri = "Ankara";
            #endregion
            #region Akademik Personel
            AkademikPersonel personel1 = new AkademikPersonel();
            personel1.Unvan = "Doç. Dr. Öğr. Üyesi";
            personel1.Bölüm = "Bilgisayar";
            personel1.Fakülte = "Mühendislik";
            personel1.OdaNo = "B-61";
            // Kalıtım Sonrası
            personel1.Ad = "Tusubasa";
            personel1.DoğumTarihi = 1961;
            personel1.DoğumYeri = "Trabzon";
            #endregion
        }
    }
}
