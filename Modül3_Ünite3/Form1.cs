using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Modül3_Ünite3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;

            if (!int.TryParse(textBox1.Text, out sayi1) || !int.TryParse(textBox2.Text, out sayi2))
            {
                MessageBox.Show("Lütfen geçerli sayılar giriniz.");
                return;
            }

            int toplam = 0;

            for (int i = sayi1; i <= sayi2; i++)
            {
                toplam += i;
            }

            textBox3.Text = toplam.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            int sayi1, sayi2;

            if (!int.TryParse(textBox1.Text, out sayi1) || !int.TryParse(textBox2.Text, out sayi2))
            {
                MessageBox.Show("Lütfen geçerli sayılar giriniz.");
                return;
            }

            int toplam = 0;
            int i = sayi1;

            while (i <= sayi2)
            {
                toplam += i;
                i++;
            }

            textBox3.Text = toplam.ToString();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;

            if (!int.TryParse(textBox1.Text, out sayi1) || !int.TryParse(textBox2.Text, out sayi2))
            {
                MessageBox.Show("Lütfen geçerli sayılar giriniz.");
                return;
            }

            int toplam = 0;
            int i = sayi1;

            do
            {
                toplam += i;
                i++;
            } while (i <= sayi2);

            textBox3.Text = toplam.ToString();

        }
    }
}
