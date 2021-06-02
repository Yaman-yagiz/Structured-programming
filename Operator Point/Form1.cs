using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operatörler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Point point1 = new Point(2, 2);
            Point point2 = new Point(4, 5);

            Point point3 = point1 + point2;
            Point point4 = point3 - point2;
            if (point1 == point2)
                MessageBox.Show("point1 == point2");
            if (point1 != point2) 
                MessageBox.Show("point1 != point2");
            // ToString Override
            MessageBox.Show(point1.ToString());
            MessageBox.Show(point2.ToString());
            MessageBox.Show(point3.ToString());
            MessageBox.Show(point4.ToString());

            bool küçüktür = point1 < point2;
            if (küçüktür)
                MessageBox.Show("point1 < point2");
            bool büyüktür = point1 > point2;
            if (büyüktür)
                MessageBox.Show("point1 > point2");
            bool küçükeşit = point1 <= point2;
            if (küçükeşit)
                MessageBox.Show("point1 <= point2");
            bool büyükeşit = point1 >= point2;
            if (büyükeşit)
                MessageBox.Show("point1 >= point2");
        }
    }
}
