using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Operasyonları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStringDongu_Click(object sender, EventArgs e)
        {
            string test = "Merhaba Dünya";
            for (int i = 0; i < test.Length; i++)
            {
                MessageBox.Show(test[i].ToString());
            }
            MessageBox.Show("İlk Döngü Tamamlandı..");

            foreach (char c in test)
            {
                MessageBox.Show(c.ToString());
            }
            MessageBox.Show("İkinci Döngü Tamamlandı..");
        }

        private void BtnStringSplit_Click(object sender, EventArgs e)
        {
           
            string test = "abc.def.ghi.jpg";
            char[] SplitCharacter = { '.' };
            string[] dizi = test.Split(SplitCharacter);
            for (int i = 0; i < dizi.Length; i++)
            {
                MessageBox.Show(dizi[i].ToString());
            }
            MessageBox.Show("Ayırma İşlemi Tamamlandı..");
            string extension = dizi[dizi.Length - 1];

        }

        private void BtnSubstring_Click(object sender, EventArgs e)
        {
            string test = "adasvddsfsddfgdfgdfg";
            string SubStr1 = test.Substring(10); // İlk 10 değeri almadan yazar.
            MessageBox.Show(SubStr1);

            string SubStr2 = test.Substring(10, 4); // İlk 10 değeri almıyor ondan sonraki 4 değeri yazıyor.
            MessageBox.Show(SubStr2);
        }

        private void BtnArrayString_Click(object sender, EventArgs e)
        {
            string[] array1 = new string[3] { "str1", "str2", "str3" };
            for (int i = 0; i < array1.Length; i++)
            {
                MessageBox.Show(array1[i].ToString());
            }
            string[,] array2 = new string[2, 2] { { "str1", "str2" }, { "str3", "str4" } };
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j <array2.GetLength(1); j++)
                {
                    MessageBox.Show(array2[i, j].ToString());
                }
            }

        }

        private void BtnStringReverse_Click(object sender, EventArgs e)
        {
            int x = 0;
            string test = "Trabzonspor";
            string[] yeni = new string[test.Length];

            for (int i = (test.Length - 1); i >=0; i--)
            {
                yeni[x] = test[i].ToString();
                x++;
                MessageBox.Show(yeni[i]);
            }
            
        }

        private void BtnStringReverse2_Click(object sender, EventArgs e)
        {
            string test = "";
            char[] MyArray = test.ToCharArray();
            Array.Reverse(MyArray);

            string s = string.Join("", MyArray);
            MessageBox.Show(s);
        }

        private void BtnStringCompare_Click(object sender, EventArgs e)
        {
            string str1 = "abc123test";
            string str2 = "abb123test";
            // Harflerin ve sayıların sayı değeri kıyası yapar(Compare).

            // Bu metodu araştır. 3. parametre olarak bool alabilir . o parametre ne işe yarıyor.
            int result = string.Compare(str1, str2);
            if (result.Equals(0))
                MessageBox.Show("Stringler Aynı-Eşit.");
            else if (result > 0)
                MessageBox.Show("str2 Küçük..");
            else if(result<0)
                MessageBox.Show("str1 Küçük..");
        }

        private void BtnStringNull_Click(object sender, EventArgs e)
        {
            string test = "1";
            bool result = string.IsNullOrEmpty(test);

            if (result)
                MessageBox.Show("String Null ya da Boş..");
            else
                MessageBox.Show("String Dolu..");
        }
    }
}
