using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kutu kutu1 = new Kutu();
            Kutu kutu2 = new Kutu();
            Kutu kutu3 = new Kutu();
            Kutu kutu4 = new Kutu();
            double Hacim = 0;
            try
            {
                kutu1.Yukseklik =Convert.ToDouble(textBox1.Text);
                kutu1.Genislik = Convert.ToDouble(textBox2.Text);
                kutu1.Uzunluk =Convert.ToDouble(textBox3.Text);
                kutu2.Yukseklik = Convert.ToDouble(textBox6.Text);
                kutu2.Genislik = Convert.ToDouble(textBox5.Text);
                kutu2.Uzunluk = Convert.ToDouble(textBox4.Text);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + Environment.NewLine + hata.ToString());
            }
            Hacim = kutu1.GetirHacim();
            label8.Text += Hacim;
            Hacim = kutu2.GetirHacim();
            label7.Text += Hacim;
            kutu3 = kutu1 + kutu2;
            Hacim = kutu3.GetirHacim();
            label6.Text += Hacim;
            if (kutu1 > kutu2)
            {
                label9.Text = "kutu1 > kutu2";
            }
            else
            {
                label9.Text = "kutu1 büyük değil kutu2 den";
            }
            if (kutu1 < kutu2)
            {
                label10.Text = "kutu1 < kutu2";
            }
            else
            {
                label10.Text = "kutu1 küçük değil kutu2 den";
            }
            if (kutu1 >= kutu2)
            {
                label11.Text = "kutu1 >= kutu2";
            }
            else
            {
                label11.Text = "kutu1 büyük eşit değil kutu2 den";
            }
            if (kutu1 <= kutu2)
            {
                label12.Text = "kutu1 <= kutu2";
            }
            else
            {
                label12.Text = "kutu1 küçük eşit değil kutu2 den";
            }
            if (kutu1 != kutu2)
            {
                label13.Text = "kutu1 eşit değil kutu2";
            }
            else
            {
                label13.Text = "kutu1 eşit kutu2";
            }
           
        }

    }
}
