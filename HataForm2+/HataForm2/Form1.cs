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

namespace HataForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {              
                Ogrenci ogrenci1 = new Ogrenci();
                string Bilgi = ogrenci1.DanismanHoca.Unvan;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("NullReferenceException", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Image image = Image.FromFile(@"C:\Users\Yamans\Downloads\");
                pictureBox1.Image = image;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("FileNotFoundException", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                object obj = new object();
                int a, c;
                double y;
                a = 25;
                y = 33.678;
                c = (int)y;
                a = (int)obj;
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("InvalidCastException", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string islem = textBox3.Text;
            int sayi1 = Int32.Parse(textBox1.Text);
            int sayi2 = Int32.Parse(textBox2.Text);
            int sonuc = 0;
            try
            {
                switch(islem)
                {
                    case "+": sonuc = sayi1 + sayi2; break;
                    case "-": sonuc = sayi1 - sayi2; break;
                    case "*": sonuc = sayi1 * sayi2; break;
                    case "/": sonuc = sayi1 / sayi2; break; 
                    default: throw new InvalidOperationException("Hatalı İşlem Girişi!");
                }
                label4.Text += sonuc.ToString();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("InvalidOperationException", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 100;

            try
            {
                int z = y / x;
            }
            catch (ArithmeticException)
            {
                MessageBox.Show("ArithmeticException", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\asdasd";
                Directory.SetCurrentDirectory(path);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("DirectoryNotFoundException", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {   
            try
            {
                string pathCreate = @"C:\xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
                Directory.SetCurrentDirectory(pathCreate);
            }
            catch (PathTooLongException)
            {
                MessageBox.Show("PathTooLongException", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string path = @"C:\dosya.txt";
            try
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("UnauthorizedAccessException", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
