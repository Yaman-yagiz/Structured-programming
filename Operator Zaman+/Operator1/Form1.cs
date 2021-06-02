using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zaman zaman1 = new Zaman(5, 59, 60);
            Zaman zaman2 = new Zaman(1, 0, 120);
            Zaman toplamZaman = zaman1 + zaman2;
            MessageBox.Show(toplamZaman.Saat + "." + toplamZaman.Dakika + "." + toplamZaman.Saniye);
        }
    }
}
