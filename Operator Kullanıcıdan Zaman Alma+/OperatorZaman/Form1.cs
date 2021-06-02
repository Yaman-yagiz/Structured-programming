using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatorZaman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lbl_Toplam.Text = "Toplam:";
            try
            {
                int Saat1 = Int32.Parse(Txt_TimeH1.Text);
                int Saat2 = Int32.Parse(Txt_TimeH2.Text);
                int Dakika1 = Int32.Parse(Txt_TimeM1.Text);
                int Dakika2 = Int32.Parse(Txt_TimeM2.Text);
                int Saniye1 = Int32.Parse(Txt_TimeS1.Text);
                int Saniye2 = Int32.Parse(Txt_TimeS2.Text);
                Zaman zaman1 = new Zaman(Saat1, Dakika1, Saniye1);
                Zaman zaman2 = new Zaman(Saat2, Dakika2, Saniye2);
                Zaman zaman3 = zaman1 + zaman2;
                Lbl_Toplam.Text += zaman3.Saat + ":" + zaman3.Dakika + ":" + zaman3.Saniye;
            }
            catch (FormatException)
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
