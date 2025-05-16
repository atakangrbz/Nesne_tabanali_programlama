using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modül3_Ünite2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kat;
            if (!int.TryParse(textBox1.Text, out kat))
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz.");
                return;
            }

            richTextBox1.Clear();

            if (kat == 0)
            {
                richTextBox1.Text = "Zemin Kat:\n- Danışma\n- Güvenlik\n- Öğrenci İşleri";
            }
            else if (kat == 1)
            {
                richTextBox1.Text = "1. Kat:\n- Müdür Odası\n- Öğretmenler Odası\n- Rehberlik Servisi";
            }
            else if (kat == 2)
            {
                richTextBox1.Text = "2. Kat:\n- 9 ve 10. Sınıf Derslikleri\n- Laboratuvar";
            }
            else if (kat == 3)
            {
                richTextBox1.Text = "3. Kat:\n- 11 ve 12. Sınıf Derslikleri\n- Kütüphane";
            }
            else
            {
                richTextBox1.Text = "Lütfen 0-3 arasında bir kat numarası giriniz...";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kat;

            if (!int.TryParse(textBox1.Text, out kat))
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz.");
                return;
            }

            richTextBox1.Clear();

            switch (kat)
            {
                case 0:
                    richTextBox2.Text = "Zemin Kat:\n- Danışma\n- Güvenlik\n- Öğrenci İşleri";
                    break;
                case 1:
                    richTextBox2.Text = "1. Kat:\n- Müdür Odası\n- Öğretmenler Odası\n- Rehberlik Servisi";
                    break;
                case 2:
                    richTextBox2.Text = "2. Kat:\n- 9 ve 10. Sınıf Derslikleri\n- Laboratuvar";
                    break;
                case 3:
                    richTextBox2.Text = "3. Kat:\n- 11 ve 12. Sınıf Derslikleri\n- Kütüphane";
                    break;
                default:
                    richTextBox2.Text = "Lütfen 0-3 arasında bir kat numarası giriniz...";
                    break;
            }
        }
    }
}
