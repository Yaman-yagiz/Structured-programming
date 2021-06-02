using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YapisalHafta7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_dosyakonrol_Click(object sender, EventArgs e)
        {
            string dosyadizini = @"C:\Users\Yamans\Desktop";

            //1. Yöntem dosyanın bir örneğini oluşturuyoruz
            FileInfo fi = new FileInfo(dosyadizini);
            if (fi.Exists)
                MessageBox.Show("Dosya Var");
            else
                MessageBox.Show("Dosya Yok");

            //2. Yöntem Sadece varlığını kontrol ediyor
            if(File.Exists(dosyadizini))
                MessageBox.Show("Dosya Var");
            else
                MessageBox.Show("Dosya Yok");
        }
        private void btn_dizinal_Click(object sender, EventArgs e)
        {
            string Dizin = Path.GetDirectoryName(Application.LocalUserAppDataPath);
            MessageBox.Show(Dizin);
        }
        private void btn_dosyaolustur_Click(object sender, EventArgs e)
        {
            string dizin = @"C:\Users\Yamans\Desktop\";
            string dosyaadi = "Test.txt";
            string dosyakonum = dizin + dosyaadi;
            if(File.Exists(dosyakonum)) {
                MessageBox.Show("Dosya Var");
            }
            else
            {
                File.Create(dosyakonum);
            }
        }
        private void btn_dosyayaz_Click(object sender, EventArgs e)
        {
            string dizin = @"C:\Users\Yamans\Desktop\";
            string dosyaadi = "Test.txt";
            string dosyakonum = dizin + dosyaadi;
            if (!File.Exists(dosyakonum))
            {
                File.Create(dosyakonum);
            }
            TextWriter tw = new StreamWriter(dosyakonum);
            tw.WriteLine("ilk satır Yazısı");
            tw.Close(); // nesneyi kapatır ama bellekte yer tutar.
            tw.Dispose(); // nesneyi bellekten atar, yok eder.
            MessageBox.Show("Dosya üzerine Yazıldı");
        }
        private void btn_dosyauzerineyaz_Click(object sender, EventArgs e)
        {
            string dizin = @"C:\Users\Yamans\Desktop\";
            string dosyaadi = "Test.txt";
            string dosyakonum = dizin + dosyaadi;
            if (!File.Exists(dosyakonum))
            {
                File.Create(dosyakonum);
            }
            //using kod bloğu içinde tanımlanan nesnenin dispose edilmesini garanti eder
            using (StreamWriter sw = File.AppendText(dosyakonum))
            {
                string mesaj = string.Empty; // string.Empty komutu string a ="" ile aynıdır.             
                    mesaj = "Selam ";
                    sw.WriteLine(mesaj + Environment.NewLine);                
                MessageBox.Show("Dosya içine Yeni Satırlar Yazıldı");
            }
        }
        private void btn_dosyasil_Click(object sender, EventArgs e)
        {
            string dizin = @"C:\Users\Yamans\Desktop\";
            string dosyaadi = "Test.txt";
            string dosyakonum = dizin + dosyaadi;
            if (File.Exists(dosyakonum))
            {
                File.Delete(dosyakonum);
                MessageBox.Show("Dosya Silindi");
            }
            else
            {
                MessageBox.Show("Dosya Yok");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string metin = "Video, size görüşünüzü kanıtlamak için güçlü bir yol sunar. Çevrimiçi Video'ya tıkladığınızda, eklemek istediğiniz videoya ait ekleme kodunu yapıştırabilirsiniz. Belgenize en iyi uyan videoyu çevrimiçi olarak aramak için bir anahtar sözcük de yazabilirsiniz. Word, belgenizin profesyonelce üretilmiş görünmesini sağlamak için birbirini tamamlayan üst bilgi, alt bilgi, kapak sayfası ve metin kutusu tasarımları sağlar. Örneğin, birbiriyle uyumlu bir kapak sayfası, başlık ve kenar çubuğu ekleyebilirsiniz. Ekle'ye tıklayın ve ardından farklı galerilerden eklemek istediğiniz öğeleri seçin. Temalar ve stiller de belgenizin düzenli kalmasına yardımcı olur. Tasarım'a tıklayıp yeni bir Tema seçtiğinizde, resimler, grafikler ve SmartArt grafikleri, yeni temanızla eşleşecek şekilde değiştirilir. Stilleri uyguladığınızda, başlıklarınız yeni tema ile eşleşecek şekilde değiştirilir.";
            // 1.Yöntem
            metin = metin.Replace('.', ' '); // Nokta olan yerler, Boşluk haline gelir.
            MessageBox.Show(metin);
            // ---------------------------------- //
            // 2.Yöntem
            int metinuzunluk = metin.Length;
            string yenimetin = "";
            for (int i = 0; i < metinuzunluk; i++)
            {
                if (metin[i] == '.')
                {
                    yenimetin += " "; // Eğer i. karakter nokta ise bunu boşluğa çeviriyoruz.
                }
                else
                {
                    yenimetin += metin[i].ToString(); // Eğer değil ise yenimetin e ekliyoruz.
                }
            }
            MessageBox.Show(yenimetin);
        }       
    }
}
