using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HataForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] num = { 4, 8, 16, 32, 64, 128 };
            int[] den = { 2, 0, 4, 4, 0, 8 };
            for (int i = 0; i < num.Length+1; i++)
            {
                try
                {
                    MessageBox.Show(num[i] + "/" + den[i] + "=" + num[i] / den[i]);
                }
                catch (DivideByZeroException)
                {
                    MessageBox.Show("DivideByZeroException");
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("IndexOutOfRangeException");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {         
            try
            {
                int num1 = null;
                int num2 = Int32.Parse(textBox2.Text);
                int num3 = num1 * num2;
                label3.Text = num3.ToString();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("ArgumentNullException");
            }
            catch (FormatException)
            {
                MessageBox.Show("FormatException");
            }
            catch (OverflowException)
            {
                MessageBox.Show("OverflowException");
            }
            finally
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
